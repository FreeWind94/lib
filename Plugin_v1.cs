

using System.Drawing;

namespace ds.test.impl
{
    abstract class Plugin_v1 : IPlugin
    {
        static private Image defaultImage;

        protected Plugin_v1()
        {
            if(defaultImage == null)
            {
                defaultImage = new Bitmap(10, 10);
            }
        }

        public abstract string PluginName { get; }

        public string Version => "1.0";

        public abstract string Description { get; }

        public Image Image => defaultImage;

        public abstract int Run(int input1, int input2);
    }
}
