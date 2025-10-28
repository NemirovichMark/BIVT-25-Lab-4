using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here

            int kmi = -1, ma = -100000, s = 0, kma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= ma)
                {
                    ma = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    kmi = i;
                    break;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == ma)
                {
                    kma = i; break;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i > kma && kma != array.Length)
                {
                    s += array[i];
                }
                else
                {
                    s = 0;
                }
            }
            if (kmi!=-1 && kma != array.Length)
            {
                array[kmi] = s;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here

            int n = array.Length;
            int k = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    k = i;
                }
            }
            answer = new int[n + 1];
            if (k > -1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i <= k)
                    {
                        answer[i] = array[i];
                    }
                    else
                    {
                        answer[i + 1] = array[i];
                    }
                }
                answer[k + 1] = P;
            }
            else
            {
                answer = array;
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here

            int n = array.Length;
            int k = -1, mi = 100000;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < mi && array[i]>0)
                {
                    mi = array[i];
                    k = i;
                }
            }
            answer = new int[n - 1];
            if (k > -1)
            {
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i < k)
                    {
                        answer[i] = array[i];
                    }
                    else
                    {
                        answer[i] = array[i+1];
                    }
                }
            }
            else
            {
                answer = array;
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here

            double sr = 0;
            for (int i = 0;i<array.Length; i++)
            {
                sr+= array[i];
            }
            if (sr!=0)
            {
                sr = sr / (array.Length);
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i]-sr;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here

            if (A.Length==B.Length)
            {
                for (int i = 0; i < A.Length;i++)
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

            int n = array.Length;
            double sr = 0;
            int k = 0, c = 0;
            for (int i = 0; i < n; i++)
            {
                sr += array[i];
            }
            sr = sr / n;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < sr)
                {
                    k++;
                }
            }
            indexes = new int[k];
            for (int i = 0; i < n; i++)
            {
                if (array[i] < sr)
                {
                    indexes[c] = i;
                    c++;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 1;

            // code here

            int k = 1, c = 1;
            for ( int i = 1; i<array.Length;i++)
            {
                if (array[i]>=array[i-1])
                {
                    k++;
                }
                else
                {
                    k = 1;
                }
                if (k>count)
                {
                    count = k;
                }
                if (array[i] <= array[i - 1])
                {
                    c++;
                }
                else
                {
                    c = 1;
                }
                if (c>count)
                {
                    count = c;
                }
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here

            answer=new int[array.Length*2];
            int c = 0;
            for (int i = 0;i<array.Length;i++)
            {
                answer[c]= array[i];
                answer[c + 1] = array[i];
                c += 2;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here

            normalized = new double[array.Length];
            int ma = -100000, mi = 1000000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > ma)
                {
                    ma = array[i];
                }
                if (array[i] < mi)
                {
                    mi = array[i];
                }
            }
            double down = ma - mi;
            if (down != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = (array[i]-mi)/down;
                }
            }
            else
            {
                normalized = null;
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = -1;

            // code here

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
            int low = 0, high = array.Length - 1, mid = 0;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here

            int k = 0;
            if (b < 0)
            {
                array = null;
            }
            else
            {
                for (int i = a; i <= c;)
                {
                    k++;
                    i += b;
                }
                array = new int[k];
                for (int i = 0; i < k; i++)
                {
                    array[i] = a;
                    a += b;
                }
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            int ma = int.MinValue;
            int k1 = -1, k2 = -1, k3 = -1;
            if (magazine.Length > 3)
            {
                indexes = new int[3];
                for (int i = 0; i < magazine.Length - 2; i++)
                {
                    if ((magazine[i] + magazine[i + 1] + magazine[i + 2]) > ma)
                    {
                        ma = (magazine[i] + magazine[i + 1] + magazine[i + 2]);
                        k1 = i; k2 = i + 1; k3 = i + 2;
                    }
                }
                indexes[0] = k1; indexes[1] = k2; indexes[2] = k3;
            }
            else
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }
            }
            // end

            return indexes;
        }
    }
}
