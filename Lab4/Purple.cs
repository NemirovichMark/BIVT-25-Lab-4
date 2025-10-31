namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            double max = array[0];
            foreach (double item in array)
            {
                sum += item;
                if (item > max) max = item;
            }
            double average = sum / array.Length;
            bool replacing = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (replacing)
                {
                    array[i] = average;
                }
                if (array[i] == max)
                {
                    replacing = true;
                }
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int evens = Convert.ToInt32(Math.Ceiling(0.5 * array.Length));
            even = new int[evens];
            odd = new int[array.Length - evens];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[i / 2] = array[i];
                } else
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
            int mindelta_i = 0;
            double average = 0;
            foreach (var item in array)
            {
                average += (double)item / array.Length;
            }
            double mindelta = Math.Abs(array[0] - average);
            for (int i = 1; i < array.Length; i++)
            {
                double delta = Math.Abs(array[i] - average);
                if (delta < mindelta)
                {
                    mindelta = delta;
                    mindelta_i = i;
                }
            }
            int p_index = mindelta_i + 1;
            answer = new int[array.Length + 1];
            for (int i = 0; i < answer.Length; i++)
            {
                if (i < p_index)
                {
                    answer[i] = array[i];
                } else if (i > p_index)
                {
                    answer[i] = array[i - 1];
                } else
                {
                    answer[i] = P;
                }
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int positive_items = 0, negative_items = 0;
            foreach (int item in array)
            {
                if (item >= 0)
                {
                    positive_items++;
                } else
                {
                    negative_items++;
                }
            }
            int[] positive = new int[positive_items];
            int[] negative = new int[negative_items];
            int positive_i = 0, negative_i = 0;
            foreach (int item in array)
            {
                if (item >= 0)
                {
                    positive[positive_i++] = item;
                } else
                {
                    negative[negative_i++] = item;
                }
            }
            for (int i = 0; i < positive.Length; i++)
            {
                array[i] = positive[i];
            }
            for (int i = 0; i < negative.Length; i++)
            {
                array[positive.Length + i] = negative[i];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k == A.Length)
            {
                answer = new int[A.Length + B.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    answer[i] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[A.Length + i] = B[i];
                }
            } else if (k > A.Length)
            {
                return A;
            }
            else
            {
                int[] A_before_k = new int[k];
                int[] A_after_k = new int[A.Length - k];
                for (int i = 0; i < k; i++)
                {
                    A_before_k[i] = A[i];
                }
                for (int i = k; i < A.Length; i++)
                {
                    A_after_k[i - k] = A[i];
                }
                answer = new int[A_before_k.Length + B.Length + A_after_k.Length];
                for (int i = 0; i < A_before_k.Length; i++)
                {
                    answer[i] = A_before_k[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[A_before_k.Length + i] = B[i];
                }
                for (int i = 0; i < A_after_k.Length; i++)
                {
                    answer[A_before_k.Length + B.Length + i] = A_after_k[i];
                }
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length != B.Length) return (null, null);
            int length = A.Length;
            sum = new int[length];
            dif = new int[length];
            for (int i = 0; i < length; i++)
            {
                sum[i] = A[i] + B[i];
                dif[i] = A[i] - B[i];
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;
            int max = array[0], min = array[0];
            foreach (int item in array)
            {
                if (item > max) max = item;
                if (item < min) min = item;
            }
            if (max == min) return normalized;
            
            // code here
            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = 2.0 * ((double)(array[i] - min) / (double)(max - min)) - 1.0;
            }
            // end
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                C[A.Length + i] = B[i];
            }
            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < C.Length - 1; j++)
                {
                    if (C[j] > C[j + 1])
                    {
                        int temp = C[j + 1];
                        C[j + 1] = C[j];
                        C[j] = temp;
                    }
                }
            }
            int start = 0;
            int end = C.Length - 1;
            while (start < end)
            {
                int temp = C[end];
                C[end] = C[start];
                C[start] = temp;
                start++;
                end--;
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int max = array[0];
            foreach (int item in array)
            {
                if (item > max) max = item;
            }
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    k = i;
                    break;
                }
            }

            if (k == 0) return;

            int[] array_last_k = new int[k];
            int last_k = array.Length - k;
            for (int i = last_k; i < array.Length; i++)
            {
                array_last_k[i - last_k] = array[i];
            }
            int[] array_other = new int[array.Length - k];
            for (int i = 0; i < array.Length - k; i++)
            {
                array_other[i] = array[i];
            }
            for (int i = 0; i < array_last_k.Length; i++)
            {
                array[i] = array_last_k[i];
            }
            for (int i = 0; i < array_other.Length; i++)
            {
                array[array_last_k.Length + i] = array_other[i];
            }

            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here

            int leftTotal = N;
            int rightTotal = array.Length - N + 1;
            int replaceTotal = Math.Min(leftTotal, rightTotal);

            for (int i = 0; i < replaceTotal - 1; i++)
            {
                int left = N - 2 - i;
                int right = N + i;
                array[right] = array[left];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            double step = (b - a) / (n - 1);

            if (n > 1 && a >= b) return (null, null);
            if (step <= 0) return (null, null);

            double yPrev = Math.Cos(a) + a * Math.Sin(a);
            double xCurr = a + step;
            double yCurr = Math.Cos(xCurr) + xCurr * Math.Sin(xCurr);
            int extremesTotal = 0;

            for (int i = 1; i < n - 1; ++i)
            {
                double xNext = a + (i + 1) * step;
                double yNext = Math.Cos(xNext) + xNext * Math.Sin(xNext);

                if ((yCurr > yPrev && yCurr > yNext) || (yCurr < yPrev && yCurr < yNext))
                {
                    extremesTotal++;
                }

                yPrev = yCurr;
                yCurr = yNext;
            }
            Xext = new double[extremesTotal];
            Yext = new double[extremesTotal];

            yPrev = Math.Cos(a) + a * Math.Sin(a);
            xCurr = a + step;
            yCurr = Math.Cos(xCurr) + xCurr * Math.Sin(xCurr);
            int index = 0;

            for (int i = 1; i < n - 1; ++i)
            {
                double xNext = a + (i + 1) * step;
                double yNext = Math.Cos(xNext) + xNext * Math.Sin(xNext);

                if ((yCurr > yPrev && yCurr > yNext) || (yCurr < yPrev && yCurr < yNext))
                {
                    double xAt = a + i * step;
                    Xext[index] = xAt;
                    Yext[index] = yCurr;
                    index++;
                }

                yPrev = yCurr;
                yCurr = yNext;
            }

            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double average = 0;
            foreach (double item in raw) average += item / raw.Length;
            int total_bright = 0, total_dim = 0;
            foreach (double item in raw)
            {
                if (item > 2 * average) total_bright++;
                if (item < 0.5 * average) total_dim++;
            }
            bright = new double[total_bright];
            dim = new double[total_dim];
            double[] removed_anomalies = new double[raw.Length - bright.Length - dim.Length];
            int bright_index = 0, dim_index = 0, removed_index = 0;

            foreach (double item in raw)
            {
                if (item > 2 * average)
                {
                    bright[bright_index++] = item;
                }
                else if (item < 0.5 * average)
                {
                    dim[dim_index++] = item;
                }
                else
                {
                    removed_anomalies[removed_index++] = item;
                }
            }

            double normal_average = 0;
            foreach (double item in removed_anomalies) normal_average += item / removed_anomalies.Length;
            normal = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                bool contains = false;
                foreach (double item in removed_anomalies)
                {
                    if (item == raw[i])
                    {
                        contains = true;
                        break;
                    }
                }
                if (contains)
                {
                    normal[i] = raw[i];
                } else
                {
                    normal[i] = 0.5 * (raw[i] + normal_average);
                }
            }
            for (int i = 0; i < normal.Length; i++)
            {
                for (int j = 0; j < normal.Length - 1; j++)
                {
                    if (normal[j] > normal[j + 1])
                    {
                        double temp = normal[j + 1];
                        normal[j + 1] = normal[j];
                        normal[j] = temp;
                    }
                }
            }
            int start = 0;
            int end = normal.Length - 1;
            while (start < end)
            {
                double temp = normal[end];
                normal[end] = normal[start];
                normal[start] = temp;
                start++;
                end--;
            }

            // end

            return (bright, normal, dim);
        }
    }
}
