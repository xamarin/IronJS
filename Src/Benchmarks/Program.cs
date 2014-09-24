﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace Benchmarks
{
    class Program
    {
        static string GetExecutableDirectory()
        {
            return Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);
        }

        static bool ReadYesOrNo(string question)
        {
            while(true) {
                Console.Write(question);
                switch(Console.ReadLine().Trim().ToLower()) {
                    case "yes": return true;
                    case "no": return false;
                }
            };
        }

        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.Priority =
                System.Threading.ThreadPriority.Highest;

            var basePath = args.Length > 0 ? args[0] : new DirectoryInfo(GetExecutableDirectory()).Parent.Parent.FullName;

#if !DISABLE_QUESTIONS
            if (ReadYesOrNo("Run SunSpider 0.9.1 benchmark, yes/no? "))
            {
#endif
                TestSuite sunSpider = new SunSpiderTestSuite(basePath);
                sunSpider.Run();
#if !DISABLE_QUESTIONS
            }
#endif
            
#if !DISABLE_QUESTIONS
            if (ReadYesOrNo("Run V8 Benchmark v6, yes/no? "))
            {
#endif
                TestSuite v8Benchmark = new V8BenchMarkTestSuite(basePath);
                v8Benchmark.Run();

#if !DISABLE_QUESTIONS
            }
#endif
            
#if !DISABLE_QUESTIONS
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
#endif
        }
    }
}
