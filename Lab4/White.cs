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
            int min = P < Q ? P : Q;
            int max = P > Q ? P : Q;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > min && array[i] < max) count++;
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            int m = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[m]) m = i;

            if (m >= array.Length - 1) return;

            int n = m + 1;
            for (int i = m + 2; i < array.Length; i++)
                if (array[i] < array[n]) n = i;

            if (n < array.Length)
            {
                int t = array[m];
                array[m] = array[n];
                array[n] = t;
            }
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            int idx = -1;
            int max = int.MinValue;

            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    idx = i;
                }
            }

            if (idx != -1)
                array[idx] = idx;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = -1;

            // code here
            for (int i = 0; i < array.Length; i++)
                if (array[i] == P) 
                { 
                    index = i; 
                    break; 
                }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array == null || array.Length < 2) return;

            int m = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[m]) m = i;

            if (m == 0) return;
            for (int i = 0; i < m - 1; i += 2)
            {
                int t = array[i];
                array[i] = array[i + 1]; 
                array[i + 1] = t;
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null) return null;

            int c = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] >= 0) c++;

            answer = new int[c];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] >= 0) answer[j++] = array[i];
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            if (array == null || array.Length < 2) return;

            bool s;
            do
            {
                s = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int t = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = t;
                        s = true;
                    }
                }
            } while (s);
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length < 2) return;
            for (int i = 0; i < array.Length / 2; i++)
            {
                int t = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = t;
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A == null && B == null) return new int[0];
            if (A == null || A.Length == 0) 
            {
                C = (int[])B.Clone();
                return C;
            }
            if (B == null || B.Length == 0) 
            {
                C = (int[])A.Clone();
                return C;
            }
            C = new int[A.Length + B.Length];
            int x = 0, y = 0, z = 0;
            while (x < A.Length && y < B.Length)
            {
                C[z++] = A[x++];
                C[z++] = B[y++];
            }
            while (x < A.Length) C[z++] = A[x++];
            while (y < B.Length) C[z++] = B[y++];
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n < 1) return null;
            if (n == 1)
            {
                if (a == b) return new double[] { a };
                else return null;
            }
            if (a == b) return null;

            array = new double[n];
            double s = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
                array[i] = a + i * s;
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw == null || raw.Length < 3) return null;
            restored = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
                restored[i] = raw[i];
            for (int i = 0; i < restored.Length; i++)
            {
                if (restored[i] == -1)
                {
                    double l = restored[(i - 1 + restored.Length) % restored.Length];
                    double r = restored[(i + 1) % restored.Length];
                    if (l != -1 && r != -1)
                        restored[i] = (l + r) / 2;
                }
            }
            // end

            return restored;
        }
    }
}
