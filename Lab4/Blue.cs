using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int n_max = array[0];
            int index_max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > n_max)
                {
                    n_max = array[i];
                    index_max = i;
                }
            }
            int s = 0;
            if (index_max != array.Length - 1)
            {
                for (int i = index_max + 1; i < array.Length; i++)
                {
                    s += array[i];
                }
            }
            for (int i = 0;  i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = s;
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;
            int lastpos = 0;
            int npos = 0;
            // code here
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    npos = array[i];
                    lastpos = i;
                    break;
                }
            }
            if (npos != 0)
            {
                answer = new int[array.Length + 1];
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i <= lastpos) answer[i] = array[i];
                    else if (i == lastpos + 1) answer[i] = P;
                    else answer[i] = array[i - 1];
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
            int n_min = int.MaxValue;
            int in_min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] > 0) && (array[i] < n_min))
                {
                    n_min = array[i];
                    in_min = i;
                }
            }
            if (n_min != int.MaxValue)
            {
                answer = new int[array.Length - 1];
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i < in_min) answer[i] = array[i];
                    else answer[i] = array[i + 1];
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
            double s = 0;
            for (int i = 0; i < array.Length;i++)
            {
                s += array[i];
            }
            double sr = s / array.Length;

            // end
            for (int i = 0; i < array.Length;i++)
            {
                array[i] -= sr;
            }
        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;
            // code here
            if (A.Length == B.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    sum += A[i] * B[i];
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
            int s = 0;
            int len = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
            }
            sr = (double) s / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr) len += 1;
            }
            indexes = new int[len];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
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
            int len_up = 1;
            int len_down = 1;
            int cur_up = 1;
            int cur_down = 1;
            for (int i = 1; i < array.Length; i++)
            {
                int a = array[i-1];
                int b = array[i];
                if (a == b) { cur_up++; cur_down++; }
                else if (a > b)
                {
                    cur_down++;
                    if (cur_up > len_up) len_up = cur_up;
                    cur_up = 1;
                }
                else
                {
                    cur_up++;
                    if (cur_down > len_down) len_down = cur_down;
                    cur_down = 1;
                }

            }
            if (cur_up > len_up) len_up = cur_up;
            if (cur_down > len_down) len_down = cur_down;
            if (len_up > len_down) count = len_up;
            else count = len_down;
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length * 2];
            int j = 0;
            for (int i = 1; i < answer.Length; i += 2)
            {
                answer[i-1] = array[j];
                answer[i] = array[j];
                j++;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int check = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == array[i]) check++;
            }
            if (check != array.Length - 1)
            {
                normalized = new double[array.Length];
                int n_max = array[0], n_min = array[0];
                for (int i = 1;  i < array.Length; i++)
                {
                    if (array[i] < n_min)
                    {
                        n_min = array[i];
                    }
                    if (array [i] > n_max)
                    {
                        n_max = array[i];
                    }
                }
                for (int i = 0; i < normalized.Length; i++)
                {
                    normalized [i] = (double)(array[i] - n_min) / (n_max - n_min);
                }
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                bool flag = false;
                for (int j = 1; j < array.Length - i; j++)
                {
                    if (array[j-1] > array[j])
                    {
                        flag = true;
                        (array[j - 1], array[j]) = (array[j], array[j - 1]);
                    }
                }
                if (!flag) break;
            }
            int low = 0; int high = array.Length - 1; int k = 0;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    k++;
                    break;
                }
                else if (array[mid] > P)
                {
                    high = mid - 1;
                }
                else { low = mid + 1; }
            }
            if (k == 0) index = -1;
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b > 0)
            {
                int k = 0;
                for (int i = a; i <= c; i += b)
                {
                    k++;
                }
                array = new int[k];
                int j = 0;
                for (int i = a; i <= c; i += b)
                {
                    array[j++] = i;
                }
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if(magazine.Length < 3)
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++) indexes[i] = i;
            }
            else
            {
                int max_sum = 0;
                int in_max = 0;
                indexes = new int[3];
                for (int i = 2; i < magazine.Length; i++)
                {
                    if (magazine[i - 2] + magazine[i - 1] + magazine[i] > max_sum)
                    {
                        max_sum = magazine[i - 2] + magazine[i - 1] + magazine[i];
                        in_max = i;
                    }
                }
                if (max_sum == 0) { indexes[0] = 0; indexes[1] = 1; indexes[2] = 2; }
                else { indexes[0] = in_max - 2; indexes[1] = in_max - 1; indexes[2] = in_max; }
            }
            // end

            return indexes;
        }
    }
}