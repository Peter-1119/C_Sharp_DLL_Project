using System;
using System.IO;

namespace MathLibrary
{
    public class MathOperations
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                logError("Division by zero attemped.");
                return double.NaN;
            }
            return (double)a / b;
        }

        private static void logError(string msg)
        {
            string logPath = "log.txt";
            using (StreamWriter sw = new StreamWriter(logPath, true))
            {
                sw.WriteLine($"{DateTime.Now}: {msg}");
            }
        }
    }
}
