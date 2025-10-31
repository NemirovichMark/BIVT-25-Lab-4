namespace Lab4
{
    public class White
    {
        public double Task1(int[] v)
        {
            double length = 0;
            double summ = 0;
            // code here
            for (int i = 0; i < v.Length; i++)
            {
                summ += Math.Pow(v[i], 2);
            }
            length = Math.Sqrt(summ);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int cnt = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] > P) && (array[i] < Q))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
            // end
            return cnt;
        }
        public void Task3(int[] array)
        {

            // code here
            int minn = 100000000;
            int mask = 0;
            int maxx = -100000000;
            int tmp = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                    tmp = i;
                }
            }

            for (int i = tmp; i < array.Length; i++)
            {
                if (array[i] < minn)
                {
                    minn = array[i];
                    mask = i;
                }
            }
            (array[tmp], array[mask]) = (array[mask], array[tmp]);
            // end
            
        }
        public void Task4(int[] array)
        {

            // code here
            int maxx = -100000000;
            int tmp = -1;
            for (int i = 0; i < array.Length; i+=2)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                    tmp = i;
                }
            }
            array[tmp] = tmp;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int tmp = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    tmp = i;
                    break;
                }
                else
                {
                    tmp = -1;
                }
            }
            // end

            return tmp;
        }
        public void Task6(int[] array)
        {

            // code here
            int maxx = -100000000;
            int tmp = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                    tmp = i;
                }
            }

            for (int i = 1; i < tmp; i+=2)
            {
                (array[i-1], array[i]) = (array[i], array[i-1]);
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null)
            {
                return answer;
            }
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    cnt++;
                }
            }
            answer = new int[cnt];
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
            if (array == null || array.Length < 2)
            {
                return;
            }
            for (int i = 1; i < array.Length; i++)
            {
                int cur = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] < cur)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = cur;
            }
            // end
        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length < 2)
            {
                return;
            }
            int last = array.Length - 1;
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[last - i]; 
                array[last - i] = temp;
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A == null && B == null)
            {
                return C;
            }
            if (A == null || A.Length == 0)
            {
                if (B == null)
                {
                    return C;
                }
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
                for (int i = 0; i < A.Length; i++)
                {
                    C[i] = A[i];
                }
                return C;
            }
            C = new int[A.Length + B.Length];
            int index = 0;
            int indexA = 0;
            int indexB = 0;
            while (indexA < A.Length || indexB < B.Length)
            {
                if (indexA < A.Length)
                {
                    C[index] = A[indexA];
                    index++;
                    indexA++;
                }
                if (indexB < B.Length)
                {
                    C[index] = B[indexB];
                    index++;
                    indexB++;
                }
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n <= 0)
            {
                return array;
            }
            if (a == b)
            {
                if (n == 1)
                {
                    array = new double[1];
                    array[0] = a;
                }

                return array;
            }
            if (n == 1)
            {
                return array;
            }
            array = new double[n];
            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                array[i] = a + step * i;
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw == null)
            {
                return restored;
            }
            if (raw.Length < 3)
            {
                return restored;
            }
            bool allDamaged = true;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] != -1)
                {
                    allDamaged = false;
                    break;
                }
            }
            restored = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                restored[i] = raw[i];
            }
            if (allDamaged)
            {
                return restored;
            }
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] == -1)
                {
                    int leftIndex = (i - 1 + raw.Length) % raw.Length;
                    int rightIndex = (i + 1) % raw.Length;
                    double leftValue = raw[leftIndex];
                    double rightValue = raw[rightIndex];
                    if (leftValue != -1 && rightValue != -1)
                    {
                        restored[i] = (leftValue + rightValue) / 2.0;
                    }
                }
            }
            // end

            return restored;
        }
    }
}