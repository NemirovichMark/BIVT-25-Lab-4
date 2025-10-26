using System;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            int s = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                s += vector[i] * vector[i];
            }
            length = Math.Sqrt(s);
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
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {
            // code
            int mx = array[0];
            int mInd = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mInd = i;
                    mx = array[i];
                }
            }
            if (mInd >= array.Length - 1)
            {
                return;
            }
            int mn = array[mInd + 1];
            int mnInd = mInd + 1;
            for (int i = mInd + 2; i < array.Length; i++)
            {
                if (array[i] < mn)
                {
                    mn = array[i];
                    mnInd = i;
                }
            }
            if (mn < mx)
            {
                array[mnInd] = mx;
                array[mInd] = mn;
            }
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int mVal = array[0];
            int mInd = 0;
            for (int i = 0; i < array.Length; i+=2)
            {
                if (array[i] >  mVal)
                {
                    mVal = array[i];
                    mInd = i;
                }
            }
            array[mInd] = mInd;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;
            int c = 0;

            // code here
            for (int i=0; i < array.Length; i++)
            {
                if (array[i]==P)
                {
                    index = i;
                    c += 1;
                    break;
                }
            }
            if (c == 0)
            {
                return -1;
            }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here

            int mINd = 0;
            int mx = array[0];
            for (int i = 0; i < array.Length;  i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    mINd = i;
                }
            }
            for (int i = 0; i < mINd-1; i+= 2)
            {
                int temp = array[i];
                array[i] = array[i+1];
                array[i+1] = temp;
            }
            
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            int c = 0;
            for (int i =0; i < array.Length; i++)
            {
                if (array[i]<0)
                {
                    c += 1;
                }
            }
            int index = 0;
            int[] a = new int[array.Length-c];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>=0)
                {
                    a[index] = array[i];
                    index++;
                }
            }
            answer = a;
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length-1; i++)
            {
                int mInd = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] > array[mInd])
                    {
                        mInd = j;
                    }
                }
                int temp = array[i];
                array[i] = array[mInd];
                array[mInd] = temp;
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length/2;i++)
            {
                int temp = array[i];
                array[i] = array[array.Length-1-i];
                array[array.Length-1-i] = temp;
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            if (A.Length == 0 && B.Length == 0)
            {
                return null;
            }
            if (A.Length == 0)
            {
                return B.ToArray();
            }
            if (B.Length == 0)
            {
                return A.ToArray(); 
            }
            int[] C = new int[A.Length + B.Length];
            int indA = 0;
            int indB = 0;
            int indC = 0;
            while (indA < A.Length && indB < B.Length)
            {
                C[indC++] = A[indA++];
                C[indC++] = B[indB++];
            }
            while (indA < A.Length)
            {
                C[indC++] = A[indA++];
            }
            while (indB < B.Length)
            {
                C[indC++] = B[indB++];
            }

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (a == b)
            {
                if (n == 1)
                {
                    array = new double[] { 1 };
                }
            }
            else if (n >= 2)
            {
                array = new double[n];
                double st = (b - a) / (n - 1);

                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * st;
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
                        double lNeighbor;
                        if (i == 0)
                        {
                            lNeighbor = raw[raw.Length - 1];
                        }
                        else
                        {
                            lNeighbor = raw[i - 1];
                        }

                        double rNeighbor;
                        if (i == raw.Length - 1)
                        {
                            rNeighbor = raw[0];
                        }
                        else
                        {
                            rNeighbor = raw[i + 1];
                        }
                        if (lNeighbor != -1 && rNeighbor != -1)
                        {
                            restored[i] = (lNeighbor + rNeighbor) / 2;
                        }
                    }
                }
            }
            // end

            return restored;
        }
    }
}
