using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            double first_num = Convert.ToDouble(input[0]);

            char op = Convert.ToChar(input[1]);

            double second_num = Convert.ToDouble(input[2]);
            //double first_num = double.Parse(Console.ReadLine());

           // char op = char.Parse(Console.ReadLine());

            //double second_num = double.Parse(Console.ReadLine());

            double result = 0;

            switch(op)
            {
                case '-':
                    result = first_num - second_num;
                break;

                case '+':
                    result = first_num + second_num;
                break;

                case '*':
                    result = first_num * second_num;
                break;
                case '/':
                    if(second_num != 0)
                    {
                        result = first_num / second_num;
                    }
                    else
                    {
                        Console.WriteLine("You cant devide by 0!");
                    }
                break;

                default:
                    Console.WriteLine("Invalid operator!");
                break;
            }
            Console.WriteLine($"{first_num}{op}{second_num} = {result}");
        }
    }
}