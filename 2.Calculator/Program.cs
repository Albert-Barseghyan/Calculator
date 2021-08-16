using System;

namespace _2.Calculator
{
    class Program
    {
        static bool Operation(ref double res)
        {
            double op;
            string tion;

            Console.Write("Input operation: ");
            if ((tion = Console.ReadLine()) == "=") {Console.WriteLine("Result = " + res); return false; }

            Console.Write("Input Operator: ");
            op = Convert.ToDouble(Console.ReadLine());

            if (tion ==  "-") res -= op;
            else if (tion == "+") res += op;
            else if (tion == "*") res *= op;
            else if (tion == "/") { if (op == 0) { Console.WriteLine("Error"); return false; } res /= op;}
            else { Console.WriteLine("Error"); return false; }

            //Console.WriteLine("Result = " + res);
            return true;
        }
        static void Main(string[] args)
        {
            double result;
            bool b = true;

            Console.Write("Input both operation characters and operators separately.Operations can be (+,-,*,/ or =).\nEnter operator: ");
            result = Convert.ToDouble(Console.ReadLine());

            while (b)
            {
                b = Operation(ref result);
            }

        }
    }
}
