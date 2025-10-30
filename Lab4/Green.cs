namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

                        // code here

            double s = 0;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>0){ s += array[i]; k++;}
                    
            }
            s=s/k;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>0)
                    array[i]=s;
            }
            // end
            
        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here

            double o = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<0)
                    o=1;
            }
            if (o==0)
                return 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<0)
                    break;
                sum += array[i]*array[i];
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here

            int imax = 0, imin = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[imax]) 
                    imax = i;
                if (array[i] < array[imin]) 
                    imin = i;
            }
            int left = Math.Min(imax, imin);
            int right = Math.Max(imax, imin);

            int count = 0;
            for (int i = left + 1; i < right; i++)
                if (array[i] < 0) 
                    count++;

            if (count == 0) 
                return new int[0];

            negatives = new int[count];
            int index = 0;
            for (int i = left + 1; i < right; i++)
                if (array[i] < 0) 
                    negatives[index++] = array[i];
            // end

            return negatives;
       }
        public void Task4(int[] array)
        {

            // code here

            int j = int.MinValue;
            int g = int.MinValue;
            int jj = int.MinValue;
            int gg = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<0 && j==int.MinValue)
                {
                    j=array[i];
                    g=i;
                }
                if ((array[i]==array.Max()) && jj==int.MinValue)
                {
                    jj=array[i];
                    gg=i;
                }
            }
            if (j!=int.MinValue)
            {
                array[g] = jj;
                array[gg]=j;
            }
            
            // end

            }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here

            int max = array.Max();
            int b = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==max)
                    b++;
            }
            answer = new int[b];
            int g = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==max)
                {
                    answer[g] = i;
                    g++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here

            int max = array.Max();
            int b = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==max)
                {  
                    array[i]=max+b;
                    b++;
                }
            }
            
            // end

        }
        public void Task7(int[] array)
        {

            // code here

            int max = array.Max();
            int b = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==max)
                    b++;
            }
            int [] answer = new int[b];
            int g = 0;
            int t = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==max)
                {
                    answer[g] = t;
                    g++;
                }
                t+=array[i];
            }
            g=0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==max)
                {
                    array[i] = answer[g];
                    g++;
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here

            length+=1;
            int b = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i]>array[i+1])
                {
                    b++;
                    length=Math.Max(length, b);
                }
                else
                    b=1;
            }
                // end

                return length;
        }
        public void Task9(int[] array)
        {

            // code here

            int ch = (array.Length+1)/2;
            int[] a = new int[ch];
            int p = 0;
            for (int i = 0; i < array.Length; i += 2) a[p++] = array[i];

            for (int i = 0; i < ch - 1; i++)
                for (int j = i + 1; j < ch; j++)
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }

            p = 0;
            for (int i = 0; i < array.Length; i += 2) 
                array[i] = a[p++];

            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here

            if (array == null || array.Length == 0) 
                return null;

            int n = array.Length;
            int[] a = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                bool seen = false;
                for (int j = 0; j < count; j++)
                    if (a[j] == array[i]) 
                    {
                        seen = true;
                        break;
                    }
                if (!seen) 
                    a[count++] = array[i];
            }

            cleared = new int[count];
            for (int i = 0; i < count; i++) 
                cleared[i] = a[i];
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here

            A = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }
            double ss = 0;
            int n2 = 0;
            for (int i = 0;i<n;i++)
            {
                if (A[i]>=0)
                {   
                    ss+=A[i];
                    n2++;
                }
            }
            ss=ss/n2;
            n2=0;
            for (int i = 0; i<n; i++)
            {
                if (A[i]>ss)
                {
                    n2++;
                }
            }
            B= new double[n2];
            int g = 0;
            for (int i = 0; i<n; i++)
            {
                if (A[i]>ss)
                {
                    B[g++]=A[i];
                }
            }
            if ((n<=1)||(a==b))
            {
                return null;
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here

            int fine = 0;
            int a = 0;
            int b = 0;
            for (int i = 0;i<dices.Length;i++)
            {
                a=dices[i]-fine;
                b=6-i;
                if (a<1) a=1;
                if (b<1) b=1;
                if (a>b)
                    wins++;
                if (dices[i]==6)
                    fine++;
            }
            // end

            return wins;

        }
    }
}
