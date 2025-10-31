using System.Threading.Tasks.Dataflow;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;
            double sum = 0;
            // code here
            for(int i = 0; i < vector.Length; i++)
            {
                sum += vector[i] * vector[i];
            }
            length = Math.Sqrt(sum);
            // end
            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            for(int i = 0; i < array.Length; i++)
            {
                int a = array[i];
                if(((a < P) && (a > Q)) || ((a < Q) && (a > P)))
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
            int iMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i]; 
                    iMax = i;
                }
            }
            int min = int.MaxValue;
            int iMin = 0;
            for (int i = iMax; i < array.Length; i++)
            {
                if(array[i] < min)
                {
                    min = array[i];
                    iMin = i;
                }
            }
            (array[iMax], array[iMin]) = (array[iMin], array[iMax]);
            Console.WriteLine(array);
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int max = int.MinValue;
            int iMax = 0;
            for(int i = 0; i < array.Length; i++)
            {
                 if (i % 2 == 0)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        iMax = i;
                    }
                }            
            }
            array[iMax] = iMax;
            Console.WriteLine(array);
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = -1;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    break;
                }
            }
           
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = int.MinValue;
            int iMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    iMax = i;
                }
            }
            for (int i = 0; i < iMax - 1; i += 2)
            {
                int a = array[i];
                array[i] = array[i + 1];
                array[i + 1] = a;
            }
            // end
            Console.WriteLine(array);
        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;
            // code here
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    count++;
                }
            }
            answer = new int[count];
            int NASHindex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[NASHindex] = array[i];
                    NASHindex++;
                }
            }
            // end
            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j - 1] < array[j])
                    {
                        (array[j - 1], array[j]) = (array[j], array[j - 1]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", array));
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            int temp = 0;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            Console.WriteLine(array);
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;
            // code here
            
            if ((A == null || A.Length == 0) && (B == null || B.Length == 0))
            {
                return new int[0];
            }
            if (A == null || A.Length == 0)
            {
                C = new int[B.Length];
                for (int i = 0; i < B.Length; i++)
                {
                    C[i] = B[i];
                }
                return C;
            }
            if (B == null || B.Length == 0)
            {
                C = new int[A.Length];
                for( int i = 0; i < A.Length; i++)
                {
                    C[i] = A[i];
                }
                return C;
            }
            int a = A.Length;
            int b = B.Length;
            int c = a + b;
            C = new int[c];
            int k = 0;
            for (int i = 0; i < c; i++)
            {
                if (i < a)
                {
                    C[k++] = A[i];
                }
                if (i < b)
                {
                    C[k++] = B[i];
                }
            }
            Console.WriteLine(string.Join(" ", C));
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;
            
            // code here
            if (n == 1 && a != b)
            {
                return null;
            }
            if (n == 0)
            {
                return null;
            }
            if (a == b)
            {
                if (n == 1)
                {
                    array = new double[] { a };
                    return array;
                }
                else
                {
                    return array;
                }
            }
            double k = (n - 1);
            array = new double[n];
            if (a < b)
            {
                int j = 0;
                for (double i = a; i <= b + 0.00000001; i += (b - a) / k)
                {
                    array[j] = Math.Round((double)i, 5);
                    j++;
                }
            }
            else if (a > b)
            {
                int j = 0;
                for (double i = a; i >= b - 0.0000001; i -= (a - b) / k)
                {
                    array[j] = (double)i;
                    j++;
                }
            }
            //array = new double[n];
            //if (a > b)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = a - ((a - b) * i / (n - 1)); 
            //    }
            //}
            //else if (a < b)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = a + ((b - a) * i / (n - 1)); 
            //    }
            //}
            //else
            //{
            //    array[0] = a;
            //}
            // end
            Console.WriteLine(string.Join(" ", array));
                return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if(raw.Length < 3)
            {
                return null;
            }
            restored = new double[raw.Length];
            for( int i = 0; i < restored.Length; i++)
            {
                restored[i] = raw[i];
            }
            bool neg = true;
            for(int i = 0; i < raw.Length; i++)
            {
                if (raw[i] != -1)
                {
                    neg = false;
                    break;
                }
            }
            if (neg)
            {
                return restored;
            }
           for (int i = 0; i < restored.Length; i++)
            {
                int previous = i - 1;
                if (previous < 0)
                {
                    previous = restored.Length - 1;
                }
                int next = i + 1;
                if (next >= restored.Length)
                {
                    next = 0;
                }
                if (raw[i] == -1)
                {
                    if ((restored[previous] != -1) && (restored[next] != -1))
                    {
                        restored[i] = (restored[previous] + restored[next]) / 2.0;
                    }
                    
                }
            }
            // end
            Console.WriteLine(string.Join(" ", restored));
            return restored;
        }
    }
}