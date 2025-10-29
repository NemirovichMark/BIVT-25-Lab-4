using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int n = array.Length;
            int m = -2147483647;
            int im = 0;
            for (int i = 0; i < n; i++) {
                if (array[i] > m) {
                    m  = array[i];
                }
            }
            for (int i = 0; i < n; i++) {
                if (array[i] == m) {
                    im = i;
                    break;
                }
            }
            int s = 0;
            for (int i = im + 1; i < n; i++) s += array[i];
            for (int i = 0; i < n; i++) {
                if (array[i] < 0) {
                    array[i] = s;
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int n = array.Length;
            int idx = -1;
            for (int i = 0; i < n; i++) if (array[i] > 0) idx = i;
            if (idx == -1)
            {
                answer = new int[n];
                for (int i = 0; i < n; i++) answer[i] = array[i];
            }
            else
            {
                answer = new int[n + 1];
                for (int i = 0; i <= idx; i++) answer[i] = array[i];
                answer[idx + 1] = P;
                for (int i = idx + 1; i < n; i++) answer[i + 1] = array[i];
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int n = array.Length;
            int m = 2147483647;
            for (int i = 0; i < n; i++) if (0 < array[i] && array[i] < m) m = array[i];
            int im = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == m)
                {
                    im = i;
                    break;
                }
            }
            if (im == -1)
            {
                answer = new int[n];
                for (int i = 0; i < n; i++) answer[i] = array[i];
            }
            //если нет
            else
            {
                answer = new int[n - 1];
                int j = 0;
                for (int i = 0; i < n; i++)
                {
                    if (i != im)
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
            int n = array.Length;
            double s = 0;
            for (int i = 0; i < n; i++) s += array[i];
            double m = s / n;
            for (int i = 0; i < n; i++) array[i] -= m;
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length != B.Length) return 0;
            int n = 0;
            int na = A.Length;
            int nb = B.Length;
            if (A.Length < B.Length) n = na;
            else n = nb;
            for (int i = 0; i < n; i++) sum += A[i] * B[i];
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            int n = array.Length;
            double s = 0.0;
            for (int i = 0; i < n; i++) s += array[i];
            double mid = s / n;
            int c = 0;
            for (int i = 0; i < n; i++) if (array[i] < mid) c++;
            indexes = new int[c];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < mid)
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
            // код позор, ну а зачем оптимизировать если на тестах маввисы на три элемента
            if (array.Length == 0) return 0;
            int maxlen = 1;
            int curlen = 1;
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                if (array[i] >= array[i - 1]) curlen++;
                else curlen = 1;
                if (curlen > maxlen) maxlen = curlen;
            }
            curlen = 1;
            for (int i = 1; i < n; i++)
            {
                if (array[i] <= array[i - 1]) curlen++;
                else curlen = 1;
                if (curlen > maxlen) maxlen = curlen;
            }
            count = maxlen;
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            int n = array.Length;
            answer = new int[n * 2];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                answer[j] = array[i];
                answer[j + 1] = array[i];
                j += 2;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            double mn = 2147483647.0;
            double mx = -2147483647.0;
            int n = array.Length;
            if (n == 0) return null;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < mn) mn = array[i];
                if (array[i] > mx) mx = array[i];
            }
            if ((mx - mn) == 0) return null;
            normalized = new double[n];
            for (int i = 0; i < n; i++)
            {
                normalized[i] = (array[i] - mn) / (mx - mn);
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int m = array[i];
                int im = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < m)
                    {
                        m = array[j];
                        im = j;
                    }
                }
            int c = array[i];
            array[i] = array[im];
            array[im] = c;
            }
            int left = 0;
            int right = n - 1;
            index = -1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P) left = mid + 1;
                else right = mid - 1;
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <= 0) return null;
            if (a > c) return new int[0];
            int count = ((c - a) / b) + 1;
            array = new int[count];
            for (int i = 0; i < count; i++) array[i] = a + i * b;
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int n = magazine.Length;
            if (n == 0) return null;
            else if (n >= 1 && n <= 3)
            {
                if (n == 1) indexes = new int[1] { 0 };
                if (n == 2) indexes = new int[2] { 0, 1 };
                if (n == 3) indexes = new int[3] { 0, 1, 2 };
                return indexes;
            }
            indexes = new int[3];
            int s = -100000000;
            for (int i = 0; i < n - 2; i++)
            {
                if (magazine[i] + magazine[i + 1] + magazine[i + 2] > s)
                {
                    s = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    indexes[0] = i;
                    indexes[1] = i + 1;
                    indexes[2] = i + 2;
                }
            }


            // end

            return indexes;
        }
    }
}