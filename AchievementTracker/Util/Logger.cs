﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchievementTracker.Util
{
    public static class Logger
    {
        public static void Log(string msg)
        {
            Main.Instance.ModHelper.Console.WriteLine("[Achievements] Log: " + msg, OWML.Common.MessageType.Info);
        }

        public static void LogError(string msg)
        {
            Main.Instance.ModHelper.Console.WriteLine("[Achievements] Error: " + msg, OWML.Common.MessageType.Error);
        }
    }
}
