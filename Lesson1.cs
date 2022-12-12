using System;
using System.Threading;
namespace TIC_TAC_TOE
{

    class Lesson1
    {

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Игрок_1:X и Игрок_2:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Ход игрока 2");
                }
                else
                {
                    Console.WriteLine("Ход игрока 1");
                }
                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else

                {
                    Console.WriteLine("Извините, строка {0} уже отмечена символом {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Пожалуйста, подождите 2 секунды, пока доска снова загрузится...");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);

            Console.Clear();
            Board();
            if (flag == 1)

            {
                Console.WriteLine("Игрок {0} выиграл", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Ничья");
            }
            Console.ReadLine();
        }

        private static void DrawVoid(int num)
        {
            if (num == 2)
            {
                num = 4;
            }
            if (num == 3)
            {
                num = 7;
            }
            Console.Write('|');
            if (arr[num] != 'O' && arr[num] != 'X')
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            Console.Write("     ");
            Console.ResetColor();
            Console.Write('|');
            if (arr[num + 1] != 'O' && arr[num + 1] != 'X')
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            Console.Write("     ");
            Console.ResetColor();
            Console.Write('|');
            if (arr[num + 2] != 'O' && arr[num + 2] != 'X')
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            Console.Write("     ");
            Console.ResetColor();
            Console.Write("|\n");
        }
        private static void DrawVert(int num)
        {
            if (num == 2)
            {
                num = 4;
            }
            if (num == 3)
            {
                num = 7;
            }
            Console.Write('|');
            if (arr[num] != 'O' && arr[num] != 'X')
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            Console.Write("_____");
            Console.ResetColor();
            Console.Write('|');
            if (arr[num + 1] != 'O' && arr[num + 1] != 'X')
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            Console.Write("_____");
            Console.ResetColor();
            Console.Write('|');
            if (arr[num + 2] != 'O' && arr[num + 2] != 'X')
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            Console.Write("_____");
            Console.ResetColor();
            Console.Write("|\n");
        }
        private static void DrawChoise(int num)
        {
            if (num == 2)
            {
                num = 4;
            }
            if (num == 3)
            {
                num = 7;
            }
            Console.Write('|');
            if (arr[num] != 'O' && arr[num] != 'X')
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;

            }
            Console.Write("  {0}  ", arr[num]);
            Console.ResetColor();
            Console.Write('|');
            if (arr[num + 1] != 'O' && arr[num + 1] != 'X')
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            Console.Write("  {0}  ", arr[num + 1]);
            Console.ResetColor();
            Console.Write('|');
            if (arr[num + 2] != 'O' && arr[num + 2] != 'X')
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;

            }
            Console.Write("  {0}  ", arr[num + 2]);
            Console.ResetColor();
            Console.Write("|\n");
        }



        private static void Board()
        {
            Console.WriteLine("___________________");
            DrawVoid(1);
            DrawChoise(1);
            DrawVert(1);
            DrawVoid(2);
            DrawChoise(2);
            DrawVert(2);
            DrawVoid(3);
            DrawChoise(3);
            DrawVert(3);
        }

        private static int CheckWin()
        {
            #region Horzontal Winning Condtion

            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }

            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }

            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion

            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }

            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }

            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw

            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}