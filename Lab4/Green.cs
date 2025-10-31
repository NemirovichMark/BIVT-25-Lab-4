using System.Numerics;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            double summ = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    summ += array[i];
                    count++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = (double)summ / count;
                }
            }

        }
        public int Task2(int[] array)
        {
            int sum = 0;
            bool f = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    f = true;
                    break;
                }

                sum += array[i] * array[i];
            }
            if (f == false)
                return 0;
            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = {};

            int mn = 0;
            int mx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[mx])
                    mx = i;
                if (array[i] < array[mn])
                    mn = i;
            }
            
            int s = Math.Min(mx, mn);
            int f = Math.Max(mx, mn);
            // ......
            // n = 3 // [0,]

            int len  = 0;
            for (int i = s + 1; i < f; i++)
            {          
                if (array[i] < 0)
                {
                    len++;
                }
            }
            negatives = new int[len];
      
            int k = 0;
            for (int i = s + 1; i < f; i++)
            {
                if (array[i] < 0)
                negatives[k++] = array[i];

            }
            return negatives;
        }
        public void Task4(int[] array)
        {
            int otr = -1;
            int val_otr = 0;
            int val_mx = array[0];
            int mx = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && otr == -1)
                {
                    otr = i;
                    val_otr = array[i];
                }
                if (array[i] > array[mx])
                {
                    mx = i;
                    val_mx = array[i];
                }

            }
            if (otr != -1)
            {
                array[otr] = val_mx;
                array[mx] = val_otr;
            }

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;
            int mx = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                    mx = array[i];
            }
            int len = 0;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == mx)
                    len++;
            }
            answer = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == mx)
                    answer[k++] = i;
            }
            return answer;
        }
        public void Task6(int[] array)
        {

            int mx = array[0];
            for (int i = 0; i <  array.Length; i++)
            {
                if (array[i] > mx)
                    mx = array[i];
            }
            int count = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == mx)
                {
                    array[i] = mx + count;
                    count++;
                }
            }
        }
        public void Task7(int[] array)
        {
            int mx = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                    mx = array[i];
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != mx)
                    sum += array[i];
                else
                {
                    array[i] = sum;
                    sum += mx;
                }

            }
        }
        public int Task8(int[] array)
        {
            int length = 0;
            int k = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i + 1] < array[i])
                    k += 1;
                else
                {
                    length = Math.Max(length, k+1);
                    k = 0;
                }    

            }
            if (length == 0)
                length = 1;
            return length;
        }
        public void Task9(int[] array)
        {
            int k = 0;
            int[] ind = new int[(array.Length+1)/2];
            for (int i = 0; i < array.Length; i += 2)
            {
                ind[k++] = array[i];
            }
            for (int i = 0; i < ind.Length - 1; i++)
            {
                for (int j = 0; j < ind.Length - 1; j++)
                {
                    if (ind[j + 1] < ind[j])
                    {
                        int a = ind[j + 1];
                        ind[j + 1] = ind[j];
                        ind[j] = a;
                    }
                }

            }
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    array[i] = ind[n++];
            }
        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;
            int leng = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool rep = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        rep = true;
                        break;
                    }
                }
                if (rep == false)
                {
                    leng++;
                }

            }
            cleared = new int[leng];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool rep = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        rep = true;
                        break;
                    }
                }
                if (rep == false)
                {
                    cleared[k++] = array[i];
                }

            }
            //Console.WriteLine(string.Join(" ", cleared));
            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;
            A = new double[n];
            if (n <= 1)
                return null;
            if (a == b)
                return null;
            double mv = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                A[i] = a + mv * i;
            }

            double summ = 0;
            int len_b = 0;
            int cnt = 0;
                
            foreach (double elem in A)
            {
                if (elem > 0)
                {
                    cnt++;
                    summ += elem;
                }

            }
            if (cnt > 0)
            {
                double sr_ar = summ / cnt;
                foreach (double elem in A)
                {
                    if (elem > sr_ar)
                        len_b++;
                }
                B = new double[len_b];
                int k = 0;
                foreach (double elem in A)
                {
                    if (elem > 0 && elem > sr_ar)
                        B[k++] = elem;
                }
                return B;

            }
            else
                return new double[0];
        }
        public int Task12(int[] dices)
        {
            int wins = 0;
            int minus = 1;
            int leng = dices.Length;
            int[] sh = new int[leng];
            for (int i = 0; i < leng; i++)
            {
                sh[i] = Math.Max(1, 6 - minus * i);
            }
            minus = 0;
            for (int i = 0; i < leng; i++)
            {
                int now = dices[i];
                dices[i] = Math.Max(1, dices[i] - minus);
                if (now == 6)
                    minus++;
            }
            for (int i = 0; i < leng; i++)
            {
                if (dices[i] > sh[i])
                    wins++;
            }

            return wins;

        }
    }
}
