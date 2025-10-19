using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int otric = -1;
            int sum = 0;
            int mx = -100;
            int mxi = 0;
            int a = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    otric = i;
                    break;
                }

            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    mxi = i;
                }
            }
            for (int i = mxi + 1; i < array.Length; i++)
            {
                sum += array[i];

            }
            if (otric >= 0)
            {
                array[otric] = sum;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer;

            // code here
            int a = array.Length;
            int r = 0;
            int mxi = -1;
            int n = a;
            for (int i = a - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    mxi = i;
                    r = array[i];
                    n = a + 1;

                    break;
                }
            }
            answer = new int[n];
            if (mxi >= 0)
            {

                for (int i = 0; i <= mxi; i++)
                {
                    answer[i] = array[i];
                }
                answer[mxi + 1] = P;
                for (int i = mxi + 2; i < n; i++)
                {
                    answer[i] = array[i - 1];
                }
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
            int[] answer;

            // code here
            int c = 0;
            int mn = 900;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < mn)
                {
                    mn = array[i];
                    index = i;
                }
            }
            if (mn != 900)
            {
                answer = new int[array.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    answer[i] = array[i];
                }
                for (int i = index; i < answer.Length; i++)
                {
                    answer[i] = array[i + 1];
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
            int k = 0;
            double s = 0;
            double sr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                k += 1;
                s += array[i];
            }
            if (k > 0)
            {
                sr = s / k;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (array[i] - sr);
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length == B.Length)
            {
                for (int i = 0; i < B.Length; i++)
                {
                    sum += A[i] * B[i];
                }
            }
            else
            {
                sum = 0;
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes;

            // code here
            int c = 0;
            int sum = 0;
            double sr = 0;
            int k = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                c += 1;
                sum += array[i];
            }
            if (c > 0)
            {
                sr = (double)sum / c;
            }
            Console.WriteLine(sr);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    k += 1;
                }
            }
            indexes = new int[k];
            k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    indexes[k++] = i;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int mx1 = -100;
            int k1 = 0;
            int k2 = 0;
            int mx2 = -100;
            int mx = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1])
                {
                    k1++;
                    if (k1 >= mx1)
                    {
                        mx1 = k1 + 1;
                    }
                }
                else
                {
                    k1 = 0;
                }
                if (array[i + 1] <= array[i])
                {
                    k2++;
                    if (k2 >= mx2)
                    {
                        mx2 = k2 + 1;
                    }
                }
                else
                {
                    k2 = 0;
                }

            }

            if (mx1 > mx2)
            {
                count = mx1;
            }
            else
            {
                count = mx2;
            }
            if (array.Length == 1)
            {
                count = 1;
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            // code here
            int[] answer = new int[array.Length * 2];
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                answer[n] = array[i];
                answer[n + 1] = array[i];
                n += 2;

            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here

            normalized = new double[array.Length];
            int mx = -100; 
            int mn = 100;
            double s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                }
                if (array[i] < mn)
                {
                    mn = array[i];
                }
            }
            int a = (mx - mn);
            if (a != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    s = (array[i] - mn) / ((double)a);
                    normalized[i] = s;
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
            int g = 0;
            int low = 0;
            int high = array.Length - 1;
            for (int n = 0; n < array.Length; n++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i + 1] < array[i])
                    {
                        g = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = g;

                    }
                }
            }
            while (low <= high)
            {
                int mid = (low + high) / 2;
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
            // code here
            int k = 0;
            int s = a;
            int[] array;
            if (b < 0)
            {
                array = null;
            }
            else
            {
                while (s <= c)
                {
                    s += b;
                    k++;
                }
                array = new int[k];
                if (k > 0)
                {
                    array[0] = a;
                    for (int i = 1; i < array.Length; i++)
                    {
                        array[i] = array[i - 1] + b;
                    }
                }

            }

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            // code here
            int[] indexes = new int[3];
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int s = 0;
            int mx = -100;
            if (magazine.Length > 3)
            {
                indexes = new int[3];
                for (int i = 0; i < magazine.Length - 2; i++)
                {
                    a1 = magazine[i];
                    a2 = magazine[i + 1];
                    a3 = magazine[i + 2];
                    if (a1 + a2 + a3 > mx)
                    {
                        mx = (a1 + a2 + a3);
                        indexes[0] = i;
                        indexes[1] = i + 1;
                        indexes[2] = i + 2;
                    }
                }
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
