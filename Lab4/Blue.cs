using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int I = -1, mi = -1, sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (I == -1 || array[i] > array[I])
                {
                    I = i;
                    sum = 0;
                }
                else
                {
                    sum += array[i];
                }
                if (mi == -1 && array[i] < 0) mi = i;
            }
            if(mi != -1)
                array[mi] = sum;
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int l = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) l = i;
            }
            if(l == -1)
            {
                return array;
            }
            l++;
            answer = new int[array.Length+1];
            for(int i = 0; i < answer.Length; i++)
            {
                if(i > l) answer[i] = array[i - 1];
                else if (i == l) answer[i] = P;
                else answer[i] = array[i];
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int l = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (l == -1) l = i;
                    else if (array[i] < array[l]) l = i;
                }
            }
            if (l == -1)
            {
                return array;
            }
            answer = new int[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i > l) answer[i - 1] = array[i];
                else if (i == l) continue;
                else answer[i] = array[i];
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double mid = 0;
            for (int i = 0; i < array.Length; i++) mid += array[i];
            mid /= array.Length;
            for(int i = 0; i < array.Length; i++)array[i] -= mid;
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            Console.WriteLine($"{A.Length} {B.Length}");
            if (A.Length != B.Length) return 0;
            for (int i = 0; i < Math.Min(A.Length, B.Length); i++) sum += A[i] * B[i];
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double mid = 0;
            for (int i = 0; i < array.Length; i++) mid += array[i];
            mid /= array.Length;
            int s = 0;
            for (int i = 0; i < array.Length; i++) if (array[i] < mid) s += 1;
            indexes = new int[s];
            int j = 0;
            for (int i = 0; i < array.Length; i++) if (array[i] < mid) 
                { indexes[j] = i; j++; }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 1;

            // code here
            int cp = 1, cm = 1;
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1]) { cp++; cm = 1; }
                else if (array[i] < array[i - 1]) { cp = 1; cm++; }
                else { cp++; cm++; }
                count = Math.Max(count, Math.Max(cp, cm));
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++) { answer[i * 2] = array[i]; answer[i * 2 + 1] = array[i]; }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int max = array[0], min = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                max = Math.Max(array[i], max);
                min = Math.Min(array[i], min);
            }
            if (max == min) return null;
            normalized = new double[array.Length];
            for(int i = 0; i < normalized.Length; i++)
            {
                normalized[i] = ((double)array[i] - (double)min) / ((double)max - (double)min);
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            int[] sarray = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                int minInd = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[minInd] > array[j]) minInd = j;
                }
                sarray[i] = array[minInd];
                array[minInd] = 1_000_000_000;
            }
            int l = 0, r = array.Length - 1, m = 0;
            while(l <= r)
            {
                m = (l + r) / 2;
                if (sarray[m] < P)
                {
                    l = m + 1;
                }
                else if (sarray[m] > P)
                {
                    r = m - 1;
                }
                else
                {
                    return m;
                }
            }
            if (sarray[m] != P) return -1;
            // end

            return m;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            int count = 0;
            if (b < 0) return null;
            for (int i = a; i <= c; i+=b) count++;
            array = new int[count];
            count = 0;
            for (int i = a; i <= c; i+=b) array[count++] = i;
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            switch (magazine.Length)
            {
                case 1: return new int[] { 0 };
                case 2: return new int[] { 0, 1 };
                case 3: return new int[] { 0, 1, 2 };
                default: break;
            }
            int max = magazine[0] + magazine[1] + magazine[2], ind = 1;
            for(int i = 1; i < magazine.Length - 1; i++)
            {
                if (magazine[i - 1] + magazine[i] + magazine[i + 1] > max)
                {
                    max = magazine[i - 1] + magazine[i] + magazine[i + 1];
                    ind = i;
                }
            }
            return new int[] { ind - 1, ind, ind + 1 };
            // end

            return indexes;
        }
    }
}
