using System.Buffers;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int maxnumber = array.Max();
            int S = 0;
            int i_value = 0;
            int minus_value = 0;
            int minus_count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxnumber)
                {
                    i_value = i;
                    break;
                }
            }
            for (int j = i_value + 1; j < array.Length; j++)
            {
                S += array[j];
            }
            for (int o = 0; o < array.Length; o++)
            {
                if (array[o] < 0)
                {
                    minus_value = o;
                    minus_count++;
                    break;
                }
            }
            if (minus_count >= 1)
            {
                array[minus_value] = S;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int last_plus = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    last_plus = i;
                }
            }
            answer = new int[array.Length + 1];
            if (last_plus > -1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i <= last_plus)
                    {
                        answer[i] = array[i];
                    }
                    else
                    {
                        answer[i + 1] = array[i];
                    }
                }
                answer[last_plus + 1] = P;
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
            int minimal = 100000000;
            int min_index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < minimal)
                {
                    minimal = array[i];
                    min_index = i;
                }
            }
            answer = new int[array.Length - 1];
            if (min_index > -1)
            {
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i < min_index)
                    {
                        answer[i] = array[i];
                    }
                    else
                    {
                        answer[i] = array[i + 1];
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

            // code her
            double sr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sr += array[i];
            }
            if (sr != 0)
            {
                sr = sr / array.Length;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] - sr;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length == B.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    sum += (A[i] * B[i]);
                }
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double sr = 0;
            int index_count = 0;
            int indexes_counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sr += array[i];
            }
            sr = sr / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    index_count++;
                }
            }
            indexes = new int[index_count];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    indexes[indexes_counter] = i;
                    indexes_counter++;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int plus_length = 1;
            int minus_length = 1;
            bool flag = false;
            if (array.Length == 1)
            {
                count++;
                flag = true;
            }
            if (flag == false)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] >= array[i - 1])
                    {
                        plus_length++;
                    }
                    else
                    {
                        plus_length = 1;
                    }
                    if (plus_length > count)
                    {
                        count = plus_length;
                    }
                    if (array[i] <= array[i - 1])
                    {
                        minus_length++;
                    }
                    else
                    {
                        minus_length = 1;
                    }
                    if (minus_length > count)
                    {
                        count = minus_length;
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
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                answer[counter] = array[i];
                answer[counter + 1] = array[i];
                counter += 2;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            normalized = new double[array.Length];
            int maximum = -100000000;
            int minimum = 100000000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maximum)
                {
                    maximum = array[i];
                }
                if (array[i] < minimum)
                {
                    minimum = array[i];
                }
            }
            double down = maximum - minimum;
            if (down != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = (array[i] - minimum) / down;
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
            int low = 0;
            int high = array.Length - 1;
            int mid = 0;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            int k = 0;
            if (b < 0)
            {
                array = null;
            }
            else
            {
                for (int i = a; i <= c;)
                {
                    k++;
                    i += b;
                }
                array = new int[k];
                for (int i = 0; i < k; i++)
                {
                    array[i] = a;
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
            int maximum = int.MinValue;
            int index1 = -1;
            int index2 = -1;
            int index3 = -1;
            if (magazine.Length > 3)
            {
                indexes = new int[3];
                for (int i = 0; i < magazine.Length - 2; i++)
                {
                    if ((magazine[i] + magazine[i + 1] + magazine[i + 2]) > maximum)
                    {
                        maximum = (magazine[i] + magazine[i + 1] + magazine[i + 2]);
                        index1 = i;
                        index2 = i + 1;
                        index3 = i + 2;
                    }
                }
                indexes[0] = index1;
                indexes[1] = index2;
                indexes[2] = index3;
            }
            else
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }
            }
                // end

                return indexes;
        }
    }
}
