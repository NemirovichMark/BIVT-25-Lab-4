using System.Data;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            double sum = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sum += Math.Pow(vector[i], 2);
            }
            length = Math.Sqrt(sum);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > P &&  array[i] < Q)
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            int max = int.MinValue;
            int min = int.MaxValue;
            int maxi = 0;
            int mini = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxi = i;
                }
            }
            for (int i = maxi + 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    mini = i;
                }
            }
            array[maxi] = min;
            array[mini] = max;

            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int max = int.MinValue;
            int maxi = 0;
            for (int i = 0; i < array.Length; i+=2)
            {
                if (array[i] > max)
                {
                    maxi = i;
                    max = array[i];
                }
            }
            array[maxi] = maxi;
            

            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    return index;
                }
                else
                {
                    index = -1;
                }
            }

            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = int.MinValue;
            int maxi = -1;
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxi = i;
                }
            }
            for (int i = 0; i < maxi - 1; i+= 2)
            {
                temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    n++;
                }
            }
            answer = new int[n];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[k] = array[i];
                    k++;
                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            int max = int.MinValue; 
            int maxi = 0;
            for (int i = 0; i < array.Length; i++)
            {
                max = array[i];
                maxi = i;

                for (int j = maxi + 1; j < array.Length; j++)
                {
                    if (array[j] > max)
                    {
                        max = array[j];
                        maxi = j;
                    }
                }
                var temp = array[i];
                array[i] = array[maxi];
                array[maxi] = temp;
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            int temp, n = array.Length;
            for (int i = 0; i < n / 2; i++)
            {
                temp = array[i];
                array[i] = array[n - i - 1];
                array[n - i - 1] = temp;
            }
            Console.WriteLine(array);
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            int indC = 0;
            int i = 0;
            if (A == null || A.Length == 0)
            {
                if (B == null)
                {
                    return new int[0];
                }
                else
                {
                    return B;
                }
            }
            if (B == null || B.Length == 0)
            {
                return A;
            }
            C = new int[A.Length + B.Length];
            while (i < A.Length && i < B.Length)
            {
                C[indC++] = A[i];
                C[indC++] = B[i];
                i++;
            }
            while (i < A.Length)
            {
                C[indC++] = A[i];
                i++;
            }
            while (i < B.Length)
            {
                C[indC++] = B[i];
                i++;
            }

            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            array = new double[n];
            if (n < 1) 
            { 
                return null; 
            }
            if (n == 1 && a == b)
            {
                array = new double[] {a};
                return array;
            }
            if (n == 1 && a != b)
            {
                return null;
            }
            if (n > 1 && a == b)
            {
                return null;
            }
            if (a == b)
            {
                for (int i = 0; i < n; i++)
                {
                    array[i] = a;
                }
            }
            else if (a < b)
            {
                double s = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * s;
                }
            }
            else
            {
                double s = (a - b) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a - i * s;
                }
            }
                // end

                return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            int n = 0;
            double l = 0;
            double r = 0;
            int indL = 0;
            int indR = 0;
            restored = new double[raw.Length];
            if (raw.Length < 3)
            {
                return null;
            }
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] == -1)
                {
                    n++;
                }
            }
            if (n == raw.Length)
            {
                return raw;
            }
            for (int i = 0; i < raw.Length; i++)
            {
                restored[i] = raw[i];
            }
            for (int i = 0; i < restored.Length; i++)
            {
                if (i == 0)
                {
                    indL = restored.Length - 1;
                }
                else
                {
                    indL = i - 1;
                }
                l = restored[indL];
                if (i == restored.Length - 1)
                {
                    indR = 0;
                }
                else
                {
                    indR = i + 1;
                }
                r = restored[indR];
                if (restored[i] == -1)
                {
                    if (l != -1 && r != -1)
                    {
                        restored[i] = (l + r) / 2;
                    }
                }
            }
            // end

            return restored;
        }
    }
}
