using System;

namespace domjudge_version_extractor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(typeof(string).Assembly.ImageRuntimeVersion);
        }
    }
}