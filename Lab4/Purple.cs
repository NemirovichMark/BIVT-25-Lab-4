namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            
            // code here
            int max_index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max_index]) max_index = i;
            }
            Console.WriteLine(max_index);

            double sr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sr += array[i];
            }
            sr /= array.Length;
            Console.WriteLine(sr);
            
            for (int i = max_index + 1; i < array.Length; i++) array[i] = sr;
            Console.WriteLine(String.Join(" ", array));
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            even = new int[array.Length / 2 + array.Length % 2];
            odd = new int[array.Length / 2];
            for (int i = 0, j = 0; i < array.Length; i += 2, j++) even[j] = array[i];
            for (int i = 1, j = 0; i < array.Length; i += 2, j++) odd[j] = array[i];
            Console.WriteLine(String.Join(' ', even));
            Console.WriteLine(String.Join(' ', odd));
            // end
            
            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            double sr = 0;
            foreach(int i in array) sr += i;
            sr /= array.Length;

            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - sr) < Math.Abs(array[index] - sr)) index = i;
            }

            answer = new int[array.Length + 1];
            for (int i = 0; i < index + 1; i++) answer[i] = array[i];
            answer[index + 1] = P;
            for (int i = index + 1; i < array.Length; i++) answer[i + 1] = array[i];
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int[] new_array = new int[array.Length];
            int j = 0;
            foreach (int i in array)
                if (i >= 0)
                {
                    new_array[j] = i; 
                    j++;
                }
            foreach (int i in array)
                if (i < 0)
                {
                    new_array[j] = i; 
                    j++;
                }

            j = 0;
            foreach (int i in new_array)
            {
                array[j] = i;
                j++;
            }
                
            Console.WriteLine(String.Join(" ", array));
            // end
        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k > A.Length) answer = A;
            else
            {
                answer = new int[A.Length + B.Length];

                for (int i = 0; i < k; i++) answer[i] = A[i];

                for (int i = 0; i < B.Length; i++) answer[i + k] = B[i];
   
                for (int i = k; i < A.Length; i++) answer[i + B.Length] = A[i];
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
                sum = new int[A.Length];
                dif = new int[A.Length];
                for (int i = 0; i < B.Length; i++) 
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
            int Max = array[0];
            int Min = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1]) flag = false;
                if (array[i + 1] < Min) Min = array[i + 1];
                if (array[i + 1] > Max) Max = array[i + 1];
            }

            if (flag) return null;
            else
            {
                normalized = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = 2*((double)(array[i] - Min) / (Max - Min) - 0.5);
                }
            }
            
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            C = new int[A.Length + B.Length];

            // code here

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
                int max = C[i];
                int i_max = i;
                for (int j = i+1; j < C.Length; j++)
                {
                    if (C[j] > max)
                    {
                        max = C[j];
                        i_max = j;
                    }
                }

                (C[i], C[i_max]) = (max, C[i]);
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int i_max = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > array[i_max]) i_max = i;
            
            for (int i = (array.Length-1)*i_max; i > 0; i--)
            {
                (array[i%array.Length], array[(i + 1)%array.Length]) = (array[(i + 1)%array.Length], array[i%array.Length]);
            }
            // end
            
        }
        public void Task10(int[] array, int N)
        {

            // code here
            for (int i = 0; i < N - 1; i++)
            {
                if (N * 2 - 1 - (i+1) < array.Length)
                    array[N * 2 - 1 - (i+1)] = array[i];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (a == b && n == 1)
            {
                Xext = new double[0];
                Yext = new double[0];
            }
            else if (a < b && n > 2)
            {
                X = new double [n];
                Y = new double [n];

                for (int i = 0; i < n; i++)
                {
                    X[i] = a + (b - a) / (n - 1) * i;
                    Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
                }

                double ex = Y[0];
                int cnt = 0;
                for (int i = 1; i < n - 1; i++)
                    if (Math.Abs(Y[i - 1]) < Math.Abs(Y[i]) & Math.Abs(Y[i + 1]) < Math.Abs(Y[i]))
                        cnt++;
                Xext = new double[cnt];
                Yext = new double[cnt];

                int j = 0;
                for (int i = 1; i < n - 1; i++)
                    if (Math.Abs(Y[i - 1]) < Math.Abs(Y[i]) & Math.Abs(Y[i + 1]) < Math.Abs(Y[i]))
                    {
                        Xext[j] = X[i];
                        Yext[j] = Y[i];
                        j++;
                    }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double sr = 0;
            foreach (double el in raw) sr += el / raw.Length;

            int cnt_bright = 0, cnt_dim = 0, cnt_normal = 0;
            foreach (double el in raw)
            {
                if (el > sr * 2) cnt_bright++;
                else if (el < sr / 2) cnt_dim++;
                else cnt_normal++;
            }
            
            bright = new double[cnt_bright];
            dim = new double[cnt_dim];
            normal = new double[cnt_normal];
            double sr_normal = 0;
            int i_bright = 0, i_dim = 0;
            foreach (double el in raw)
            {
                if (el > sr * 2)
                {
                    bright[i_bright] = el;
                    i_bright++;
                }
                else if (el < sr / 2) {
                    dim[i_dim] = el;
                    i_dim++;
                }
                else sr_normal += el/cnt_normal;
            }
            
            for (int i = 0; i < raw.Length; i++)
                if (raw[i] > sr * 2 | raw[i] < sr / 2) raw[i] = (sr_normal + raw[i]) / 2;


            int Max_i;
            for (int i = 0; i < raw.Length; i++)
            {
                Max_i = i;
                for (int j = i + 1; j < raw.Length; j++)
                {
                    if (raw[j] > raw[Max_i]) Max_i = j;
                }
                (raw[i], raw[Max_i]) = (raw[Max_i], raw[i]);
            }

            normal = raw;
            // end

            return (bright, normal, dim);
        }
    }
}