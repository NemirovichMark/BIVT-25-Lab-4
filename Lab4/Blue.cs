using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            // code here
            int mx = -1000000;
            int indexMx = 0;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] > mx) { 
                    mx = array[i];
                    indexMx = i;
                }
            }

            int indexUnsingedNumber = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) { 
                    indexUnsingedNumber = i;
                    break;
                }
            }

            if (indexUnsingedNumber != -1)
            {
                int summa = 0;
                for (int i = indexMx + 1; i < array.Length; i++)
                    summa += array[i];

                array[indexUnsingedNumber] = summa;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int indexLastPositiveNumber = -1;
            for (int i = array.Length - 1; i >= 0 ; i--)
            {
                if (array[i] > 0)
                {
                    indexLastPositiveNumber = i;
                    indexLastPositiveNumber++;
                    break;
                }
            }
            if (indexLastPositiveNumber == -1)
                answer = array;
            else
            {
                int[] numbers = new int[array.Length + 1];
                for (int i = 0; i < indexLastPositiveNumber; i++)
                    numbers[i] = array[i];
                numbers[indexLastPositiveNumber] = P;
                for (int i = indexLastPositiveNumber; i < array.Length; i++)
                    numbers[i + 1] = array[i];
                answer = numbers;
            }
                // end

                return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here

            int indexMinPositiveNum = -1;
            int mx = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < mx && array[i] > 0) { 
                    mx = array[i];
                    indexMinPositiveNum = i;
                }
            }
            if (indexMinPositiveNum != -1)
            {
                int[] nums = new int[array.Length - 1];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i < indexMinPositiveNum)
                        nums[i] = array[i];
                    else
                        nums[i] = array[i + 1];
                }
                //for (int i = 0; i < indexMinPositiveNum; i++)
                //    nums[i] = array[i];
                //for (int i = indexMinPositiveNum; i < nums.Length; i++)
                //{
                //    nums[i] = array[i + 1];
                //}
                answer = nums;
            }
            else
                answer = array;
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double summa = 0;
            foreach (int item in array)
                summa += item;
            double average = summa / array.Length;

            for (int i = 0; i < array.Length; i++)
                array[i] = array[i] - average;
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length == B.Length)
            {
                for (int i = 0; i < B.Length; i++)
                    sum += A[i] * B[i];
            }
            else
                sum = 0;
            // end
                return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double sum = 0;
            foreach (int item in array)
                sum += item;
            double average = sum / array.Length;

            int countForLenIndexArray = 0;
            foreach(int item in array)
            {
                if (item < average)
                    countForLenIndexArray++;
            }

            int[] copyNums = new int[countForLenIndexArray];

            int numForI = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < average)
                    copyNums[i - numForI] = i;
                else
                    numForI++;
            }
            indexes = copyNums;

            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int l = 0;
            int positiveCount = 1;
            for (int r = 1; r < array.Length; r++)
            {
                if (array[r] >= array[l])
                {
                    positiveCount++;
                    l++;
                }
                else
                {
                    if (count < positiveCount)
                        count = positiveCount;
                    l = r;
                    positiveCount = 1;
                }
            }
            if (count < positiveCount)
                count = positiveCount;

            int negativeCount = 1;
            l = 0;
            for (int r = 1; r < array.Length; r++)
            {
                if (array[r] <= array[l])
                {
                    negativeCount++;
                    l++;
                }
                else
                {
                    if (count < negativeCount)
                        count = negativeCount;
                    l = r;
                    negativeCount = 1;
                }
            }
            if (count < negativeCount)
                count = negativeCount;

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            int[] nums = new int[array.Length * 2];
            int flForNumsIteration = 0;
            for (int i = 0; i < array.Length; i++)
            {
                nums[i + flForNumsIteration] = array[i];
                nums[i + 1 + flForNumsIteration] = array[i];
                flForNumsIteration++;
            }
            answer = nums;

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int mx = int.MinValue;
            int mn = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                    mx = array[i];
                if (array[i] < mn)
                    mn = array[i]; ;
            }
            if (mn != mx) { 
                double[] nums = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    nums[i] = (double)((array[i] - mn)) / (double)((mx - mn));
                }
                normalized = nums;
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = array.Length - 1; i > 0; i--)
            {
                int maxIndex = 0;
                for (int j = 1; j < i + 1; j++)
                {
                    if (array[j] > array[maxIndex])
                        maxIndex = j;
                }
                if (maxIndex != i)
                {
                    int num = array[maxIndex];
                    array[maxIndex] = array[i];
                    array[i] = num;
                }
            }

            int r = array.Length - 1;
            int l = 0;
            bool flagOfAllNice = false;

            while (l <= r)
            {
                int middle = (r + l) / 2;
                if (array[middle] == P)
                {
                    index = middle;
                    flagOfAllNice = true;
                    break;
                }

                else if (array[middle] > P)
                    r = middle - 1;

                else
                    l = middle + 1;
            }
            if (!flagOfAllNice)
                index = -1;
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b > 0) { 
                int counter = 0;
                for (int i = a; i < c + 0.0001; i += b)
                {
                    counter++;
                }

                int count = 0;
                int[] nums = new int[counter];
                for (int i = a; i < c + 0.0001; i += b)
                {
                    nums[count] = i;
                    count++;
                }
                array = nums;
            }
                // end

                return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if (magazine.Length > 3)
            {
                int[] indexesRooms = new int[3];
                int leftSum = magazine[0] + magazine[1] + magazine[2];
                int MaxsumThreeRooms = leftSum;
                indexesRooms[0] = 0;
                indexesRooms[1] = 1;
                indexesRooms[2] = 2;

                int rightSum = magazine[^1] + magazine[^2] + magazine[^3];
                    
                if (rightSum > leftSum)
                {
                    MaxsumThreeRooms = rightSum;
                    indexesRooms[0] = magazine.Length - 3;
                    indexesRooms[1] = magazine.Length - 2;
                    indexesRooms[2] = magazine.Length - 1;
                }

                for (int i = 1; i < magazine.Length - 1; i++)
                {
                    int AverSm = magazine[i - 1] + magazine[i] + magazine[i + 1];
                    int lfSm = 0;
                    int rgSm = 0;
                    if ((i - 2) >= 0)
                        lfSm = magazine[i - 2] + magazine[i - 1] + magazine[i];
                    if ((i + 2) < magazine.Length)
                        rgSm = magazine[i] + magazine[i + 1] + magazine[i + 2];

                    if (AverSm > lfSm && AverSm > rgSm && AverSm > MaxsumThreeRooms)
                    {
                        MaxsumThreeRooms = AverSm;
                        indexesRooms[0] = i - 1;
                        indexesRooms[1] = i;
                        indexesRooms[2] = i + 1;
                    }

                    else if ((lfSm > AverSm && lfSm > rgSm && lfSm > MaxsumThreeRooms))
                    {
                        MaxsumThreeRooms = lfSm;
                        indexesRooms[0] = i - 2;
                        indexesRooms[1] = i - 1;
                        indexesRooms[2] = i;
                    }
                    else if ((rgSm > AverSm && rgSm > lfSm && rgSm > MaxsumThreeRooms))
                    {
                        MaxsumThreeRooms = rgSm;
                        indexesRooms[0] = i;
                        indexesRooms[1] = i + 1;
                        indexesRooms[2] = i + 2;
                    }

                }
                indexes = indexesRooms;
            }
            else
            {
                int[] indexesRooms = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                {
                    indexesRooms[i] = i;
                }
                indexes = indexesRooms;
            }
                // end

                return indexes;
        }
    }
}
