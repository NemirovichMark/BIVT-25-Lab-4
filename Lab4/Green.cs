namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            double sm = 0;
            int c = 0;
            for (int i = 0; i < array.Length; i++)

                if (array[i] > 0)
                {
                    sm += array[i];
                    c++;
                }
            if (c == 0) return;
            double srf = sm / c;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0)
                    array[i] = srf;
           

            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int m = -1;
            if (array.Length==0 || array==null) return 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                { m = i; break; }
            }
            if (m == -1)
                return 0;
            for (int i=0;i<m;i++)
                sum += array[i] * array[i];


            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max = -1000000;
            int min = 100000;
            int n = 0;
            int m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                { max = array[i];}
                if (array[i] < min)
                { min = array[i];}
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                { m = i; break; }
            }
            for (int i = 0; i < array.Length; i++)
            { 
                if (array[i]==min)
                { n=i; break; }
            }

            int start, end;
            int c = 0;
            if (m < n)
            {
                start = m + 1;
                end = n-1;
            }
            else 
            {
                start = n + 1;
                end = m-1;
            }
            for (int i = start; i <=end; i++)
            {
                if (array[i] < 0)
                    c++;
            }
            negatives = new int[c];
            int k = 0;
            for (int i = start; i <=end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[k] = array[i];
                    k++;
                }
            }

                // end

                return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = -10000;
            for (int i = 0; i < array.Length; i++)
            { 
                if (array[i] > max)
                {  max = array[i]; }
            }
            int ind=0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==max)
                { ind = i; break; }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<0)
                { var p = array[i]; 
                  array[i] = array[ind]; 
                  array[ind] = p;
                  break;
                }
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = -1000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                { max = array[i]; }
             }
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                { n++; }
            }
            answer= new int[n];
            n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]== max)
                { answer[n] = i;
                    n++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = -1000;
            for (int i = 0; i<array.Length ; i++)
            {
                if (array[i] > max)
                { max = array[i]; }
            }
            int n = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                { array[i]+=n; n++; }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                { max = array[i]; }
            }
            int sum = 0;
            for (int i = 0; i < array.Length;i++)
            {
                if (array[i] == max)
                {
                    int p = array[i];
                    array[i] = sum;
                    sum += p;
                }
                else 
                {
                    sum += array[i];
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int n = 1;
            int[] b = new int[array.Length];
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    n++;
                    b[i] = n;
                }
                else
                    n=1;
            }
            int max = 1;
            for (int i = 0; i < b.Length; i++) 
            {
                if (b[i] > max)
                { max = b[i]; }
            }
            // end

            return max;
        }
        public void Task9(int[] array)
        {

            // code here
            int n = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                n++;
            }
            int[] b= new int[n];
            n = 0;
            for (int i = 0;i < array.Length;i++)
            {
                b[n]=array[i];
                n++;
                i++;
            }
            Array.Sort(b);
            n = 0;
            for (int i = 0; i < array.Length; i ++)
            {
                array[i] = b[n];
                n++;
                i++;
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int  n= 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool s = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        s = false;
                        break;
                    }
                }
                if (s)
                { n++; }
            }
            cleared = new int[n];
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool s = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        s = false;
                        break;
                    }
                }
                if (s)
                {
                    cleared[ind] = array[i];
                    ind++;
                }
            }
        
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (b == a)
                return null;
            if (n <= 1)
                return null;
            A = new double[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = a + i * (b - a) / (n - 1);
            }
            double s = 0;
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                { s += A[i];
                    k++; }
            }
            double sr = s / k;
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > sr && A[i]>0)
                {
                    c++;
                }
            }
            B= new double[c];
            int y = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > sr && A[i]>0)
                {
                    B[y]= A[i];
                    y++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int s = 6;
            int n = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                int r = Math.Max(1, dices[i] - n);
                if (r > s)
                { wins++; }
                if (dices[i] == 6)
                { n++; }
                s = Math.Max(1, s - 1);
            }
            // end

            return wins;

        }
    }
}
