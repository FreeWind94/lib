

namespace ds.test.impl
{
    class MultiplePlugin : Plugin_v1
    {
        public override string PluginName => "MultiplePlugin";

        public override string Description => "Плагин для перемножения двух чисел. Вызов метода Run возращает множество двух чисел, переданных в качестве параметров input1 и input2. Плагин работает только с целыми 32х битными числами";

        public override int Run(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}
