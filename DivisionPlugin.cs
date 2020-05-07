using System;

namespace ds.test.impl
{
    class DivisionPlugin : Plugin_v1
    {
        public override string PluginName => "DivisionPlugin";

        public override string Description => "Плагин для целочисленного деления одного числа на другое. Вызов метода Run возращает результат деления input1 на input2 с округлением в сторону нуля. Плагин работает только с целыми 32х битными числами";

        public override int Run(int input1, int input2)
        {
            if (input2 == 0) throw new DivideByZeroException("Параметр input2 не может быть равен нулю");
            return input1 / input2;
        }
    }
}
