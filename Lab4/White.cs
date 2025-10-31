namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            double sum = 0;
            for (int i = 0; i < vector.Length; i = i + 1)
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
            if (array == null) return 0;

            int min = Math.Min(P, Q);
            int max = Math.Max(P, Q);
            
            foreach (int num in array)
            {
                if (num > min && num < max)
                    count=count+1;
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            int maxIndex = 0;
            int max_b = -999;
            int min_b = 999;
            int max_index = 0;
            int min_index = 0;

            for (int i = 0; i != array.Length; i++)
            {
                if (array[i] > max_b)
                {
                    max_b = array[i];
                    max_index = i;
                }
            }

            for (int i = max_index; i != array.Length; i++)
            {
                if (array[i] < min_b)
                {
                    min_b = array[i];
                    min_index = i;
                }
            }

            array[min_index] = max_b;
            array[max_index] = min_b;

            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int maxindex = 0;
            for(int i = 2; i < array.Length; i += 2)
            {
                if (array[i] > array[maxindex])
                    maxindex = i;
            }
            array[maxindex] = maxindex;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                    return i;
            }
            return -1;
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }

            
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
            if (array == null) return new int[0];

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                    count++;
            }

            answer = new int[count];
            int idx = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[idx] = array[i];
                    idx++;
                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length - 1; i++)
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
            for (int i = 0; i < array.Length / 2; i++) //проходим до средины массива
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            int[] result = new int[A.Length + B.Length];
            int i = 0;
            int j = 0;

            while (j < A.Length && j < B.Length)
            {
                result[i] = A[j];
                i++;
                result[i] = B[j];
                i++;
                j++;
            }
            while (j < A.Length)
            {
                result[i] = A[j];
                i++;
                j++;
            }
            while (j < B.Length)
            {
                result[i] = B[j];
                i++;
                j++;
            }
            C = result;
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n != 0 && n != 1)
            {
                if (a < b)
                {
                    double[] anw = new double[n];
                    double X = (b - a) / (n - 1);

                    anw[0] = a;
                    anw[n - 1] = b;

                    if (n > 2)
                    {
                        for (int i = 1; i < n - 1; i++)
                        {
                            anw[i] = anw[i - 1] + X;
                        }
                    }

                    array = anw;
                }

                else if (a > b)
                {
                    double[] anw = new double[n];
                    double X = -1 * ((b - a) / (n - 1));

                    anw[0] = a;
                    anw[n - 1] = b;

                    if (n > 2)
                    {
                        for (int i = 1; i < n - 1; i++)
                        {
                            anw[i] = anw[i - 1] - X;
                        }
                    }

                    array = anw;
                }
            }

            else if (a == b && n == 1)
            {
                double[] anw = new double[n];
                anw[0] = a;
                array = anw;
            }
            else
            {
                return null;
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw.Length >= 3)
            {
                double[] answ = new double[raw.Length];
                for (int i = 0; i < raw.Length; i++)
                {
                    answ[i] = -1;
                }

                if (raw[0] == -1)
                {
                    answ[0] = (raw[1] + raw[^1]) / 2;
                }
                if (raw[^1] == -1)
                {
                    answ[^1] = (raw[0] + raw[^2]) / 2;
                }
                if (raw[0] != -1)
                {
                    answ[0] = raw[0];
                }
                if (raw[^1] != -1)
                {
                    answ[^1] = raw[^1];
                }

                for (int i = 1; i < raw.Length - 1; i++)
                {
                    if (raw[i] == -1 && raw[i - 1] != -1 && raw[i + 1] != -1)
                    {
                        answ[i] = (raw[i - 1] + raw[i + 1]) / 2;
                    }
                    else
                    {
                        answ[i] = raw[i];
                    }
                }
                restored = answ;
            }
            // end

            return restored;
        }
    }
}
