using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            for(int i = 0; i < vector.Length; i++)
            {
                length += vector[i] * vector[i];
            }
            length = Math.Sqrt(length);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            int n = array.Length;
            for (int i = 0;i<n;i++)
            {
                if ((array[i] < Q)&& (array[i] > P))
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
            int n = array.Length;
            int max = -10000000;
            int indexmax = 0;
            for(int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexmax = i;
                }
            }
            if (indexmax == (n - 1))
            {
                return;
            }
            int min = 100000;

            int indexmin = 0;
            for (int i = indexmax; i < n; i++)
            {
                
               if (array[i] < min)
               {
                    min = array[i];
                    indexmin = i;
               }
                
            }
            (array[indexmin], array[indexmax]) = (array[indexmax], array[indexmin]);

            // end

        }
        public void Task4(int[] array)
        {

            // code here
            double max = -100000;
            int n = array.Length;
            int index = 0;
            for(int i = 0; i < n; i+=2)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                    //max = index;
                }
            }
            array[index] = index;
            
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            int n = array.Length;
            index = -1;
            for(int i = 0; i < n; i++)
            {
                if (array[i] == P)
                {
                    index = i; break;
                }
                
                
            }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max]) { max = i; }
            }
            for (int i = 0; i < max-1; i+=2)
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            int n = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                
                    n++;
                
            }
            answer = new int[n];
            n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[n++] = array[i];
                    
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
                for (int k =i+1; k < array.Length; k++)
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
            int temp, n = array.Length;
            for(int i = 0; i < n / 2; i++)
            {
                temp = array[i];
                array[i] = array[n - i - 1];
                array[n - i - 1] = temp;
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
