using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BotNet_Control
{
    static class configs
    {
        public static string server { get; set; }
        public static string server_title { get; set; }

        public static string spliter { get; } = "{split}";

        public static string auth_file { get; } = "TokenData";
    }
}
