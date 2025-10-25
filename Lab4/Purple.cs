using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            double max = array[0];
            int maxIndex = 0;
            for (int i = 0; i <= array.Length-1; i++)
            {
                if (array[i]>max)
                {
                    maxIndex = i;
                    max = array[i];
                }
                sum += array[i];
            }
            double srAr = 0;
            if (array.Length != 0)
            {
                srAr = (double)sum / (array.Length);
            }
            for (int j = maxIndex+1; j<=array.Length-1; j++)
            {
                array[j] = srAr;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int evenLength = (array.Length + 1) / 2;
            int oddLength = array.Length / 2;
            even = new int[evenLength];
            odd = new int[oddLength];

            int evenIndex = 0;
            int oddIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[evenIndex] = array[i];
                    evenIndex++;
                }
                else
                {
                    odd[oddIndex] = array[i];
                    oddIndex++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int sum = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                sum += array[i];
            }
            double srAr = 0;
            if (array.Length!=0)
            {
                srAr =(double) sum / array.Length;
            }
            double min = Math.Abs(srAr - array[0]);
            int minIndex = 0;
            for (int i=0; i <= array.Length - 1; i++)
            {
                if (min > Math.Abs(srAr - array[i]))
                {
                    min = Math.Abs(srAr - array[i]);
                    minIndex = i;
                }
            }
            answer = new int[array.Length+1];
            int k = 0;
            for (int j = 0; j<=answer.Length-1; j++)
            {
                if (j==minIndex+1)
                {
                    answer[j] = P;
                } else
                {
                    answer[j] = array[k];
                    k++;
                }
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int[] nArray = new int[array.Length];
            int k = 0;
            for (int d = 0; d<=array.Length-1; d++)
            {
                nArray[d] = array[d];
            }
            for (int i =0; i<=nArray.Length-1;i++)
            {
                if (nArray[i]>=0)
                {
                    array[k] = nArray[i];
                    k++;
                }
            }
            for (int j = 0; j <= nArray.Length-1; j++)
            {
                if (nArray[j] < 0)
                {
                    array[k] = nArray[j];
                    k++;
                }
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k > A.Length)
            {
                answer = new int[A.Length];
                for (int i = 0; i<A.Length; i++)
                {
                    answer[i] = A[i];
                }
            }
            else
            {
                answer = new int[A.Length + B.Length];
                int index = 0;
                for (int i = 0; i < k && i < A.Length; i++)
                {
                    answer[index] = A[i];
                    index++;
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[index] = B[i];
                    index++;
                }
                for (int i = k; i < A.Length; i++)
                {
                    answer[index] = A[i];
                    index++;
                }
            }
        // end

        return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here

            if (A.Length == B.Length)
            {
                sum = new int[A.Length];
                dif = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            }

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            int min = array[0];
            int max = array[0];
            bool ifSame = true;
            for (int i = 1; i<array.Length; i++)
            {
                if (array[i]<min)
                {
                    min = array[i];
                }
                if (array[i]>max)
                {
                    max = array[i];
                }
                if (array[i - 1] != array[i])
                {
                    ifSame = false;
                }
            }
            normalized = new double[array.Length];
            if (!ifSame)
            {
                if (max != min)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        normalized[i] = (double)2 * (array[i] - min) / (max - min) - 1;
                    }
                }
            } else
            {
                normalized = null;
            }
                // end

                return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            int bIndex = 0;
            for (int i = 0; i<C.Length;i++)
            {
                if (i>=A.Length)
                {
                    C[i] = B[bIndex];
                    bIndex++;
                }else
                {
                    C[i] = A[i];
                }
            }
            for (int i = 0; i < C.Length; i++)
            {
                for (int j = i; j < C.Length; j++)
                {
                    if (C[i] < C[j])
                    {
                        int temp = C[j];
                        C[j] = C[i];
                        C[i] = temp;
                    }
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int max = array[0];
            int maxInd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxInd = i;
                }
            }
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i+maxInd>=array.Length)
                {
                    arr[i + maxInd - array.Length] = array[i];
                } else
                {
                    arr[i + maxInd] = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = arr[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            int indexL = N - 2;
            for (int i = N; i < array.Length && indexL >= 0; i++)
            {
                array[i] = array[indexL];
                indexL--;
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (a < b || (a == b && n == 1))
            {
                double step = (b - a) / (n - 1);
                X = new double[n];
                Y = new double[n];
                int index = 0;
                for (double x = a; x <= b + step/2; x += step)
                {
                    X[index] = x;
                    Y[index] = Math.Cos(x) + x * Math.Sin(x);
                    index++;
                }

                double[] XExtNew = new double[n];
                double[] YExtNew = new double[n];
                index = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i] < Y[i - 1] && Y[i] < Y[i + 1]) || ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1])))
                    {
                        XExtNew[i - 1] = X[i];
                        YExtNew[i - 1] = Y[i];
                        index++;
                    }
                }

                Xext = new double[index];
                Yext = new double[index];
                index = 0;
                for (int i = 0; i < XExtNew.Length; i++)
                {
                    if (XExtNew[i] != 0 && YExtNew[i] != 0)
                    {
                        Xext[index] = XExtNew[i];
                        Yext[index] = YExtNew[i];
                        index++;
                    }
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double[] brightOther = new double[raw.Length];
            double[] dimOther = new double[raw.Length];
            double sum = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                sum += raw[i];
            }
            double srAr = (double)sum / raw.Length;

            int brightIndex = 0;
            int dimIndex = 0;
            double sumOther = 0;
            int kol = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > srAr * 2.0)
                {
                    brightOther[brightIndex] = raw[i];
                    brightIndex++;
                }
                else if (raw[i] < srAr / 2.0)
                {
                    dimOther[dimIndex] = raw[i];
                    dimIndex++;
                }
                else
                {
                    sumOther += raw[i];
                    kol++;
                }
            }

            bright = new double[brightIndex];
            normal = new double[raw.Length];
            dim = new double[dimIndex];
            for (int i = 0; i < brightIndex; i++)
            {
                bright[i] = brightOther[i];
            }
            for (int i = 0; i < dimIndex; i++)
            {
                dim[i] = dimOther[i];
            }

            double srArNew = (double)sumOther / kol;
            for (int i = 0; i < raw.Length; i++)
            {
                if ((raw[i] > srAr * 2.0) || (raw[i] < srAr / 2.0))
                {
                    raw[i] = (raw[i] + srArNew) / 2.0;
                }
            }

            for (int i = 0; i < raw.Length; i++)
            {
                normal[i] = raw[i];
            }

            for (int i = 0; i < normal.Length; i++)
            {
                for (int j = 0; j < normal.Length; j++)
                {
                    if (normal[i] > normal[j])
                    {
                        double temp = normal[i];
                        normal[i] = normal[j];
                        normal[j] = temp;
                    }
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
}
