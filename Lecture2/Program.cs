namespace Lecture2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //var firstVariable = Console.ReadLine();
            //var incorectVariable;

            int intVariable;
            int intVariable1, intVariable2, intVariable3;

            int intVariable_;

            int intVariableWithValue = 5;
            var varVariableWithValue = "tt";
            char variable = 'd';

            Console.WriteLine($"intVariableWithValue={intVariableWithValue}    ");
            Console.WriteLine("varVariableWithValue={0}     ", varVariableWithValue);
            Console.WriteLine("variable=" + variable + "   ");
             // temp changes

            var firstVariable = Console.ReadLine();

            Console.WriteLine("firstVariable=" + firstVariable + "   .");

            bool boolVar = true; // false
            bool boolVar1 = false; // false

            double doubleVar = 0.0;
            double doubleVar1 = -1.0;
            Console.WriteLine("1boolVar=" + boolVar + "   .");
            boolVar = !boolVar;
            Console.WriteLine("2boolVar=" + boolVar + "   .");
            boolVar = !boolVar;
            Console.WriteLine("3boolVar=" + boolVar + "   .");
            boolVar = true;
            Console.WriteLine("4boolVar=" + boolVar + "   .");
            boolVar = !boolVar;
            Console.WriteLine("5boolVar=" + boolVar + "   .");
            boolVar = !boolVar;
            Console.WriteLine("6boolVar=" + boolVar + "   .");

            const string testc_ = "Hello";

            int inpConvVar = 77;
            double inpConvVar1 = inpConvVar;

            Console.WriteLine($"inpConvVar = {inpConvVar}, {inpConvVar.GetType()}");
            Console.WriteLine($"inpConvVar1 = {inpConvVar1}, {inpConvVar1.GetType()}");

            int inpConvVar2 = (int)inpConvVar1;
            Console.WriteLine($"inpConvVar2 = {inpConvVar2}, {inpConvVar2.GetType()}");
            int inpConvVar3 = (int)0.77;

            Console.WriteLine($"inpConvVar3 = {inpConvVar3}, {inpConvVar3.GetType()}");

            var toBool = 1;

            //Arithmetic 
            // + - * / % ++ --

            Console.WriteLine("---------------------");

            int a = 21, b = 10;
            int c;

            c = a + b;
            Console.WriteLine($"c = a + b / {c} /");

            c = a - b;
            Console.WriteLine($"c = a - b / {c} /");

            c = a * b;
            Console.WriteLine($"c = a * b / {c} /");

            c = a / b;
            Console.WriteLine($"c = a / b / {c} /");

            c = a % b;
            Console.WriteLine($"c = a % b / {c} /");

            c = a++;
            Console.WriteLine($"c = a++/ {c} /");
            c = a;   
            Console.WriteLine($"c = a/ {c} /");
            c = b--;
            Console.WriteLine($"c = b--/ {c} /");

            // Relational 
            // == != > < >= <=

            Console.WriteLine($"a==b {a == b}");
            Console.WriteLine($"a!=b {a != b}");
            Console.WriteLine($"a >b {a > b}");
            Console.WriteLine($"a<b {a < b}");
            Console.WriteLine($"a>=b {a >= b}");
            Console.WriteLine($"a<=b {a <= b}");

            //Logical 
            // && || !
            Console.WriteLine($"a == b && a > b {(a == b ) && (a > b)}");
            Console.WriteLine($"a == b || a > b {(a == b) || (a > b)}");
            Console.WriteLine($"!(a == b)  {!(a == b)}");

            //Assignment Operators
            // = += -= *= /= %= <<= >>= &=  |= 

            Console.WriteLine($"a = {a}, c = {c}");
            c += a; // c = c+a;
            Console.WriteLine($"c = {c}");
            c = 10;
            Console.WriteLine($"c>>=2 {c>>=2}");
            c = 10;
            Console.WriteLine($"c<<=2 {c <<= 2}");


        }
    }
}