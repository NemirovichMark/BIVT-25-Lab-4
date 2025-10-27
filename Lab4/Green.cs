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

            int n = -1;
            int k = 0;
            int l = 0;
            int fl = 0;
            int imin = 1000000;
            int imax = -100000;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<imin)
                    imin=i;
                if (array[i]>imax)
                    imax=i;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (n==-1)
                {
                    if (i==imin || i==imax)
                    {
                        fl=1;
                        n=i;
                    }

                }
                if (fl==1)
                {
                    if (i==imin || i==imax)
                    {
                        k = i;
                        fl=0;
                    }
                    if (array[i]<0)
                    l++;
                }
                
            }
            if (l==0)
                return [ ];
            negatives = new int[l];
            int b = 0;
            for (int i = n+1; i < k; i++)
            {
                if (array[i]<0)
                {
                    negatives[b] = array[i];
                    b++;
                }
            }
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

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = array[i*2];
            }
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                array[2*i] = a[i];
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here

            cleared = array.Distinct().ToArray();
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
