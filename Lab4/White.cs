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
            int amin = Math.Min(Q, P);
            int amax = Math.Max(Q, P);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > amin && array[i] < amax)
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
            if (array != null && array.Length > 1)
            {
                int imax = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[imax])
                        imax = i;
                }

                if (imax < array.Length - 1)
                {
                    imax = imax + 1;
                    for (int i = imax + 2; i < array.Length; i++)
                    {
                        if (array[i] < array[imax])
                            imax = i;
                    }

                    if (array[imax] != array[imax])
                    {
                        int temp = array[imax];
                        array[imax] = array[imax];
                        array[imax] = temp;
                    }
                }
            }
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array != null && array.Length > 0)
            {
                int imax = 0;
                for (int i = 2; i < array.Length; i += 2)
                {
                if (array[i] > array[imax])
                {
                    imax = i;
                }  
            
                    array[imax] = imax;
                }
            }
        }
            // end

        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == P)
                    {
                        index = i;
                        break;
                    }
                }
            }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array != null && array.Length > 1)
            {
                 int imax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[imax])
                {
                    imax = i;
                }
                if (imax > 0)
                    {
                    for (int i = 0; i < imax - 1; i += 2)
                        {
                            int temp = array[i];
                            array[i] = array[i +1];
                            array[i + 1] = temp;
                        }
                    }
            }
            }
            // end
        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            if (array != null)
            {
                int count = 0;
                for (int i = 0; i < array.length; i++)
                {
                    if (array[i] >= 0)
                    {
                        count++;
                    }
                }
                int[] A = new int[count];
                int index = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0)
                    {
                        A[index++] = array[i];
                    }
                }
                
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length - 1;i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }

                }

            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            int n = array.Length;
            int[] reversed = new int[n];
            for (int i = 0; i < n; i++)
            {
                reversed[i] = array[n - 1 - i];
            }
            return;
          
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = A.Length + B.Length;
            int i = 0, j = 0, k =0;
            while (i < A.Length && j < B.Length)
            {
                if (A[i] <= B[i])
               
                {
                    C[k++] = A[i++];
                } 
                else
                {
                    C[k++] = B[j++];
                }
            }
            while (i < A.Length)
            {
                C[k++] = A[i++];
            }
            while (j < B.Length)
            {
                C[k++] = B[j++];
            }

            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (a == b && n == 1)
            {
                return new double[] {a};
            }
            else if (n > 1 && a != b)
            {
                array = new double[n];
                double jamp = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * jamp;
                }
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw != null && raw.Length >= 3)
            {
                restored = new double[raw.Length];
                Array.Copy(raw, restored, raw.Length);
                if (restored[0] == -1 && restored[1] != -1 && restored[raw.Length - 1] != -1)
                {
                    restored[0] = (restored[1] + restored[raw.Length - 1]) / 2;
                }
                if (restored[raw.Length - 1] == -1 && restored[0] != -1 && restored[raw.Length - 2] != -1)
                {
                    restored[raw.Length - 1] = (restored[0] + restored[raw.Length - 2]) / 2;
                }
                for (int i = 1; i < raw.Length - 1; i++)
                {
                    double prev = restored[(i - 1)];
                    double next = restored[(i + 1)];
                    if (restored[i] == -1 && prev != -1 && next != -1)
                    {

                        restored[i] = (prev + next) / 2;

                    }
                }
            }
            // end

            return restored;
        }
    }
}