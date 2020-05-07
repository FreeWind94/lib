using System;

namespace ds.test.impl
{
    class LCMPlugin : Plugin_v1
    {
        public override string PluginName => "LCMPlugin";

        public override string Description => "Плагин для нохождения наименьшего общего кратного (НОК) двух чисел. Вызов метода Run возращает НОК двух чисел, переданных в качестве параметров input1 и input2. Плагин работает только с целыми 32х битными числами";

        public override int Run(int input1, int input2)
        {
            var gcd = (new GCDPlugin()).Run(input1, input2);
            return Math.Abs(input1 * input2) / gcd;
        }
    }
}
