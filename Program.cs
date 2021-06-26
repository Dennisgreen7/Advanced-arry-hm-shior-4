using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Arry
{
    class Program
    {
        public static void targil2()
        {
            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int flag = 0, index_;
            int count = 0;
            while (flag == 0)
            {
                Console.WriteLine("Enter number");
                int num = Convert.ToInt32(Console.ReadLine());
                index_ = Array.IndexOf(arr, num);
                if (index_ == 1)
                {
                    Console.WriteLine("You guessed right after " + count + " trys");

                    flag = 1;
                }
                else
                {
                    Console.WriteLine("You guessed wrong");
                    count++;
                }
            }
        }
        public static void targil2_etgar()
        {
            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index_ = 0, num, guess;
            int[] count = new int[10];
            int count2 = 0;

            while (index_ != 10)
            {
                Console.WriteLine("Enter number");
                num = Convert.ToInt32(Console.ReadLine());
                guess = Array.IndexOf(arr, num);
                if (guess == index_)
                {
                    Console.WriteLine("You guessed right \n ");
                    count[index_]++;
                    index_++;
                }
                else
                {
                    Console.WriteLine("You guessed wrong \n ");
                    count[index_]++;
                    count2++;
                    if (count2 == 30)
                    {
                        Console.WriteLine("Game Over \n");
                        break;
                    }
                }

            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] == 30)
                {
                    Console.WriteLine("You didnt guess the " + i + " num ");
                }
                else
                {
                    Console.WriteLine("You gussed the " + i + " num after " + count[i] + " trys");
                }
            }
        }
        public static void targil3()
        {
            int[,] arr = new int[5, 5];
            Random rnd = new Random();
            int num, index_;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    num = rnd.Next(1, 11);
                    arr[i, j] = num;
                    Console.WriteLine(arr[i, j]);
                }
            }

            Console.WriteLine("Enter number");
            index_ = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == index_)
                    {
                        Console.WriteLine("Row: " + i + " Column: " + j);
                    }
                }
            }
        }
        public static void targil4()
        {
            int[,] arr = new int[10, 10];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = (i + 1) * (j + 1);
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine("  ");
            }
        }
        public static void targil5()
        {
            int[,] arr = new int[3, 3];
            Random rnd = new Random();
            int num, shora, amoda;
            int count = 0;
            int total_zeros = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    num = rnd.Next(0, 2);
                    arr[i, j] = num;
                    if (arr[i, j] == 0)
                    {
                        total_zeros++;
                    }
                }
            }

            while (true)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                    Console.WriteLine("");
                }

                if (total_zeros == arr.Length)
                {
                    Console.WriteLine("You won after " + count + " trys");
                    break;
                }

                Console.WriteLine(total_zeros);
                Console.WriteLine("Enter shora");
                shora = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter amoda");
                amoda = Convert.ToInt32(Console.ReadLine());
                if (arr[shora, amoda] == 1)
                {
                    Console.WriteLine("Boom");
                    arr[shora, amoda] = 0;
                    total_zeros++;
                }
                else
                {
                    Console.WriteLine("Miss");
                }
                count++;
            }
        }
        public static void targil678()
        {
            //6.
            int[,,] arr = new int[6, 6, 6];
            Random rnd = new Random();
            int num;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        //לפי התרגיל
                        //Console.WriteLine("Enter num");
                        //num = Convert.ToInt32(Console.ReadLine());
                        num = rnd.Next(1, 101);
                        arr[i, j, k] = num;
                        Console.Write(arr[i, j, k] + "\t");
                    }
                    Console.WriteLine("");
                }
            }
            //7.
            int[,] arr1 = new int[6, 4];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    //לפי התרגיל
                    //Console.WriteLine("Enter num");
                    //num = Convert.ToInt32(Console.ReadLine());
                    num = rnd.Next(1, 101);
                    arr1[i, j] = num;
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            //8.
            int[][] jagArr = new int[4][];
            //מילוי מערך משונן בעזרת מערך
            for (int i = 0; i < jagArr.Length; i++)
            {
                jagArr[i] = new int[i + 1];
                for (int j = 0; j < jagArr[i].Length; j++)
                {
                    num = rnd.Next(1, 101);
                    jagArr[i][j] = num;
                    Console.Write(jagArr[i][j] + "\t");
                }
                Console.WriteLine("");
            }
        }
        public static void targil9()
        {
            int max = 0;
            int index_ = 0;
            int sum, memotza;
            Console.WriteLine("Enter num of clases");
            int num = Convert.ToInt32(Console.ReadLine());
            int[][] jagArr = new int[num][];
            int[] memotza_shihva = new int[num];

            for (int i = 0; i < jagArr.Length; i++)
            {
                Console.WriteLine("Enter num of students in class num " + (i + 1));
                num = Convert.ToInt32(Console.ReadLine());
                jagArr[i] = new int[num];
                memotza = 0;
                sum = 0;
                for (int j = 0; j < jagArr[i].Length; j++)
                {
                    Console.WriteLine("Enter grade of student " + (j + 1));
                    num = Convert.ToInt32(Console.ReadLine());
                    jagArr[i][j] = num;
                    sum += jagArr[i][j];
                    if (j == jagArr[i].Length - 1)
                    {
                        memotza = sum / jagArr[i].Length;
                        if (memotza > max)
                        {
                            max = memotza;
                            index_ = i + 1;
                        }
                        Console.WriteLine("memotza " + memotza);
                        //לפי התרגיל
                        //memotza_shihva[i] = memotza;
                    }
                }
                Console.WriteLine("");
            }
            //לפי התרגיל 
            //for (int i = 0; i < memotza_shihva.Length; i++)
            //{
            //    if (memotza_shihva[i] > max)
            //    {
            //        max = memotza_shihva[i];
            //        index_ = i + 1;
            //    }
            //}
            Console.WriteLine("class num " + index_ + " have the best memotza " + max);
        }
        static void Main(string[] args)
        {
            //targil2();
            //targil2_etgar();
            //targil3();
            //targil4();
            //targil5();
            //targil678();
            targil9();
            Console.ReadLine();
        }
    }
}
