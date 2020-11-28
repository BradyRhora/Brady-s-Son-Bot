using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace Brady_s_Son_Bot
{
    class Constants
    {
        public class Colours
        {
            public static Color SPOTIFY_GREEN = new Color(8, 195, 103);
            public static Color DEFAULT = new Color();
        }

        public class Users
        {
            public static ulong BRADY = 108312797162541056;
            public static ulong EZRA = 481633326831108096;
            public static ulong TEK = 157848178681446401;
        }

        public class Strings
        {
            public static string DB_CONNECTION_STRING = @"data source=Files\RaidDB.db";
        }
    }
}
