using System;

namespace inclassassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the years of experience");
            try
            {
                string input = Console.ReadLine();
                int years = 0;
                switch (years)
                {
                    case 0:
                        Console.WriteLine("need lots of practice");
                        Console.WriteLine("Press any key to exit the program ...");
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("Looks like you have a little experience");
                        Console.WriteLine("Press any key to exit the program ...");
                        Console.ReadKey(true);
                        break;
                    case 2:
                        Console.WriteLine("Wow! You have been doing this for a while");
                        Console.WriteLine("Press any key to exit the program ...");
                        Console.ReadKey(true);
                        break;
                    default:
                        Console.WriteLine("You are an expert");
                        Console.WriteLine("Press any key to exit the program ...");
                        Console.ReadKey(true);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Please enter");

                Console.ReadKey(true);
            }    
        }
        }
    }

