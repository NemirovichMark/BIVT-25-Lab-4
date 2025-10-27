using System.Numerics;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            double sum = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sum += Math.Pow(vector[i], 2);
            }
            length = Math.Sqrt(sum);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > P && array[i] < Q)
                    count++;
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            int mx = -1000000000; int mn = 100000000;
            int indmx = -1; int indmn = -1;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    indmx = i;
                }
            }
            
            for (int j = indmx + 1; j < array.Length; j++)
            {
                if (array[j] < mn)
                {
                    mn = array[j];
                    indmn = j;
                }
            }
            
            if (indmx != -1 && indmn != -1)
            {
                array[indmx] = mn;
                array[indmn] = mx;
            }
        }
            // end

        
        public void Task4(int[] array)
        {

            // code here
            int mx = -1000000000; int mxind = -1;
            for (int i = 0; i < array.Length; i+=2)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    mxind = i;
                }
            }
            if (mxind != -1)
            {
                array[mxind] = mxind;
            }

            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    return index;
                }
                else
                {
                    index = -1;
                }
            }
            
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int mx = -1000000000; int mxind = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    mxind = i;
                }
            }
            if (mxind == 0)
                return;
            for (int i = 0; i < mxind - 1; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    c++;
                }
            }
            answer = new int[c];
            int k = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j]  >= 0)
                {
                    answer[k] = array[j];
                    k++;
                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            int max = 0; int indmax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                max = array[i];
                indmax = i;

                for (int j = indmax + 1; j < array.Length; j++)
                {
                    if (array[j] > max)
                    {
                        max = array[j];
                        indmax = j;
                    }
                }
                int temp = array[i];
                array[i] = array[indmax];
                array[indmax] = temp;
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            int[] arr = new int[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                arr[j] = array[i];
                j++;
            }
            for (int l = 0; l < array.Length; l++)
            {
                array[l] = arr[l];
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            int indA = 0; int indB = 0; int indC = 0;
            int lenC = A.Length + B.Length;
            C = new int[lenC];
            while (indA < A.Length && indB < B.Length)
            {
                C[indC] = A[indA];
                indA++;
                indC++;

                C[indC] = B[indB];
                indB++;
                indC++;
            }
            if (A.Length == 0)
            {
                C = new int[B.Length];
                for (int i = 0; i < B.Length; i++)
                {
                    C[i] = B[i];
                }
                return C;
            }
            if (B.Length == 0)
            {
                C = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    C[i] = A[i];
                }
                return C;
            }
            if ((A.Length == 0) && (B.Length == 0))
            {
                return new int[0];
            }
            
            while (indA < A.Length)
            {
                C[indC] = A[indA];
                indA++;
                indC++;
            }

            while (indB < B.Length)
            {
                C[indC] = B[indB];
                indB++;
                indC++;
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            array = new double[n];

            if (a < b)
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = a + i * step;
                }
            }
            else
            {
                double step = (a - b) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a - i * step;
                }
            }
            if (n == 1 && a == b)
            {
                return new double[] { a };
            }
            if (n == 1)
            {
                return null;
            }
            if (a == b)
            {
                return null;
            }
                // end

                return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            int c = 0; int len = 0;
            double left = 0; double right = 0;
            if (raw.Length < 3)
            {
                return null;
            }
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] == -1)
                {
                    c++;
                }
            }
            if (c == raw.Length)
            {
                restored = new double[raw.Length];
                for (int i = 0; i < raw.Length; i++)
                {
                    restored[i] = -1;
                }
                return restored;
            }
            restored = new double[raw.Length];
            for (int j = 0; j < raw.Length; j++)
            {
                restored[j] = raw[j];

            }
            for (int j = 0; j < raw.Length; j++)
            {
                if (raw[j] == -1)
                {
                    if (j == 0)
                    {
                        left = raw[raw.Length - 1];
                    }
                    else
                    {
                        left = raw[j - 1];
                    }
                    if (j == raw.Length - 1)
                    {
                        right = raw[0];
                    }
                    else
                    {
                        right = raw[j + 1];
                    }
                    if (left != -1 && right != -1)
                    {
                        restored[j] = (left + right) / 2;
                    }
                }
            }
           
            // end

            return restored;
        }
    }
}
