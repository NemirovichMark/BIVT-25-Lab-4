namespace Lab4
{
    public class White
     public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            if (vector == null || vector.Length == 0)
            {
                return length;
            }

            double sum = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                double value = vector[i];
                sum += value * value;
            }

            length = Math.Sqrt(sum);
            
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            if (array == null || array.Length == 0)
            {
                return count;
            }

            int left = Math.Min(P, Q);
            int right = Math.Max(P, Q);

            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                if (value > left && value < right)
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
            if (array == null || array.Length == 0)
            {
                return;
            }

            int maxIndex = 0;
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }

            if (maxIndex >= array.Length - 1)
            {
                return;
            }

            int minIndex = maxIndex + 1;
            int minValue = array[minIndex];
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minIndex = i;
                }
            }

            if (minValue == maxValue)
            {
                return;
            }

            int temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;
            
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
            {
                return;
            }

            int index = 0;
            int maxValue = array[0];
            for (int i = 2; i < array.Length; i += 2)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
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
            if (array == null || array.Length == 0)
            {
                return -1;
            }

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
            if (array == null || array.Length == 0)
            {
                return;
            }

            int maxIndex = 0;
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }

            for (int i = 0; i + 1 < maxIndex; i += 2)
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
            if (array == null)
            {
                return answer;
            }

            int nonNegativeCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    nonNegativeCount++;
                }
            }

            answer = new int[nonNegativeCount];
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
                int current = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] < current)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = current;
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
