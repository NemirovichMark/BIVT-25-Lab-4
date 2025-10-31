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
                length += Math.Pow(vector[i],2);
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
                    count += 1;
                }
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            int index = 0;
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            int minindex = 0;
            int min = int.MaxValue;
            for (int i = index + 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minindex = i;
                    Console.WriteLine(min);
                }
            }
            array[index] = min;
            array[minindex] = max;
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int index = 0;
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max && i % 2 == 0)
                {
                    max = array[i];
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
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    break;
                }
            }
            if (array[index] != P)
            {
                index = -1;
            }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int index = 0;
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            int a = 0;
            for (int i = 1; i < index; i += 2)
            {
                a = array[i];
                array[i] = array[i - 1];
                array[i - 1] = a;
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
                    count += 1;
                }
            }
            answer = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[index] = array[i];
                    index++;
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
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            int[] a = new int[array.Length];
            int j = a.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                a[i] = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = a[j];
                j -= 1;
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            int indexA = 0;
            int indexB = 0;
            for (int i = 0; i < C.Length; i++)
            {
                if (indexA < A.Length && indexB < B.Length)
                {
                    if (i % 2 == 0)
                    {
                        C[i] = A[indexA];
                        indexA++;
                    }
                    else
                    {
                        C[i] = B[indexB];
                        indexB++;
                    }
                }
                else if (indexA >= A.Length)
                {
                    C[i] = B[indexB];
                    indexB++;
                }
                else
                {
                    C[i] = A[indexA];
                    indexA++;
                }
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n == 1 && a == b)
            {
                array = new double[] { a };
            }
            else if (n <= 1 || a == b)
            {
                array = null;
            }
            else
            {
                array = new double[n];
                for (int i = 0; i < n; i++)
                {
                    double d = Math.Abs(b - a) / (n - 1);
                    if (a < b)
                    {
                        array[i] = a + i * d;
                    }
                    else
                    {
                        array[i] = a - i * d;
                    }
                }
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw.Length < 3)
            {
                restored = null;
            }
            else
            {
                restored = new double[raw.Length];

                bool minus1 = true;
                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] != -1) 
                    {
                        minus1 = false;
                        break;
                    }
                }

                if (minus1 == true) 
                {
                    for (int i = 0; i < raw.Length; i++)
                    {
                        restored[i] = raw[i];
                    }
                }
                else
                {
                    for (int i = 0; i < raw.Length; i++)
                    {
                        restored[i] = raw[i];
                    }
                    for (int i = 0; i < raw.Length; i++)
                    {
                        if (restored[i] == -1)
                        {
                            if (i == 0)
                            {
                                double left = restored[raw.Length - 1];
                                double right = restored[i + 1];
                                if (left != -1 && right != -1)
                                {
                                    restored[i] = (left + right) / 2;
                                }
                            }
                            else if (i == raw.Length - 1) 
                            {
                                double left = restored[i - 1];
                                double right = restored[0];
                                if (left != -1 && right != -1)
                                {
                                    restored[i] = (left + right) / 2;
                                }
                            }
                            else
                            {
                                double left = restored[i - 1];
                                double right = restored[i + 1];
                                if (left != -1 && right != -1)
                                {
                                    restored[i] = (left + right) / 2;
                                }
                            }
                        }
                    }
                }
            }
            // end

            return restored;
        }
    }
}
