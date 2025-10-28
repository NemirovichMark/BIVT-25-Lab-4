using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int s = 0;
            int ind = 0;
            for (int i = 0; i < array.Length; i++) 
            { 
                if (array[i] > array[ind])
                {
                    ind = i;
                }
            }
            if (ind != array.Length - 1)
            {
                for (int i = ind + 1; i < array.Length; i++)
                {
                    s += array[i];
                }
            }
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = s;
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int ind = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    ind = i;
                }
            }
            if (ind != -1)
            {
                answer=new int[array.Length+1];
                for(int i = 0; i <= ind; i++)
                {
                    answer[i] = array[i];
                }
                answer[ind + 1] = P;
                for (int i = ind + 1;i < array.Length; i++)
                {
                    answer[i+1] = array[i];
                }
            }
            else
            {
                answer = new int[array.Length];
                for(int i=0; i<array.Length; i++)
                {
                    answer[i] = array[i];
                }
            }
                // end

                return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int min = int.MaxValue;
            int ind = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < min)
                {
                    min=array[i];
                    ind = i;
                }
            }
            if (ind !=-1)
            {
                answer=new int[array.Length-1];
                for (int i = 0;i < ind; i++)
                {
                    answer[i]=array[i];
                }
                for (int i = ind+1;i < array.Length; i++)
                {
                    answer[i - 1] = array[i];
                }
            }
            else
            {
                answer = new int[array.Length];
                for(int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }
            }
                // end

                return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double sr = 0;
            int cnt = 0;
            for(int i=0;i<array.Length; i++)
            {
                sr+= array[i];
                cnt++;
            }
            sr /= cnt;
            for (int i=0;i< array.Length; i++)
            {
                array[i] -= sr;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length != B.Length)
            {
                return 0;
            }
            for (int i=0; i < A.Length; i++)
            {
                sum += A[i] * B[i];
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double avg = 0;
            for(int i= 0; i < array.Length; i++)
            {
                avg += array[i];
            }
            avg/= array.Length;
            int cnt = 0;
            for (int i= 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                    cnt++;
            }
            indexes = new int[cnt];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                {
                    indexes[k] = i;
                    k++;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            count = 1;
            int l = 1;
            for (int i= 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1])
                {
                    l++;
                }
                else
                {
                    count = Math.Max(count, l);
                    l = 1;
                }
                count = Math.Max(count, l);
            }
            l = 1;
            for(int i=0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    l++;
                }
                else
                {
                    count = Math.Max(count, l);
                    l = 1;
                }
                count = Math.Max(count, l);
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length*2];
            int k = 0;
            for (int i= 0; i < array.Length; i++)
            {
                answer[k]=array[i];
                answer[++k] = array[i];
                k++;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int min=int.MaxValue;
            for (int i= 0; i < array.Length; i++)
            {
                if (array[i]<min)
                    min = array[i];
            }
            int max=int.MinValue;
            for (int i= 0; i < array.Length; i++)
            {
                if (array[i]>max)
                    max=array[i];
            }
            if(max==min)
                return null;
            else
            {
                normalized = new double[array.Length];
                for(int i= 0;i<array.Length; i++)
                {
                    normalized[i] = (double)(array[i]-min)/(max-min);
                }
            }
                // end

                return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            int l = 0;
            int r = array.Length - 1;
            for (int i= 0; i < array.Length - 1; i++)
            {
                for(int k=0;k<array.Length-1-i; k++)
                {
                    if (array[k] > array[k + 1])
                        (array[k], array[k + 1]) = (array[k + 1], array[k]);
                }
            }
            int cnt = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                    cnt++;
            }
            if (cnt != 0)
            {
                while (l <= r)
                {
                    int m = l + (r - l) / 2;
                    if (array[m] == P)
                    {
                        index = m;
                        break;
                    }
                    else if (array[m] < P)
                    {
                        l = m + 1;
                    }
                    else
                    {
                        r = m -1;
                    }
                }
            }
            else
            {
                index = -1;
            }
                // end

                return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <= 0) return null;
            if (c < a) return [];
            int l = ((c - a) / b) + 1;
            if (l <= 0)
                return null;
            array = new int[l];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = a + b * i;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if (magazine.Length <= 3)
            {
                indexes=new int[magazine.Length];
                for (int i = 0;i < indexes.Length; i++)
                {
                    indexes[i] = i;
                }
            }
            else
            {
                indexes = new int[3];
                int max = int.MinValue;
                for(int i = 1; i < magazine.Length-1; i++)
                {
                    int s = magazine[i - 1] + magazine[i] + magazine[i + 1];
                    if (s > max)
                    {
                        max = s;
                        indexes[0] = i - 1;
                        indexes[1]=i;
                        indexes[2] = i + 1;
                    }
                }
            }
                // end

                return indexes;
        }
    }
}