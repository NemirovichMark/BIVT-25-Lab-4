using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            // code here
            int s = 0;
            int max = int.MinValue;
            int imax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i]) { max = array[i]; imax = i; }
            }
            if (imax != array.Length - 2)
            {
                for (int i = imax + 1; i < array.Length; i++)
                {
                    s += array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    if (imax == array.Length - 2) { array[i] = 0; }
                    else
                    {
                        array[i] = s;
                    }
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int ip = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    ip = i;
                }
            }

            int[] array2 = new int[array.Length + 1];
            answer = array2;

            if (ip == array.Length - 1)
            {

                for (int i = 0; i < array2.Length - 1; i++)
                {
                    array2[i] = array[i];
                }
                array2[ip + 1] = P;

            }

            else if (ip == -1 || ip == array.Length - 1)
            {
                answer = array;
                return answer;
            }

            else
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    if (i <= ip) { array2[i] = array[i]; }
                    else if (i == ip + 1)
                    {
                        array2[i] = P;
                    }
                    else if (i > ip + 1) { array2[i] = array[i - 1]; }
                }
            }

            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;
            int[] array2 = new int[array.Length-1];
            // code here
            int mn = int.MaxValue;
            int imn = -1;
            for (int i=0; i < array.Length; i++)
            {
                if (array[i] < mn && array[i]>0)
                {
                    mn = array[i];
                    imn = i;
                }
            }
            if (imn == -1)
            {
                return answer = array;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i < imn) { array2[i] = array[i]; }
                else if (i == imn) { continue; }
                else if (i > imn) { array2[i-1] = array[i]; }
            }
            answer = array2;
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double s = 0;
            double ss = 0;
            for (int i=0; i < array.Length; i++)
            {
                s += array[i];
            }
            ss=s/array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= ss;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length == B.Length)
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
            double a = 0;
            double s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
            }
            a=s/array.Length;
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < a)
                {
                    cnt++;
                }
            }
            int[] ind = new int[cnt];
            cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < a)
                {
                    ind[cnt] = i;
                    cnt++;
                }
            }
            indexes = ind;
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            if (array.Length == 1)
            {
                return count = 1;
            }
            int d = 0;
            int cnt = 1;
            count = int.MinValue;
            for (int j = 0; j < array.Length - 1; j++)
            {
                cnt = 1;
                d = 0;
                for (int i = j; i < array.Length - 1; i++)
                {
                    if (array[i] == array[i + 1])
                    {
                        cnt++;
                        count = Math.Max(count, cnt);
                    }
                    else if (array[i] > array[i + 1] && d == 1)
                    {
                        cnt++;
                        count = Math.Max(count, cnt);
                    }
                    else if (array[i] > array[i + 1] && d == 0)
                    {
                        cnt++;
                        d = 1;
                        count = Math.Max(count, cnt);
                    }
                    else if (array[i] < array[i + 1] && d == 2)
                    {
                        cnt++;
                        count = Math.Max(count, cnt);
                    }
                    else if (array[i] < array[i + 1] && d == 0)
                    {
                        cnt++;
                        d = 2;
                        count = Math.Max(count, cnt);
                    }

                    else
                    {
                        count = Math.Max(count, cnt);
                        cnt = 1;
                        d = 0;
                    }
                }
            }

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            int j = 0;
            int[] arr2 = new int  [array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                arr2[j] = array[i];
                arr2[j + 1] = array[i];
                j += 2;
            }
            answer = arr2;
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int cnt = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i]== array[i+1])
                {
                    cnt++;
                }         
            }
            if (cnt == array.Length)
            {
                return normalized;
            }
            double[] arr2 = new double[array.Length];
            double mn = double.MaxValue;
            double mx = double.MinValue; 
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
            for (int i = 0; i < array.Length; i++)
            {
                arr2[i] = (array[i] - mn) / (mx - mn);         
            }

            normalized = arr2;
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;
            // code here
            int i = 1, n = array.Length;
            while (i < n)
            {
                if (i == 0 || array[i] >= array[i - 1])
                    i++;
                else
                {
                    (array[i], array[i - 1]) = (array[i - 1], array[i]);
                    i--;
                }
            }
            int low = 0, high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == P) { return index = mid; }
                else if (array[mid] < P) { low = mid + 1; }
                else { high = mid - 1; }
            }
            return -1;

            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <= 0) { return array; }
            int k = a;
            int l = 1;
            while (k <= c)
            {
                k += b;
                l++;
            }
            int[] arr2 = new int[l-1];
            k = a;
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = k;
                k += b;
            }
            // end
            array = arr2;

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;
            // code here
            if (magazine.Length < 3)
            {
                int[] k = { 0 };
                indexes = k;
                return indexes;
            }
            else if (magazine.Length < 3)
            {
                int[] k = {0,1,2};
                indexes = k;
                return indexes;
            }
            int[] k2 = new int[3];
            int mx = int.MinValue;
            for (int i = 0; i < magazine.Length - 2; i++)
            {
                if (magazine[i]+ magazine[i+1]+ magazine[i + 2] > mx)
                {
                    mx = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    k2[0] = i;
                    k2[1] = i+1;
                    k2[2] = i+2;
                }
            }
            indexes = k2;
            // end

            return indexes;
        }
    }
}
