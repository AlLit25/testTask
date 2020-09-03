using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrSize, halfArr = 0;


            int[] array;
            Random rand = new Random();

            Console.WriteLine("\t*** TASK 1 ***\n");

            Console.WriteLine("Enter array size:");
            arrSize = Convert.ToInt32(Console.ReadLine());
            halfArr = arrSize - 1;

            array = new int[arrSize + halfArr];
            Console.WriteLine("Initial array:");
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) array[i] = 0;
                else
                {
                    array[i] = rand.Next(1, 10);
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Final array:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0) array[i] = array[i - 1] + array[i + 1];
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n\n\t*** TASK 2 ***\n");

            int sumA = 0, sumB = 0, sumM = 0;


            Console.WriteLine("Enter array size:");
            arrSize = Convert.ToInt32(Console.ReadLine());
            int[] mainarray = new int[arrSize];
            
            int[] a = new int[arrSize];
            int[] b = new int[arrSize];

            Console.WriteLine("Initial array:");

            for(int i = 0; i<mainarray.Length; i++)
            {
                mainarray[i] = rand.Next(1,arrSize);
                a[i] = 0;
                b[i] = 0;
                Console.Write(mainarray[i] + " ");
            }

            for (int i = 0; i < mainarray.Length; i++)
            {
                 sumM += mainarray[i];
            }

            int temp;
            for (int i = 0; i < mainarray.Length - 1; i++)
            {
                for (int j = i + 1; j < mainarray.Length; j++)
                {
                    if (mainarray[i] > mainarray[j])
                    {
                        temp = mainarray[i];
                        mainarray[i] = mainarray[j];
                        mainarray[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n\nSort array:");
            for (int i = 0; i < mainarray.Length; i++)
            {
                Console.Write(mainarray[i] + " ");
            }


            Console.WriteLine();

            for (int i = 0; i<mainarray.Length; i++)
            {
                a[i] = mainarray[i];
                mainarray[i] = 0;

                sumA = 0;
                sumB = 0;

                for(int x = 0; x<mainarray.Length; x++)
                {
                    sumA += a[x];
                    sumB += mainarray[x];
                }


                //sumA - sumB >= 0 && sumA - sumB <= arrSize/2 || sumA - sumB <= 0 && sumA - sumB >= -arrSize/2
                //sumA>=sumB || sumB>=sumM/2
                if (sumB-sumA<=2)
                {
                    Console.Write("\nA: ");
                    for (int y = 0; y < mainarray.Length; y++)
                    {
                        if (a[y] == 0) Console.Write("");
                        else Console.Write(a[y] + " ");
                    }
                    Console.Write("\nB: ");
                    for (int q = 0; q < mainarray.Length; q++)
                    {
                        b[q] = mainarray[q];
                        if (b[q] == 0) Console.Write("");
                        else Console.Write(b[q] + " ");
                    }
                    break;
                }
            }
            Console.WriteLine("\nsumA = " + sumA + "\tsumB = " + sumB);

            Console.ReadKey();
        }
    }
}
