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
            if (array == null || array.Length == 0)
                return 0;
            
            int min = Math.Min(P, Q);
            int max = Math.Max(P, Q);
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min && array[i] < max)
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
            
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }
            
            if (maxIndex == array.Length - 1)
                return;
            
            int minIndex = maxIndex + 1;
            for (int i = maxIndex + 2; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                    minIndex = i;
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
                return;
            
            int maxIndex = 0;
            bool found = false;
            
            for (int i = 0; i < array.Length; i += 2)
            {
                if (!found || array[i] > array[maxIndex])
                {
                    maxIndex = i;
                    found = true;
                }
            }
            
            if (found)
                array[maxIndex] = maxIndex;
            // end
        }

        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            if (array == null)
            {
                index = -1;
                return index;
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    return index;
                }
            }
            
            index = -1;
            // end

            return index;
        }

        public void Task6(int[] array)
        {
            // code here
            if (array == null || array.Length < 2)
                return;
            
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }
            
            if (maxIndex < 2)
                return;
            
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
            if (array == null)
                return new int[0];
            
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    count++;
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
            if (array == null || array.Length < 2)
                return;
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            // end
        }
        
        public void Task9(int[] array)
        {
            // code here
            if (array == null || array.Length < 2)
                return;
            
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
            if (A == null && B == null)
                return new int[0];
            if (A == null)
                return (int[])B.Clone();
            if (B == null)
                return (int[])A.Clone();
            
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
    if (n <= 0)
        return null;
    
    // Only return array when n = 1 and a = b
    if (n == 1)
    {
        if (a == b)
        {
            array = new double[] { a };
            return array;
        }
        else
        {
            return null;
        }
    }
    
    // For n > 1, a must not equal b
    if (a == b)
        return null;
    
    array = new double[n];
    
    if (a < b)
    {
        double step = (b - a) / (n - 1);
        for (int i = 0; i < n; i++)
        {
            array[i] = a + i * step;
        }
    }
    else // a > b
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
            if (raw == null || raw.Length < 3)
                return raw?.ToArray() ?? new double[0];
            
            restored = new double[raw.Length];
            
            // Check if all elements are -1
            bool allNegativeOne = true;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] != -1)
                {
                    allNegativeOne = false;
                    break;
                }
            }
            
            if (allNegativeOne)
            {
                Array.Copy(raw, restored, raw.Length);
                return restored;
            }
            
            // Copy original values
            Array.Copy(raw, restored, raw.Length);
            
            // Restore damaged values - multiple passes until no more changes
            bool changed;
            do
            {
                changed = false;
                for (int i = 0; i < restored.Length; i++)
                {
                    if (restored[i] == -1)
                    {
                        // Find left neighbor (circular)
                        double left = -1;
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (restored[j] != -1)
                            {
                                left = restored[j];
                                break;
                            }
                        }
                        
                        // Find right neighbor (circular)
                        double right = -1;
                        for (int j = i + 1; j < restored.Length; j++)
                        {
                            if (restored[j] != -1)
                            {
                                right = restored[j];
                                break;
                            }
                        }
                        
                        // If both neighbors are valid, calculate average
                        if (left != -1 && right != -1)
                        {
                            restored[i] = (left + right) / 2.0;
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


