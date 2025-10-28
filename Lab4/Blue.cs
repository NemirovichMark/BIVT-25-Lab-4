using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            // code here
            if (array == null || array.Length == 0)
            {
                return;
            }
            int imax = 0;
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    imax = i;
                    break;
                }
            }
            int ineg = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    ineg = i;
                    break;
                }
            }
            if (imax == array.Length - 1)
            {
                sum = 0;
            }
            else
            {
                for (int i = imax + 1; i < array.Length; i++)
                {
                    sum += array[i];
                }
            }
            if(ineg == -1)
            {
                return;
            }
            array[ineg] = sum;
            // end
        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int ipol = -1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    ipol = i;
                    break;
                }
            }
            if(ipol == -1)
            {
                answer = array;
            }
            else
            {
                answer = new int[array.Length + 1];
                for (int i = 0; i < ipol + 1; i++)
                {
                    answer[i] = array[i];
                }
                answer[ipol + 1] = P;
                for(int i = ipol + 1; i < array.Length; i++)
                {
                    answer[i + 1] = array[i];
                }
            }
                // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int min = int.MaxValue;
            int imin = -1;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < min && array[i] > 0)
                {
                    min = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == min)
                {
                    imin = i;
                    break;
                }
            }
            if(imin == -1)
            {
                return array;
            }
            else
            {
                answer = new int[array.Length - 1];
                for(int i = 0; i < imin; i++)
                {
                    answer[i] = array[i];
                }
                for (int i = imin; i < array.Length - 1; i++)
                {
                    answer[i] = array[i + 1];
                }
            }
                // end

                return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            if (array == null || array.Length == 0)
            {
                return;
            }
            double sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            for(int i = 0; i< array.Length; i++)
            {
                array[i] -= sum/array.Length;
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
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double srznach = sum / array.Length;
            int t = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < srznach)
                {
                    t++;
                }
            }
            indexes = new int[t];
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < srznach)
                {
                    indexes[count] = i;
                    count++;
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
            int t1 = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1])
                {
                    t1++;
                }
                else
                {
                    count = Math.Max(count, t1);
                    t1 = 1;
                }
            }
            count = Math.Max(count, t1);
            int t2 = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    t2++;
                }
                else
                {
                    count = Math.Max(count, t2);
                    t2 = 1;
                }
            }
            count = Math.Max(count, t2);
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[(2 * array.Length)];
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                answer[count] = array[i];
                answer[count + 1] = array[i];
                count+=2;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == array[0])
                {
                    count++;
                }
            }
            if (count != array.Length)
            {
                int max = int.MinValue;
                int min = int.MaxValue;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
                normalized = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = (double)(array[i] - min) / (max - min);
                }
                // end
            }
                return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            if (array == null || array.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
            int low = 0; int high = array.Length - 1; index = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
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
            int count = 0;
            if (b > 0)
            {
                for (int i = a; i < c + 0.0001; i += b)
                {
                    count++;
                }
                array = new int[count];
                int count0 = 0;
                for (int i = a; i < c + 0.0001; i += b)
                {
                    array[count0] = i;
                    count0++;
                }
            }
                // end

                return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if (magazine == null || magazine.Length == 0)
            {
                return null;
            }
            if (magazine.Length <= 3)
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }
            }
            else
            {
                int max = 0;
                int i0 = 0;
                int sum = 0;
                for (int i = 0; i < magazine.Length - 2; i++)
                {
                    sum = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    if (sum > max)
                    {
                        max = sum;
                        i0 = i;
                    }
                }
                indexes = new int[3];
                int t = 0;
                for(int i = 0; i< 3; i++)
                {
                    indexes[i] = i0 + t;
                    t++;
                }
            }
            // end
            return indexes;
        }
    }
}
