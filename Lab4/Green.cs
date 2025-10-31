namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            double sa = 0;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sa += array[i];
                    k += 1;
                }
            }
            if (k > 0)
            {
                sa = sa / k;
            }
            else
            {
                sa = 0;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = sa;
                }
            }

        }
        public int Task2(int[] array)
        {
            int sum = 0;
            int f = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] >= 0) && (f == 0))
                {
                    sum += array[i] * array[i];
                }
                if (array[i] < 0)
                {
                    f = -1;
                }
            }
            if (f ==0)
            {
                sum = 0;
            }

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            int max = -100000;
            int min = 1000000;
            int f1 = 0;
            int f2 = 0;
            int i1 = 0;
            int i2 = 0;
            int p1 = 0;
            int p2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            int s = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == max && f1 == 0)
                {
                    f1++;
                    i1 = j;
                    //Console.WriteLine(i1);
                }
                else if (array[j] == min && f2 == 0)
                {
                    f2++;
                    i2 = j;
                    //Console.WriteLine(i2);
                }
                if ((f1 + f2 == 1) && (array[j] < 0) && i2 != j && i1 != j)
                {
                    s++;
                    Console.WriteLine(array[j]);
                }
            }

            negatives = new int[s];
            int t = 0;
            if (i1 > i2)
            {
                for (int k = i2 + 1; k < i1; k++)
                {
                    if (array[k] < 0)
                    {
                        negatives[t] = array[k];
                        //Console.WriteLine(array[k]);
                        t++;
                    }
                }
            }
            if (i2 > i1)
            {
                for (int a = i1 + 1; a < i2; a++)
                {
                    if (array[a] < 0)
                    {
                        negatives[t] = array[a];
                        t++;
                        //Console.WriteLine(array[a]);
                    }
                }
            }
            return negatives;
            //Console.WriteLine(string.Join(" ", negatives));
        }
        public void Task4(int[] array)
        {

            int max = -1000000;
            int m = 0;
            int min = 0;
            int n  = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ( array[i] > max)
                {
                    max = array[i];
                    m = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<0)
                {
                    min = array[i];
                    n = i;
                    break;
                }
            }
            if (min != 0)
            {
                array[m] = min;
                array[n] = max;
            }

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;
            int max = -100000;
            int k = 0;
            for( int i  = 0; i < array.Length;i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }
            }
            for( int i  = 0; i < array.Length;i++)
            {
                if (array[i] == max)
                {
                    k++;
                }
            }
            answer = new int[k];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ( array[i] == max)
                {
                    answer[j] = i; 
                    j++;
                }
            }

                return answer;
        }
        public void Task6(int[] array)
        {
            int max = -100000;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            int k = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if (max == array[j])
                {
                    array[j] = max + +k;
                    k++;
                }
            }
        }
        public void Task7(int[] array)
        {
            int max = -100000;
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            for (int j = 0; j < array.Length; j++)
            {
                s += array[j];
                if (array[j] == max)
                {
                    array[j] = s - max;

                }

            }


        }
        public int Task8(int[] array)
        {
            int length = 0;
            int l = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    l++;

                }
                if (l+1 > length)
                {
                    length = l + 1;
                }
                if (array[i + 1] >= array[i])
                {
                    l = 0;
                }
            }
            if (length == 0)
            {
                length = 1;
            }
            return length;
        }
        public void Task9(int[] array)
        {
            double l = array.Length;
            int r = (int)Math.Ceiling(l / 2);
            int[] q = new int[r];
            q = new int[r];
            int c = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                q[c] = array[i];
                c++;
            }
            Console.WriteLine(string.Join(" ", q));
            for (int j = 0; j < q.Length; j++)
            {
                int qmax = q[j];
                int jmax = j;
                for (int k = j + 1; k < q.Length; k++)
                {
                    if (q[k] > qmax)
                    {
                        qmax = q[k];
                        jmax = k;
                    }

                }
                (q[j], q[jmax]) = (q[jmax], q[j]);
            }
            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = q[r - 1];
                r--;
            }
        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;
            int s = 0;
            int c = 0;
            for (int i = 0;i< array.Length;i++)
            {
                for (int j = 0;j < array.Length; j++)
                {
                    if (array[i]== array[j] && j!=i && array[i] != -10000000)
                    {
                        s++;
                        array[j] = -10000000;
                    }
                }
            }
            cleared = new int[array.Length-s];
            for (int k=0; k< array.Length;k++)
            {
                if (array[k]!= -10000000)
                {
                    cleared[c]=array[k];
                    c++;
                }
            }
            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            double r = (b-a)/(n-1);
            A = new double[n];
            double c = 0;
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                A[i] = a + r * i;
                if (A[i] > 0)
                {
                    s += A[i];
                    c++;
                }

            }
            s = s / c;
            int f = 0;
            for (int j = 0; j < n; j++)
            {
                if (A[j] > s)
                {
                    f++;
                }
            }
            int e = 0;
            B = new double[f];
            int g = 0;
            for(int i = 0;i<n;i++)
            {
                if (A[i]>s)
                {
                    B[g] = A[i];
                    g++;
                }
            }
            if ((n <= 1) || (a==b))
            {
                return null;
            }
            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            int[] s = new int[dices.Length];
            for (int i = 0; i <= 4 & i < dices.Length; i++)
            {
                s[i] = 6 - i;
            }
            for (int i = 5; i < dices.Length; i++)
            {
                s[i] = 1;
            }
            int k = 6;
            for (int i = 0; i < dices.Length - 1; i++)
            {
                if (dices[i] == k)
                {
                    for (int j = i + 1; j < dices.Length; j++)
                    {
                        dices[j] = dices[j] - 1;
                    }
                    k--;
                }
            }
            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[i] > s[i])
                    wins++;
            }
            return wins;

        }
    }
}
