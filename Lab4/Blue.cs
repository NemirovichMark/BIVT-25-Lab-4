using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return;
            }

            int firstNegativeIndex = -1;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    firstNegativeIndex = i;
                    break;
                }
            }

            if (firstNegativeIndex == -1)
            {
                return;
            }
            
            int maxIndex = 0;
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            
            int sumAfterMax = 0;
            
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                sumAfterMax += array[i];
            }
            
            array[firstNegativeIndex] = sumAfterMax;
        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            if (array == null || array.Length == 0)
            {
                answer = new int[0];
                return answer;
            }
            
            int lastPositiveIndex = -1;
            
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    lastPositiveIndex = i;
                    break;
                }
            }

            if (lastPositiveIndex == -1)
            {
                answer = new int[array.Length];
                
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }
                
                return answer;
            }
            
            answer = new int[array.Length + 1];
            
            for (int i = 0; i <= lastPositiveIndex; i++)
            {
                answer[i] = array[i];
            }
            
            answer[lastPositiveIndex + 1] = P;
            
            for (int i = lastPositiveIndex + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;
            
            if (array == null || array.Length == 0)
            {
                answer = new int[0];
                return answer;
            }
            
            int minPositive = -1;
            bool foundPositive = false;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (foundPositive == false || array[i] < minPositive)
                    {
                        minPositive = array[i];
                        foundPositive = true;
                    }
                }
            }
            
            if (foundPositive == false)
            {
                answer = new int[array.Length];
                
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }
                
                return answer;
            }
            
            answer = new int[array.Length - 1];
            bool removed = false;
            int j = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (removed == false && array[i] == minPositive)
                {
                    removed = true;
                }
                else
                {
                    answer[j] = array[i];
                    j++;
                }
            }
            
            return answer;
        }
        public void Task4(double[] array)
        {
            if (array == null || array.Length == 0)
            {
                return;
            }

            double sredZnach = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                sredZnach += array[i];
            }
            
            sredZnach /= array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= sredZnach;
            }
        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;
            
            if (A == null || B == null || A.Length != B.Length)
            {
                return sum;
            }
            
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i] * B[i];
            }

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            if (array == null || array.Length == 0)
            {
                indexes = new int[0];
                return indexes;
            }
            
            double sum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            
            double average = sum / array.Length;
            int count = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < average)
                {
                    count++;
                }
            }
            
            indexes = new int[count];
            int index = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < average)
                {
                    indexes[index] = i;
                    index++;
                }
            }

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 1;
            
            if (array == null || array.Length == 0)
            {
                return count;
            }
            
            int currentPos = 1;
            int currentNeg = 1;
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentPos++;
                    currentNeg++;
                }
                else if (array[i] > array[i - 1])
                {
                    currentPos++;
                    currentNeg = 1;
                }
                else
                {
                    currentNeg++;
                    currentPos = 1;
                }

                if (currentPos > count)
                {
                    count = currentPos;
                }

                if (currentNeg > count)
                {
                    count = currentNeg;
                }
            }

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;
            
            if (array == null || array.Length == 0)
            {
                answer = new int[0];
                return answer;
            }

            answer = new int[array.Length * 2];
            int j = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                answer[j] = array[i];
                answer[j + 1] = array[i];
                j += 2;
            }

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;
            
            if (array == null || array.Length == 0)
            {
                return normalized;
            }
            
            int min = array[0];
            int max = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            
            if (min == max)
            {
                return null;
            }
            
            normalized = new double[array.Length];
            
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (double)(array[i] - min) / (max - min);
            }

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            if (array == null || array.Length == 0)
            {
                return -1;
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            
            int left = 0;
            int right = array.Length - 1;
            index = -1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                if (array[mid] < P)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            if (b <= 0)
            {
                return null;
            }
            
            int count = 0;
            int current = a;
            
            while (current <= c)
            {
                count++;
                current += b;
            }
            
            array = new int[count];
            current = a;
            
            for (int i = 0; i < count; i++)
            {
                array[i] = current;
                current += b;
            }

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;
            
            if (magazine.Length == 0)
            {
                return new int[0];
            }
            
            if (magazine.Length <= 3)
            {
                indexes = new int[magazine.Length];
                
                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }
                
                return indexes;
            }
            
            int maxSum = 0;
            int currentSum =  magazine[0] + magazine[1] + magazine[2];
            int index = 0;
            maxSum = currentSum;
            
            for (int i = 1; i <= magazine.Length - 3; i++)
            {
                currentSum = currentSum - magazine[i - 1] + magazine[i + 2];
                
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    index = i;
                }
            }
            
            indexes = new int[3];
            
            for (int i = 0; i < 3; i++)
            {
                indexes[i] = index + i;
            }
            
            return indexes;
        }
    }
}
