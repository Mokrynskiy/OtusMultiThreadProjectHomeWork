using System.Diagnostics;
using System.Numerics;

namespace OtusMultiThreadProjectHomeWork
{
    internal class Program
    {
        static Stopwatch sw = new Stopwatch();
        static async Task Main(string[] args)
        {
            RunOneTreadingTest();
            RunParalelLinqTest();
            await RunMultiTaskTest();
            RunMultiThreadTest();
        }

        static void RunOneTreadingTest()
        {
            Console.WriteLine("Сумма массива в однопоточном режиме:");
            OneThreadRangeSum oneThreadRangeSum = new OneThreadRangeSum();
            sw.Reset();
            sw.Start();
            var res1 = oneThreadRangeSum.GetResult(1,100000);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 100000: результат - {res1}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var res2 = oneThreadRangeSum.GetResult(1, 1000000);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 1000000: результат - {res2}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var res3 = oneThreadRangeSum.GetResult(1, 10000000);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 10000000: результат - {res3}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
        }

        static void RunParalelLinqTest()
        {
            Console.WriteLine("Сумма массива ParalelLinq:");
            ParallelLinqRangeSum paralelLinqRangeSum = new ParallelLinqRangeSum();
            sw.Reset();
            sw.Start();
            var res1 = paralelLinqRangeSum.GetResult(1, 100000);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 100000: результат - {res1}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var res2 = paralelLinqRangeSum.GetResult(1, 1000000);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 1000000: результат - {res2}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var res3 = paralelLinqRangeSum.GetResult(1, 10000000);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 10000000: результат - {res3}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
        }

        static async Task RunMultiTaskTest()
        {
            MultiTaskRangeSum multiTaskRangeSum = new MultiTaskRangeSum();  
            
            Console.WriteLine("Сумма массива (Class Task) - 2 потока");
            sw.Reset();
            sw.Start();
            var twoTaskRes1 = await multiTaskRangeSum.GetResult(1, 100000, 2);
            sw.Stop();            
            Console.WriteLine($"Cумма чисел от 1 до 100000: результат - {twoTaskRes1}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var twoTaskRes2 = await multiTaskRangeSum.GetResult(1, 1000000, 2);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 1000000: результат - {twoTaskRes2}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var twoTaskRes3 = await multiTaskRangeSum.GetResult(1, 10000000, 2);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 10000000: результат - {twoTaskRes3}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Сумма массива (Class Task) - 4 потока");
            sw.Reset();
            sw.Start();
            var fourTaskRes1 = await multiTaskRangeSum.GetResult(1, 100000, 4);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 100000: результат - {fourTaskRes1}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var fourTaskRes2 = await multiTaskRangeSum.GetResult(1, 1000000, 4);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 1000000: результат - {fourTaskRes2}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var fourTaskRes3 = await multiTaskRangeSum.GetResult(1, 10000000, 4);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 10000000: результат - {fourTaskRes3}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Сумма массива (Class Task) - 8 потоков");
            sw.Reset();
            sw.Start();
            var eightTaskRes1 = await multiTaskRangeSum.GetResult(1, 100000, 8);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 100000: результат - {eightTaskRes1}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var eightTaskRes2 = await multiTaskRangeSum.GetResult(1, 1000000, 8);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 1000000: результат - {eightTaskRes2}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var eightTaskRes3 = await multiTaskRangeSum.GetResult(1, 10000000, 8);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 10000000: результат - {eightTaskRes3}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Сумма массива (Class Task) - 16 потоков");
            sw.Reset();
            sw.Start();
            var sixteenTaskRes1 = await multiTaskRangeSum.GetResult(1, 100000, 16);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 100000: результат - {sixteenTaskRes1}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var sixteenTaskRes2 = await multiTaskRangeSum.GetResult(1, 1000000, 16);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 1000000: результат - {sixteenTaskRes2}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var sixteenTaskRes3 = await multiTaskRangeSum.GetResult(1, 10000000, 16);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 10000000: результат - {sixteenTaskRes3}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
        }
        static void RunMultiThreadTest()
        {
            MultiThreadRangeSum multiThreadRangeSum = new MultiThreadRangeSum();

            Console.WriteLine("Сумма массива (Class Thread) - 2 потока");
            sw.Reset();
            sw.Start();
            var twoTreadRes1 = multiThreadRangeSum.GetResult(1, 100000, 2);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 100000: результат - {twoTreadRes1}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var twoTreadRes2 = multiThreadRangeSum.GetResult(1, 1000000, 2);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 1000000: результат - {twoTreadRes2}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var twoTreadRes3 = multiThreadRangeSum.GetResult(1, 10000000, 2);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 10000000: результат - {twoTreadRes3}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Сумма массива (Class Thread) - 4 потока");
            sw.Reset();
            sw.Start();
            var fourTreadRes1 = multiThreadRangeSum.GetResult(1, 100000, 4);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 100000: результат - {fourTreadRes1}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var fourTreadRes2 = multiThreadRangeSum.GetResult(1, 1000000, 4);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 1000000: результат - {fourTreadRes2}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var fourTreadRes3 = multiThreadRangeSum.GetResult(1, 10000000, 4);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 10000000: результат - {fourTreadRes3}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Сумма массива (Class Thread) - 8 потоков");
            sw.Reset();
            sw.Start();
            var eightTreadRes1 = multiThreadRangeSum.GetResult(1, 100000, 8);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 100000: результат - {eightTreadRes1}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var eightTreadRes2 = multiThreadRangeSum.GetResult(1, 1000000, 8);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 1000000: результат - {eightTreadRes2}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var eightTreadRes3 = multiThreadRangeSum.GetResult(1, 10000000, 8);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 10000000: результат - {eightTreadRes3}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Сумма массива (Class Thread) - 16 потоков");
            sw.Reset();
            sw.Start();
            var sixteenTreadRes1 = multiThreadRangeSum.GetResult(1, 100000, 16);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 100000: результат - {sixteenTreadRes1}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var sixteenTreadRes2 = multiThreadRangeSum.GetResult(1, 1000000, 16);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 1000000: результат - {sixteenTreadRes2}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            sw.Reset();
            sw.Start();
            var sixteenTreadRes3 = multiThreadRangeSum.GetResult(1, 10000000, 16);
            sw.Stop();
            Console.WriteLine($"Cумма чисел от 1 до 10000000: результат - {sixteenTreadRes3}; время выполнения - {sw.Elapsed.TotalMicroseconds} мс.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
        }

    }
}
