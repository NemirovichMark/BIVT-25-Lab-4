using System.ComponentModel;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double max = Double.NegativeInfinity;
            double average = 0;
            foreach(double x in  array)
            {
                average += x;
                max = Math.Max(max, x);
            }
            average /= array.Length;
            bool change= false;
            for(int j = 0; j<array.Length; j++)
            {
                if (change)
                {
                    array[j] = average;
                }
                if (array[j] == max)
                {
                    change = true;
                }
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            even = new int[(int)Math.Ceiling(array.Length/2.0)];
            odd = new int[(int)Math.Floor(array.Length / 2.0)];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[i / 2] = array[i];
                }
                else
                {
                    odd[(i - 1) / 2] = array[i];
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            double avg = 0;
            foreach (int x in array)
            {
                avg += x;
            }
            avg /= array.Length;
            double dist = Double.PositiveInfinity;
            int index = -1, sub=0;
            for (int i = 0; i<array.Length; i++)
            {
                if (Math.Abs(array[i] - avg) < dist)
                {
                    index = i;
                    dist = Math.Abs(array[i] - avg);
                }
            }
            answer = new int[array.Length+1];
            
            for (int i =0; i<array.Length+1;i++)
            {
                if (i==index+1)
                {
                    answer[i] = P;
                    sub = 1;
                }
                else
                {
                    answer[i] = array[i-sub];
                }
            }

            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            bool change=true;
            int temp = 0;
            while (change)
            {
                change = false;
                for (int i = 0;i<array.Length-1;i++)
                {
                    if (array[i]<0 && array[i+1]>=0)
                    {
                        temp = array[i];
                        array[i]= array[i+1];
                        array[i + 1] = temp;
                        change= true;
                    }
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
            }
            else
            {
                answer = new int[A.Length + B.Length];
            }
            int add = 0;
            for (int i=0; i<answer.Length; i++)
            {
                if (i<k)
                {
                    answer[i] = A[i];
                }
                if (i >= k && i < k + B.Length)
                {
                    answer[i] = B[add];
                    add++;
                }
                if (i>=k+B.Length)
                {
                    answer[i] = A[i-B.Length];
                }
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if(A.Length == B.Length)
            {
                sum = new int[A.Length];
                dif = new int[A.Length];
                for (int i = 0; i<A.Length; i++)
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
            int max=int.MinValue;
            int min=int.MaxValue;
            foreach (int i in array)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }
            if (min != max)
            {
                normalized = new double[array.Length];
                for (int i = 0; i < normalized.Length; i++)
                {
                    normalized[i] = (Double.Round((double)array[i] * 2 - (min + max)) / (max - min));
                    //Сбой Assert.AreEqual. Ожидается: <-0,4285714285714286>. Фактически: <-0,42857142857142855>. Test 2 faled (index 5)
                }
            }
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            int temp;
            bool change = true;
            while (change)
            {
                change = false;
                for (int i = 0; i < A.Length - 1; i++)
                {
                    if (A[i] < A[i + 1])
                    {
                        temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                        change = true;
                    }
                }
            }
            change = true;
            while (change)
            {
                change = false;
                for (int i = 0; i < B.Length - 1; i++)
                {
                    if (B[i] < B[i + 1])
                    {
                        temp = B[i];
                        B[i] = B[i + 1];
                        B[i + 1] = temp;
                        change = true;
                    }
                }
            }
            C = new int[A.Length + B.Length];
            for (int i = 0;i<C.Length;i++)
            {
                if (i<A.Length)
                {
                    C[i]= A[i];
                }
                else
                {
                    C[i] = B[i-A.Length];
                }
            }
            change = true;
            while (change)
            {
                change = false;
                for (int i = 0; i < C.Length - 1; i++)
                {
                    if (C[i] < C[i + 1])
                    {
                        temp = C[i];
                        C[i] = C[i + 1];
                        C[i + 1] = temp;
                        change = true;
                    }
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int max = int.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    index = i;
                    max = array[i];
                }
            }
            int[] sdvig = new int[array.Length];
            for (int i = 0; i < sdvig.Length; i++)
            {
                sdvig[i] = array[(array.Length + i - index) % array.Length];
            }
            for (int i = 0; i< array.Length; i++)
            {
                array[i] = sdvig[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            for (int i = 0; i<N; i++)
            {
                if (N*2 - i -2< array.Length)
                {
                    array[N*2-i-2]=array[i];
                }
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (a < b || a==b && n==1)
            {
                X = new double[n];
                Y = new double[n];
                int poz = 0;
                double x;
                for (int i = 0; i < n; i++)
                {
                    x = a + i * (b - a) / (n - 1);
                    X[i] = x;
                    Y[i] = Math.Cos(x) + x * Math.Sin(x);
                    poz++;
                }
                int len = 0;
                for (int i = 1; i < (n - 1); i++)
                {
                    if ((Y[i] - Y[i - 1]) * (Y[i] - Y[i + 1]) > 0)
                    {
                        len++;
                    }
                }
                Xext = new double[len];
                Yext = new double[len];
                poz = 0;
                for (int i = 1; i < (n - 1); i++)
                {
                    if ((Y[i] - Y[i - 1]) * (Y[i] - Y[i + 1]) > 0)
                    {
                        Xext[poz] = X[i];
                        Yext[poz] = Y[i];
                        poz++;
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
            double avg = 0;
            foreach (double x in raw) {avg += x;}
            avg /= raw.Length;
            int normall = raw.Length, brightl = 0, diml = 0;
            foreach (double y in raw)
            {
                if (y > avg * 2)
                {
                    brightl++;
                }
                else if (y < avg / 2)
                {
                    diml++;
                }
            }
            bright = new double[brightl];
            normal = new double[normall];
            dim = new double[diml];
            brightl = 0;
            normall = 0;
            diml = 0;
            foreach (double x in raw)
            {
                if (x > avg * 2)
                {
                    bright[brightl++] = x;
                }
                else if (x < avg / 2)
                {
                    dim[diml++] = x;
                }
                else
                {
                    normal[normall++] = x;
                }
            }
            double newavg = 0;
            if (normall > 0)
            {
                for (int i = 0; i < normall; i++)
                {
                    newavg += normal[i];
                }
                newavg /= normall;
            }
            for (int i = normall; i< raw.Length; i++)
            {
                if (i<normall + brightl)
                {
                    normal[i] = (bright[i - normall] + newavg) / 2;
                }
                else
                {
                    normal[i] = (dim[i-normall-brightl] + newavg) / 2;
                }
            }
            bool change = true;
            double temp;
            while (change)
            {
                change = false;
                for (int i = 0;i < raw.Length-1; i++)
                {
                    if (normal[i]<normal[i+1])
                    {
                        temp = normal[i];
                        normal[i] = normal[i+1];
                        normal[i+1] = temp;
                        change = true;
                    }
                }
            }


                    // end

                    return (bright, normal, dim);
        }
    }
}
