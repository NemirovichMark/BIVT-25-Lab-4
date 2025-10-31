namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            double sum = 0;
            double maxElement = array[0];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    index = i;
                }
            }

            double average = sum / array.Length;

            for (int i = index + 1; i < array.Length; i++)
                array[i] = average;
        }

        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            int lenOfFirst = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;
            even = new int[lenOfFirst];
            odd = new int[array.Length - lenOfFirst];

            int evenI = 0;
            int oddI = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[evenI] = array[i];
                    evenI++;
                }
                else
                {
                    odd[oddI] = array[i];
                    oddI++;
                }
            }
            
            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            double avg = array.Average();

            int closestIndex = 0;
            double minDiff = Math.Abs(array[0] - avg);
            for (int i = 1; i < array.Length; i++)
            {
                double diff = Math.Abs(array[i] - avg);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    closestIndex = i;
                }
            }

            int[] answer = new int[array.Length + 1];

            for (int i = 0, j = 0; i < answer.Length; i++)
            {
                answer[i] = array[j];
                if (j == closestIndex)
                {
                    i++;
                    if (i < answer.Length)
                        answer[i] = P;
                }
                j++;
            }

            return answer;
        }
        
        public void Task4(int[] array)
        {
            int countOfNegative = 0;
            
            int[] copy = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    countOfNegative++;
                
                copy[i] = array[i];
            }
            
            int[] negativeElements = new int[countOfNegative];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativeElements[j] =  array[i];
                    j++;
                }
            }
            
            for (int i = 0; i < array.Length; i++)
                array[i] = 0;

            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (copy[i] >= 0)
                {
                    array[k] = copy[i];
                    k++;
                }
            }

            for (int i = 0; i < negativeElements.Length; i++)
            {
                array[k] = negativeElements[i];
                k++;
            }
            
        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            answer = new int[A.Length + B.Length];
            if (k <= A.Length)
            {
                for (int i = 0; i < k; i++) 
                    answer[i] = A[i];
                
                for (int i = 0; i < B.Length; i++)
                    answer[k + i] = B[i];
                
                for (int i = 0; i < A.Length - k; i++)
                    answer[k + B.Length + i] = A[k + i];
            }
            else
            {
                answer = A;
            }

            return answer;
        }

        
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            if (A == null || B == null)
                return (null, null);

            if (A.Length != B.Length)
                return (null, null); 

            int[] sum = new int[A.Length];
            int[] dif = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                sum[i] = A[i] + B[i];
                dif[i] = A[i] - B[i];
            }

            return (sum, dif);
        }
        
        public double[] Task7(int[] array)
        {
            if (array == null || array.Length == 0)
                return null;

            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            if (min == max)
                return null;

            double[] normalized = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = 2.0 * (array[i] - min) / (max - min) - 1.0;
            }

            return normalized;
        }

        public int[] Task8(int[] A, int[] B)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = 0; j < A.Length - i - 1; j++)
                {
                    if (A[j] < A[j + 1])
                    {
                        int temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < B.Length - 1; i++)
            {
                for (int j = 0; j < B.Length - i - 1; j++)
                {
                    if (B[j] < B[j + 1])
                    {
                        int temp = B[j];
                        B[j] = B[j + 1];
                        B[j + 1] = temp;
                    }
                }
            }
            
            int[] C = new int[A.Length + B.Length];
            int indexA = 0, indexB = 0, indexC = 0;

            while (indexA < A.Length && indexB < B.Length)
            {
                if (A[indexA] >= B[indexB])
                {
                    C[indexC++] = A[indexA++];
                }
                else
                {
                    C[indexC++] = B[indexB++];
                }
            }

            while (indexA < A.Length)
            {
                C[indexC++] = A[indexA++];
            }

            while (indexB < B.Length)
            {
                C[indexC++] = B[indexB++];
            }

            return C;
        }

        public void Task9(int[] array)
        {
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            int n = array.Length;
            int shift = maxIndex % n; 

            if (shift == 0) 
                return;

            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
            {
                int newIndex = (i + shift) % n;
                temp[newIndex] = array[i];
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = temp[i];
            }
        }

        public void Task10(int[] array, int N)
        {
            if (array == null || array.Length == 0 || N < 1 || N > array.Length)
                return;

            int leftCount = N - 1;
            int rightCount = array.Length - N;
            int count = Math.Min(leftCount, rightCount);

            for (int i = 0; i < count; i++)
            {
                array[N + i] = array[N - 2 - i];
            }
        }

        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            X = new double[n];
            Y = new double[n];

            double step = 0;
            if (n == 1) step = (a + b) / 2;
            else step = (b - a) / (n - 1);

            if (step != 0 && b>=a)
            {
                int index = 0;
                for (double x = a; x <= b + 0.0001; x += step)
                {
                    double y = Math.Cos(x) + x * Math.Sin(x);
                    
                    X[index] = x;
                    Y[index] = y;
                    index++;
                }

                int k = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i - 1] < Y[i] && Y[i + 1] < Y[i]) || (Y[i - 1] > Y[i] && Y[i + 1] > Y[i])) 
                        k++;
                }

                Xext = new double[k];
                Yext = new double[k];
                index = 0;

                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i - 1] < Y[i] && Y[i + 1] < Y[i]) || (Y[i - 1] > Y[i] && Y[i + 1] > Y[i])) 
                    {
                        Xext[index] = X[i];
                        Yext[index] = Y[i];
                        index++;
                    }
                }
            }
            
            return (Xext, Yext);
        }
        
        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            if (raw == null || raw.Length == 0)
                return (new double[0], new double[0], new double[0]);

            double avg = 0;
            for (int i = 0; i < raw.Length; i++)
                avg += raw[i];
            avg /= raw.Length;

            int brightCount = 0, dimCount = 0, normalCount = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * avg)
                    brightCount++;
                else if (raw[i] < avg / 2)
                    dimCount++;
                else
                    normalCount++;
            }

            double[] bright = new double[brightCount];
            double[] dim = new double[dimCount];
            double[] normal = new double[normalCount];

            int ib = 0, id = 0, inr = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * avg)
                    bright[ib++] = raw[i];
                else if (raw[i] < avg / 2)
                    dim[id++] = raw[i];
                else
                    normal[inr++] = raw[i];
            }

            double meanNormal = normalCount > 0 ? 0 : avg;
            if (normalCount > 0)
            {
                for (int i = 0; i < normalCount; i++)
                    meanNormal += normal[i];
                meanNormal /= normalCount;
            }

            double[] normalFull = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                double val = raw[i];
                if (val > 2 * avg || val < avg / 2)
                    normalFull[i] = 0.5 * (meanNormal + val);
                else
                    normalFull[i] = val;
            }

            for (int i = 0; i < normalFull.Length - 1; i++)
            {
                for (int j = 0; j < normalFull.Length - i - 1; j++)
                {
                    if (normalFull[j] < normalFull[j + 1])
                    {
                        double temp = normalFull[j];
                        normalFull[j] = normalFull[j + 1];
                        normalFull[j + 1] = temp;
                    }
                }
            }

            return (bright, normalFull, dim);
        }


    }
}
