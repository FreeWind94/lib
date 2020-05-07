using System;
using System.Reflection;

namespace ds.test.impl
{
    public static class Plugins
    {
        public static int PluginsCount => GetPluginNames.Length;

        public static string[] GetPluginNames { get; } = {
            "SummPlugin",
            "SubtractionPlugin",
            "MultiplePlugin",
            "DivisionPlugin",
            "RemainderPlugin",
            "ExponentiationPlugin",
            "GCDPlugin",
            "LCMPlugin"
        };

        public static IPlugin GetPlugin(string pluginName)
        {
            var pluginType = Type.GetType("ds.test.impl." + pluginName);

            return (IPlugin)Activator.CreateInstance(pluginType);
        }
    }
}
