using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            int index_max = 0, max = array[0], index_min = 0;
            bool stop = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    index_max = i;
                }

                if (array[i] < 0 && !stop)
                {
                    index_min = i;
                    stop = true;
                }
            }

            int s = 0;
            for (int i = index_max + 1; i < array.Length && stop; i++)
            {
                s += array[i];
            }
            if (stop)
                array[index_min] = s;
        }
        public int[] Task2(int[] array, int P)
        {
            int index = -1; // индекс элемента массива, после которого вставляется P 
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0) {
                    index = i;
                    break;
                }
            }
            
            if (index != -1)
            {
                int[] answer = new int[array.Length + 1];
                int j = 0; // индекс для изначального массива array, когда мы дойдем до index
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i <= index)
                        answer[i] = array[i];
                    if (i == index)
                    {
                        answer[i + 1] =  P;
                        i++;
                        j = i;
                    } else if (i > index)
                    {
                        answer[i] = array[j];
                        j++;
                    }
                }
                return answer;
            }
            else
                return array;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = new int[array.Length - 1];
            int index = -1, min = Int32.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                        index = i;
                    }
                }
            }

            if (index != -1)
            {
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i < index)
                        answer[i] = array[i];
                    else if (i == index)
                        j = i;
                    else if (i > index)
                    {
                        answer[j] =  array[i];
                        j++;
                    }
                }
                return answer;
            } else 
                return array;
        }
        public void Task4(double[] array)
        {
            double sum = 0;
            double[] temp = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
                sum += array[i];
            }
            sum /= (double)array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i] - sum;
            }
        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            if (A.Length != B.Length)
                return 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i] * B[i];
            }
            
            return sum;
        }
        public int[] Task6(int[] array)
        {
            // среднее значение массива
            double sum = 0;
            if (array.Length != 0)
            {
                foreach (int value in array)
                    sum += value;
                sum /= (double)array.Length;
            }

            // количество членов, меньших среднего
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sum)
                    count++;
            }
            
            int[] indexes = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sum)
                {
                    indexes[j] = i;
                    j++;
                }
            }
            return indexes;
        }

        public int Task7(int[] array)
        {
            int count = 1;
            if (array.Length == 0)
                return 0;
            if (array.Length == 1)
                return 1;
            if (array.Length > 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int temp = 1;
                    bool rise = false, fall = false; 
                    for (int j = i; j < array.Length - 1; j++)
                    {
                        if (array[j] == array[j + 1]) {
                            temp++;
                        } 
                        else if (array[j] > array[j + 1] && !fall)
                        {
                            rise = true;
                            temp++;
                        } 
                        else if (array[j] < array[j + 1] && !rise)
                        {
                            fall = true;
                            temp++;
                        }
                        else
                            break;
                    }

                    if (count < temp)
                        count = temp;
                }
            }
            return count;
        }
        public int[] Task8(int[] a)
        {
            int[] answer = new int[a.Length * 2];
            int j = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = a[j];
                if (i + 1 != answer.Length)
                    answer[i + 1] = a[j];
                j++;
                i++;
            }
            
            return answer;
        }
        
        public double[] Task9(int[] array)
        {
            double min = array[0];
            double max = array[0];
            
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
            
            double[] normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (array[i] - min) / (max - min);
            }
            
            return normalized;
        }
        static int BinarySearch(int[] array, int value)
        {
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == value)
                    return mid;
                if (array[mid] < value)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
    
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }
        public int Task10(int[] array, int P)
        {
            BubbleSort(array);
            return BinarySearch(array, P);
        }
        public int[] Task11(int a, int b, int c)
        {
            int count = 0, value = a;
            int[] array = { };
            
            /*
            зачем писать в условии, что a, b и c - положительные, если по итогу
            в тесте есть отрицательные b и с 
            */
            
            if (b < 0)
                return null;
            if (a > c)
                return array;
            for (int x = a; x <= c; x += b)
                count++;
            array = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
                value += b;
            }
            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int size = magazine.Length;
            int[] indexes;
            if (size <= 3)
            {
                indexes = new int[size];
                for (int i = 0; i < size; i++)
                    indexes[i] = i;
                
            }
            else
            {
                indexes = new int[3];
                int sum = 0;
                for (int i = 0; i < size - 2; i++)
                {
                    int temp = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    if (i == 0)
                    {
                        sum = temp;
                        indexes[0] = i;
                        indexes[1] = i + 1;
                        indexes[2] = i + 2;
                    }
                    else if (temp > sum)
                    {
                        sum = temp;
                        indexes[0] = i;
                        indexes[1] = i + 1;
                        indexes[2] = i + 2;
                    }
                }
            }
            return indexes;
        }
    }
}
