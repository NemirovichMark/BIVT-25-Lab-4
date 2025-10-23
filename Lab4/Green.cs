namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int cnt = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    cnt++;
                    sum += array[i];
                }
            }

            double el = sum / cnt;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] > 0 ? el : array[i];
            }

            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int pos = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    pos = i;
                    break;
                }
            }

            for (int i = 0; i < pos; i++)
            {
                sum += array[i] * array[i];
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int mx = 0, mn = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[mx]) mx = i;
                if (array[i] < array[mn]) mn = i;
            }

            negatives = [];
            for (int i = Math.Min(mx, mn) + 1; i < Math.Max(mx, mn); i++)
            {
                if (array[i] < 0)
                {
                    int n = negatives.Length + 1;
                    int[] neg = new int[n];
                    for (int j = 0; j < negatives.Length; j++)
                    {
                        neg[j] = negatives[j];
                    }
                    neg[neg.Length - 1] = array[i];
                    negatives = neg;
                }
            }

            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int mx = 0;
            int pos = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[mx]) mx = i;
                if (array[i] < 0 && pos == -1) pos = i;
            }

            if (pos != -1)
            {
                int t = array[mx];
                array[mx] = array[pos];
                array[pos] = t;
            }

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int mx = -1000000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx) mx = array[i];
            }

            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == mx) cnt++;
            }

            answer = new int[cnt];
            int pos = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == mx) answer[pos++] = i;
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int n = array.Length;
            int mx = -1000000;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > mx) mx = array[i];
            }
            int c = 1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == mx) array[i] += c++;
            }

            // end

        }
        public void Task7(int[] array)
        {
            // code here
            int n = array.Length;
            int mx = -1000000;
            for (int i = 0; i < n; i++)
            {
                mx = Math.Max(mx, array[i]);
            }

            int s = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == mx)
                {
                    array[i] = s;
                    s += mx;
                }
                else s += array[i];
            }

            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int n = array.Length;

            int mx_len = 1;
            int l = 0, r = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    r = i + 1;
                    mx_len = Math.Max(mx_len, r - l + 1);
                }
                else
                {
                    r = i + 1;
                    l = i + 1;
                }
            }
            // end

            return mx_len;
        }
        public void Task9(int[] array)
        {

            // code here
            int n = array.Length;

            int[] chet = new int[(n + 1) / 2];

            for (int i = 0; i < n; i += 2)
            {
                chet[i / 2] = array[i];
            }
            int k = chet.Length;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k - i - 1; j++)
                {
                    if (chet[j] > chet[j + 1])
                    {
                        int t = chet[j];
                        chet[j] = chet[j + 1];
                        chet[j + 1] = t;
                    }
                }
            }

            for (int i = 0; i < n; i += 2)
            {
                array[i] = chet[i / 2];
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int n = array.Length;
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                bool duplicated = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        duplicated = true;
                        break;
                    }
                }
                if (!duplicated)
                {
                    cnt++;
                }
            }
            cleared = new int[cnt];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                bool duplicated = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        duplicated = true;
                        break;
                    }
                }
                if (!duplicated)
                {
                    cleared[k++] = array[i];
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here

            //Console.WriteLine(a + " " + b + " " + n);
            //code here

            if (n == 1 || n == 0 || a == b)
            {
                return B;
            }

            A = new double[n];
            double s = Math.Sqrt((a - b) * (a - b)) / (n - 1);
            int ind = 0;
            for (double i = Math.Min(a, b); i <= Math.Max(a, b) + 0.00001; i += s)
            {
                A[ind++] = i;
            }

            double sum = 0;
            int cnt = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    cnt++;
                }
            }

            int k = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > (sum) / (cnt))
                {
                    k++;
                }
            }

            B = new double[k];
            ind = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > (sum) / (cnt))
                {
                    B[ind++] = A[i];
                }
            }
            if (B == null) return [];
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int n = dices.Length;
            int[] shuler = new int[n];
            int loss = 0;
            for (int i = 0; i < n; i++)
            {
                shuler[i] = Math.Max(1, 6 - loss);
                loss++;
            }
            loss = 0;
            for (int i = 0; i < n; i++)
            {
                int prev = dices[i];
                dices[i] = Math.Max(1, dices[i] - loss);
                if (prev == 6)
                {
                    loss++;
                }
            }
            // end
            for (int i = 0; i < n; i++)
            {
                if (shuler[i] < dices[i])
                {
                    wins++;
                }
            }
            return wins;

        }
    }
}
