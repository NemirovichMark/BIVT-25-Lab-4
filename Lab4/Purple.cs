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
            int leftCount = N - 1;
            int rightCount = array.Length - N;
            int elementsReplace = Math.Min(leftCount, rightCount);
            for (int i = 0; i < elementsReplace; i++)
            {
                array[N + i] = array[N - 2 - i];
            }

            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            X = new double[n];
            Y = new double[n];
            double step = 0;
            if (n == 1)
            {
                X[0] = (b - a) / 2;
            }
            else
            {
                step = ((b - a)) / (double)(n - 1);
            }
            if ((a == b && n != 1) || a > b) { return (null, null); }
            if (step < 0) { return (null, null); }
            for (int i = 0; i < n; i++)
            {
                X[i] = a + i * step;
                double x = X[i];
                Y[i] = Math.Cos(x) + x * Math.Sin(x);
            }
            int MaxCount = 0;
            int MinCount = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if (Y[i] > Y[i - 1] && Y[i] > Y[i + 1])
                {
                    MaxCount++;
                }
                else if (Y[i] < Y[i - 1] && Y[i] < Y[i + 1])
                {
                    MinCount++;
                }
            }
            int indexYext = 0;
            Yext = new double[MaxCount + MinCount];
            Xext = new double[MaxCount + MinCount];
            for (int i = 1; i < n - 1; i++)
            {
                if (Y[i] > Y[i - 1] && Y[i] > Y[i + 1] || Y[i] < Y[i - 1] && Y[i] < Y[i + 1])
                {
                    Yext[indexYext] = Y[i];
                    Xext[indexYext] = X[i];
                    indexYext++;
                }
            }

            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double sm = 0;
            foreach (double item in raw)
            {
                sm += item;
            }
            double avarge_raw = sm / (double)raw.Length;
            int c_dim = 0;
            int c_br = 0;
            foreach (double item in raw)
            {
                if (item > 2 * avarge_raw) { c_br++; }
                if (item < avarge_raw * 0.5) { c_dim++; }
            }
            bright = new double[c_br];
            dim = new double[c_dim];
            int j_br = 0, j_dim = 0;
            double sm_normal = 0;
            foreach (double item in raw)
            {
                if (item > 2 * avarge_raw) { bright[j_br++] = item; }
                else if (item < avarge_raw * 0.5) { dim[j_dim++] = item; }
                else { sm_normal += item; }
            }
            double avarge_norm = sm_normal / (double)(raw.Length - c_dim - c_br);
            normal = new double[raw.Length];
            for (int i = 0; i < normal.Length; i++)
            {
                if (raw[i] > 2 * avarge_raw) { normal[i] = (raw[i] + avarge_norm) / 2; }
                else if (raw[i] < avarge_raw * 0.5) { normal[i] = (raw[i] + avarge_norm) / 2; }
                else { normal[i] = raw[i]; }
            }

            int a = 1;
            int j = 2;
            while (a < normal.Length)
            {
                if (a == 0 || normal[a] <= normal[a - 1]) { a = j; j++; }

                else { (normal[a], normal[a - 1]) = (normal[a - 1], normal[a]); a--; }
            }
            // end

            return (bright, normal, dim);
        }
    }
}