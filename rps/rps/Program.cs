using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rps
{
    class Program
    {

        static void Main(string[] args)
        {
            for (; ; )
            {
                Random random = new Random();
                int num = random.Next(3);
                string text;

                Console.WriteLine("rock, paper or scizors?");

                text = Console.ReadLine();

                if (text == "rock")
                {
                    if (num == 1)
                    {
                        Console.WriteLine("You Lose!");
                    }

                    if (num == 2)
                    {
                        Console.WriteLine("You win!");
                    }

                    if (num == 0)
                    {
                        Console.WriteLine("It's A Tie");
                    }
                }
                if (text == "paper")
                {
                    if (num == 1)
                    {
                        Console.WriteLine("You Lose!");
                    }

                    if (num == 2)
                    {
                        Console.WriteLine("You win!");
                    }


                    if (num == 0)
                    {
                        Console.WriteLine("It's A Tie");
                    }
                }
                if (text == "scizors")
                {
                    if (num == 1)
                    {
                        Console.WriteLine("You Lose!");
                    }

                    if (num == 2)
                    {
                        Console.WriteLine("You win!");
                    }


                    if (num == 0)
                    {
                        Console.WriteLine("It's A Tie");
                    }
                }

            }
        }
    }
}
