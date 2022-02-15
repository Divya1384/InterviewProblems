using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArrays
{
    public class MergeArrays
    {
        public void Merge(ref int[] firstArray, ref int[] secondArray)
        {
            int firstArrayIndex = 0, secondArrayIndex = 0, mergeArrayIndex = 0;

            int firstArraySize = firstArray.Length;
            int secondArraySize = secondArray.Length;

            int highestFirstArrayElement = firstArray[firstArraySize - 1];
            int highestSecondArrayElement = secondArray[secondArraySize - 1];

            int maxValue = (highestFirstArrayElement > highestSecondArrayElement)
                ? highestFirstArrayElement + 1
                : highestSecondArrayElement + 1;

            while (firstArrayIndex < firstArraySize && secondArrayIndex < secondArraySize &&
                   mergeArrayIndex < (firstArraySize + secondArraySize))
            {
                int firstArrayElement = firstArray[firstArrayIndex] % maxValue;
                int secondArrayElement = secondArray[secondArrayIndex] % maxValue;

                if (firstArrayElement <= secondArrayElement)
                {
                    if (mergeArrayIndex < firstArraySize)
                    {
                        firstArray[mergeArrayIndex] += firstArrayElement * maxValue;
                    }
                    else
                    {
                        secondArray[mergeArrayIndex - firstArraySize] += firstArrayElement * maxValue;
                    }

                    mergeArrayIndex++;
                    firstArrayIndex++;
                }
                else
                {
                    if (mergeArrayIndex < firstArraySize)
                    {
                        firstArray[mergeArrayIndex] += secondArrayElement * maxValue;
                    }
                    else
                    {
                        secondArray[mergeArrayIndex - firstArraySize] += secondArrayElement * maxValue;
                    }

                    mergeArrayIndex++;
                    secondArrayIndex++;
                }
            }

            while (firstArrayIndex < firstArraySize)
            {
                int firstArrayElement = firstArray[firstArrayIndex] % maxValue;

                if (mergeArrayIndex < firstArraySize)
                {
                    firstArray[mergeArrayIndex] += firstArrayElement * maxValue;
                }
                else
                {
                    secondArray[mergeArrayIndex - firstArraySize] += firstArrayElement * maxValue;
                }

                mergeArrayIndex++;
                firstArrayIndex++;
            }

            while (secondArrayIndex < secondArraySize)
            {
                int secondArrayElement = secondArray[secondArrayIndex] % maxValue;

                if (mergeArrayIndex < firstArraySize)
                {
                    firstArray[mergeArrayIndex] += secondArrayElement * maxValue;
                }
                else
                {
                    secondArray[mergeArrayIndex - firstArraySize] += secondArrayElement * maxValue;
                }

                secondArrayIndex++;
                mergeArrayIndex++;
            }

            for (int index = 0; index < firstArraySize; index++)
            {
                firstArray[index] = firstArray[index] / maxValue;
            }

            for (int index = 0; index < secondArraySize; index++)
            {
                secondArray[index] = secondArray[index] / maxValue;
            }
        }
    }
}
