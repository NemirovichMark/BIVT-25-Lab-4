
namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            foreach (int num in vector)
            {
                length += num * num;
            }
            length = Math.Sqrt(length);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            int min = Math.Min(P, Q);
            int max = Math.Max(P, Q);
            
            foreach (int num in array)
            {
                if (num > min && num < max)
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
            if (array == null || array.Length == 0) return;
            
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            
            if (maxIndex >= array.Length - 1) return;
            
            int minAfterMaxIndex = maxIndex + 1;
            for (int i = maxIndex + 2; i < array.Length; i++)
            {
                if (array[i] < array[minAfterMaxIndex])
                {
                    minAfterMaxIndex = i;
                }
            }
            
            if (array[minAfterMaxIndex] == array[maxIndex]) return;
            
            int temp = array[maxIndex];
            array[maxIndex] = array[minAfterMaxIndex];
            array[minAfterMaxIndex] = temp;
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            
            int maxIndex = 0;
            for (int i = 2; i < array.Length; i += 2)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            
            array[maxIndex] = maxIndex;
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
            if (array == null || array.Length < 2) return;
            
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            
            if (maxIndex == 0) return;
            
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
            if (array == null) return answer;
            
            int count = 0;
            foreach (int num in array)
            {
                if (num >= 0) count++;
            }
            
            answer = new int[count];
            int index = 0;
            foreach (int num in array)
            {
                if (num >= 0)
                {
                    answer[index++] = num;
                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            if (array == null || array.Length < 2) return;
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length < 2) return;
            
            for (int i = 0; i < array.Length / 2; i++)
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
            if (A == null && B == null) return new int[0];
            if (A == null) return (int[])B.Clone();
            if (B == null) return (int[])A.Clone();
            
            C = new int[A.Length + B.Length];
            int indexA = 0, indexB = 0, indexC = 0;
            
            while (indexA < A.Length && indexB < B.Length)
            {
                C[indexC++] = A[indexA++];
                C[indexC++] = B[indexB++];
            }
            
            while (indexA < A.Length)
            {
                C[indexC++] = A[indexA++];
            }
            
            while (indexB < B.Length)
            {
                C[indexC++] = B[indexB++];
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n <= 0) return array;
            if (n == 1 && a == b)
            {
                array = new double[] { a };
                return array;
            }
            if (a == b && n != 1) return array;
            
            array = new double[n];
            if (a < b)
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * step;
                }
            }
            else if (a > b)
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
            if (raw == null || raw.Length < 3) return restored;
            
            restored = (double[])raw.Clone();
            bool allDamaged = true;
            foreach (double num in raw)
            {
                if (num != -1)
                {
                    allDamaged = false;
                    break;
                }
            }
            if (allDamaged) return restored;
            
            for (int i = 0; i < restored.Length; i++)
            {
                if (restored[i] == -1)
                {
                    double left = -1, right = -1;
                    
                    // Find left neighbor
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (restored[j] != -1)
                        {
                            left = restored[j];
                            break;
                        }
                    }
                    
                    // Find right neighbor
                    for (int j = i + 1; j < restored.Length; j++)
                    {
                        if (restored[j] != -1)
                        {
                            right = restored[j];
                            break;
                        }
                    }
                    
                    if (left != -1 && right != -1)
                    {
                        restored[i] = (left + right) / 2.0;
                    }
                }
            }
            // end

            return restored;
        }
    }
}
