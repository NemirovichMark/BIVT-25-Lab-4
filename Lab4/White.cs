using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            if (vector == null) return 0;
            
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
            if (array == null) return 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > P && array[i] < Q)
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
            if (array == null || array.Length < 2) return;
            
            // Find position of maximum element
            int maxPos = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxPos])
                {
                    maxPos = i;
                }
            }
            
            // Find minimum after maximum
            if (maxPos == array.Length - 1) return; // No elements after max
            
            int minPos = maxPos + 1;
            for (int i = maxPos + 2; i < array.Length; i++)
            {
                if (array[i] < array[minPos])
                {
                    minPos = i;
                }
            }
            
            // Swap
            int temp = array[maxPos];
            array[maxPos] = array[minPos];
            array[minPos] = temp;
            // end
        }

        public void Task4(int[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;
            
            // Find maximum at even positions (0, 2, 4...)
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i += 2)
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
            int index = 0;
               
            // code here
             index = -1;
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == P)
                    {
                        index = i;
                        return index; // Return immediately when found
                    }
                }
            }
            // end

            return index;
        }

        public void Task6(int[] array)
        {
            // code here
            if (array == null || array.Length < 2) return;
            
            // Find maximum element position
            int maxPos = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxPos])
                {
                    maxPos = i;
                }
            }
            
            // Swap pairs before maximum
            for (int i = 0; i < maxPos - 1; i += 2)
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
            if (array == null) return null;
            
            // Count non-negative numbers
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    count++;
                }
            }
            
            // Create new array
            answer = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[j] = array[i];
                    j++;
                }
            }
            // end

            return answer;
        }

        public void Task8(int[] array)
        {
            // code here
            if (array == null || array.Length < 2) return;
            
            // Simple bubble sort for descending order
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        // Swap
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
            if (array == null || array.Length < 2) return;
            
            int left = 0;
            int right = array.Length - 1;
            
            while (left < right)
            {
                // Swap
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

            // code here
            if (A == null && B == null) 
            {
                C = new int[0];
                return C;
            }
            
            if (A == null) 
            {
                C = new int[B.Length];
                for (int i = 0; i < B.Length; i++)
                {
                    C[i] = B[i];
                }
                return C;
            }
            
            if (B == null) 
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
            int iA = 0, iB = 0;
            
            // Alternate between arrays
            while (iA < A.Length && iB < B.Length)
            {
                C[index] = A[iA]; iA++; index++;
                C[index] = B[iB]; iB++; index++;
            }
            
            // Add remaining from A
            while (iA < A.Length)
            {
                C[index] = A[iA]; iA++; index++;
            }
            
            // Add remaining from B
            while (iB < B.Length)
            {
                C[index] = B[iB]; iB++; index++;
            }
            // end

            return C;
        }

      public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n <= 0) { return null; }

            if (n == 1)
            {
                if (a == b)
                {
                    return new double[] { a };
                }
                else
                {
                    return null;
                }
            }

            if (a == b) { return null; }


            array = new double[n];
            if (a < b)
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * step;
                }
            }
            else 
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
            if (raw == null) return null;
            if (raw.Length < 3) 
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
            
            bool changed;
            do
            {
                changed = false;
                for (int i = 0; i < restored.Length; i++)
                {
                    if (restored[i] == -1)
                    {
                        int leftIndex = i - 1;
                        if (leftIndex < 0) leftIndex = restored.Length - 1; // circular
                        
                        int rightIndex = i + 1;
                        if (rightIndex >= restored.Length) rightIndex = 0; // circular
                        
                        if (restored[leftIndex] != -1 && restored[rightIndex] != -1)
                        {
                            restored[i] = (restored[leftIndex] + restored[rightIndex]) / 2.0;
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


