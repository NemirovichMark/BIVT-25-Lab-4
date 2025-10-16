using System.Numerics;
using System.Runtime.ExceptionServices;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double mx = -1000000;
            int indMx = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    indMx = i;
                }
                sum += array[i];
            }
            double middle = sum / array.Length;
            for(int i = array.Length - 1; i > indMx; i--)
                array[i] = middle;
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            even = new int[array.Length / 2 + array.Length % 2];
            odd = new int[array.Length / 2];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) 
                    even[i / 2] = array[i];
                else
                    odd[i / 2] = array[i];
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int[] nouns = new int[array.Length + 1];
            double dist = 100000;
            int sum = 0;
            double middle = 0;
            int indNear = 0;
            foreach (var i in array) sum += i;
            middle = (double)sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                double curDist = Math.Abs(middle - array[i]);
                if (dist > curDist)
                {
                    dist = curDist;
                    indNear = i;
                }
            }
            for (int i = 0; i < array.Length + 1; i++)
            {
                if (i <= indNear) nouns[i] = array[i];
                else if (i == indNear + 1) nouns[i] = P;
                else nouns[i] = array[i - 1];
            }
            answer = nouns;
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int countNegative = 0;
            foreach (var i in array)
            {
                if(i < 0)
                    countNegative++;
            }
            int[] positives = new int[array.Length - countNegative];
            int[] negatives = new int[countNegative];
            int countPos = 0;
            int countNeg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negatives[countNeg] = array[i];
                    countNeg++;
                }
                else
                {
                    positives[countPos] = array[i];
                    countPos++;
                }
            }
            int curInd = 0;
            for (int i = 0; i < countPos; i++)
            {
                array[i] = positives[i];
                curInd++;
            }
            for(int i = 0; i < countNeg; i++) array[curInd + i] = negatives[i];
            
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            answer = new int[A.Length + B.Length];
            if (k == A.Length - 1)
            {
                int curInd = 0;
                for(int i = 0; i < A.Length; i++)
                {
                    answer[i] = A[i];
                    curInd++;
                }
                for (int i = 0; i < B.Length; i++) answer[curInd + i] = B[i];
            }
            else
            {
                int curInd = 0;
                for (int i = 0; i <= k; i++)
                {
                     answer[curInd] = A[i];
                     curInd = i;
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[curInd] = B[i];
                    curInd++;
                }
                for (int i = k + 1; i < A.Length; i++)
                {
                    answer[curInd] = A[i];
                    curInd++;
                }
            }

            //end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here

            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here

            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here

            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here

            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here

            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here

            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here

            // end

            return (bright, normal, dim);
        }
    }
}
