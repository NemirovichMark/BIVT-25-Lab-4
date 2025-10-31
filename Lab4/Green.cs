using System.Security.Cryptography;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            
            // code here
            double su = 0;
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    su += array[i];
                    cnt++;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if  (array[i] > 0)
                    array[i] = su / cnt;
            }
            // end

        }
        public int Task2(int[] array)
        {
            // code here
            int sum = 0;
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    flag = true;
                    break;
                }
                sum += (array[i] *  array[i]);
            }

            if (flag == false)
                return 0;
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
            int mx = -10000;
            int ind = -1;
            int c = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    c = i;
                }

                if (array[i] < 0 && ind == -1)
                    ind = i;
            }
            if (ind != -1)
                (array[ind], array[c]) = (array[c], array[ind]);
            // end
        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;
            int cnt = 0;
            int mx = -10000;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == mx)
                    cnt++;
                if (array[i] > mx)
                {
                    mx = array[i];
                    cnt = 1;
                }
                
            }
            int[] ans = new int[cnt];
            int cnt2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == mx)
                    ans[cnt2++] = i;
            }
            // end
            return ans;
        }
        public void Task6(int[] array)
        {

            // code here
            int cnt = 1;
            int mx = -10000;
            for (int i = 0; i < array.Length; i++)
            {
                if  (array[i] > mx) 
                    mx = array[i]; 
            }

            for (int i = 0; i < array.Length; i++)
            {
                if  (array[i] == mx)
                    array[i] += cnt++;;
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int mx = -10000;
            int su = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if  (array[i] > mx)
                    mx =  array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == mx)
                {
                    array[i] = su;
                    su += mx;
                }
                else
                {
                    su += array[i];
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;
            int cnt = 0;
            int [] ans = new int [array.Length];
            // code here
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    length++;
                else
                {
                    ans[cnt++] = length;
                    length = 0;
                }
            }

            int mx = 0;
            for (int i = 0; i < ans.Length; i++)
            {
                if (ans[i] > mx)
                    mx = ans[i];
            }
            // end

            return mx + 1;
        }
        public void Task9(int[] array)
        {

            // code here
            int cnt = 0;
            
            for (int i = 0; i < array.Length; i += 2)
            {
                cnt++;
            }
            int[] cur = new int[cnt];
            int cnt2 = 0;
            for (int i = 0; i < array.Length ; i += 2)
            {
                cur[cnt2++] = array[i];
            }

            for (int i = 0; i < cur.Length; i++)
            {
                for (int j = 0; j < cur.Length - 1; j++)
                {
                    if (cur[j] > cur[j + 1])
                        (cur[j], cur[j + 1]) = (cur[j + 1], cur[j]);
                }
            }
            int cnt3 = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = cur[cnt3++];
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