using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
                        int maxnumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxnumber)
                {
                    maxnumber = array[i];
                }
            }

            int ResultSum = 0;
            int indexMax = 0;
            int indexNegative = 0;
            int countNegative = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxnumber)
                {
                    indexMax = i;
                    break;
                }
            }

            for (int k = indexMax + 1; k < array.Length; k++)
            {
                ResultSum += array[k];
            }

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] < 0)
                {
                    indexNegative = j;
                    countNegative++;
                    break;
                }
            }

            if (countNegative > 0)
            {
                array[indexNegative] = ResultSum;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int lastPositiveIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    lastPositiveIndex = i;
                }
            }

            answer = new int[array.Length + 1];
            if (lastPositiveIndex > -1)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (j <= lastPositiveIndex)
                    {
                        answer[j] = array[j];
                    }
                    else
                    {
                        answer[j + 1] = array[j];
                    }
                }
                answer[lastPositiveIndex + 1] = P;
            }
            else
            {
                answer = array;
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int minimalValue = 100000000;
            int indexMin = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < minimalValue)
                {
                    minimalValue = array[i];
                    indexMin = i;
                }
            }

            answer = new int[array.Length - 1];
            if (indexMin > -1)
            {
                for (int j = 0; j < answer.Length; j++)
                {
                    if (j < indexMin)
                    {
                        answer[j] = array[j];
                    }
                    else
                    {
                        answer[j] = array[j + 1];
                    }
                }
            }
            else
            {
                answer = array;
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double averageValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                averageValue += array[i];
            }

            if (averageValue != 0)
            {
                averageValue = averageValue / array.Length;
            }

            for (int j = 0; j < array.Length; j++)
            {
                array[j] = array[j] - averageValue;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length == B.Length)
            {
                for (int index = 0; index < A.Length; index++)
                {
                    sum += (A[index] * B[index]);
                }
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double averageValue = 0;
            int countBelowAverage = 0;
            int currentIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                averageValue += array[i];
            }
            averageValue = averageValue / array.Length;

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] < averageValue)
                {
                    countBelowAverage++;
                }
            }

            indexes = new int[countBelowAverage];
            for (int k = 0; k < array.Length; k++)
            {
                if (array[k] < averageValue)
                {
                    indexes[currentIndex] = k;
                    currentIndex++;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int increasingSequence = 1;
            int decreasingSequence = 1;
            bool singleElement = false;

            if (array.Length == 1)
            {
                count++;
                singleElement = true;
            }

            if (singleElement == false)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] >= array[i - 1])
                    {
                        increasingSequence++;
                    }
                    else
                    {
                        increasingSequence = 1;
                    }
                    if (increasingSequence > count)
                    {
                        count = increasingSequence;
                    }

                    if (array[i] <= array[i - 1])
                    {
                        decreasingSequence++;
                    }
                    else
                    {
                        decreasingSequence = 1;
                    }
                    if (decreasingSequence > count)
                    {
                        count = decreasingSequence;
                    }
                }
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length * 2];
            int position = 0;

            for (int i = 0; i < array.Length; i++)
            {
                answer[position] = array[i];
                answer[position + 1] = array[i];
                position += 2;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            normalized = new double[array.Length];
            int maxValue = -100000000;
            int minValue = 100000000;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            double range = maxValue - minValue;
            if (range != 0)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    normalized[j] = (array[j] - minValue) / range;
                }
            }
            else
            {
                normalized = null;
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }

            int left = 0;
            int right = array.Length - 1;
            int middle = 0;

            while (left <= right)
            {
                middle = (left + right) / 2;
                if (array[middle] == P)
                {
                    index = middle;
                    break;
                }
                else if (array[middle] < P)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            int count = 0;

            if (b < 0)
            {
                array = null;
            }
            else
            {
                for (int i = a; i <= c;)
                {
                    count++;
                    i += b;
                }

                array = new int[count];
                for (int j = 0; j < count; j++)
                {
                    array[j] = a;
                    a += b;
                }
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int maxSum = int.MinValue;
            int firstIndex = -1;
            int secondIndex = -1;
            int thirdIndex = -1;

            if (magazine.Length > 3)
            {
                indexes = new int[3];
                for (int i = 0; i < magazine.Length - 2; i++)
                {
                    if ((magazine[i] + magazine[i + 1] + magazine[i + 2]) > maxSum)
                    {
                        maxSum = (magazine[i] + magazine[i + 1] + magazine[i + 2]);
                        firstIndex = i;
                        secondIndex = i + 1;
                        thirdIndex = i + 2;
                    }
                }
                indexes[0] = firstIndex;
                indexes[1] = secondIndex;
                indexes[2] = thirdIndex;
            }
            else
            {
                indexes = new int[magazine.Length];
                for (int j = 0; j < magazine.Length; j++)
                {
                    indexes[j] = j;
                }
            }
            // end

            return indexes;
        }
    }
}
