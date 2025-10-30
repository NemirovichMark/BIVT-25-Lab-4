using System.Security.Cryptography;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            double ma = -999999;
            int in_ma = 0, sum = 0;
            Console.WriteLine(string.Join(" ", array));
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > ma)
                {
                    ma = array[i];
                    in_ma = i;
                }
            }
            for (int i = (in_ma + 1); i < array.Length; i++)
            {
                sum += array[i];
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = sum;
                    break;
                }
            }
            // end
        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int last_ind_pl = -1;
            answer = new int[array.Length+1] ;
            if (array.Length > 0)
            {
                for (int i = (array.Length - 1); i >= 0; i--)
                {
                    if (array[i] > 0)
                    {
                        last_ind_pl = i;
                        answer[i + 1] = P;
                        break;
                    }
                    answer[i +1] = array[i];
                }
                if (last_ind_pl == -1)
                {
                    answer = array;
                }
                for (int j = (last_ind_pl); j >= 0; j--)
                {
                    answer[j] = array[j];
                }
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            double mn = int.MaxValue;
            int ind_mn = -1;
            int j = 0;
            if (array.Length > 0)
            {
                for ( int i  = 0; i < array.Length; i++)
                {
                    if ((array[i] >0) && (array[i] < mn))
                    {
                        ind_mn = i;
                        mn = array[i];
                    }   
                }
                if (ind_mn != -1)
                {
                    answer = new int[array.Length-1];
                    for (int i = 0; i < ind_mn; i++)
                    {
                        answer[j] = array[i];
                        j++;
                    }
                    for (int i = ind_mn+1; i < array.Length; i++)
                    {
                        answer[j] = array[i];
                        j++;
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
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double sum = 0;
            double sr = 0;
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                sr = sum / array.Length;
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] -= sr;
                }

            }

            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;
            Console.WriteLine(string.Join(" ", A));
            Console.WriteLine(string.Join(" ", B));
            // code here
            if (A.Length == B.Length)
            {
                for (int i = 0; i < Math.Min(A.Length, B.Length); i++)
                {
                    sum += (A[i] * B[i]);
                }
            }



            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            Console.WriteLine(String.Join(" ", array));
            double sum = 0;
            int kl = 0;
            for (int i  = 0; i<array.Length;i++)
            {
                sum += array[i];
            }
            double sr = sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                    kl += 1;
            }
            indexes = new int[kl];
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
            int dl = 1;
            Console.WriteLine(string.Join(" ", array));
            int uv = 1, um = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if ((array[i-1] >= array[i]))
                {
                    dl++;
                    if (dl>count)
                    {
                        um = int.Max(dl, um);
                        
                    }


                }
                else
                {
                    dl = 1;

                }
            }
            dl = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if ((array[i - 1] <= array[i]))
                {
                    dl++;
                    if (dl > count)
                    {
                        uv = int.Max(dl, uv);

                    }

                }
                else
                {
                    dl = 1;

                }
            }
            count = int.Max(um, uv);

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length*2];
            int j = 0;
            for (int i = 0; i < answer.Length; i+=2)
            {
                answer[i] = array[j];
                answer[i + 1] = array[j];
                j++;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int cz = 0;
            int mn = array[0], mx = array[0];
            for (int i = 1; i < array.Length;i++)
            {
                mn = Math.Min(mn, array[i]);
                mx = Math.Max(mx, array[i]);
            }
            if (mn != mx)
            {
                normalized = new double[array.Length];
                for (int i = 0;i < array.Length;i++)
                {
                    normalized[i] = (double)(array[i] - mn) / (mx - mn);
                }    
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            Console.WriteLine(string.Join(" ", array));
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                double amn = array[i];
                int imn = i;
                for (int k = i + 1; k < n; k++)
                    if (array[k] < amn)
                    {
                        amn = array[k];
                        imn = k;
                    }
                (array[i], array[imn]) = (array[imn], array[i]);
            }
            index = -1;
            int low = 0, high = array.Length - 1;
            while (low <= high)
            {

                int mid = (low + high) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P)
                    low = mid + 1;
                else 
                    high = mid - 1;
            }

            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b > 0)
            {
                array = new int[Math.Max(0, (c - a) / b + 1)];
                for (int i = 0; i < array.Length; i++)
                    array[i] = a + b * i;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int mx = int.MinValue;
            if (magazine.Length > 3)
            {
                for (int i = 0; (i < magazine.Length-2); i++)
                {
                    int pr_sum = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    if (pr_sum > mx)
                    {
                        mx = pr_sum;

                        indexes = new int[3]{i, i+1, i+2};

                    }
                }

            }
            else
            {
                indexes = new int[magazine.Length];
                for (int i = 0; (i < magazine.Length); i++)
                {
                    indexes[i] = i;
                }
            }
            // end

            return indexes;
        }
    }
}
