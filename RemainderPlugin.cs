using System;


namespace ds.test.impl
{
    class RemainderPlugin : Plugin_v1
    {
        public override string PluginName => "RemainderPlugin";

        public override string Description => "Плагин для определения остатка от деления. Вызов метода Run возращает остаток от деления input1 на input2. Плагин работает только с целыми 32х битными числами";

        public override int Run(int input1, int input2)
        {
            if (input2 == 0) throw new DivideByZeroException("Параметр input2 не может быть равен нулю");
            return input1 % input2;
        }
    }
}
