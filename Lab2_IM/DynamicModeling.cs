using System;

namespace Lab2_IM
{
    class DynamicModeling
    {
        public void StartModeling(double deltaTime, double interval)
        {
            //Уровни
            var levelsA = new Level[3];
            levelsA[0] = new Level(150);
            levelsA[1] = new Level(30);
            levelsA[2] = new Level(25);

            var levelsB = new Level[5];
            levelsB[0] = new Level(120);
            levelsB[1] = new Level(30);
            levelsB[2] = new Level(30);
            levelsB[3] = new Level(30);
            levelsB[4] = new Level(50);

            //Входные потоки
            var inputFlowA = new InputFlow(levelsA[0], Distribution.GetCompletion, levelsA[0].Value, 0.2);
            var inputFlowB = new InputFlow(levelsB[0], Distribution.GetCompletion, levelsB[1].Value, 0.2);

            //Основные потоки
            var flowsA = new Flow[2];
            flowsA[0] = new Flow(levelsA[0], levelsA[1], 12, 4, 1, 10);
            flowsA[1] = new Flow(levelsA[1], levelsA[2], 12, 4, 1, 10);

            var flowsB = new Flow[4];
            flowsB[0] = new Flow(levelsB[0], levelsB[1], 12, 4, 0.5, 10);
            flowsB[1] = new Flow(levelsB[1], levelsB[2], 12, 4, 0.5, 10);
            flowsB[2] = new Flow(levelsB[2], levelsB[3], 12, 4, 0.5, 10);
            flowsB[3] = new Flow(levelsB[3], levelsB[4], 12, 4, 0.5, 10);

            //Выходной поток
            var outputFlow = new OutputFlow(
                new Level[] { levelsA[2], levelsB[4] },
                new double[] { 200, 400 },
                0.05);

            //Задержки

            for (double timeScale = 0; timeScale < interval; timeScale += deltaTime)
            {
                //Рассчитываем потоки
                for (int i = 0; i < flowsA.Length; i++)
                    flowsA[i].MakeFlow(deltaTime);

                for (int i = 0; i < flowsB.Length; i++)
                    flowsB[i].MakeFlow(deltaTime);

                outputFlow.MakeFlow();

                //Рассчитываем задержки в промежуточном потоке
                for (int i = 0; i < flowsA.Length; i++)
                    flowsA[i].CalculateDelay();

                for (int i = 0; i < flowsB.Length; i++)
                    flowsB[i].CalculateDelay();

                //Пробуем пополнить ресурсы
                inputFlowA.TryComplation();
                inputFlowB.TryComplation();
            }
        }
    }

    class Flow
    {
        readonly double maxDelay;
        readonly double minDelay;
        readonly double midDelay;

        double lastDelay;

        public Level From { get; set; }
        public Level To { get; set; }
        public double Rate { get; set; }
        public double Alpha { get; set; }

        public Flow(Level from, Level to, double maxDelay, double minDelay, double alpha, double rate = 0.0)
        {
            From = from;
            To = to;
            Rate = rate;

            this.minDelay = minDelay;
            this.maxDelay = maxDelay;
            midDelay = (midDelay + maxDelay) / 2.0;
            lastDelay = midDelay;
            Alpha = alpha;

            CalculateDelay();
        }

        public void MakeFlow(double delta)
        {
            var deltaValue = delta * Rate;
            From.Value -= deltaValue;
            To.Value += deltaValue;

            if (From.Value < 0 || To.Value < 0) throw new Exception("Wrong value");
        }

        public void CalculateDelay()
        {
            lastDelay = minDelay + midDelay * (From.Value / lastDelay) + Alpha * maxDelay;
            Rate = From.Value / lastDelay;
            //Rate = InterpolateDelayBetween(Alpha);
        }

        private double InterpolateDelayBetween(double koeff)
        {
            if (koeff < 0 || koeff > 1) throw new Exception("Wrong koefficient");

            var interpolateDelta = maxDelay - midDelay;

            return From.Value / (midDelay + interpolateDelta * koeff);
        }
    }

    class InputFlow
    {
        public delegate double GetDistribution();

        public Level To { get; set; }

        private readonly double maxReplenishment;
        private readonly double criticalValue;
        private readonly GetDistribution getCompletion;

        public InputFlow(Level to, GetDistribution getCompletion, double maxReplenishment, double criticalValue)
        {
            this.getCompletion = getCompletion;
            this.maxReplenishment = maxReplenishment;
            this.criticalValue = criticalValue;
            To = to;
        }

        public void MakeFlow()
        {
            var deltaValue = getCompletion();
            To.Value += maxReplenishment * getCompletion();
        }

        public bool TryComplation()
        {
            if (To.Value / maxReplenishment > criticalValue) return false;

            MakeFlow();
            return true;
        }
    }

    class OutputFlow
    {
        readonly Level[] from;
        readonly double[] target;
        readonly double[] mu;
        readonly int levelsLength;
        readonly double criticalMu;

        int IssuedCount { get; set; } = 0;

        public OutputFlow(Level[] from, double[] target, double criticalMu)
        {
            levelsLength = from.Length;
            if (levelsLength != target.Length) throw new Exception("Wrong arrays");

            mu = new double[levelsLength];
            this.from = from;
            this.target = target;
            this.criticalMu = criticalMu;
        }

        public void MakeFlow()
        {
            for (int i = 0; i < levelsLength; i++)
            {
                mu[i] = from[i].Value / target[i];
                if (mu[i] < 1) return;
            }

            for (int i = 0; i < levelsLength; i++)
            {
                from[i].Value -= target[i];
            }

            IssuedCount++;
        }

        //РАБОТАЕТ ТОЛЬКО С ДВУМЯ ПЕРВЫМИ Mu
        public bool TryOverrideAlpha(Flow[] flowsA, Flow[] flowsB)
        {
            for (int i = 0; i < levelsLength; i++)
            {
                mu[i] = from[i].Value / target[i];
            }

            var deltaMu = mu[1] - mu[0];
            //Тут идёт эвристика. Будем вычитать из альфы некую константу в ветви, где mu больше            

            throw new NotImplementedException();
        }
    }

    class Level
    {
        Level() { }

        public Level(double value)
        {
            Value = value;
        }
        public double Value { get; set; }
    }

    public static class Distribution
    {
        static Random random = new Random();

        /// <summary>
        /// Получить пополнение ресурсов
        /// </summary>
        public static double GetCompletion()
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
    }
}