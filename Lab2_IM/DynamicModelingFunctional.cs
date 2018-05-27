using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSharpModeling;

namespace Lab2_IM
{
    /// <summary>
    /// Код для лабы в функциональном стиле. Никаких классов. Вообще. Кроме этого
    /// </summary>
    static class DynamicModelingFunctional
    {
        
        //Константы
        static readonly Random random = new Random();

        //Вспомогательные функции
        static double GetMid(double minDelay, double maxDelay) => (maxDelay + minDelay) / 2.0;

        static double GetCriticalValue(double defaultValue, double criticalKoefficient) 
            => defaultValue * criticalKoefficient;

        static double GetCompletion()
        {
            double[] probability = { 0.4, 0.3, 0.2, 0.1 };
            double[] replenishment = { 0.1, 0.2, 0.5, 1 };

            double R = random.NextDouble();

            int pos = 0;

            while (R > probability[pos])
            {
                R -= probability[pos];
                pos++;
            }

            return replenishment[pos];
        }

        //Основные функции
        static double Flow(double level, double delay) 
            => level / delay;

        static double FlowInput(double currentLevel, double criticalValue)
           => (currentLevel < criticalValue) ? GetCompletion() : 0;

        static double Delay(double minDelay, double maxDelay, double currentDelay, double level, double alpha) 
            => minDelay + GetMid(minDelay, maxDelay) * (level / currentDelay) + maxDelay * alpha;

        static double Level(double current, double flowFrom, double flowTo, double deltaTime)
            => current + deltaTime * (flowTo - flowFrom);

        static double LevelFirst(double current, double criticalValue, double flowFrom, double deltaTime)
            => current - flowFrom * deltaTime + FlowInput(current, criticalValue);

        static double LevelLast(double current, double flowTo, double deltaTime)
            => current + flowTo * deltaTime;
       

        static int MakeProduct(double aNeed, double bNeed, ref double levelA, ref double levelB)
        {
            var makingCount = 0;
            while ((aNeed < levelA) && (bNeed < levelB))
            {
                levelA -= aNeed;
                levelB -= bNeed;
                makingCount++;
            }
            return makingCount;
        }

        //Функциональное программирование, так функциональное программирование
        //Юзаем кортежи

        //Основной процесс
        public static IEnumerable<(double time, int count, int stackA, int stackB)> Simulate(double intervalLength, double deltaTime, double[] flowsAlphaA, double[] flowsAlphaB)
        {
            //Константы 
            const double minDelay = 4;
            const double maxDelay = 12;
            const double criticalValueKoeff = 0.2;
            const double aNeed = 50;
            const double bNeed = 100;

            
            var productCount = 0;

            //Начальные значения уровней
            var levelsA = new double[3];
            levelsA[0] = 150;
            levelsA[1] = 30;
            levelsA[2] = 25;

            var levelsADefault = levelsA.Clone() as double[];

            var levelsB = new double[5];
            levelsB[0] = 120;
            levelsB[1] = 30;
            levelsB[2] = 30;
            levelsB[3] = 30;
            levelsB[4] = 50;

            var levelsBDefault = levelsB.Clone() as double[];

            //Начальные значения задержки
            var levelsADelay = new double[3];
            for (int j = 0; j < levelsADelay.Length; j++)
                levelsADelay[j] = levelsA[j] / 10.0; 

            var levelsBDelay = new double[5];
            for (int j = 0; j < levelsBDelay.Length; j++)
                levelsBDelay[j] = levelsB[j] / 10.0;

            double flow = 0, lastFlow = 0;

            //Основной цикл
            for (int i = 0; i * deltaTime < intervalLength; i++)
            {
                for (int j = 0; j < levelsA.Length; j++)
                {
                    levelsADelay[j] = Delay(minDelay, maxDelay, levelsADelay[j], levelsA[j], flowsAlphaA[j]);
                    flow = Flow(levelsA[j], levelsADelay[j]);

                    if (j == 0)
                        levelsA[j] = LevelFirst(levelsA[0], GetCriticalValue(levelsADefault[0], criticalValueKoeff), flow, deltaTime);
                    else if (j == levelsA.Length - 1)
                        levelsA[j] = LevelLast(levelsA[j], lastFlow, deltaTime);
                    else levelsA[j] = Level(levelsA[j], flow, lastFlow, deltaTime);
                    lastFlow = flow;
                }

                for (int j = 0; j < levelsB.Length; j++)
                {
                    levelsBDelay[j] = Delay(minDelay, maxDelay, levelsBDelay[j], levelsB[j], flowsAlphaB[j]);
                    flow = Flow(levelsB[j], levelsBDelay[j]);

                    if (j == 0)
                        levelsB[j] = LevelFirst(levelsB[0], GetCriticalValue(levelsBDefault[0], criticalValueKoeff), flow, deltaTime);
                    else if (j == levelsB.Length - 1)
                        levelsB[j] = LevelLast(levelsB[j], lastFlow, deltaTime);
                    else levelsB[j] = Level(levelsB[j], flow, lastFlow, deltaTime);
                    lastFlow = flow;
                }

                productCount += MakeProduct(aNeed, bNeed, ref levelsA[2], ref levelsB[4]);

                yield return (i * deltaTime, productCount, (int)levelsA[2], (int)levelsB[4]);
            }
        }

        public static IEnumerable<(double time, int count, int stackA, int stackB)> SimulateFSharp(double intervalLength, double alphaA, double alphaB, double deltaTime)
        {

            //Начальные значения уровней
            var levelsA = new double[3];
            levelsA[0] = 150;
            levelsA[1] = 30;
            levelsA[2] = 25;

            var levelsB = new double[5];
            levelsB[0] = 120;
            levelsB[1] = 30;
            levelsB[2] = 30;
            levelsB[3] = 30;
            levelsB[4] = 50;

            var levelsADelay = new double[3];
            levelsADelay[0] = levelsADelay[1] = levelsADelay[2]
                = (4 + 12) / 2;

            var levelsBDelay = new double[5];
            levelsBDelay[0] = levelsBDelay[1] = levelsBDelay[2] = levelsBDelay[3] = levelsBDelay[4]
                = (4 + 12) / 2;

            MainSystem.SimulationInput input =
                new MainSystem.SimulationInput(levelsA, levelsB, levelsADelay, levelsBDelay, alphaA, alphaB, deltaTime);

            return MainSystem.simulation(input, intervalLength);
        }
    }
}
