namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            for (int i = 0; i < vector.Length; i++)
            {
                length += vector[i] * vector[i];
            }
            length = Math.Sqrt(length);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > P && array[i] < Q)
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
            int maxind=0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxind = i;
                }
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((i > maxind))
                {
                    count++;
                }
            }

            if (count == 0) return;

            int[] twoarray = new int[count];
            int counttwo = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((i > maxind))
                {
                    twoarray[counttwo] = array[i];
                    counttwo++;
                }
            }

            if (twoarray.Length == 0) return;

            int k = 1;
            for (int i = 0; i < twoarray.Length - 1; i++)
            {
                if (twoarray[i] == twoarray[i+1])
                {
                    k += 1;
                }
            }
            if (k == twoarray.Length) return;

            int minEl = int.MaxValue;
            int minId = 0;

            for (int i = 0; i < twoarray.Length;  i++)
            {
                if (twoarray[i] < minEl)
                {
                    minEl = twoarray[i];
                    minId = i;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if ( i > maxind && array[i] == minEl)
                {
                    minId = i;
                    break;
                }
            }
            (array[maxind], array[minId]) = (array[minId], array[maxind]);
            
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int maxind = 0;
            int maxElem = int.MinValue;
            for (int i = 0; i < array.Length; i+=2)
            {
                if (array[i] > maxElem)
                {
                    maxind = i;
                    maxElem = array[i];
                }
            }
            array[maxind] = maxind;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here

            if (array == null || array.Length == 0)
                return -1;

            index = -1;
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
            if (array == null || array.Length < 2)
                return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            if (maxIndex <= 1)
                return;

            for (int i = 0; i < maxIndex - 1; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
            // end

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
            
            if (count == 0) return new int[0];

            answer = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[j++] = array[i];
                }
            }

            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            for (int i = 0; i <= array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j-1] < array[j])
                    {
                        (array[j - 1], array[j]) = (array[j], array[j - 1]);
                    }
                }
            }

            // end

        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length / 2; i++)
            {
                (array[i], array[array.Length - 1 - i]) = (array[array.Length - 1 - i], array[i]);
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here

            if (A == null || A.Length == 0)
            {
                if (B == null)
                    return new int[0];
                else
                    return B;
            }

            if (B == null || B.Length == 0)
            {
                return A; 
            }

            C = new int[A.Length + B.Length];
            int indexC = 0;

            int i = 0;
            while (i < A.Length && i < B.Length)
            {
                C[indexC++] = A[i];  
                C[indexC++] = B[i]; 
                i++;
            }

            while (i < A.Length)
            {
                C[indexC++] = A[i];
                i++;
            }

            while (i < B.Length)
            {
                C[indexC++] = B[i];
                i++;
            }

            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n < 1) return null;
            if (n == 1 && a == b)
            {
                array = new double[] { a };
                return array;
            }
            if (n == 1 && a != b) return null;
            if (n > 1 && a == b) return null;
            array = new double[n];
            if (a==b)
            {
                for (int i = 0; i < n; i++)
                {
                    array[i] = a;
                }
            }
            else if(a<b)
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * step;
                }
            }
            else
            {
                double step = (a - b) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a - i * step;
                }
            }

            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw.Length < 3) return null;
            int k = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] == -1)
                {
                    k += 1;
                }
            }
            if (k == raw.Length) return raw;

            restored = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                restored[i] = raw[i];
            }
            
            for (int i = 0; i < restored.Length; i++)
            {
                int leftind;
                if (i == 0)
                {
                    leftind = restored.Length - 1;
                }
                else leftind = i - 1;
                double left = restored[leftind];

                int rightind;
                if (i == restored.Length - 1)
                {
                    rightind = 0;
                }
                else rightind = i + 1;
                double right = restored[rightind];

                if (restored[i] == -1)
                {
                    if (left != -1 && right != -1)
                    {
                        restored[i] = (left + right) / 2.0;
                    }
                    //else if (left != -1)
                    //{
                    //    restored[i] = left;  
                    //}
                    //else if (right != -1)
                    //{
                    //    restored[i] = right;
                    //}
                }
            }
            // end

            return restored;
        }
    }
}