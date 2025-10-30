using System.Numerics;
using System.Xml.Serialization;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double s = 0;
            int m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s += array[i];
                    m++;
                }
            }
            double cr = s / m;
            for (int j=0; j<array.Length; j++)
            {
                if (array [j]>0)
                {
                   array [j] = cr;
                }
            }
            
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int pos = 0;
            for (int i=0; i<array.Length;i++)
            {
                if (array[i]<0)
                {
                    pos = i;
                    break;
                }
            }
            for (int i=0;i<pos;i++)
            {
                sum += array[i] * array[i];
            }

            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int amax = array[0], a = 0, z = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > amax)
                {
                    amax = array[i];
                    a = i;
                }
            int amin=array[0], b = 0;
            for (int i=1; i<array.Length; i++)
                if (array[i] < amin)
                {
                    amin= array[i];
                    b = i;
                }
            int start=Math.Min(a,b);
            int end=Math.Max(a,b);

            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    z += 1;
                }
            }

            negatives = new int[z];
            int j = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[j] = array[i];
                    j++;
                }
            }

            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int amax = array[0], imax = 0, index = -1;
            for (int i=1; i<array.Length; i++)
            { 
                if (array[i]>amax)
                {
                    amax= array[i];
                    imax = i;
                }
            }
            for (int i=0; i<array.Length; i++)
            {
                if (array[i] < 0)
                {
                    index = i;
                    break;
                }       
            }
            if (index>=0)
            {
                (array[index], array[imax]) = (array[imax], array[index]);
            }
           
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = array[0];
            for (int i=1; i<array.Length; i++)
            {
                if (array[i]>max)
                {
                    max= array[i];
                }
            }
            int cnt = 0;
            for (int i=0;i<array.Length;i++)
            {
                if (array[i]==max)
                {
                    cnt++;
                }
            }
            int index = 0;
            answer = new int[cnt];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[index] = i;
                    index++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    
                }
            }
            int index = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += index;
                    index++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] == max)
                {
                    array[i] = sum - array[i];
                }

            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;
            // code here
            int cnt = 1, mxcnt = 1;
            for (int i=0;i<array.Length-1;i++)
            {
                if (array[i] > array[i + 1])
                {
                    cnt++;
                    if (cnt > mxcnt)
                    {
                        mxcnt = cnt;
                    }
                }
                else
                    cnt = 1;
            } 
            length = mxcnt;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i=0;i<array.Length-2;i+=2)
            {
                for (int j = 0; j < array.Length - 2; j += 2)
                {
                    if (array[j]> array[j+2])
                    {
                        (array[j], array[j + 2]) = (array[j + 2], array[j]);
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int[] arrayUnique = new int[array.Length];

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isDublicate = false;
                for (int j = 0; j < count; j++)
                {
                    if (array[i] == arrayUnique[j])
                    {
                        isDublicate = true;
                        break;
                    }
                }
                if (!isDublicate)
                {
                    arrayUnique[count] = array[i];
                    count++;
                }
            }

            cleared = new int[count];


            for (int i = 0; i < count; i++)
            {
                cleared[i] = arrayUnique[i];
            }
            // end

            return cleared;
 
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (a==b)
            {
                return null;
            }
            if (n<=1)
            {
                return null;
            }
            A =new double[n];

            double step=(b-a)/(n-1);
            for (int i=0; i<n;i++)
            {
                A[i] = a + step * i;
            }

            double sum = 0;
            int cnt = 0;
            for (int i=0; i<n;i++)
            {
                if (A[i]>0)
                {
                    cnt++;
                    sum += A[i];
                }
            }
            if (cnt==0)
            {
                return new double[0];
            }

            double avrg = sum / cnt;
            int k = 0;
            for (int i=0; i<n; i++)
            {
                if (A[i]>avrg)
                {
                    k++;
                }
            }
            B=new double[k];
            int index = 0;
            for (int i=0; i<n;i++)
            {
                if (A[i]>avrg)
                {
                    B[index] = A[i];
                    index++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int[] shuler = new int[dices.Length];
            for (int i = 0; i < dices.Length; i++)
            {
                shuler[i] = 6 - i;
                if (shuler[i] < 1)
                {
                    shuler[i] = 1;
                }
            }
            int countCursed = 0;
            int real = 0;
            int changed = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                real = dices[i];
                changed = real - countCursed;
                if (real == 6)
                {
                    countCursed++;
                }
                if (changed < 1)
                {
                    changed = 1;
                }
                if (changed > shuler[i])
                {
                    wins++;
                }
            }
            // end

            return wins;

        }
    }
}