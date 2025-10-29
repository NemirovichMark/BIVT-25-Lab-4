namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                length += Math.Pow(vector[i],2);
            }
            length = Math.Sqrt(length);
            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > P && array[i] < Q) { count++; }
            }

            return count;
        }
        public void Task3(int[] array)
        {

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

        }
        public void Task4(int[] array)
        {
            int maxI = -999;
            int max_index = 0;
            for (int i = 0; i != array.Length; i++)
            {
                if (array[i] > maxI && i%2== 0)
                {
                    maxI = array[i];
                    max_index = i;
                }
            }
            array[max_index] = max_index;

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            for (int i =0; i < array.Length; i++)
            {
                if (array[i] == P) { index = i; break; }
                else { index = -1; }
            }
            
            return index;
        }
        public void Task6(int[] array)
        {

            int max = -9999;
            int max_index = 0;

            int x = 0;
            int y = 0;

            for (int i = 0; i != array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_index = i;
                }
            }

            for (int i = 0; i < max_index; i += 2)
            {
                if (i + 1 < max_index)
                {
                    x = array[i];
                    y = array[i + 1];

                    array[i] = y;
                    array[i + 1] = x;
                }
            }

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            int count = 0;

            for (int i = 0; i != array.Length; i++)
            {
                if (array[i] < 0) count++;
            }

            answer = new int[array.Length - count];
            count = 0;
            for (int i = 0; i != array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[count] = array[i];
                    count++;
                }
            }

            return answer;
        }
        public void Task8(int[] array)
        {

            int n = array.Length;
            for (int i = 0; i < n -1; i++)
            {
                for (int j = 0; j <n -1; j++)
                {
                    if (array[j] < array[j + 1]) { (array[j], array[j + 1]) = (array[j + 1], array[j]); }
                }
            }
            
        }
        public void Task9(int[] array)
        {
            int temp, n = array.Length;
            for(int i = 0; i < n/2; i++)
            {
                temp = array[i];
                array[i] = array[n - i - 1];
                array[n - i - 1] = temp;
            }

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            C = new int[A.Length + B.Length];

            int a = 0, b = 0;

            for (int i = 0; i != C.Length; i++)
            {
                if (a < A.Length && (i % 2 == 0 || b >= B.Length)) C[i] = A[a++];
                else if (b < B.Length) C[i] = B[b++];
            }

            return C;
            
        }
        public double[] Task11(double a, double b, int n)
        {
            

            if (n <= 0)
                return null;

            if (a == b)
            {
                if (n == 1)
                    return [a];
                else
                    return null;
            }

            if (n == 1 && a != b)
                return null;

            double[] answer = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
                answer[i] = a + step * i;

            return answer;
        }

        public double[] Task12(double[] raw)
        {
            if (raw.Length < 3) return null;

            bool flag = true;

            for (int i = 0; i != raw.Length; i++)
            {
                if (raw[i] != -1)
                {
                    flag = false;
                    break;
                }
            }

            if (flag == true) return raw;

            double[] restored = new double[raw.Length];
            for (int i = 0; i != restored.Length; i++) restored[i] = raw[i];

            for (int i = 0; i < raw.Length; i++)
            {
                if (restored[i] == -1)
                {
                    int left = (i - 1 + raw.Length) % raw.Length;
                    int right = (i + 1) % raw.Length;

                    if (restored[left] != -1 && restored[right] != -1) restored[i] = (restored[left] + restored[right]) / 2;
                }
            }

            return restored;
        }
    }
}
