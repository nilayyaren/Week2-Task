using System;

namespace Week2_AlternativeTaskSln
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
                do
                {
                    Console.WriteLine("choose one of the operators: '+' '-' '*' '/'");
                    choice = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("");
                }
                while (choice!='+' && choice!='-' && choice != '*' && choice != '/');
                {
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
                    }
                }
                Console.ReadLine();
            }
        }
    }
}

