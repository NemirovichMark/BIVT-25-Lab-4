using System;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            int firstNegIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) { firstNegIndex = i; break; }
            }
            if (firstNegIndex == -1) return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
            }

            int sumAfterMax = 0;
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                sumAfterMax += array[i];
            }

            array[firstNegIndex] = sumAfterMax;
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            if (array == null) return null;
            int n = array.Length;
            if (n == 0) return new int[0];

            int lastPos = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0) lastPos = i;
            }

            if (lastPos == -1)
            {
                answer = new int[n];
                Array.Copy(array, answer, n);
                return answer;
            }

            answer = new int[n + 1];
            for (int i = 0; i <= lastPos; i++) answer[i] = array[i];
            answer[lastPos + 1] = P;
            for (int i = lastPos + 1; i < n; i++) answer[i + 1] = array[i];
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null) return null;
            int n = array.Length;
            if (n == 0) return new int[0];

            int minPosValue = int.MaxValue;
            int minPosIndex = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0 && array[i] < minPosValue)
                {
                    minPosValue = array[i];
                    minPosIndex = i;
                }
            }

            if (minPosIndex == -1)
            {
                answer = new int[n];
                Array.Copy(array, answer, n);
                return answer;
            }

            answer = new int[n - 1];
            int idx = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == minPosIndex) continue;
                answer[idx++] = array[i];
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            double sum = 0.0;
            int n = array.Length;
            for (int i = 0; i < n; i++) sum += array[i];
            double avg = sum / n;
            for (int i = 0; i < n; i++) array[i] = array[i] - avg;
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A == null || B == null) return 0;
            if (A.Length == 0 || B.Length == 0) return 0;
            if (A.Length != B.Length) return 0;

            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i] * B[i];
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            if (array == null) return null;
            int n = array.Length;
            if (n == 0) return new int[0];

            double sum = 0;
            for (int i = 0; i < n; i++) sum += array[i];
            double avg = sum / n;

            System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
            for (int i = 0; i < n; i++)
            {
                if (array[i] < avg) list.Add(i);
            }

            indexes = list.ToArray();
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            if (array == null) return 0;
            int n = array.Length;
            if (n == 0) return 0;
            if (n == 1) return 1;

            int maxLen = 1;
            int incLen = 1;
            int decLen = 1;

            for (int i = 1; i < n; i++)
            {
                if (array[i] >= array[i - 1]) incLen++; else incLen = 1;
                if (array[i] <= array[i - 1]) decLen++; else decLen = 1;
                if (incLen > maxLen) maxLen = incLen;
                if (decLen > maxLen) maxLen = decLen;
            }

            count = maxLen;
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null) return null;
            int n = array.Length;
            if (n == 0) return new int[0];

            answer = new int[n * 2];
            int idx = 0;
            for (int i = 0; i < n; i++)
            {
                answer[idx++] = array[i];
                answer[idx++] = array[i];
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            if (array == null) return null;
            int n = array.Length;
            if (n == 0) return new double[0];

            int min = array[0];
            int max = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            if (max == min) return null;

            normalized = new double[n];
            double range = (double)(max - min);
            for (int i = 0; i < n; i++)
            {
                normalized[i] = (array[i] - min) / range;
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            if (array == null) return -1;
            int n = array.Length;
            if (n == 0) return -1;
            int[] copy = new int[n];
            Array.Copy(array, copy, n);
            Array.Sort(copy);
            int left = 0;
            int right = n - 1;
            int found = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (copy[mid] == P) { found = mid; break; }
                else if (copy[mid] < P) left = mid + 1;
                else right = mid - 1;
            }

            index = found == -1 ? -1 : found;
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <= 0) return null;

            if (a > c)
            {
                return new int[0];
            }

            int count = ((c - a) / b) + 1;
            if (count <= 0) return new int[0];

            array = new int[count];
            int val = a;
            for (int i = 0; i < count; i++)
            {
                array[i] = val;
                val += b;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if (magazine == null) return null;
            int n = magazine.Length;
            if (n == 0) return new int[0];

            if (n < 3)
            {
                indexes = new int[n];
                for (int i = 0; i < n; i++) indexes[i] = i;
                return indexes;
            }

            int bestStart = 0;
            int bestSum = magazine[0] + magazine[1] + magazine[2];
            int currentSum = bestSum;

            for (int i = 1; i <= n - 3; i++)
            {
                currentSum = currentSum - magazine[i - 1] + magazine[i + 2];
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestStart = i;
                }
            }

            indexes = new int[3] { bestStart, bestStart + 1, bestStart + 2 };
            // end

            return indexes;
        }
    }
}
