using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[7, 6];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\t\t\t\t 1 2 3 4 5 6 7\n");
            Console.ForegroundColor = ConsoleColor.White;
            string setTab = "\t\t\t\t ";
            for (int row = 0; row < 6; row++)
            {
                Console.Write(setTab);
                for (int col = 0; col < 7; col++)
                {
                    Console.Write(0);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            bool tree = true;
            while (tree)
            {
                Console.Write("\n\n\t\t\t\tChoose a number? ");
                var userResponse = Console.ReadLine();
                switch (userResponse)
                {
                    case "1":
                        if (board[0, 0] < 4)
                        {
                            board[0, 0]++;
                            if(board[0, 0] == 4)
                            {
                                Console.WriteLine("You Win!");
                                tree = false;
                                return;
                            }
                        }
                        continue;
                    case "2":
                        if (board[1, 0] < 7)
                        {
                            board[1, 0]++;
                            if (board[1, 0] == 4)
                            {
                                Console.WriteLine("You Win!");
                                tree = false;
                                return;
                            }
                        }
                        continue;
                    case "3":
                        if (board[2, 0] < 7)
                        {
                            board[2, 0]++;
                            if (board[2, 0] == 4)
                            {
                                Console.WriteLine("You Win!");
                                tree = false;
                                return;
                            }
                        }
                        continue;
                    case "4":
                        if (board[3, 0] < 7)
                        {
                            board[3, 0]++;
                            if (board[3, 0] == 4)
                            {
                                Console.WriteLine("You Win!");
                                tree = false;
                                return;
                            }
                        }
                        continue;
                    case "5":
                        if (board[4, 0] < 7)
                        {
                            board[4, 0]++;
                            if (board[4, 0] == 4)
                            {
                                Console.WriteLine("You Win!");
                                tree = false;
                                return;
                            }
                        }
                        continue;
                    case "6":
                        if (board[5, 0] < 7)
                        {
                            board[5, 0]++;
                            if (board[5, 0] == 4)
                            {
                                Console.WriteLine("You Win!");
                                tree = false;
                                return;
                            }
                        }
                        continue;
                    case "7":
                        if (board[6, 0] < 7)
                        {
                            board[6, 0]++;
                            if (board[6, 0] == 4)
                            {
                                Console.WriteLine("You Win!");
                                tree = false;
                                return;
                            }
                        }

                        continue;
                    default:
                        continue;
                }
            }
        }
    }
}
