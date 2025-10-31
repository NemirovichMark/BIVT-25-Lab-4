namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double sum_of_elem = 0;
            int count_of_elem = 0;
            double max_elem = -1e9;
            int max_elem_index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum_of_elem += array[i];
                count_of_elem++;
                if (array[i] > max_elem)
                {
                    max_elem = array[i];
                    max_elem_index = i;
                }
            }
            double srednee = sum_of_elem / count_of_elem;
            for (int i = array.Length - 1; i > max_elem_index; i--)
            {
                array[i] = srednee;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int even_count = 0;
            int odd_count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even_count++;
                }
                else
                {
                    odd_count++;
                }
            }
            even = new int[even_count];
            odd = new int[odd_count];
            even_count = 0;
            odd_count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[even_count] = array[i];
                    even_count++;
                }
                else
                {
                    odd[odd_count] = array[i];
                    odd_count++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int sum_of_elem = 0;
            double count_of_elem = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                sum_of_elem += array[i];
            }
            double srednee = sum_of_elem / count_of_elem;
            double difference = 1e9;
            int index_of_elem = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - srednee) < difference)
                {
                    difference = Math.Abs(array[i] - srednee);
                    index_of_elem = i;
                }
            }
            answer = new int[array.Length + 1];
            for (int i = 0; i <= index_of_elem; i++)
            {
                    answer[i] = array[i];
            }
            answer[index_of_elem + 1] = P;
            for (int i = index_of_elem + 2; i < answer.Length; i++)
            {
                answer[i] = array[i-1];
            }

            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int negative = 0;
            int positive = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0 )
                {
                    positive++;
                }
                else
                {
                    negative++;
                }
            }
            int[] negative_arr = new int[negative];
            int[] positive_arr = new int[positive];
            negative = 0;
            positive = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    positive_arr[positive] = array[i];
                    positive++;
                }
                else
                {
                    negative_arr[negative] = array[i];
                    negative++;
                }
            }
            int array_index = 0;
            for (int i = 0; i < positive_arr.Length; i++)
            {
                array[array_index] = positive_arr[i];
                array_index++;
            }
            for (int i = 0; i < negative_arr.Length; i++)
            {
                array[array_index] = negative_arr[i];
                array_index++;
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            answer = new int[A.Length + B.Length];
            if (k > A.Length)
                return A;
            else
            {
                int ans = 0;
                for (int i = 0; i < k; i++)
                {
                    answer[ans] = A[i];
                    ans++;
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[ans] = B[i];
                    ans++;
                }
                for (int i = k; i < A.Length; i++)
                {
                    answer[ans] = A[i];
                    ans++;
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
                return (sum, dif);
            sum = new int[Math.Max(A.Length, B.Length)];
            dif = new int[Math.Max(A.Length, B.Length)];
            for (int i = 0; i < dif.Length; i++)
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

            // code here
            double sum_of_elem = 0;
            double arr_max = -1e9;
            double arr_min = 1e9;
            for (int i = 0; i < array.Length; i++)
            {
                arr_max = Math.Max(arr_max, array[i]);
                arr_min = Math.Min(arr_min, array[i]);
                sum_of_elem += array[i];
            }
            if (arr_min == arr_max)
            {
                return normalized;
            }
            normalized = new double[array.Length];
            for (int i = 0; i < normalized.Length; i++)
            {
                normalized[i] = 2.0 * (array[i] - arr_min) / (arr_max - arr_min) - 1.0;
            }
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            int index = 0;
            for (int i = 0; i < A.Length; i++)
            {
                C[index] = A[i];
                index++;
            }
            for (int i = 0; i < B.Length; i++)
            {
                C[index] = B[i];
                index++;
            }

            for (int i = 0; i < C.Length - 1; i++)
            {
                for (int j = 0; j < C.Length - i - 1; j++)
                {
                    if (C[j] < C[j+1])
                    {
                        (C[j], C[j + 1]) = (C[j + 1], C[j]);
                    }
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int shift = 0;
            double max_el = -1e9;
            for (int i = 0; i < array.Length; i++)
            {
                if (max_el < array[i])
                {
                    max_el = array[i];
                    shift = i;
                }
            }
            shift = shift % array.Length;
            for (int i = 0; i < shift; i++)
            {
                int temp = array[array.Length - 1];
                for (int j = array.Length - 1; j > 0; j--)
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
            if (N <= 0)
                return;
            N--;
            int[] mirror = new int[N];
            for (int i = 0; i < N && i < array.Length; i++)
            {
                mirror[i] = array[i];
            }
            int temp;
            for (int i = 0; i < mirror.Length / 2; i++)
            {
                temp = mirror[i];
                mirror[i] = mirror[mirror.Length - i - 1];
                mirror[mirror.Length - i - 1] = temp;

            }
            int change_index = N + 1;
            for (int i = 0; i < mirror.Length && change_index < array.Length; i++)
            {
                array[change_index] = mirror[i];
                change_index++;
                
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (n == 1)
            {
                Xext = Yext = new double[0];
                return (Xext, Yext);
            }
            if (a > b)
            {
                return (null, null);
            }
            if (a == b && n > 1)
            {
                return (null, null);
            }
            double step = (b - a) / (n - 1);
            X = new double[n];
            Y = new double[n];
            int i = 0;
            for (double x = a; x <= b; x += step)
            {
                X[i] = x;
                Y[i] = Math.Cos(x) + x * Math.Sin(x);
                i++;
            }
            int ext_count = 0;
            for (int j = 1; j < Y.Length - 1; j++)
            {
                if ((Y[j] > Y[j - 1] && Y[j] > Y[j + 1]) || (Y[j] < Y[j - 1] && Y[j] < Y[j + 1]))
                    ext_count++;
            }
            Xext = new double[ext_count];
            Yext = new double[ext_count];
            ext_count = 0;
            for (int j = 1; j < Y.Length - 1; j++)
            {

                if ((Y[j] > Y[j - 1] && Y[j] > Y[j + 1]) || (Y[j] < Y[j - 1] && Y[j] < Y[j + 1]))
                {
                    Xext[ext_count] = X[j];
                    Yext[ext_count] = Y[j];
                    ext_count++;
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            normal = new double[1];
            if (raw.Length == 1)
            {
                bright = new double[0];
                dim = new double[0];
                normal[0] = raw[0];
                return (bright, normal, dim);
            }
            double summa = 0;
            int n = raw.Length;
            for (int i = 0; i < n; i++)
            {
                summa += raw[i];
            }
            double srednee = summa / n;
            int bright_counter = 0;
            int dim_counter = 0;
            int normal_counter = 0;
            int not_deleted_counter = 0;
            for (int i = 0; i < n; i++)
            {
                if (raw[i] > 2*srednee)
                {
                    bright_counter++;
                }
                else if (raw[i] < srednee / 2)
                {
                    dim_counter++;
                }
                else
                {
                    normal_counter++;
                    not_deleted_counter++;
                }
            }
            normal = new double[raw.Length];
            bright = new double[bright_counter];
            dim = new double[dim_counter];
            double temp_summa = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if ((raw[i] <= 2 * srednee) && (raw[i] >= srednee / 2))
                {
                    temp_summa += raw[i];
                }
            }
            double srednee_new;
            if (not_deleted_counter == 0)
            {
                srednee_new = srednee;
            }
            else
            {
                srednee_new = temp_summa / not_deleted_counter;
            }
            bright_counter = 0;
            dim_counter = 0;
            normal_counter = 0;
            
            for (int i = 0; i < n; i++)
            {
                if (raw[i] > 2 * srednee)
                {
                    bright[bright_counter] = raw[i];
                    bright_counter++;
                    normal[normal_counter] = (raw[i] + srednee_new) / 2.0;
                    normal_counter++;
                }
                else if (raw[i] < srednee / 2)
                {
                    dim[dim_counter] = raw[i];
                    dim_counter++;
                    normal[normal_counter] = (raw[i] + srednee_new) / 2.0;
                    normal_counter++;
                }
                else
                {
                    normal[normal_counter] = raw[i];
                    normal_counter++;
                }
            }

            for (int i = 0; i < normal.Length - 1; i++)
            {
                for (int j = 0; j < normal.Length - i - 1; j++)
                {
                    if (normal[j] < normal[j + 1])
                        (normal[j], normal[j + 1]) = (normal[j + 1], normal[j]);
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
}