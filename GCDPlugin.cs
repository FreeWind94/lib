

namespace ds.test.impl
{
    class GCDPlugin : Plugin_v1
    {
        public override string PluginName => "GCDPlugin";

        public override string Description => "Плагин для нохождения наибольшего общего делителя (НОД) двух чисел. Вызов метода Run возращает НОД двух чисел, переданных в качестве параметров input1 и input2. Плагин работает только с целыми 32х битными числами";

        public override int Run(int input1, int input2)
        {
            while (input2 != 0)
            {
                var temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            return input1;
        }
    }
}
