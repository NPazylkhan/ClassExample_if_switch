using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{class Example
{
    public const double KOEF = 4.5;
    public readonly double field;
    public static double StaticField;

    public Example(int f)
    {
        this.field = KOEF * f;
        StaticField = KOEF + 0.5;
    }
        public void SetVal(int val)
        {
            StaticField = val;
        }
}
    class Account
    {
        public static decimal bonus = 100;
        public decimal totalSum;
        decimal isprivatetotalSum;
        public Account(decimal sum)
        {
            totalSum = sum + bonus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Account.bonus);      // 100
            Account.bonus += 200;

            Account account1 = new Account(150);
            Console.WriteLine(account1.totalSum);   // 450


            Account account2 = new Account(1000);
            Console.WriteLine(account2.totalSum);   // 1300

            if (account1.totalSum < 5)
            {
                Console.WriteLine('1');
            }
            else if(account1.totalSum < 50)
            {
                Console.WriteLine('2');
            }
            else if (account1.totalSum < 500)
            {
                Console.WriteLine("2.1");
            }
            else
            {
                Console.WriteLine('3');
            }

            int n = 3;
            switch (n)
            {
                case 1:
                    Console.WriteLine('1');
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine('3');
                    break;
                default:
                    Console.WriteLine("4");
                    break;
            }

                Console.ReadKey();
        }
    }
}

