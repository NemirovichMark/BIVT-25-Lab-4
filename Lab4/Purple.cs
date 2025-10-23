using System.Diagnostics.Tracing;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            double max = array[0];
            foreach (double i in array)
            {
                sum += i;
                if (i >= max) max = i;
            }

            double medium = sum / array.Length;
            int maxindex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max && maxindex == -1)
                {
                    maxindex = i;
                }

                if (i > maxindex && maxindex != -1)
                {
                    array[i] = medium;
                }
            }

            // end
            Console.Write(string.Join(" ", array));
        }

        public (int[] even, int[] odd) Task2(int[] array)
        {
            // code here
            int[] even = new int[(array.Length + 1) / 2], odd = new int[array.Length / 2];
            int evenindex = 0, oddindex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[evenindex] = array[i];
                    evenindex++;
                }
                else
                {
                    odd[oddindex] = array[i];
                    oddindex++;
                }
            }

            // end
            return (even, odd);
        }

        public int[] Task3(int[] array, int P)
        {
            int[] answer = new int[array.Length + 1];

            // code here
            double sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }

            double medium = sum / array.Length;
            double dif = 0, current_dif = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0) dif = current_dif = Math.Abs(array[i] - medium);
                else
                {
                    current_dif = Math.Abs(array[i] - medium);
                    if (current_dif < dif)
                    {
                        dif = current_dif;
                    }
                }
            }

            int current_index = 0;
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - medium) == dif && !flag)
                {
                    answer[current_index] = array[i];
                    answer[current_index + 1] = P;
                    flag = true;
                    current_index += 2;
                }
                else
                {
                    answer[current_index] = array[i];
                    current_index++;
                }
            }



            // end

            return answer;
        }

        public void Task4(int[] array)
        {

            // code here
            int plus = 0, minus = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) plus++;
                else minus++;
            }

            int[] pluses = new int[plus];
            int[] minuses = new int[minus];
            int current_pluses = 0;
            int current_minuses = 0;
            foreach (int i in array)
            {
                if (i >= 0)
                {
                    pluses[current_pluses] = i;
                    current_pluses++;
                }
                else
                {
                    minuses[current_minuses] = i;
                    current_minuses++;
                }
            }

            current_pluses = 0;
            current_minuses = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i < pluses.Length)
                {
                    array[i] = pluses[current_pluses];
                    current_pluses++;
                }
                else
                {
                    array[i] = minuses[current_minuses];
                    current_minuses++;
                }
            }

            // end

        }

        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = new int[A.Length + B.Length];
            if (k > A.Length) return A;
            for (int i = 0; i < k; i++)
            {
                answer[i] = A[i];
            }


            for (int i = 0; i < B.Length; i++)
            {
                answer[k + i] = B[i];
            }


            for (int i = k; i < A.Length; i++)
            {
                answer[B.Length + i] = A[i];
            }

            return answer;
        }


        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = new int[A.Length], dif = new int[B.Length];

            // code here
            if (A.Length == B.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    sum[i] = A[i] + B[i];
                }

                for (int i = 0; i < B.Length; i++)
                {
                    dif[i] = A[i] - B[i];
                }
            }
            else
            {
                return (null, null);
            }
            // end

            return (sum, dif);
        }

        public double[] Task7(int[] array)
        {
            double[] normalized = new double[array.Length];

            // code here
            if (array == null || array.Length == 0)
                return normalized;

            bool isRavno = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[0])
                {
                    isRavno = false;
                    break;
                }
            }

            if (isRavno)
                return null;


            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }


            for (int i = 0; i < array.Length; i++)
            {
                double normalizedValue = (array[i] - min) / (double)(max - min);
                normalized[i] = normalizedValue * 2 - 1;
            }
            // end

            return normalized;
        }

        public int[] Task8(int[] A, int[] B)
        {
            int[] C = new int[A.Length + B.Length];

            // code here
            int i = 1, j = 2, n = A.Length;
            while (i < n)
            {
                if (i == 0 || A[i] <= A[i - 1])
                {
                    i = j;
                    j++;
                }
                else
                {
                    (A[i], A[i - 1]) = (A[i - 1], A[i]);
                    i--;
                }
            }

            int i1 = 1, j1 = 2, n1 = B.Length;
            while (i1 < n1)
            {
                if (i1 == 0 || B[i1] <= B[i1 - 1])
                {
                    i1 = j1;
                    j1++;
                }
                else
                {
                    (B[i1], B[i1 - 1]) = (B[i1 - 1], B[i1]);
                    i1--;
                }
            }

            for (i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
            }

            int k = 0;
            for (i = A.Length; i < C.Length; i++)
            {
                C[i] = B[k];
                k++;
            }

            int i2 = 1, j2 = 2, n2 = C.Length;
            while (i2 < n2)
            {
                if (i2 == 0 || C[i2] <= C[i2 - 1])
                {
                    i2 = j2;
                    j2++;
                }
                else
                {
                    (C[i2], C[i2 - 1]) = (C[i2 - 1], C[i2]);
                    i2--;
                }
            }
            // end

            return C;
        }

        public void Task9(int[] array)
        {
            if (array == null || array.Length <= 1)
                return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }

            if (maxIndex == 0)
                return;

            int[] temp = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int newIndex = (i + maxIndex) % array.Length;
                temp[newIndex] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i];
            }
        }

        public void Task10(int[] array, int N)
        {

            // code here
            if (N > array.Length || array == null || array.Length <= 1 || N <= 1)
                return;

            int[] copy = new int[N - 1];
            for (int i = 0; i < N - 1; i++)
            {
                copy[i] = array[i];
            }

            int k = N - 2;
            if (N - 1 <= array.Length - N)
            {
                for (int i = N; i < N + copy.Length; i++)
                {
                    array[i] = copy[k];
                    k--;
                }
            }
            else
            {
                for (int i = N; i < array.Length; i++)
                {
                    array[i] = copy[k];
                    k--;
                }
            }
            // end

        }

        public (double[], double[]) Task11(double a, double b, int n)
        {
            if ((a > b) || (a == b && a == n))
                return (null, null);
            if (n < 3)
                return (new double[0], new double[0]);
            double step = (b - a) /  (n - 1);
            double[] X = new double[n], Y = new double[n];
            int i = 0;
            for (double x = a; x <= b; x += step)
            {
                X[i] = x;
                Y[i] = Math.Cos(x) + x*Math.Sin(x);
                i++;
            }

            int ext_cnt = 0;
            for (int j = 1; j < Y.Length - 1; j++)
            {
                if ((Y[j] > Y[j - 1] && Y[j] > Y[j + 1]) || (Y[j] < Y[j - 1] && Y[j] < Y[j + 1]))
                    ext_cnt++;
            }

            double[] Xext = new double[ext_cnt], Yext = new double[ext_cnt];
            int k = 0;
            for (int j = 1; j < Y.Length - 1; j++)
            {
                if ((Y[j] > Y[j - 1] && Y[j] > Y[j + 1]) || (Y[j] < Y[j - 1] && Y[j] < Y[j + 1]))
                {
                    Xext[k] = X[j];
                    Yext[k] = Y[j];
                    k++;
                }
            }
            return (Xext, Yext);

        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {

            // code here
            double sum = 0;
            foreach (double i in raw)
                sum += i;
            double sred_arefm = sum / raw.Length;
            int bright_count = 0, dim_count = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] / sred_arefm > 2)
                    bright_count++;
                if(raw[i] / sred_arefm < 0.5)
                    dim_count++;
            }

            double[] bright = new double[bright_count], dim = new double[dim_count];
            int i_bright = 0, i_dim = 0;
            double sum1 = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] / sred_arefm > 2)
                {
                    bright[i_bright] = raw[i];
                    i_bright++;
                }

                else if (raw[i] / sred_arefm < 0.5)
                {
                    dim[i_dim] = raw[i];
                    i_dim++;
                }
                else
                {
                    sum1 += raw[i];
                }
            }
            double sred_arifm1 = sum1 / (raw.Length - bright_count - dim_count);
            double[] normal = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] / sred_arefm > 2)
                    normal[i] = (sred_arifm1 + raw[i]) / 2;
                else if (raw[i] / sred_arefm < 0.5)
                    normal[i] = (sred_arifm1 + raw[i]) / 2;
                else normal[i] = raw[i];
            }
            int i1 = 1, j1 = 2, n = normal.Length;
            while (i1 < n)
            {
                if (i1 == 0 || normal[i1] <= normal[i1 - 1])
                {
                    i1 = j1;
                    j1++;
                }
                else
                {
                    (normal[i1], normal[i1 - 1]) = (normal[i1 - 1], normal[i1]);
                    i1--;
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
}
