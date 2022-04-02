﻿using System.Diagnostics;

namespace testApp.Utilitites
{
    public static class TimeUtils
    {
        public static string DoSomethingAndGetTime(Action doSomething, Stopwatch StartTime)
        {
            StartTime.Restart();
            StartTime.Start();
            doSomething.Invoke();
            StartTime.Stop();
            return $"Run time --> {StartTime.Elapsed}";
        }
    }
}