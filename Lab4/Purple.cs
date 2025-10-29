namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here

            double max = -999999;
            int max_index = 0;
            double sm = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sm += array[i];
                
                if (array[i] > max)
                {
                    max = array[i];
                    max_index = i;
                }
            }

            double avarge = sm / (double)array.Length;

            if (max_index == array.Length -1)
            {
                return;
            }

            for (int i = max_index + 1; i < array.Length; i++) 
            {
                array[i] = avarge;
            }

            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;
            
            // code here
            // 0 1 2 - 3/2=1
            int n = array.Length;
            if (n%2 == 0)
            {
                even = new int[n / 2];
                odd = new int[n / 2];
            }
            else
            {
                even = new int[n / 2 + 1];
                odd = new int[n / 2];
            }

            int c_e = 0;
            int c_o = 0;
            for(int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    even[c_e++] = array[i];
                }
                else
                {
                    odd[c_o++] = array[i];
                }
            }
                // end

                return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int sm = 0;
            foreach (int i in array) 
            {
                sm += i;
            }
            double avarge = (double)sm/(double)array.Length;

            double dif = 999999999;
            int cl_index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]-avarge) < dif)
                {
                    dif = Math.Abs(array[i] - avarge);
                    cl_index = i;
                }
            }

            answer = new int[array.Length + 1];
            int j = 0;

            for (int i = 0; i<array.Length; i++ )
            {

                if (i != cl_index) 
                {
                    answer[j++] = array[i];
                }
                else
                {
                    answer[j++] = array[i];
                    answer[j++] = P;
                }

            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int c_p = 0;
            int c_n = 0;
            foreach(int i in array)
            {
                if (i >= 0)
                {
                    c_p++;
                }
                else
                {
                    c_n++;
                }
            }
            if(c_n == 0 || c_n == array.Length) { return;  }


            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < 0 && array[j + 1] >= 0)
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }

            }

            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            
            answer = new int[A.Length + B.Length];
            if (k > A.Length) { return A; }
            if (k == A.Length)
            {

                int c = 0;
                foreach (int i in A) 
                {
                    answer[c++] = i;  
                }
                foreach (int i in B)
                {
                    answer[c++] = i;
                }

            }
            else
            {
           

                for (int i = 0;i < k; i++) 
                {
                    answer[i] = A[i];
                }
                int c = k;
                foreach(int i in B)
                {
                    answer[c++] = i;
                }

                for (int i = k; i < A.Length; i++)
                {
                    answer[c++] = A[i];
                }

            }
                // end

                Console.WriteLine(String.Join(", ",answer));
                return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length != B.Length) { return (sum, dif); }
            sum = new int[A.Length];
            dif = new int[A.Length];
            for (int i = 0; i < A.Length; i++) 
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
            int max = -9999999;
            int min = 99999999;

            foreach (int i in array) 
            {
                if (i > max) { max = i; }
                if(i < min) { min = i; }
            }
            if (max == min) { return normalized; }

            int c = 0;
            normalized = new double[array.Length];
            foreach (int i in array)
            {
                normalized[c++] = -1 + 2*(double)(i-min)/(max-min);
            }

            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            int na = A.Length;
            int nb = B.Length;

            int i = 1;
            int j = 2;
            while (i < na)
            {
                if (i == 0 || A[i] <= A[i - 1]) { i=j;j++; }

                else { (A[i], A[i-1]) = (A[i-1], A[i]); i--; }  
            }
            i = 1;
            j = 2;
            while (i < nb)
            {
                if (i == 0 || B[i] <= B[i - 1]) { i = j; j++; }

                else { (B[i], B[i - 1]) = (B[i - 1], B[i]); i--; }
            }
            i = 0;
            j = 0;
            int k = 0;
            C = new int[A.Length + B.Length];
            while (i < na && j < nb)
            {
                if (A[i] >= B[j])
                {
                    C[k++] = A[i++];
                    
                }
                else
                {
                    C[k++] = B[j++];
                }
            }
            while (i < na)
            {
                C[k++] = A[i++];
            }
            while (j < nb)
            {
                C[k++] = B[j++];
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int max = -999999;
            int max_index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > max) { max = array[i]; max_index = i; }
            }
            int shift = max_index % array.Length;
            int n = array.Length;
            for(int i = 0; i < shift; i++)
            {
                int t = array[n-1];
                for(int j = n-1; j > 0; j--)
                {
                    array[j] = array[j-1];
                }
                array[0] = t;
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here

            if (N <= 1 || N >= array.Length || array.Length == 1) {  return; }
            int[] miror = new int[N-1];
  
            
            for (int i = 0;i < N - 1; i++)
            {
                miror[^(i+1)] = array[i];

            }

            if (array.Length - N <= miror.Length)
            {
                int j = 0;
                for (int i = N; i < array.Length; i++)
                {
                    array[i] = miror[j++];
                }
            }
            else
            {
                int j = N;
                foreach (int item in miror)
                {
                    array[j++] = item;
                }
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            X = new double[n]; Y = new double[n];
            double step = 0;


            if (n == 1) { X[0] = (b-a)/2; }
            else { step = (b - a) / (double)(n - 1); }

            if( (a == b && n!=1) || a>b ) { return (null, null); }
            if(step < 0) { return (null, null); }

            int c = 0;
            if (n != 1)
            {
                for (double x = a; x <=b; x += step)
                {
                    X[c] = x;
                    Y[c] = Math.Cos(x) + x * Math.Sin(x);
                    c++;
                }
            }
            Console.WriteLine(String.Join("; ", X));
            Console.WriteLine(String.Join("; ", Y));
            int count_ex = 0;
            for(int i = 1;i<n-1;i++)
            {
                if (Y[i-1]< Y[i] && Y[i] > Y[i + 1]) {  count_ex++; }
                if (Y[i - 1] > Y[i] && Y[i] < Y[i + 1]) { count_ex++; }
            }
            
            Xext = new double[count_ex]; Yext = new double[count_ex];
            c= 0;
            for (int i = 1; i < n - 1; i++)
            {
                if (Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) { Xext[c] = X[i]; Yext[c] = Y[i];c++; }
                if (Y[i - 1] > Y[i] && Y[i] < Y[i + 1]) { Xext[c] = X[i]; Yext[c] = Y[i]; c++; }
            }
            //Console.WriteLine(String.Join("; ", Xext));
            //Console.WriteLine(String.Join("; ", Yext));
            // end
            //Console.WriteLine($"{X.Length}, {Y.Length}");//, {Xext.Length}, {Yext.Length}");
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
                if(item > 2*avarge_raw) { c_br++; }
                if(item < avarge_raw*0.5) { c_dim++; }
            }
            bright = new double[c_br];
            dim = new double[c_dim];
            int j_br = 0, j_dim = 0;
            double sm_normal = 0;
            foreach (double item in raw)
            {
                if (item > 2 * avarge_raw) { bright[j_br++] = item; }
                else if (item < avarge_raw * 0.5) { dim[j_dim++]= item; }
                else { sm_normal += item; }
            }
            double avarge_norm = sm_normal/ (double)(raw.Length - c_dim - c_br);
            normal = new double[raw.Length];
            for (int i = 0; i < normal.Length; i++)
            {
                if (raw[i] > 2 * avarge_raw) { normal[i] = (raw[i]+avarge_norm)/2; }
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