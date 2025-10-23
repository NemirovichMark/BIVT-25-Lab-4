using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int sum = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[index])
                {
                    index = i;
                }
            }

            if (index != array.Length - 1)
            {
                for (int i = index+1; i < array.Length; i++)
                {
                    sum += array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = sum;
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    index = i;
                }
            }

            if (index != -1)
            {
                answer = new int[array.Length+1];
                for (int i = 0; i <= index; i++)
                {
                    answer[i] = array[i];
                }
                answer[index+1] = P;
                for (int i = index + 1; i < array.Length; i++)
                {
                    answer[i+1] =  array[i];
                }
            }
            else
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
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
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }

            if (index != -1)
            {
                answer = new int[array.Length-1];
                for (int i = 0; i < index; i++)
                {
                    answer[i] = array[i];
                }

                for (int i = index + 1; i < array.Length; i++)
                {
                    answer[i-1]=array[i];
                }
            }
            else
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double sr = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sr+=array[i];
                count++;
            }
            sr /= count;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= sr;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length != B.Length)
            {
                return 0;
            }
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i]*B[i];
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                avg += array[i];
            }
            avg /= array.Length;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                    count++;
            }
            indexes = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                {
                    indexes[j] = i;
                    j++;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            count = 1;
            int len = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] <= array[i + 1])
                {
                    len++;
                }
                else
                {
                    count = Math.Max(count, len);
                    len = 1;
                }
                count = Math.Max(count, len);
            } 
            len = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    len++;
                }
                else
                {
                    count = Math.Max(count, len);
                    len = 1;
                }
                count = Math.Max(count, len);
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length * 2];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                answer[j]=array[i];
                answer[++j] = array[i];
                j++;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int min=int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <min)
                {
                    min = array[i];
                }
            }
            int max=int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }
            }
            if (max==min)
            {
                return null;
            }
            else
            {
                normalized = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = (double)(array[i] - min) / (max - min);
                }
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            int left = 0;
            int right = array.Length - 1;
            
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j=0; j<array.Length-i-1; j++)
                {
                    if (array[j]>array[j+1])
                    {
                        (array[j], array[j+1]) = (array[j+1], array[j]);
                    }
                }
            }
            int cont = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P) cont++;
            }
            if (cont!=0)
            {
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
            }
            else
            {
                index = -1;
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <=0 ) return null;
            if (c < a) return [];
            int len = ((c - a) / b) + 1;
            if (len <= 0) return null;
            array = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = a + b * i;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
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
                indexes = new int[3];
                int max = int.MinValue;
                for (int i = 1; i < magazine.Length-1; i++)
                {
                    int sum = magazine[i - 1] + magazine[i] + magazine[i + 1];
                    if (sum > max)
                    {
                        max = sum;
                        indexes[0] = i - 1;
                        indexes[1] = i;
                        indexes[2] = i + 1;
                    }
                
                }
            }
            // end

            return indexes;
        }
    }

}
