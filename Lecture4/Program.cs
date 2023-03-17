using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Lecture4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {//var str = Console.ReadLine();

            //int result = 0;
            //int result2 = 0;
            //// 123
            //var temp = int.Parse(str);

            //while(temp != 0)
            //{
            //    result += temp % 10;
            //    temp /= 10;
            //}

            //Console.WriteLine(result);

            //for(int i = 0; i < str.Length; i++)
            //{
            //    var l = Convert.ToInt32(str[i].ToString());
            //    result2 += l;   
            //}
            //Console.WriteLine(result2);
            //var num1 = 1;
            //var num2 = 2;
            ////var result = SumTwoNumbers(num1, num2);

            ////Console.WriteLine(result);
            //var result = FindMax(num1, num2);


            //Console.WriteLine(factorial(3));
            //Console.WriteLine(factorial(6));
            //Console.WriteLine(factorial(7));
            //int n1 = 100;
            //int n2 = 200;
            //Console.WriteLine($"n1 = {n1}");
            //Console.WriteLine($"n1 = {n2}");

            ////swap(n1, n2);
            //swapNew(ref n1 ,ref n2);   

            //Console.WriteLine($"new n1 = {n1}");
            //Console.WriteLine($"new n2 = {n2}");

            //var price = 100.0;
            //Console.WriteLine($"old price: {price}");
            //changePrice(ref price);
            //Console.WriteLine($"new price: {price}");
            //changePrice(ref price);
            //changePrice(ref price);
            //changePrice(ref price);
            //changePrice(ref price);
            //Console.WriteLine($"new price2: {price}");
            }
            //var tt = 527348.0;
            //Console.WriteLine($"current tt {tt}");

            //getPrice(out tt);
            //Console.WriteLine($"after method tt {tt}");

            //string[] strings = new string[10];
            //strings[0] = "First";

            //string[] strings1 = { "a", "b", "c" };
            //string[] strings2 = new string[5] { "q", "w", "e", "r", ""};
            //string[] strings3 = new string[] { "q", "w", "e", "r", "" };
            //string[] strings4 = strings;

            //int[] n = new int[25];
            //for(int i = 0; i < 25; i++)
            //{
            //    n[i] = i + 100;
            //}

            //for (int j = 0; j< 25; j++)
            //{
            //    Console.WriteLine($"n[{j}] = {n[j]}");
            //}
            //foreach(var t in n)
            //{
            //    Console.WriteLine($"t = {t}");
            //}

            //int[,] array1 = new int[3, 4] {
            //{ 1,2,3,4 },
            //{ 2,3,4,5 },
            //{ 3,4,5,6 }
            //};

            //for(int i = 0; i< 3; i++)
            //{
            //    for(int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine($"array[{i} {j}] = {array1[i,j]}");
            //    }
            //}
            //int[][] numbers = new int [5][];
            //for(int i = 0; i< numbers.Length; i++)
            //{
            //    numbers[i]  = new int[4];
            //}

            int i = 5, j;
            Console.WriteLine(j = i * 2);

            //int[][] a = new int[][] {
            //    new int[] { 0,0},
            //    new int[] { 1,2, 3},
            //    new int[] { 3,4, 6, 6, 6},
            //    new int[] { 5,6},
            //    new int[] { 7,8}
            //};
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine($"a[{i}][{j}] = {a[i][j]}");
            //    }
            //}
            //int[] numb = new int[] { -1, 0, 5};
            //Console.WriteLine(getAvg(numb));

        }
        static double getAvg(int[] arr)
        {
            double avg = 0;
            double sum = 0;

            foreach(var i in arr)
            {
                sum += i;
            }
            avg = sum / arr.Length;
            return avg;
        }

        //static void changePrice (ref double price)
        //{
        //    price *= 1.2;
        //    Console.WriteLine($"price inside method : {price}");
        //}

        static void getPrice(out double price)
        {
            var t = 55;
            price = t;
            Console.WriteLine($"price inside method : {price}");
        }
        //static int SumTwoNumbers(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //static int FindMax(int num1, int num2)
        //{
        //    int result = 0;
        //    if (num1 > num2)
        //    {
        //        result = num1;
        //    }
        //    else
        //        result = num2;
        //    return result;
        //}

        //static int factorial(int num)
        //{
        //    int result;
        //    if (num == 1)
        //        return 1;
        //    else
        //    {
        //        result = factorial(num - 1) * num;
        //        return result;
        //    }
        //}

        //static void swap(int n1, int n2)
        //{
        //    int temp = n1;
        //    n1= n2;
        //    n2 = temp;
        //}

        //static void swapNew(ref int n1, ref int n2)
        //{
        //    int temp = n1;
        //    n1 = n2;
        //    n2 = temp;
        //}

    }
}