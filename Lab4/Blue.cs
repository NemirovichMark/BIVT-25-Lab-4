using System.Dynamic;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int otr_i = -1, max_i = 0, summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    otr_i = i;
                    break;
                }
            }
            if (otr_i == -1) return;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max_i])
                {
                    max_i = i;
                }
            }
            for (int i = max_i + 1; i < array.Length; i++)
            {
                summ += array[i];
            }
            
            array[otr_i] = summ;

            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = new int[array.Length+1];
            int posl_pl = -1;
            // code here
            for (int i = array.Length-1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    posl_pl = i;
                    break;
                }
            }
            if (posl_pl == -1) return array;
            for (int i = 0; i <= posl_pl; i++)
            {
                answer[i] = array[i];
            }
            answer[posl_pl + 1] = P;

            for (int i = posl_pl+1; i < array.Length; i++)
            {
                answer[i+1] = array[i];
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = new int[array.Length - 1];
            // code here
            int min_pl = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] > 0) && ((min_pl == -1) || array[i] < array[min_pl])) { min_pl = i; }
            }
            if (min_pl == -1) return array;

            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != min_pl) { answer[c++] = array[i]; }
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double sum = 0, sr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sr = sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= sr;
            }
            // end
        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;
            if (A.Length != B.Length) return 0;
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
            int[] indexes = new int[0];
            double sum = 0, sr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sr = sum / array.Length;
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    c++;
                }
            }
            if (c > 0)
            {
                indexes = new int[c];
                c = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < sr)
                    {
                        indexes[c++] = i;
                    }
                }
            }

                return indexes;
        }
        public int Task7(int[] array)
        {
            // code here
            if (array.Length == 1) return 1;
            int vz = 0, max_vz = 0;
            int yb = 0, max_yb = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1]) vz++;
                else vz = 0;
                if (vz > max_vz) max_vz = vz;
            }
            if (max_vz != 0) max_vz += 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1]) yb++;
                else yb = 0;
                if (yb > max_yb) max_yb = yb;
            }
            if (max_yb != 0) max_yb += 1;
            // end
            if (max_yb > max_vz) return max_yb;
            else return max_vz;
        }
        public int[] Task8(int[] array)
        {

            // code here
            int[] answer = new int[array.Length * 2];
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                {
                    answer[c++] = array[i];
                    answer[c++] = array[i];
                }

            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = new double[array.Length];

            // code here
            int c = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1]) c++;
            }
            if (c == array.Length) return null;

            int min = 0, max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[min]) min = i;
                if (array[i] > array[max]) max = i;
            }

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (double)((double)(array[i] - array[min]) / (double)(array[max] - array[min]));
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            // Сортировка пузырьком
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Обмен элементов
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            // Бинарный поиск
            int left = 0;
            int right = array.Length - 1;
            int index = -1;

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

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            if (b < 0) return null;
            int k = 0, temp = a;
            while (temp <= c)
            {
                temp += b;
                k++;
            }
            int[] array = new int[k];
            temp = a;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp;
                temp += b;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            // code here
   
            int in1 = 0, in2 = 1, in3 = 2;
            if (magazine.Length == 1) return new int[] { 0 };
            if (magazine.Length == 2) return new int[] { 0, 1 };
            int max = magazine[0] + magazine[1] + magazine[2];
            for (int i = 0; i < magazine.Length - 2; i++)
            {
                if (magazine[i] + magazine[i + 1] + magazine[i + 2] > max)
                {
                    max = magazine[i] + magazine[i+1] + magazine[i+2];
                    in1 = i;
                    in2 = i + 1;
                    in3 = i + 2;
                }
            }
            int[] ans = new int[] { in1, in2, in3 };
            // end

            return ans;
        }
    }
}