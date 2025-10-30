namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            int maxIndex = 0;
            double summ = 0;
            if (array.Length == 0)
                return;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            if (maxIndex == array.Length - 1)
                return;

            double roundedAverage = summ / (array.Length);

            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                array[i] = roundedAverage;
            }

            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {


            // code here

            int length = array.Length;

            int evenLength = (length + 1) / 2;  // Для четных индексов
            int oddLength = length / 2;         // Для нечетных индексов

            // Создаем результирующие массивы
            int[] even = new int[evenLength];
            int[] odd = new int[oddLength];

            // Заполняем массивы
            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0) 
                {
                    even[i / 2] = array[i];
                }
                else 
                {
                    odd[i / 2] = array[i];
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
            foreach (int num in array)
            {
                sum += num;
            }
            double average = sum / array.Length;
            
            int cI = 0;
            double minD = Math.Abs(array[0] - average);
            
            for (int i = 1; i < array.Length; i++)
            {
                double cD = Math.Abs(array[i] - average);
                if (cD < minD)
                {
                    minD = cD;
                    cI = i;
                }
            }
            
            answer = new int[array.Length + 1];
            
            for (int i = 0; i <= cI; i++)
            {
                answer[i] = array[i];
            }
            
            answer[cI + 1] = P;
            for (int i = cI + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }

            // end

            return answer;
        }
        public void Task4(int[] array)
        {
            int[] temp = new int[array.Length];
            int index = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    temp[index] = array[i];
                    index++;
                }
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    temp[index] = array[i];
                    index++;
                }
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i];
            }
        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k > A.Length)
                answer = new int[A.Length];
            else
                answer = new int[A.Length + B.Length];
            int index = 0;
            
            
            for (int i = 0; i < k && i < A.Length; i++)
                {
                    answer[index] = A[i];
                    index++;
                }

            if (k < A.Length)
            {

                for (int j = 0; j < B.Length; j++)
                {
                    answer[index] = B[j];
                    index++;
                }

                if (k < A.Length)
                {
                    for (int i = k; i < A.Length; i++)
                    {
                        answer[index] = A[i];
                        index++;
                    }
                }
            }
            // end

                return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A != null && B != null && A.Length == B.Length)
            {
                int length = A.Length;
                sum = new int[length];
                dif = new int[length];
                
                for (int i = 0; i < length; i++)
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

            // code here
            bool flag = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[0])
                {
                    flag = false;
                    break;
                }
            }
            
            if (!flag)
            {
                int min = array[0];
                int max = array[0];
                
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min) min = array[i];
                    if (array[i] > max) max = array[i];
                }
                
                normalized = new double[array.Length];
                double range = max - min;
                
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = 2.0 * (array[i] - min) / range - 1.0;
                }
            }
            
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            C = new int[A.Length + B.Length];
                
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                C[A.Length + i] = B[i];
            }
            
            for (int i = 0; i < C.Length - 1; i++)
            {
                for (int j = 0; j < C.Length - i - 1; j++)
                {
                    if (C[j] < C[j + 1])
                    {
                        int temp = C[j];
                        C[j] = C[j + 1];
                        C[j + 1] = temp;
                    }
                }
            }
            

            return C;
        }
        public void Task9(int[] array)
        {
            // code here
            if (array != null && array.Length > 0)
            {
                int maxIndex = 0;
                int max = array[0];
                
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        maxIndex = i;
                    }
                }
                
                if (maxIndex == 0)
                    return;
                    
                int[] temp = new int[array.Length];
                
                for (int i = 0; i < array.Length; i++)
                {
                    temp[(i + maxIndex) % array.Length] = array[i];
                }
                
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = temp[i];
                }
            }
            // end
        }
        public void Task10(int[] array, int N)
        {
            // code here

            int leftCount = N;

            int rightCount = array.Length - N + 1;

            int replaceCount;

            if (leftCount <= rightCount)
            {
                replaceCount = leftCount;
                for (int i = 0; i < replaceCount - 1; i++)
                {
                    int leftIndex = N - 2 - i;    
                    int rightIndex = N + i;    
                    array[rightIndex] = array[leftIndex];
                }
            }
            else
            {
                replaceCount = rightCount;
                for (int i = 0; i < replaceCount - 1; i++)
                {
                    int leftIndex = N - 2 - i;    
                    int rightIndex = N + i;    
                    array[rightIndex] = array[leftIndex];
                }
            }
            
            // end
        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double step = (b - a) / (n - 1);
            if (step <= 0)
            {
                return (null, null);
            }

            double ya = Math.Cos(a) + a * Math.Sin(a);
            double yb = Math.Cos(a + step) + (a + step) * Math.Sin(a + step);
            int eeeee = 0;

            for (int i = 1; i < n - 1; ++i)
            {
                double yс = Math.Cos(a + (i + 1) * step) + (a + (i + 1) * step) * Math.Sin(a + (i + 1) * step);

                if ((yb > ya && yb > yс) || (yb < ya && yb < yс))
                {
                    eeeee += 1;
                }

                ya = yb;
                yb = yс;
            }
            double[] xext = new double[eeeee];
            double[] yext = new double[eeeee];

            ya = Math.Cos(a) + a * Math.Sin(a);
            yb = Math.Cos(a + step) + (a + step) * Math.Sin(a + step);
            int idx = 0;

            for (int i = 1; i < n - 1; ++i)
            {
                double yс = Math.Cos(a + (i + 1) * step) + (a + (i + 1) * step) * Math.Sin(a + (i + 1) * step);

                if ((yb > ya && yb > yс) || (yb < ya && yb < yс))
                {
                    double xAt = a + i * step;
                    xext[idx] = xAt;
                    yext[idx] = yb;
                    idx++;
                }

                ya = yb;
                yb = yс;
            }

            return (xext, yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double average = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                average += raw[i];
            }
            average /= raw.Length;

            int brightCount = 0, dimCount = 0, normalCount = 0;
            
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * average)
                    brightCount++;
                else if (raw[i] < 0.5 * average)
                    dimCount++;
                else
                    normalCount++;
            }

            double[] bright = new double[brightCount];
            double[] dim = new double[dimCount];
            double[] normal = new double[raw.Length];
            double[] removedAnomalies = new double[normalCount];

            int brightIdx = 0, dimIdx = 0, normalIdx = 0;
            
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * average)
                {
                    bright[brightIdx++] = raw[i];
                }
                else if (raw[i] < 0.5 * average)
                {
                    dim[dimIdx++] = raw[i];
                }
                else
                {
                    removedAnomalies[normalIdx++] = raw[i];
                }
            }

            double normalAverage = 0;
            for (int i = 0; i < removedAnomalies.Length; i++)
            {
                normalAverage += removedAnomalies[i];
            }
            normalAverage /= removedAnomalies.Length;

            for (int i = 0; i < raw.Length; i++)
            {
                bool isNormal = false;
                
                for (int j = 0; j < removedAnomalies.Length; j++)
                {
                    if (raw[i] == removedAnomalies[j])
                    {
                        isNormal = true;
                        break;
                    }
                }

                if (isNormal)
                {
                    normal[i] = raw[i];
                }
                else
                {
                    normal[i] = 0.5 * (raw[i] + normalAverage);
                }
            }

            for (int i = 0; i < normal.Length - 1; i++)
            {
                for (int j = 0; j < normal.Length - i - 1; j++)
                {
                    if (normal[j] < normal[j + 1])
                    {
                        double temp = normal[j];
                        normal[j] = normal[j + 1];
                        normal[j + 1] = temp;
                    }
                }
            }

            return (bright, normal, dim);
        }
    }
}