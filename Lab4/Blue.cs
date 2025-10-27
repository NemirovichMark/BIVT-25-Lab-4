using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int maxi = 0, i_min = -1, n = array.Length;
            for (int i = 0; i < n; ++i) {
                maxi = (array[i] > array[maxi]) ? i : maxi;
                if (i_min == -1 && array[i] < 0)
                {
                    i_min = i;
                }
            }
            int sum = 0;
            for (int i = maxi + 1; i < n; ++i)
            {
                sum += array[i];
            }
            if (i_min != -1)
            {
                array[i_min] = sum;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            // code here
            int n = array.Length, j = -1;
            for (int i = n - 1; i >= 0; --i)
            {
                if (array[i] > 0)
                {
                    j = i;
                    break;
                }
            }
            if (j == -1)
            {
                int[] answer = array;
                return answer;
            }
            else
            {
                int[] answer = new int[n + 1];
                for (int i = 0; i <= j; ++i)
                {
                    answer[i] = array[i];
                }
                answer[j + 1] = P;
                for (int i = j + 2; i <= n; ++i)
                {
                    answer[i] = array[i - 1];
                }
                return answer;
            }
            // end

        }
        public int[] Task3(int[] array)
        {
            // code here
            int n = array.Length, j = -1;
            for (int i = 0; i < n; ++i)
            {
                if ((j == -1 || array[i] < array[j]) && array[i] > 0)
                {
                    j = i;
                }
            }
            if (j == -1)
            {
                int[] answer = array;
                return answer;
            }
            else
            {
                int[] answer = new int[n - 1];
                for (int i = 0; i < j; ++i)
                {
                    answer[i] = array[i];
                }
                for (int i = j + 1; i < n; ++i)
                {
                    answer[i - 1] = array[i];
                }
                return answer;
            }
            // end

        }
        public void Task4(double[] array)
        {

            // code here
            double arifm = 0;
            int n = array.Length;
            for (int i = 0; i < n; ++i)
            {
                arifm += array[i];
            }
            arifm /= n;
            for (int i = 0; i < n; ++i)
            {
                array[i] -= arifm;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            int n = A.Length, m = B.Length;
            if (n != m)
            {
                return 0;
            }
            for (int i = 0; i < n; ++i)
            {
                sum += A[i] * B[i];
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            // code here
            int k = 0, n = array.Length;
            double sr = 0;
            for (int i = 0; i < n; ++i)
            {
                sr += array[i];
            }
            sr /= n;
            for (int i = 0; i < n; ++i)
            { 
                k += (array[i] < sr) ? 1 : 0;
            }
            int[] indexes = new int[k];
            for (int i = 0, j = 0; i < n; ++i)
            {
                if (array[i] < sr)
                {
                    indexes[j++] = i;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int n = array.Length, m = 1;
            for (int i = 1; i < n; ++i)
            {
                if (array[i] - array[i - 1] >= 0)
                {
                    ++m;
                    count = (count < m) ? m : count;
                }
                else
                {
                    m = 1;
                }
            }
            count = (count < m) ? m : count;
            m = 1;
            for (int i = 1; i < n; ++i)
            {
                if (array[i] - array[i - 1] <= 0)
                {
                    ++m;
                    count = (count < m) ? m : count;
                }
                else
                {
                    m = 1;
                }
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            // code here
            int n = array.Length;
            int[] answer = new int[2 * n];
            for (int i = 0, j = 0; i < n; ++i)
            {
                answer[j++] = array[i];
                answer[j++] = array[i];
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = new double[array.Length];

            // code here
            int n = array.Length, mini = 1000000000, maxi = -1000000000;
            for (int i = 0; i < n; ++i)
            {
                mini = (mini > array[i]) ? array[i] : mini;
                maxi = (maxi < array[i]) ? array[i] : maxi;
            }
            if (mini == maxi)
            {
                return null;
            }
            for (int i = 0; i < n; ++i)
            {
                normalized[i] = (double)(array[i] - mini) / (maxi - mini);
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = -1;

            // code here
            int n = array.Length;
            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = 0; j < n - 1; ++j)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
            int l = 0, r = n - 1;
            while (r >= l)
            {
                int m = (l + r) / 2;
                if (array[m] == P)
                {
                    return m;
                }
                if (array[m] < P)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            // code here
            if (b <= 0)
            {
                return null;
            }
            int k = 0;
            for (int i = a; i <= c; i += b)
            {
                ++k;
            }
            int[] array = new int[k];
            for (int i = a, j = 0; i <= c; i += b, ++j)
            {
                array[j] = i;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            // code here
            if (magazine.Length == 0)
            {
                return null;
            }
            int n = magazine.Length, sum = 0;
            if (n > 3)
            {
                int[] indexes = new int[3];
                for (int i = 2; i < n; ++i)
                {
                    sum = (sum < magazine[i] + magazine[i - 1] + magazine[i - 2]) ? magazine[i] + magazine[i - 1] + magazine[i - 2] : sum;
                }
                for (int i = 2; i < n; ++i)
                {
                    if (magazine[i] + magazine[i - 1] + magazine[i - 2] == sum)
                    {
                        indexes[0] = i - 2;
                        indexes[1] = i - 1;
                        indexes[2] = i;
                        break;
                    }
                }
                return indexes;
            }
            else
            {
                int[] indexes = new int[n];
                for (int i = 0; i < n; ++i)
                {
                    indexes[i] = i;
                }
                return indexes;
            }
            // end
        }
    }
}