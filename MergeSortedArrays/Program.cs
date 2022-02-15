using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] firstArray = { 10, 13 };
            //int[] secondArray = { 2, 3 };

            int[] firstArray = { 1, 5, 9, 10, 15, 20 };
            int[] secondArray = { 2, 3, 8, 13 };

            //int[] firstArray = { 1, 3, 5, 7, 9 };
            //int[] secondArray = { 0, 2, 4, 6, 8, 10 };

            MergeArrays objMergeArrays = new MergeArrays();
            objMergeArrays.Merge(ref firstArray, ref secondArray);

            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.Write($"{firstArray[index]} ");
            }

            Console.WriteLine();

            for (int index = 0; index < secondArray.Length; index++)
            {
                Console.Write($"{secondArray[index]} ");
            }

            Console.Read();
        }
    }
}
