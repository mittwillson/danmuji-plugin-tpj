using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMPlugin_TPJ
{
    static public class Global_Variable
    {
        private static Config _config;
        public static Config config
        {
            get { return Global_Variable._config; }
            set { Global_Variable._config = value; }
        }
    }
}
