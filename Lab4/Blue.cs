using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            int imax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[imax]) imax = i;
            }

            int sumax = 0;
            if (imax < array.Length - 1)
            {
                for (int i = imax + 1; i < array.Length; i++)
                {
                    sumax += array[i];
                }
            }

            int ineg = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    ineg = i;
                    break;
                }
            }

            if (ineg != -1) array[ineg] = sumax;
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            if (array == null) return null;
            if (array.Length == 0) return new int[0];

            int ipol = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    ipol = i;
                }
            }

            if (ipol == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[array.Length + 1];
                for (int i = 0; i <= ipol; i++)
                {
                    answer[i] = array[i];
                }

                answer[ipol + 1] = P;

                for (int i = ipol + 1; i < array.Length; i++)
                {
                    answer[i + 1] = array[i];
                }
            }
            // end
            
            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null) return null;
            if (array.Length == 0) return new int[0];

            int ipolmin = -1;
            int n = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < n)
                {
                    ipolmin = i;
                    n = array[i];
                }
            }

            if (ipolmin == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[array.Length - 1];
                for (int i = 0; i < ipolmin; i++)
                {
                    answer[i] = array[i];
                }

                for (int i = ipolmin + 1; i < array.Length; i++)
                {
                    answer[i - 1] = array[i];
                }
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double sr = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] - sr;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A == null || B == null) return 0;
            if (A.Length != B.Length) return 0;

            int n = int.Min(A.Length, B.Length);

            for (int i = 0; i < n; i++)
            {
                sum += (A[i] * B[i]);
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            if (array == null || array.Length == 0) return new int[0];

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double sr = sum / array.Length;

            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    n++;
                }
            }

            indexes = new int[n];

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
            if (array == null || array.Length == 0) return 0;
            if (array.Length == 1) return 1;

            int a = 1;
            int cr = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                {
                    cr++;
                    a = Math.Max(a, cr);
                }
                else
                {
                    cr = 1;
                }
            }

            cr = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                {
                    cr++;
                    a = Math.Max(a, cr);
                }
                else
                {
                    cr = 1;
                }
            }

            count = a;
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null) return null;
            if (array.Length == 0) return new int[0];

            answer = new int[2 * array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                answer[2 * i] = array[i];
                answer[2 * i + 1] = array[i];
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            if (array == null || array.Length == 0) return null;

            int mn = int.MaxValue;
            int mx = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < mn)
                {
                    mn = array[i];
                }
                if (array[i] > mx)
                {
                    mx = array[i];
                }
            }

            if (mn == mx) return null;

            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (double)(array[i] - mn) / (mx - mn);
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            if (array == null || array.Length == 0) return -1;

            int[] array2 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }

            for (int i = 0; i < array2.Length - 1; i++)
            {
                for (int j = 0; j < array2.Length - 1 - i; j++)
                {
                    if (array2[j] > array2[j + 1])
                    {
                        int a = array2[j];
                        array2[j] = array2[j + 1];
                        array2[j + 1] = a;
                    }
                }
            }

            int left = 0;
            int right = array2.Length - 1;
            bool f = false;

            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (array2[mid] == P)
                {
                    index = mid;
                    f = true;
                    break;
                }
                
                if (array2[mid] < P)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            if (f == false)
            {
                index = -1;
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            int count = 0;

            if (b > 0)
            {
                for (int i = a; i < c + 0.0001; i += b)
                {
                    count++;
                }

                array = new int[count];
                int j = 0;

                for (int i = a; i < c + 0.0001; i += b)
                {
                    array[j] = i;
                    j++;
                }
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if (magazine == null || magazine.Length == 0) return new int[0];

            int n = Math.Min(3, magazine.Length);
            int maxsum = 0;
            int ind = 0;

            for (int i = 0; i <= magazine.Length - n; i++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                {
                    s += magazine[i + j];
                }

                if (s > maxsum)
                {
                    maxsum = s;
                    ind = i;
                }
            }

            indexes = new int[n];
            for (int i = 0; i < n; i++)
            {
                indexes[i] = ind + i;
            }
            // end

            return indexes;
        }
    }
}