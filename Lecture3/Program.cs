using System.Diagnostics;

namespace Lecture3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var item = 0;
            //if (item > 1)
            //{
            //    Console.WriteLine($"1. {item} > 1");
            //    Console.WriteLine($"2. {item} > 1");
            //    Console.WriteLine($"3. {item} > 1");
            //}
            //else
            //{
            //    Console.WriteLine($"1. {item} < 1");
            //}

            //if (item > 1)
            //    Console.WriteLine($"1.. {item} > 1");
            //else
            //    Console.WriteLine($"1.. {item} < 1");

            //if (item > 1)
            //    Console.WriteLine($"1.. {item} > 1");
            //else
            //{
            //    Console.WriteLine($"1.. {item} < 1");
            //};
            //;

            //Console.WriteLine("Hello, World!");

            //var item = int.Parse(Console.ReadLine());

            //Console.WriteLine(item);

            //if(item >= 18)
            //{
            //    Console.WriteLine($"your number: {item} >= 18 ");
            //}
            //else
            //{
            //    Console.WriteLine($"your number: {item} < 18 ");
            //}


            //var item = Console.ReadLine();
            //int result;

            //Console.WriteLine(item);

            //if (!int.TryParse(item, out result))
            //{
            //    Console.WriteLine($"You input not a number ");
            //}
            //else if (result >= 18)
            //{
            //    Console.WriteLine($"your number: {item} >= 18 ");
            //}
            //else
            //{
            //    Console.WriteLine($"your number: {item} < 18 ");
            //}

            //var a = 100;
            //var b = 200;
            //if(a == 100)
            //{
            //    if (b != 200)
            //    {
            //        Console.WriteLine($"Var a = 100 abd b != 200");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Var a = 100 abd b == 200");
            //    }
            //}

            //char grade =  Console.ReadLine()[0];

            //switch (grade)
            //{
            //    case 'A':
            //    case 'a':
            //        Console.WriteLine("Excellent");
            //        break;
            //    case 'B':
            //        Console.WriteLine("Well done");
            //        break;
            //    case 'C':
            //        Console.WriteLine("Well done");
            //        break;
            //    case 'D':
            //        Console.WriteLine("Passed");
            //        break;
            //    case 'F':
            //        Console.WriteLine("Try again");
            //        break;
            //    default: 
            //        Console.WriteLine("Invalid grade");
            //        break;
            //}

            // (expression) ? ... : ... 
            //var item = 0;
            //var res =  item > 1 
            //    ? $"1.. {item} > 1" 
            //    : $"1.. {item} < 1";
            //Console.WriteLine(res);


            //char grade = Console.ReadLine()[0];
            //var res = grade == 'A'
            //    ? "Excellent"
            //    : grade == 'B'
            //        ? "Well done"
            //        : grade == 'C' 
            //            ? "Well done" 
            //            : grade == 'D' ? "Passed" : "Invalid grade";

            //Console.WriteLine(res);
            //var count = 0;
            //while(count <= 10)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}

            //for (var i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //var count = 0;
            //do {
            //    Console.WriteLine(count);
            //    count++;
            //} 
            //while (count >= 10);


            //var count1 = 0;
            //while (count1 >= 10)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}
            //var stopwatch = new Stopwatch();
            //stopwatch.Start();
            //for(int i = 0; i < 10; i++)
            //{
            //    for(int j = 0; j < 10; j++)
            //    {
            //        for (int k = 0; k < 5; k++)
            //            Console.WriteLine($"i = {i}; j = {j}; k = {k}");
            //    }
            //}
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed.ToString());

            //stopwatch.Restart();
            //int ii = 0;
            //int jj = 0;
            //int kk = 0;
            //while(ii < 10)
            //{
            //    while(jj < 10)
            //    {
            //        while(kk < 5)
            //        {
            //            Console.WriteLine($"ii = {ii}; jj = {jj}; kk = {kk}");
            //            kk++;
            //        }
            //        jj++; kk = 0;
            //    }
            //    ii++; jj = 0;
            //}
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed.ToString());

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        for (int k = 0; k < 5; k++)
            //        {
            //            if (k == 3)
            //            {
            //                break;
            //            }
            //            Console.WriteLine($"i = {i}; j = {j}; k = {k}");
            //        }
            //    }
            //}
            for (int? i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (k == 3)
                        {
                            continue;
                        }
                        Console.WriteLine($"i = {i}; j = {j}; k = {k}");
                    }
                }
            }
        }
    }
}