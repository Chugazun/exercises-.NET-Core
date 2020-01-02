using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercisesCore.Ex_Prime
{
    class Ex_Prime
    {
        //static void Main(string[] agrs)
        //{
        //    Console.WriteLine("Insira o número desejado (Positivo)");
        //    int num = int.Parse(Console.ReadLine());
        //    Console.WriteLine(IsPrime(num));
        //}

        static string IsPrime(int num)
        {
            bool check = false;
            if(num == 2)
            {
                check = true;
            } else if (num % 2 == 0)
            {
                check = true;
            } else if (SumDigits(num) % 3 == 0 && num != 3)
            {
                check = true;
            } else if (num % 10 == 0 || num % 10 == 5)
            {
                check = true;
            } else if (SevenRule(num) % 7 == 0 && num != 7)
            {
                check = true;
            } else if (NumToArray(num) % 11 == 0 && num != 11)
            {
                check = true;
            }
            if (!check && num > 12)
            {
                for (int i = 2; i < num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        check = true;
                        break;
                    }
                }
            }
            if (check)
            {
                return "O número " + num + " não é primo.";
            }

            return "O número " + num + " é primo.";
        }

        static int SumDigits (int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        static int SevenRule (int n)
        {
            int lastDigit = n % 10 * 2, numMLast = n / 10;

            return numMLast - lastDigit;

        }

        static int NumToArray (int n)
        {
            List<int> digits = new List<int>();
            int evens = 0, odds = 0;
            while (n != 0)
            {
                digits.Add(n % 10);
                n /= 10;
            }
            digits.Reverse();
            for (int i = 0; i < digits.Count(); i++)
            {
                if (i % 2 == 0)
                {
                    evens += digits[i];
                } else
                {
                    odds += digits[i];
                }
            }
            return evens - odds;
        }
    }
}
