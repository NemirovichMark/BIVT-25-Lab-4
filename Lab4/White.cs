namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            if (vector == null || vector.Length == 0)
                return 0;
            
            double sum = 0;
            foreach (int num in vector)
            {
                sum += num * num;
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
                return 0;
            
            int start = Math.Min(P, Q);
            int end = Math.Max(P, Q);
            
            foreach (int element in array)
            {
                if (element > start && element < end)
                    count++;
            }
            // end

            return count;
        }

        public void Task3(int[] array)
        {
            // code here
            if (array == null || array.Length < 2)
                return;
            
            // Find max element and its index
            int maxValue = array[0];
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }
            
            // If max is last element, return
            if (maxIndex == array.Length - 1)
                return;
            
            // Find min element after max
            int minValue = array[maxIndex + 1];
            int minIndex = maxIndex + 1;
            for (int i = maxIndex + 2; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minIndex = i;
                }
            }
            
            // Swap
            (array[maxIndex], array[minIndex]) = (array[minIndex], array[maxIndex]);
            // end
        }

        public void Task4(int[] array)
        {
            // code here
            if (array == null || array.Length == 0)
                return;
            
            int maxValue = int.MinValue;
            int maxIndex = -1;
            
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }
            
            if (maxIndex != -1)
                array[maxIndex] = maxIndex;
            // end
        }

        public int Task5(int[] array, int P)
        {
            int index = -1;

            // code here
            if (array == null)
                return -1;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                    return i;
            }
            // end

            return index;
        }

        public void Task6(int[] array)
        {
            // code here
            if (array == null || array.Length < 2)
                return;
            
            // Find max index
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }
            
            // Swap adjacent elements before max
            for (int i = 0; i < maxIndex - 1; i += 2)
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
            }
            // end
        }
        
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null)
                return Array.Empty<int>();
            
            List<int> positiveList = new List<int>();
            foreach (int num in array)
            {
                if (num >= 0)
                    positiveList.Add(num);
            }
            
            answer = positiveList.ToArray();
            // end

            return answer;
        }
        
        public void Task8(int[] array)
        {
            // code here
            if (array == null || array.Length < 2)
                return;
            
            Array.Sort(array);
            Array.Reverse(array);
            // end
        }
        
        public void Task9(int[] array)
        {
            // code here
            if (array == null || array.Length < 2)
                return;
            
            Array.Reverse(array);
            // end
        }
        
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A == null && B == null)
                return Array.Empty<int>();
            if (A == null)
                return B.ToArray();
            if (B == null)
                return A.ToArray();
            
            List<int> result = new List<int>();
            int maxLength = Math.Max(A.Length, B.Length);
            
            for (int i = 0; i < maxLength; i++)
            {
                if (i < A.Length)
                    result.Add(A[i]);
                if (i < B.Length)
                    result.Add(B[i]);
            }
            
            C = result.ToArray();
            // end

            return C;
        }
        
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n <= 0)
                return null;
            
            if (n == 1)
                return new double[] { a };
            
            if (a == b)
                return null;
            
            array = new double[n];
            double step = (b - a) / (n - 1);
            
            for (int i = 0; i < n; i++)
            {
                array[i] = a + i * step;
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw == null || raw.Length < 3)
                return raw?.ToArray() ?? Array.Empty<double>();
            
            restored = raw.ToArray();
            
            // Check if all are -1
            if (restored.All(x => x == -1))
                return restored;
            
            bool changed;
            do
            {
                changed = false;
                for (int i = 0; i < restored.Length; i++)
                {
                    if (restored[i] == -1)
                    {
                        double? left = (i > 0) ? restored[i - 1] : (double?)null;
                        double? right = (i < restored.Length - 1) ? restored[i + 1] : (double?)null;
                        
                        if (left.HasValue && left.Value != -1 && right.HasValue && right.Value != -1)
                        {
                            restored[i] = (left.Value + right.Value) / 2.0;
                            changed = true;
                        }
                    }
                }
            } while (changed);
            // end

            return restored;
        }
    }
}
