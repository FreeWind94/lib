using System;

namespace ds.test.impl
{
    class ExponentiationPlugin : Plugin_v1
    {
        public override string PluginName => "ExponentiationPlugin";

        public override string Description => "Плагин для возведения числа в степень. Вызов метода Run возращает результат возведения числа input1 в степень input2";

        public override int Run(int input1, int input2)
        {
            return (int)Math.Pow(input1, input2);
        }
    }
}
