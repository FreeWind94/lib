

namespace ds.test.impl
{
    class SubtractionPlugin : Plugin_v1
    {
        public override string PluginName => "SubtractionPlugin";

        public override string Description => "Плагин для вычитания одного числа из другого. Вызов метода Run возращает разность двух чисел, переданных в качестве параметров input1 и input2 (из input1 вычитается input2). Плагин работает только с целыми 32х битными числами";

        public override int Run(int input1, int input2)
        {
            return input1 - input2;
        }
    }
}
