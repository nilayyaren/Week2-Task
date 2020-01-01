using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            char choice;
            do
            {
                Console.WriteLine("enter the number which is odd and also greater than or equal to 7");
                number = Convert.ToInt32(Console.ReadLine());
            }
            while (number < 7 || number % 2 == 0);
            {
                step:
                Console.WriteLine("choose one of the operators: '+' '-' '*' '/'");
                choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("");
                switch (choice)
                {
                    case '+':
                        for (int i = 0; i < number; i++)
                        {
                            for (int j = 0; j < number; j++)
                            {
                                if (i == number / 2 || j == number / 2)
                                {
                                    Console.Write("*");
                                }
                                else
                                    Console.Write(" ");
                            }
                            Console.Write("\n");
                        }
                        break;
                    case '-':
                        for (int i = 0; i < number; i++)
                        {
                            for (int j = 0; j < number; j++)
                            {
                                if (i == number / 2)
                                {
                                    Console.Write("*");
                                }
                                else
                                    Console.Write(" ");
                            }
                            Console.Write("\n");
                        }
                        break;
                    case '*':
                        for (int i = 0; i < number; i++)
                        {
                            for (int j = 0; j < number; j++)
                            {
                                if (i == j || i + j == number - 1)
                                {
                                    Console.Write("*");
                                }
                                else
                                    Console.Write(" ");
                            }
                            Console.Write("\n");
                        }
                        break;
                    case '/':
                        for (int i = 0; i < number; i++)
                        {
                            for (int j = 0; j < number; j++)
                            {
                                if (i + j == number - 1)
                                {
                                    Console.Write("*");
                                }
                                else
                                    Console.Write(" ");
                            }
                            Console.Write("\n");
                        }
                        break;
                    default:
                        Console.WriteLine("please choose the valid operator!!");
                        goto step;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

