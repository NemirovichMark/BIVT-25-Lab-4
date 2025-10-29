using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int po = -1;
            int pm = -1;
            int k = 0;
            int m = -100000000;
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > m)
                {
                    m = array[i];
                    pm = i;
                }
                if (array[i] < 0 && k == 0)
                {
                    po = i;
                    k = 1;
                }
            }
            for (int i = pm + 1; i < array.Length; i++)
            {
                s += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i == po)
                    array[i] = s;
                Console.Write(array[i] + " ");
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int pp = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    pp = i;
                }
            }
            if (pp == -1)
            {
                answer = new int[array.Length];
                answer = array;
            }
            else
            {
                answer = new int[array.Length + 1];
                for (int i = 0; i < array.Length + 1; i++)
                {
                    if (i == pp + 1)
                    {
                        answer[i] = P;
                    }
                    if (i <= pp)
                    {
                        answer[i] = array[i];
                    }
                    if (i > pp + 1)
                    {
                        answer[i] = array[i - 1];
                    }
                }
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int mi = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < mi)
                {
                    mi = array[i];
                }
            }
            int k = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == mi)
                    k++;
            }
            if (k == 0)
            {
                answer = new int[array.Length];
                answer = array;
            }
            else
            {
                answer = new int[array.Length - 1];
                k = 0;
                int s = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != mi || s > 0)
                    {
                        answer[k] = array[i];
                        
                        k++;
                    }
                    else
                        s++;
                }
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double s = 0;
            for (int i =0; i<array.Length; i++)
            {
                s += array[i];
            }
            s /= array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= s;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            
            if (A.Length != B.Length)
                sum = 0;
            else
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
            for (int i = 0;i<array.Length;i++)
            {
                sr += array[i];
            }
            int k = 0;
            sr/= array.Length;
            for (int i = 0;i<array.Length;i++)
            {
                if (array[i] < sr)
                    k++;
            }
            indexes = new int[k];
            k = 0;
            for (int i =0;i<array.Length;i++)
            {
                if (array[i] < sr)
                {
                    indexes[k] = i;
                    k++;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int k = 1;
            int p = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1])
                    p++;
                else
                {
                    k = Math.Max(k, p);
                    p = 1;
                }
                k = Math.Max(k, p);
            }
            p = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                    p++;
                else
                {
                    k = Math.Max(k, p);
                    p = 1;
                }
                k = Math.Max(k, p);
            }
            count = k;


            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length*2];
            int k = 0;

            for (int i = 0; i < array.Length * 2; i++)
            {
                answer[i] = array[k];
                i++;
                answer[i] = array[k];
                k++;
            }

            // end

                return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int mi = int.MaxValue;
            int ma = int.MinValue;
            for (int i = 0; i<array.Length;i++)
            {
                if (array[i] < mi)
                    mi = array[i];
                if (array [i] > ma)
                    ma = array[i];
            }
            double r = ma - mi;
            if (mi == ma)
                return null;
            normalized = new double[array.Length];
            for (int i = 0;i<array.Length;i++)
            {
                normalized[i] = array[i]-mi;
                normalized[i] /= r;
           
            }
            
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            int[] a = new int[array.Length];
            for (int j = 0; j < array.Length; j++)
            {
                a[j] = array[j];
            }
            int i = 1;
            while (i < a.Length)
            {      
                if (i == 0 || a[i] >= a[i - 1])
                    i++;
                else
                {
                    (a[i], a[i - 1]) = (a[i - 1], a[i]);
                    i-=1;
                }
            }
            index = -1;
            int l = 0;
            int r = a.Length - 1;
            int sr = 0;
            while( l <= r )
            {
                sr = l + (r - l) / 2;
                if (a[sr] == P)
                {
                    index = sr;
                    break;
                }
                else if (a[sr] < P)
                    l = sr + 1;
                else
                    r = sr - 1;
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            int k = 0;
            int n = a;
            if ( b<=0)
                return null;
            while (n <=c)
            {
                k++;
                n += b;
            }
            
            array = new int[k];
            n = a;
            
            for (int i = 0; i < k; i++)
            {
                array[i] = n;
                n += b;
            }

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int s = 0;
            if (magazine.Length < 4)
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }
            }
            else
            {
                int ma = -1;
                int ind = -1;
                for (int i = 0; i < magazine.Length - 2; i++)
                {
                    s = magazine[i] + magazine[i + 2] + magazine[i + 1];
                    if (s > ma)
                    {
                        ma = s;
                        ind = i;
                    }
                }
                indexes = new int[3];

                for (int i = 0; i < 1 + 2; i++)
                {
                    indexes[i] = ind + i;
                }
            }
            // end

            return indexes;
        }
    }

}
