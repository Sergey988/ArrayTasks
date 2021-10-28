using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace ArrayTasks
{
    class Program
    {
        static void printArray(int [,] arr, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write($"{arr[i,j]}\t");
                Console.WriteLine();
            }
        }

        static int SumElements(int[,] arr, int rows, int columns)
        {

            int max = (from int num in arr select num).Max();
            int min = (from int num in arr select num).Min();
            int sum = 0;
            int perToCount = 0;
            int? doubleNumber = null;
            int[] indexMin = new int[2];
            int[] indexMax = new int[2];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (arr[i, j] == min || arr[i, j] == max)
                    {
                        if (doubleNumber == arr[i, j]) perToCount--;
                        perToCount++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{arr[i, j]}\t");
                    }
                    else
                    {
                        if (perToCount == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{arr[i, j]}\t");
                            sum += arr[i, j];
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.Write($"{arr[i, j]}\t");
                        }
                    }
                    doubleNumber = arr[i, j];
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            return sum;
        }

        static void Main(string[] args)
        {

            #region Task1
            //There are two arrays with the size of M and N, respectively. The common non-recurring elements
            //of the first two arrays should be written in the third array.

            //int[] firstArray = new int[] { 1, 15, 20, 21, 25, 30, 9, 8, 4, 6 };
            //int[] secondArray = new int[] { 2, 4, 3, 6, 20, 24, 5, 30, 6, 8, 7};
            //int[] thirdArray = new int[firstArray.Length + secondArray.Length];
            //string result = "";
            //int count;
            //firstArray.CopyTo(thirdArray, 0);
            //secondArray.CopyTo(thirdArray, firstArray.Length);

            //for (int i = 0; i < thirdArray.Length-1; i++)
            //{
            //    count = 0;
            //    for (int j = 0; j < thirdArray.Length-1; j++)
            //         if (thirdArray[i] == thirdArray[j])
            //            count ++;
            //    if (count == 1)
            //        result += thirdArray[i] + " ";
            //}
            //string[] resultArray = result.Split(' ');
            //int[] finalArray = new int[resultArray.Length];

            //for (int i = 0; i < finalArray.Length-1; i++)
            //{
            //    finalArray[i] = int.Parse(resultArray[i]);
            //    Console.Write($"{ finalArray[i]} ");
            //}
            #endregion

            #region Task2
            //Count the number of words in the entered sentence.

            //Console.WriteLine("Entered sentence - ");
            //string sentence = Console.ReadLine();
            //sentence = Regex.Replace(sentence, @"\s+", " ");
            //string[] sentenceArr = sentence.Split(' ', ',', '.', '!', '?');
            //int count = 0;
            //foreach (var item in sentenceArr)
            //    if (item != "") 
            //        count++;
            //Console.WriteLine($"Count the number of words in the entered sentence - {count}");

            #endregion

            #region Task3
            //Given a two-dimensional array with the size of 5x5, filled with random numbers in the range of -100 to 100.
            //Determine the sum of array elements located between the minimum and maximum elements. 

            //int[,] task3Array = new int[5, 5];
            //int rows = task3Array.GetUpperBound(0) + 1;
            //int columns = task3Array.Length / rows;

            //Random rand = new Random();
            //for (int i = 0; i < rows; i++)
            //    for (int j = 0; j < columns; j++)
            //        task3Array[i, j] = rand.Next(-100, 100);
            //printArray(task3Array, rows, columns);

            //Console.WriteLine("------------------------------------");
            //Console.WriteLine($"\nSum - {SumElements(task3Array, rows, columns)}");

            #endregion

            #region Task4
            //Determine the number of elements in the array which differs from the minimum number by 5.
            //int[] arrTask4 = new int[10];
            //int count = 0;
            //Random rand = new Random();
            //for (int i = 0; i < arrTask4.Length; i++)
            //    arrTask4[i] = rand.Next(10);
            //int min = arrTask4.Min();
            //for (int i = 0; i < arrTask4.Length; i++)
            //{
            //    if (arrTask4[i] == min + 5)
            //        count++;
            //    Console.Write($"{arrTask4[i]} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Min number - {min};\tCount numbers which differs from the minimum number by 5 - {count}");

            #endregion

            #region Task5

            //Given an array of integer numbers. Check if it contains the same elements.
            //int[] arrTask5 = new int[10];
            //Random rand = new Random();
            //int containsNumber;
            //string allCountainsNumber = "";

            //for (int i = 0; i < arrTask5.Length; i++)
            //{
            //    arrTask5[i] = rand.Next(10);
            //    Console.Write($"{arrTask5[i]} ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < arrTask5.Length; i++)
            //{
            //    containsNumber = arrTask5[i];
            //    for (int j = i + 1; j < arrTask5.Length; j++)
            //        if (containsNumber == arrTask5[j])
            //            if (allCountainsNumber.Contains(containsNumber.ToString()) == false)
            //            {
            //                allCountainsNumber += containsNumber + " ";
            //                break;
            //            }
            //}
            //Console.WriteLine(allCountainsNumber);
            #endregion

            #region Task6
            //Fill the array with random numbers, and then display it.
            //Find the longest sequence of numbers ordered by ascending.
            //Display it on the screen. If there is more than one, so you should display all of them.

            //int[] arrTask6 = new int[20];
            //Random rand = new Random();
            //for (int i = 0; i < arrTask6.Length; i++)
            //{
            //    arrTask6[i] = rand.Next(10);
            //    Console.Write($"{arrTask6[i]} ");
            //}
            //string seqOfNumbers = "";
            //bool curNumber = false;

            ////int[] arrTask6 = new int[] { 1, 2, 3, 5, 7, 9, 1, 2 };      //8 - length

            //Console.WriteLine();
            //for (int i = 0; i < arrTask6.Length; i++)
            //{
            //    if ((i + 1) < arrTask6.Length)
            //    {
            //        if (arrTask6[i] == arrTask6[i + 1] - 1)
            //        {
            //            if (curNumber == true)
            //                seqOfNumbers += arrTask6[i+1] + " ";
            //            else
            //                seqOfNumbers += arrTask6[i] + " " + arrTask6[i+1] + " ";
            //            curNumber = true;
            //        }
            //        else
            //        {
            //            if(!String.IsNullOrEmpty(seqOfNumbers))
            //                Console.WriteLine(seqOfNumbers);
            //            seqOfNumbers = "";
            //            curNumber = false;
            //        }
            //    } 
            //    else
            //    {
            //        if (!String.IsNullOrEmpty(seqOfNumbers))
            //            Console.WriteLine(seqOfNumbers);
            //        seqOfNumbers = "";
            //        curNumber = false;
            //    }
            //}

            #endregion

        }
    }
}
