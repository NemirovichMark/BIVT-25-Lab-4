using System.Linq.Expressions;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double pl_s = 0, pl_c = 0;
            for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        pl_s += array[i];
                        pl_c++;
                    }
                }
            double avg = pl_s / pl_c;
            for (int i = 0; i < array.Length; i++) if (array[i] > 0) array[i] = avg;
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            
            bool f = true;
            foreach (int elem in array)
            {
                if (elem < 0)
                {
                    f = false;
                    break;
                }
                else sum += elem * elem;
            }
            if (f) sum = 0;
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max = -100, max_ind = 0, min = 100, min_ind = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                    max_ind = i;
                }
                if (array[i] <= min)
                {
                    min = array[i];
                    min_ind = i;
                }
            }
            int o_cnt = 0, c = 0;
            if (max_ind < min_ind)
            {
                for (int i = max_ind + 1; i < min_ind; i++)
                    if (array[i] < 0) o_cnt++;
                negatives = new int[o_cnt];
                for (int i = max_ind + 1; i < min_ind; i++)
                    if (array[i] < 0)
                    {
                        negatives[c] = array[i];
                        c++;
                    }
            }
            else if (min_ind < max_ind)
            {
                for (int i = min_ind + 1; i < max_ind; i++)
                    if (array[i] < 0) o_cnt++;
                negatives = new int[o_cnt];
                for (int i = min_ind + 1; i < max_ind; i++)
                    if (array[i] < 0)
                    {
                        negatives[c] = array[i];
                        c++;
                    }
            }
            else negatives = new int[0];

            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            bool f = false;
            int max = -100, max_ind = 0, otr_ind = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0)
                {
                    f = true;
                    otr_ind = i;
                    break;
                }
            Console.WriteLine(otr_ind);
            for (int i = array.Length - 1; i >= 0; i--)
                if (array[i] >= max)
                {
                    max = array[i];
                    max_ind = i;
                }
            Console.WriteLine(max_ind);
            if (f) (array[max_ind], array[otr_ind]) = (array[otr_ind], array[max_ind]);
            Console.WriteLine(string.Join(' ', array));
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int c = 0, max = -100000;
            foreach (var item in array)
            {
                if (item > max) max = item;
            }
            foreach (var item in array)
            {
                if (item == max) c++;
            }
            if (c != 0)
            {
                int x = 0;
                answer = new int[c];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == max)
                    {
                        answer[x] = i;
                        x++;
                    }
                }
            }

            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int n = 1, max = -100000;
            foreach (var item in array)
            {
                if (item > max) max = item;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += n;
                    n++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int sum = 0, max = -10000;
            foreach (var item in array)
            {
                if (item > max) max = item;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) (array[i], sum) = (sum, sum + array[i]);
                else sum += array[i];
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int c = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1]) c++;
                else
                {
                    if (c > length) length = c;
                    c = 0;
                }
            }
            length++;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int[] ch = new int[(array.Length + 1) / 2];
            int c = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                ch[c] = array[i];
                c++;
            }
            int n = ch.Length;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (ch[j] > ch[j + 1])
                        (ch[j], ch[j + 1]) = (ch[j + 1], ch[j]);
            c = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                array[c] = ch[i];
                c += 2;
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here

            int cnt = 0;
            int[] uniq = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                bool d = false;
                for (int j = 0; j < cnt; j++)
                {
                    if (array[i] == uniq[j])
                    {
                        d = true;
                        break;
                    }
                }
                if (!d)
                {
                    uniq[cnt] = array[i];
                    cnt++;
                }
            }
            cleared = new int[cnt];
            for (int i = 0; i < cnt; i++) cleared[i] = uniq[i];
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {

            if (n < 2) return null;

            double[] A = new double[n];
            double s = (b - a) / (n - 1);
            for (int i = 0; i < n; i++) A[i] = a + i * s;

            double sum = 0;
            int cnt = 0;
            for (int i = 0; i < n; i++)
                if (A[i] > 0)
                {
                    sum += A[i];
                    cnt++;
                }

            if (cnt == 0) return new double[0];

            double avg = sum / cnt;

            int c = 0;
            for (int i = 0; i < n; i++) if (A[i] > 0 && A[i] > avg) c++;

            if (c == 0)
            { 
                if (cnt > 1) return null;
                else return new double[0];
            }

            double[] B = new double[c];
            c = 0;
            for (int i = 0; i < n; i++)
                if (A[i] > 0 && A[i] > avg)
                {
                    B[c] = A[i];
                    c++;
                }

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here

            int[] p = new int[dices.Length];
            int r = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                int с = dices[i] - r;
                if (с < 1) с = 1;
                p[i] = с;

                if (dices[i] == 6) r++;
            }
            int[] cheat = new int[dices.Length];
            int rdc = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                int c_v = 6 - rdc;
                if (c_v < 1) c_v = 1; 
                cheat[i] = c_v;
                rdc++;
            }
            for (int i = 0; i < dices.Length; i++) if (p[i] > cheat[i]) wins++;

            // end

            return wins;

        }
    }
}
