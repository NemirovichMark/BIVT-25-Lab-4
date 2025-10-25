using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            if (maxIndex == array.Length - 1)
            {
                return;
            }

            int sum = 0;
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                sum += array[i];
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
                return;

            array[firstNegativeIndex] = sum;
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0)
            {
                return new int[0];
            }

            int lestovPolik = -1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    lestovPolik = i;
                    break;
                }
            }

            if (lestovPolik == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }
                return answer;
            }

            answer = new int[array.Length + 1];


            for (int i = 0; i <= lestovPolik; i++)
            {
                answer[i] = array[i];
            }


            answer[lestovPolik + 1] = P;


            for (int i = lestovPolik + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }
            // end

            return answer;

        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0)
            {
                return new int[0];
            }

            int minPositive = int.MaxValue;
            int minPositiveIndex = -1;
            bool hasPositive = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    hasPositive = true;
                    if (array[i] < minPositive)
                    {
                        minPositive = array[i];
                        minPositiveIndex = i;
                    }
                }
            }


            if (!hasPositive)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }
                return answer;
            }

            answer = new int[array.Length - 1];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i != minPositiveIndex)
                {
                    answer[index] = array[i];
                    index++;
                }
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return;

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= average;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A == null || B == null || A.Length == 0 || B.Length == 0 || A.Length != B.Length)
            {
                return 0; 
            }

            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i] * B[i];
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            if (array == null || array.Length == 0)
            {
                return new int[0];
            }

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double sredni = sum / array.Length;

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sredni)
                {
                    count++;
                }
            }

            indexes = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sredni)
                {
                    indexes[index] = i;
                    index++;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            if (array == null || array.Length == 0)
            {
                return 0;
            }
            if (array.Length == 1)
            {
                return 1;
            }

            int maxLength = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int currentLength = 1;
                int sign = 0; // 0 , 1 +, -1 

                for (int j = i; j < array.Length - 1; j++)
                {
                    int currentSign = array[j + 1] - array[j];
                    if (currentSign > 0) currentSign = 1;
                    else if (currentSign < 0) currentSign = -1;
                    if (sign == 0)
                    {
                        sign = currentSign;
                        currentLength++;
                    }
                    else if (currentSign == sign || currentSign == 0)
                    {
                        currentLength++;
                    }
                    else
                    {
                        break;
                    }
                }

                maxLength = Math.Max(maxLength, currentLength);
            }

            count = maxLength;
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0)
            {
                return new int[0];
            }

            answer = new int[array.Length * 2];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                answer[index] = array[i];
                answer[index + 1] = array[i];
                index += 2;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            if (array == null || array.Length == 0)
            {
                return new double[0];
            }


            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
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
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
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
                else if (array[mid] < P)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <= 0)
            {
                return null;
            }

            List<int> result = new List<int>();
            int current = a;

            while (current <= c)
            {
                result.Add(current);
                current += b;
            }

            array = result.ToArray();
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if (magazine == null || magazine.Length == 0)
            {
                return new int[0];
            }

            int n = Math.Min(3, magazine.Length); 

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
            int startIndex = 0;

            for (int i = 0; i <= magazine.Length - 3; i++)
            {
                int currentSum = magazine[i] + magazine[i + 1] + magazine[i + 2];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startIndex = i;
                }
            }

            indexes = new int[3];
            for (int i = 0; i < 3; i++)
            {
                indexes[i] = startIndex + i;
            }
            // end


            return indexes;
        }
    }
}
