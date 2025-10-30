namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sm = 0;
            double len = 0;
            double avg = 0;
            for (int i = 0;i < array.Length;i++)
            {
                if (array[i] > 0)
                {
                    sm += array[i]; 
                    len += 1;
                }
            }

            avg = sm / len;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = avg;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;
            int zero = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    zero += 1;
                    break;
                }

                sum += array[i] * array[i];
            }

            if (zero == 0)
                sum = 0;
            // end
            return sum;
        }
        public int[] Task3(int[] array)
        {
            int cnt = 0;
            int mx = -10_000;
            int indx_mx = -1;
            
            int mn = 10_000;
            int indx_mn = -1;
            // code here


            for (int i = 0;i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i]; 
                    indx_mx = i;
                }

                if (array[i] < mn)
                {
                    mn = array[i];
                    indx_mn = i;
                }
                    
            }

            if (indx_mn < indx_mx)
            {
                for (int i = indx_mn + 1; i < indx_mx; i++)
                {
                    if (array[i] < 0)
                        cnt += 1;
                }
            }
            else
            {
                for (int i = indx_mx + 1; i < indx_mn; i++)
                {
                    if (array[i] < 0)
                        cnt += 1;
                }
            }
            
            int[] negatives = new int[cnt];

            if (indx_mx > indx_mn)
            {
                int index = 0;
                for (int i = indx_mn + 1; i < indx_mx; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[index] = array[i];
                        index++;
                    }
                }
            }
            else
            {
                int index = 0;
                for (int i = indx_mx + 1; i < indx_mn; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[index] = array[i];
                        index++;
                    }
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {
            int mx = -10_000;
            int indx_mx = -1;

            int mn_st = 10_000;
            int indx_mn = -1;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    indx_mx = i;
                }
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    mn_st = array[i];
                    indx_mn = i;
                    break;
                }
            }

            if (indx_mx != -1 && indx_mn != -1)
            {
                array[indx_mx] = mn_st;
                array[indx_mn] = mx;
            }
            
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int mx = -10000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                    mx = array[i];
            }

            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == mx)
                    cnt++;
            }

            answer = new int[cnt];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == mx)
                {
                    answer[index] = i;
                    index++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {
            int mx = -10000;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                    mx = array[i];
            }

            int k = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == mx)
                {
                    array[i] += k;
                    k++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int mx = -10_000;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                    mx = array[i];
            }

            int sm = 0;
            int num;
            for (int i = 0; i < array.Length; i++)
            {
                num = array[i];
                if (array[i] == mx)
                {
                    array[i] = sm;  
                }
                sm += num;
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 1;
            int current = 1;
            // code here
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    current++;
                    if (current > length)
                        length = current;
                }
                else
                {
                    current = 1;
                }
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    cnt++;
            }

            int[] even = new int[cnt];
            int indx = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                even[indx++] = array[i];
            }

            for (int i = 0; i < even.Length; i++)
            {
                for (int j = 1; j < even.Length; j++)
                {
                    if (even[j - 1] > even[i])
                    {
                        (even[j - 1], even[i]) = (even[i], even[j - 1]);
                    }
                }
            }

            int index = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = even[index++];
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;
            int n = array.Length;
            int[] temp = new int[n];
            int cnt = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                bool flag = false;

                for (int j = 0; j < cnt; j++)
                {
                    if (array[i] == temp[j])
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    temp[cnt] = array[i];
                    cnt++;
                }
            }

            cleared = new int[cnt];
            for (int i = 0; i < cnt; i++)
                cleared[i] = temp[i];
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            if (n <= 1)
                return null;
            if (a == b)
                return null;
            double[] A = new double[n];
            double step = (b - a) / (n - 1);
            
            // code here
            for (int i = 0;i < n;i++)
            {
                A[i] = a + step * i;
            }

            double sm = 0;
            double cnt = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    sm += A[i];
                    cnt++;
                }
            }

            if (cnt == 0)
                return new double[] {};
            
            double avg = sm / cnt;

            int k = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    if (A[i] > avg)
                    {
                        k++;
                    }
                }
            }
            if (k == 0)
                return new double[] {};
            
            double[] B = new double[k];
            int index = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    if (A[i] > avg)
                    {
                        B[index++] = A[i];
                    }
                }
            }
            
            // end
            return B;
        }
        public int Task12(int[] dices)
        {
            
            int wins = 0;
            // code here
            int n = dices.Length;

            int cnt_6 = 0;
            int[] current = new int[n];
            for (int i = 0; i < n; i++)
            {
                int shuler = dices[i] - cnt_6;
                if (shuler < 1) shuler = 1;
                current[i] = shuler;

                if (dices[i] == 6) cnt_6++;
            }
            for (int i = 0; i < n; i++)
            {
                int shuler = 6 - i;
                if (shuler < 1) shuler = 1;
                if (current[i] > shuler) wins++;
            }
            // end

            return wins;

        }
    }
}
