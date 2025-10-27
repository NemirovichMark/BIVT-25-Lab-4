using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int po = -1;
            int pm = -1;
            int k = 0;
            int m = -100000000;
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >m)
                {
                    m = array[i];
                    pm = i;
                }
                if (array[i] < 0 && k == 0)
                {
                    po = i;
                    k = 1;
                }
            }
            for (int i = pm+1; i < array.Length; i++)
            {
                s += array[i];
            }
            for (int i = 0; i < array.Length;i++)
            {
                if (i == po)
                    array[i] = s;
                Console.Write(array[i]+" ");
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int pp = -1;
            for (int i = 0; i < array.Length;i++)
            {
                if (array[i]>0)
                {
                    pp = i;
                }
            }
            if (pp == -1)
            {
                answer = new int[array.Length];
                answer = array;
            }
            else
            {
                answer = new int[array.Length+1];
                for (int i = 0; i < array.Length + 1; i++)
                {
                    if (i == pp + 1)
                    {
                        answer[i] = P;
                    }
                    if (i <= pp)
                    {
                        answer[i] = array[i];
                    }
                    if (i > pp + 1)
                    {
                        answer[i] = array[i - 1];
                    }
                }
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here

            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here

            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here

            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here

            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            // end

            return indexes;
        }
    }

}
