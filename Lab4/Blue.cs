using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int maxch = -1000000000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxch)
                {
                    maxch = array[i];
                }

            }
            int f = 0;
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (f == 1)
                {
                    summ += array[i];
                }

                if (array[i] == maxch)
                {
                    f = 1;
                }
                
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = summ;
                    break;
                }

            }


            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int last_i = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) {
                    last_i = i;
                }
            }

            if (last_i != -1)
            {
                answer = new int[array.Length + 1];
                for (int i = 0; i < array.Length + 1; i++)
                {
                    if (i == last_i + 1)
                    {
                        answer[i] = P;
                    }
                    if (i < last_i+1) {
                        answer[i] = array [i];
                    }
                    if (i > last_i+1)
                    {
                        answer[i] = array[i-1];
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
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int minPositive = int.MaxValue;
            int minIndex = -1;

            // минимальный 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < minPositive)
                {
                    minPositive = array[i];
                    minIndex = i;
                }
            }


            if (minIndex == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[array.Length - 1];
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != minIndex)
                    {
                        answer[j] = array[i];
                        j++;
                    }
                }
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            
            double sum = 0;
            foreach (double x in array)
                sum += x;
            double average = sum / array.Length;

            // 2. Преобразуем элементы массива, вычитая среднее значение
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= average;
            }

            // end
        }




        public int Task5(int[] A, int[] B)
        {
            int sum = 0;
            int count = 0;
     
            if (A.Length != B.Length)
            {
                return 0;
            }

            // code here
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
                    count++;
            }

            indexes = new int[count];
            int idx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < average)
                {
                    indexes[idx] = i;
                    idx++;
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
            int pos = 0;

            for (int i = 0; i < array.Length; i+=1)
            {
                answer[pos] = array[i];
                answer[pos + 1] = array[i];
                pos += 2;
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
