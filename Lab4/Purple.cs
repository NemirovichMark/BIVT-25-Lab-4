using System.Security.Cryptography;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            int maxindex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxindex])
                {
                    maxindex = i;
                }
            }
            double sum = 0;
            foreach(double element in array)
            {
                sum += element;
            }
            double average = sum / array.Length;
            for (int i = maxindex + 1; i < array.Length; i++)
            {
                array[i] = average;
            }
                
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here

            int evenlength = (array.Length + 1) / 2;
            int oddlength = (array.Length) / 2;

            even = new int[evenlength];
            odd = new int[oddlength];

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[i / 2] = array[i];
                }
                if (i % 2 != 0)
                {
                    odd[i  /2] = array[i];
                }
            }
            // end

            return (even, odd);
        }
            public int[] Task3(int[] array, int P)
            {
                int[] answer = null;

                // code here
                double sum = 0;
                foreach (int i in array)
                {
                    sum += i;
                }
                double average = sum / array.Length;
                int closestindex = 0;
                double difference = Math.Abs(array[0] - average);
                for (int i = 0; i < array.Length; i++)
                {
                    if (Math.Abs(array[i] - average) < difference)
                    {
                    
                        difference = Math.Abs(array[i] - average);
                        closestindex = i;
                    }
                }
                answer = new int[array.Length + 1];
                for (int i = 0; i <= closestindex; i++)
                {
                    answer[i] = array[i];
                }
                answer[closestindex + 1] = P;
                for (int i = closestindex + 1; i < array.Length; i++)
                {
                    answer[i + 1] = array[i];
                }
                // end

                return answer;
            }
        public void Task4(int[] array)
        {

            // code here
            int[] answer = null;
            answer = new int[array.Length];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[index] = array[i];
                    index++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    answer[index] = array[i];
                    index++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = answer[i];
            }
            
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;
            answer = new int[A.Length + B.Length];
            int indexAnswer = 0;
            // code here
            if (k > A.Length) { return A; }
            if (k ==0)
            {
                for (int indexB = 0; indexB < B.Length; indexB++)
                {
                    answer[indexAnswer] = B[indexB];
                    indexAnswer++;
                }
                for (int indexA = 0; indexA < A.Length; indexA++)
                {
                    answer[indexAnswer] = A[indexA];
                    indexAnswer++;
                }

            }
            else if (k < A.Length)
            {
                for (int indexA = 0; indexA < k ; indexA++)
                {
                    answer[indexAnswer] = A[indexA];
                    indexAnswer++;
                }
                for (int indexB = 0; indexB < B.Length; indexB++)
                {
                    answer[indexAnswer] = B[indexB];
                    indexAnswer++;
                }
                for (int indexA = k ; indexA < A.Length; indexA++)
                {
                    answer[indexAnswer] = A[indexA];
                    indexAnswer++;
                }
            }
            else
            {
                for (int indexA = 0; indexA < A.Length; indexA++)
                {
                    answer[indexAnswer] = A[indexA];
                    indexAnswer++;
                }
                for (int indexB = 0; indexB < B.Length; indexB++)
                {
                    answer[indexAnswer] = B[indexB];
                    indexAnswer++;
                }
            }

                // end

                return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            
            int[] sum = null, dif = null;
                
            // code here
            if (A.Length != B.Length)
            {
                
            }
            else
            {
                sum = new int[A.Length];
                dif = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            }
                // end

                return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;
            normalized = new double[array.Length];
            // code here
            int maxElement = array[0];
            int minElement = array[0];
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                }
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }
            double range = (double)(maxElement - minElement);
            if (maxElement == minElement)
            {
                return null;
            }
            
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    double normalizedValue = (array[i] - minElement) / range;
                    normalized[i] = normalizedValue * 2 - 1;
                }
            }
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            int indexC = 0;
            for (int indexB = 0; indexB < B.Length; indexB++)
            {
                C[indexC] = B[indexB];
                indexC++;
            }
            for (int indexA = 0; indexA < A.Length; indexA++)
            {
                C[indexC] = A[indexA];
                indexC++;
            }
            int n = C.Length;
            for (int i = 0; i < n - 1; i++) 
            {
               
                for (int j = 0; j < n - i - 1; j++)
                    if (C[j] < C[j + 1]) 
                        (C[j], C[j + 1]) = (C[j + 1], C[j]); 
            }
            // end

            return C;
        }
        public void Task9(int[] array)
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
            int n = array.Length;
            for (int i = 0; i < maxIndex; i++)
            {
                int temp = array[n - 1];
                for (int j = n - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = temp;
            }

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