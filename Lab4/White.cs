namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            double n = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                n += Math.Pow(vector[i], 2);
            }
            length = Math.Sqrt(n);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            int min = Math.Min(Q, P);
            int max = Math.Max(Q, P);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < max && array[i] > min)
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
            int maxa = int.MinValue;
            int index = 0;
            int mina = int.MaxValue;
            int indexmin = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxa)
                {
                    maxa = array[i];
                    index = i;
                }

            }

            for (int i = index; i < array.Length; i++)
            {
                if (array[i] < mina)
                {
                    mina = array[i];
                    indexmin = i;
                }
            }

            int temp = 0;
            temp = array[index];
            array[index] = mina;
            array[indexmin] = temp;
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int maxa = int.MinValue;
            int index = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > maxa)
                {
                    maxa = array[i];
                    index = i;
                }
            }

            array[index] = index;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
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
            int maxa = int.MinValue;
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxa)
                {
                    maxa = array[i];
                    index = i;
                }
            }

            for (int i = 0; i + 1 < index; i += 2)
            {
                int temp = 0;
                temp = array[i + 1];
                array[i + 1] = array[i];
                array[i] = temp;
            }

            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    c++;
                }
            }

            int[] result = new int[c];

            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    result[j] = array[i];
                    j++;
                }
            }

            answer = result;
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
            for(int i = 0; i < array.Length / 2; i++) //проходим до средины массива
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

            while(j< A.Length && j < B.Length)
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
