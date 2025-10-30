namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double average = array.Average();
            double max = array.Max();
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
            double average = array.Average();
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
            int[] positive = array.Where(n => (n >= 0)).ToArray();
            int[] negative = array.Where(n => (n < 0)).ToArray();
            int i = 0;
            foreach (int num in positive.Concat(negative).ToArray())
            {
                array[i] = num;
                i++;
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k == A.Length)
            {
                answer = A.Concat(B).ToArray();
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
                answer = A_before_k.Concat(B).Concat(A_after_k).ToArray();
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

            if (array.Min() == array.Max()) return normalized;
            
            // code here
            normalized = new double[array.Length];
            int max = array.Max();
            int min = array.Min();
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
            C = A.Concat(B).ToArray();
            Array.Sort(C);
            Array.Reverse(C);
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int max = array.Max();
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
            int[] temp = array_last_k.Concat(array_other).ToArray();
            for (int i = 0; i < temp.Length; i++)
            {
                array[i] = temp[i];
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
            double average = raw.Average();
            bright = raw.Where(n => n > 2 * average).ToArray();
            dim = raw.Where(n => n < 0.5 * average).ToArray();
            double[] removed_anomalies = raw.Where(n => (n <= 2 * average) && (n >= 0.5 * average)).ToArray();

            double normal_average = removed_anomalies.Average();
            normal = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                if (removed_anomalies.Contains(raw[i]))
                {
                    normal[i] = raw[i];
                } else
                {
                    normal[i] = 0.5 * (raw[i] + normal_average);
                }
            }
            Array.Sort(normal);
            Array.Reverse(normal);

            // end

            return (bright, normal, dim);
        }
    }
}
