using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static double GetMid(double minDelay, double maxDelay) => (maxDelay - minDelay) / 2.0;

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
        static double Flow(double level, double delay) => level / delay;

        static double Delay(double minDelay, double maxDelay, double currentDelay, double level, double alpha)
            => minDelay + GetMid(minDelay, maxDelay) * (level / currentDelay) + maxDelay * alpha;

        static double Level(double currentLevel, double deltaTime, double delay)
            => currentLevel + deltaTime * Flow(currentLevel, delay);

        static double LevelWithInput(double currentLevel, double criticalValue)
            => currentLevel < criticalValue ? currentLevel + GetCompletion() : currentLevel;

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

            //Мерзкие переменные, которые нужно возвращать
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

            //Начальные значения задержки. Пусть они равны средней
            var levelsADelay = new double[3];
            levelsADelay[0] = levelsADelay[1] = levelsADelay[2]
                = GetMid(minDelay, maxDelay);

            var levelsBDelay = new double[5];
            levelsBDelay[0] = levelsBDelay[1] = levelsBDelay[2] = levelsBDelay[3] = levelsBDelay[4] 
                = GetMid(minDelay, maxDelay);



            //Основной цикл
            for (int i = 0; i * deltaTime < intervalLength; i++)
            {
                levelsA[0] = LevelWithInput(levelsA[0], GetCriticalValue(levelsADefault[0], criticalValueKoeff));
                levelsB[0] = LevelWithInput(levelsB[0], GetCriticalValue(levelsBDefault[0], criticalValueKoeff));

                for (int j = 1; j < levelsA.Length; j++)
                {
                    levelsADelay[j] = Delay(minDelay, maxDelay, levelsADelay[j], levelsA[j], flowsAlphaA[j - 1]);
                    levelsA[j] = Level(levelsA[j], deltaTime, levelsADelay[j]);
                }

                for (int j = 1; j < levelsB.Length; j++)
                {
                    levelsBDelay[j] = Delay(minDelay, maxDelay, levelsBDelay[j], levelsB[j], flowsAlphaB[j - 1]);
                    levelsB[j] = Level(levelsB[j], deltaTime, levelsBDelay[j]);
                }

                productCount += MakeProduct(aNeed, bNeed, ref levelsA[2], ref levelsB[4]);

                yield return (i * deltaTime, productCount, (int)levelsA[2], (int)levelsB[4]);
            }
        }

    }
}
