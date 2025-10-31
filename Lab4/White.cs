namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;
            double sumSquares = 0;
            
            for (int i = 0; i < vector.Length; i++)
            {
                sumSquares += vector[i] * vector[i];

            }

            length = Math.Sqrt(sumSquares);
            return length;;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;
            int max = Math.Max(P, Q);
            int min = Math.Min(P, Q);
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min && array[i] < max)
                {
                    count++;
                }
            }
            return count;
        }
        public void Task3(int[] array)
        {
            int arrayMax = array.Max();
            int arrayMin = array.Min();
            int indexMax = 0;
            int indexMin = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == arrayMax)
                {
                    indexMax = i;
                    break;
                }

            }

            for (int i = indexMax; i < array.Length; i++)
            {
                if (array[i] == arrayMin)
                {
                    indexMin = i;
                    break;
                }
            }

            int temp = array[indexMax];
            array[indexMax] = array[indexMin];
            array[indexMin] = temp;
            // end 

        }
        public void Task4(int[] array)
        // code here
        {
            int evenMax = array[0];
            int maxIndex = 0;
            for (int i = 2; i < array.Length; i += 2)
            {
                if (array[i] > evenMax)
                {
                    evenMax = array[i];
                    maxIndex = i;
                }

            }
            array[maxIndex] = maxIndex;
        }
        // end

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
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int indexMax = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    indexMax = i;
                    break;
                }
            }

            if (indexMax <= 1)
            {
                return;
            }

            for (int i = 0; i < indexMax - 1; i += 2)
            {
                int temp = array[i];
                array[i] = array[i+1];
                array[i+1] = temp;
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    count++;
                }
            }
            int[] answer = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[index] = array[i];
                    index++;
                }
            }

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
                int left = 0;
                int right = array.Length - 1;

                while (left < right)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;

                    left++;
                    right--;
                }
                // end

            }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;
            int indexA = 0;
            int indexB = 0;
            int indexC = 0;
            C = new int[A.Length + B.Length];
            // code here
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
            // code here
            if (n <= 0 || (a != b && n == 1) || (a == b && n != 1))
            {
                return null;
            }

            if (a == b && n == 1)
            {
                return new double[] { a };
            }

            double[] newArray = new double[n];
            double step = (b - a) / (n - 1);  

            for (int i = 0; i < n; i++)
            {
                double newValue = a + i * step;
        
                if (a < b)
                {
                    if (newValue <= b)
                        newArray[i] = newValue;
                    else
                        newArray[i] = b;
                }
                else 
                {
                    if (newValue >= b)  
                        newArray[i] = newValue;
                    else
                        newArray[i] = b;
                }
            }
            // end

            return newArray;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw == null)
            {
                return null;
            }
    
            if (raw.Length < 3)
            {
                return null;
            }
    
            bool allDamaged = true;
            foreach (double item in raw)
            {
                if (item != -1)
                {
                    allDamaged = false;
                    break;
                }
            }
    
            if (allDamaged)
            {
                restored = new double[raw.Length];
                for (int i = 0; i < raw.Length; i++)
                {
                    restored[i] = raw[i];
                }
                return restored;
            }
    
            restored = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                restored[i] = raw[i];
            }
    
            for (int i = 0; i < restored.Length; i++)
            {
                if (restored[i] == -1)
                {
                    int leftIndex = (i - 1 + restored.Length) % restored.Length;
                    int rightIndex = (i + 1) % restored.Length;
            
                    double left = restored[leftIndex];
                    double right = restored[rightIndex];
            
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
