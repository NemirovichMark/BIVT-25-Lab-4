using System;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] arr)
        {
            int max = arr[0] - 1;
            int sum = 0;
            int negIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 && negIndex == -1)
                    negIndex = i;

                if (arr[i] > max)
                {
                    sum = 0;
                    max = arr[i];
                }
                else
                {
                    sum += arr[i];
                }
            }

            if (negIndex != -1)
                arr[negIndex] = sum;
        }

        public int[] Task2(int[] arr, int P)
        {
            int posIndex = -1;

            for (int i = arr.Length; i > 0; i--)
            {
                if (arr[i - 1] > 0)
                {
                    posIndex = i;
                    break;
                }
            }

            if (posIndex == -1)
                return arr;

            int[] result = new int[arr.Length + 1];
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == posIndex)
                    result[j++] = P;
                
                result[j++] = arr[i];
            }

            if (posIndex == arr.Length)
                result[j] = P;

            return result;
        }

        public int[] Task3(int[] arr)
        {
            int minPosIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0 && (minPosIndex == -1 || arr[i] < arr[minPosIndex]))
                    minPosIndex = i;
            }

            if (minPosIndex == -1)
                return arr;

            int[] result = new int[arr.Length - 1];
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != minPosIndex)
                    result[j++] = arr[i];
            }

            return result;
        }

        public void Task4(double[] arr)
        {
            double sum = 0;
            foreach (double x in arr)
                sum += x;

            double avg = sum / arr.Length;

            for (int i = 0; i < arr.Length; i++)
                arr[i] -= avg;
        }

        public int Task5(int[] A, int[] B)
        {
            if (A.Length != B.Length)
                return 0;

            int sum = 0;
            for (int i = 0; i < A.Length; i++)
                sum += A[i] * B[i];

            return sum;
        }

        public int[] Task6(int[] arr)
        {
            double sum = 0;
            foreach (int x in arr)
                sum += x;

            double avg = sum / arr.Length;
            int count = 0;

            foreach (int x in arr)
                if (x < avg) count++;

            int[] result = new int[count];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < avg)
                    result[index++] = i;

            return result;
        }

        public int Task7(int[] arr)
        {
            int maxLen = 1;
            int currLen = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= arr[i - 1])
                    currLen++;
                else
                    currLen = 1;

                if (currLen > maxLen)
                    maxLen = currLen;
            }

            currLen = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] <= arr[i - 1])
                    currLen++;
                else
                    currLen = 1;

                if (currLen > maxLen)
                    maxLen = currLen;
            }

            return maxLen;
        }

        public int[] Task8(int[] arr)
        {
            int[] result = new int[arr.Length * 2];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i * 2] = arr[i];
                result[i * 2 + 1] = arr[i];
            }

            return result;
        }

        public double[] Task9(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];

            foreach (int x in arr)
            {
                if (x < min) min = x;
                if (x > max) max = x;
            }

            if (min == max)
                return null;

            double[] result = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                result[i] = (double)(arr[i] - min) / (max - min);

            return result;
        }

        public int Task10(int[] arr, int P)
        {
            int[] sorted = new int[arr.Length];
            Array.Copy(arr, sorted, arr.Length);
            Array.Sort(sorted);

            int left = 0;
            int right = sorted.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                
                if (sorted[mid] == P)
                    return mid;
                else if (sorted[mid] < P)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        public int[] Task11(int a, int b, int c)
        {
            if (b <= 0)
                return null;

            int n = (c - a) / b + 1;
            if (n <= 0)
                return null;

            int[] result = new int[n];

            for (int i = 0; i < n; i++)
                result[i] = a + b * i;

            return result;
        }

        public int[] Task12(int[] arr)
        {
            if (arr.Length < 3)
                return new int[] { 0, 1 };

            int maxSum = arr[0] + arr[1] + arr[2];
            int maxIndex = 0;

            for (int i = 1; i <= arr.Length - 3; i++)
            {
                int sum = arr[i] + arr[i + 1] + arr[i + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxIndex = i;
                }
            }

            return new int[] { maxIndex, maxIndex + 1, maxIndex + 2 };
        }
    }
}
