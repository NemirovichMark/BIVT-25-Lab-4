namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double mean = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    mean += array[i];
                    count++;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = mean /  count;
                }
            }
            // end
            

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            double min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
            }

            if (min >= 0)
            {
                return 0;
            }
            
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    flag = true;
                }
                if (flag == true)
                {
                    continue;
                }
                sum+=array[i]*array[i];
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int min = 1000;
            int max = -1000;
            int min_idx = 0;
            int max_idx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_idx = i;
                }

                if (array[i] < min)
                {
                    min = array[i];
                    min_idx = i;
                }
            }
            int start = Math.Min(min_idx, max_idx);
            int end = Math.Max(min_idx, max_idx);
            int cnt = 0;
            for (int i = start+1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    cnt++;
                }
            }
            negatives = new int[cnt];
            int j = 0;
            for (int i = start+1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[j] = array[i];
                    j++;
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = -1000;
            int idx1 = 0;
            int idx2 = 0;
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    idx1 = i;
                }

                if (array[i] < 0 && !flag)
                {
                    idx2 = i;
                    flag = true;
                }
            }
            if (flag)
            {
                (array[idx1], array[idx2]) = (array[idx2], array[idx1]); 
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            
            int m = -1000;
            int cnt = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > m)
                {
                    m = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == m)
                {
                    cnt++;
                }
            }
            answer = new int[cnt];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == m)
                {
                    answer[j] = i;
                    j++;
                }
            }
            
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int m = -1000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > m)
                {
                    m = array[i];
                }
            }

            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == m)
                {
                    array[i] += ++j;
                    
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int m = -1000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > m)
                {
                    m = array[i];
                }
            }

            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {   
                s+=array[i];
                if (array[i] == m)
                {
                    array[i] = s - array[i];
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int cur = 1, best = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i]) cur++;
                else cur = 1;
                if (cur > best) best = cur;
            }
            length = best;
            
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int n = (array.Length + 1)/2;
            int[] chet = new int[n];
            for (int i = 0; i < n; i++)
            {
                chet[i] = array[2*i];
            }
            Array.Sort(chet);
            for (int i = 0; i < n; i++)
            {
                array[2*i] = chet[i];
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            cleared = array.Distinct().ToArray();
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 1 || a == b)
            {
                return null;
            }
            
            A = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }

            double sum = 0; int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i]; cnt++;
                }
            }
            if (cnt == 0)
            {
                return System.Array.Empty<double>();
            }

            double avg = sum / cnt;
            int k = 0;
            for (int i = 0; i < n; i++)
                if (A[i] > 0 && A[i] > avg)
                {
                    k++;
                }

            B = new double[k];
            int pos = 0;
            for (int i = 0; i < n; i++)
                if (A[i] > 0 && A[i] > avg)
                {
                    B[pos++] = A[i];
                }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here

            int n = dices.Length;

            int s = 0;
            int[] mine = new int[n];
            for (int i = 0; i < n; i++)
            {
                int a = dices[i] - s;
                if (a < 1) a = 1;
                mine[i] = a;

                if (dices[i] == 6) s++;
            }
            for (int i = 0; i < n; i++)
            {
                int e = 6 - i;
                if (e < 1) e = 1;
                if (mine[i] > e) wins++;
            }

            return wins;
            // end

            return wins;

        }
    }
}
