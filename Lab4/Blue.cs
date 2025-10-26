using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int max_index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max_index])
                {
                    max_index = i;
                }
            }
            int s = 0;
            if (max_index < array.Length - 1)
            {
                for (int i = max_index+1; i < array.Length; i++)
                {
                    s += array[i];
                }
            }
            int negative_index = -1;
            for (int i = 0;  i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negative_index = i;
                    break;
                }
            }
            if (negative_index != -1) array[negative_index] = s;
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int positiveIndex = -1;
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] > 0)
                {
                    positiveIndex = i;
                    break;
                }
            }
            if (array.Length == 1 && array[0] > 0)
            {
                answer = new int[2];
                answer[0] = array[0];
                answer[1] = P;
            }
            else
            {
                if (positiveIndex == -1) answer = array;
                else
                {
                    answer = new int[array.Length + 1];
                    int n = 0;
                    for (int i = 0; i <= positiveIndex; i++)
                    {
                        answer[n++] = array[i];
                    }
                    answer[n] = P;
                    n = answer.Length - 1;
                    for (int i = array.Length - 1; i > positiveIndex; i--)
                    {
                        answer[n--] = array[i];
                    }
                }
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int indexMin = -1;
            int minPosVal = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0  && array[i] < minPosVal)
                {
                    minPosVal = array[i];
                    indexMin = i;
                }
            }
            if (array.Length == 1 && array[0] > 0)
            {
                answer = [];
            }
            else
            {
                if (indexMin == -1) answer = array;
                else
                {
                    answer = new int[array.Length - 1];
                    for (int i = 0; i < indexMin; i++)
                    {
                        answer[i] = array[i];
                    }
                    int n = array.Length - 2;
                    for (int  i = array.Length-1; i > indexMin; i--)
                    {
                        answer[n--] = array[i];
                    }
                }
            }
                // end

                return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                avg += array[i];
            }
            avg /= array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= avg;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length == B.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    sum += A[i] * B[i];
                }
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                avg += array[i];
            }
            avg /= array.Length;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg) count++;
            }
            indexes = new int[count];
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                {
                    indexes[count++] = i;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int counter = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] <= array[i+1]) counter++;
                else
                {
                    count = Math.Max(count, counter);
                    counter = 1;
                }
            }
            count = Math.Max(count, counter);
            int counter1 = 1;
            for (int i = array.Length-1; i > 0; i--)
            {
                if (array[i] <= array[i-1]) counter1++;
                else
                {
                    count = Math.Max(count, counter1);
                    counter1 = 1;
                }
            }
            count = Math.Max(count, counter1);
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length*2];
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                answer[n] = array[i];
                answer[n+1] = array[i];
                n += 2;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                maxValue = Math.Max(array[i], maxValue);
                minValue = Math.Min(array[i], minValue);
            }
            if (maxValue == minValue) return null;
            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (double)(array[i] - minValue) / (maxValue - minValue);
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            index--;
            for (int i = 0; i < array.Length-1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex]) minIndex = j;
                }
                int elem = array[i];
                array[i] = array[minIndex];
                array[minIndex] = elem;
            }
            int left = 0, right = array.Length - 1;
            while (left <= right)
            {
                int mid = (left + right)/2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (P < array[mid]) right = mid-1;
                else left = mid+1;
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <= 0) return null;
            if (a > c) return [];
            array = new int[(c - a) / b + 1];
            int n = 0;
            for (int elem = a; elem <= c; elem += b)
            {
                array[n++] = elem;
            }
                // end
            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int totalGold = int.MinValue, totalGoldCheck = int.MinValue;
            if (magazine.Length < 3)
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }
            }
            else
            {
                indexes = new int[3];
                for (int i = 0; i < magazine.Length-2; i++)
                {
                    totalGold = Math.Max(totalGold, magazine[i] + magazine[i+1] + magazine[i+2]);
                    if (totalGold != totalGoldCheck && totalGold == magazine[i] + magazine[i+1] + magazine[i+2])
                    {
                        indexes[0] = i;
                        indexes[1] = i+1;
                        indexes[2] = i+2;
                        totalGoldCheck = totalGold;
                    }
                }
            }
                // end

                return indexes;
        }
    }
}
