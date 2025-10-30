using System.Numerics;
using System.Runtime.ExceptionServices;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            double sum = 0;
            int len = vector.Length;
            for (int i = 0; i < len; i++)
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
            int min = Math.Min(P, Q);
            int max = Math.Max(Q, P);
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                if (array[i] > min && array[i] < max)
                {
                    count++;
                }
            }

            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            if (maxIndex == array.Length - 1)
            {
                return;
            }
            int imin = maxIndex + 1;
            for(int i = maxIndex + 1; i < array.Length; i++)
            {
                if (array[i] < array[imin])
                {
                    imin = i;
                }
            }
            int p = array[imin];
            array[imin] = array[maxIndex];
            array[maxIndex] = p;
            
            
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int imax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (array[i] > array[imax])
                    {
                        imax = i;
                    }

                }
            }
            array[imax] = imax;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    break;
                }
            }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            if (maxIndex == 0)
            {
                return;
            }
            int p = 0;
            for (int i = 0; i < maxIndex - 1; i +=2 )
            {
                p = array[i];
                array[i] = array[i + 1];
                array[i + 1] = p;
                
            }


            // end

        }
        public int[] Task7(int[] array)
        {
            

            // code here
            int n = 0;
            int count = 0;
            for(int i = 0; i < array.Length; i++ )
            {
                if (array[i] >= 0)
                {
                    count++;

                }
            }
            int[] answer = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[n] = array[i];
                    n++;
                    

                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                int max = array[i];
                int imax = i;
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k] > max)
                    {
                        max = array[k];
                        imax = k;
                    }
                }
                (array[i], array[imax]) = (array[imax], array[i]);
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            int c = 0;
            for (int i = 0; i < array.Length; i++) { c++; }
            int[] answer = new int[c];
            int j = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                answer[j] = array[i];
                j++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = answer[i];
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A.Length == 0 && B.Length == 0) { return new int[0]; }

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

            int CC = A.Length + B.Length;
            C = new int[CC];
            int iA = 0;
            int iB = 0;
            int iC = 0;

            while (iA < A.Length && iB < B.Length)
            {
                C[iC] = A[iA];
                iA++;
                iC++;

                C[iC] = B[iB];
                iB++;
                iC++;
            }

            while (iA < A.Length)
            {
                C[iC] = A[iA];
                iA++;
                iC++;
            }

            while (iB < B.Length)
            {
                C[iC] = B[iB];
                iB++;
                iC++;
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n <= 0) { return null; }

            if (n == 1)
            {
                if (a == b)
                {
                    return new double[] { a };
                }
                else
                {
                    return null;
                }
            }

            if (a == b) { return null; }


            array = new double[n];
            if (a < b)
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
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
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw.Length < 3)
            {
                return null;
            }

            else
            {
                bool allMinusOne = true;
                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] != -1)
                    {
                        allMinusOne = false;
                        break;
                    }
                }

                if (allMinusOne)
                {
                    restored = new double[raw.Length];
                    for (int i = 0; i < raw.Length; i++)
                    {
                        restored[i] = -1;
                    }
                    return restored;
                }

                restored = new double[raw.Length];
                for (int i = 0; i < raw.Length; i++)
                {
                    restored[i] = raw[i];
                }

                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] == -1)
                    {
                        double leftNeighbor;
                        if (i == 0)
                        {
                            leftNeighbor = raw[raw.Length - 1];
                        }
                        else
                        {
                            leftNeighbor = raw[i - 1];
                        }

                        double rightNeighbor;
                        if (i == raw.Length - 1)
                        {
                            rightNeighbor = raw[0];
                        }
                        else
                        {
                            rightNeighbor = raw[i + 1];
                        }

                        if (leftNeighbor != -1 && rightNeighbor != -1)
                        {
                            restored[i] = (leftNeighbor + rightNeighbor) / 2;
                        }

                    }
                }
            }
            // end

            return restored;
        }
    }
}
