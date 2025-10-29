using System.Runtime.ExceptionServices;
using System.Runtime.Intrinsics.X86;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int cnt = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    cnt++;
                    sum += array[i];
                }
            }
            double ans = sum / cnt;
            for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > 0)
                    {
                        array[j] = ans;
                    }
                }
            }

            
            // end

        
        public int Task2(int[] array)
        {
            int sum = 0;
            int index = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    index = i;
                    break;
                }
            }
            for (int i = 0; i < index; i++)
            {
                sum += array[i] * array[i];
            }
                // end

                return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max = array[0];
            int min = array[0];
            int maxIndex = 0;
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
                if (array[i] < min)
                {
                    min = array[i]; 
                    minIndex = i;
                }
            }
            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(maxIndex, minIndex);
            int cnt = 0;
            for (int i = start+1; i < end; i++)
                {
                    if (array[i] < 0)
                    {
                        cnt++;
                    }
                }
            negatives = new int[cnt];

            int indexNeg = 0;

            for (int i = start+1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[indexNeg] = array[i];
                    indexNeg++;
                }
            }
        
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int firstIndex = -1;
            int max = array[0];
            int indexMax = 0;
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i] < 0)
                {
                    firstIndex = i;
                    break;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexMax = i;
                }
            }
            if (firstIndex >= 0)
            {
                int temp = array[indexMax];
                array[indexMax] = array[firstIndex];
                array[firstIndex] = temp;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max= array[i];
                }
            }
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    cnt++;
                }
            }
            answer = new int[cnt];

            int ansIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[ansIndex] = i;
                    ansIndex++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max= array[i];
                }
            }
            int index = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += index;
                    index++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int maxEl = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxEl)
                {
                    maxEl = array[i];
                }
            }
            int sum = 0;
            for (int i = 0; i< array.Length; i++)
            {
                sum += array[i];
                if (array[i] == maxEl)
                {
                    array[i] = sum - array[i];
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int count = 1;
            int maxCount = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                else
                    count = 1;
            }
            length = maxCount;

            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length - 2; i += 2)
                for (int j = 0; j < array.Length - 2; j += 2)
                    if (array[j] > array[j + 2])
                        (array[j], array[j + 2]) = (array[j + 2], array[j]);
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int[] arrayUnique = new int[array.Length];

            int count = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                bool isDublicate = false;
                for (int j = 0; j < count; j++) 
                {
                    if (array[i] == arrayUnique[j])
                    {
                        isDublicate = true;
                        break;
                    }
                }
                if (!isDublicate) 
                {
                    arrayUnique[count] = array[i];
                    count++;
                }
            }

            cleared = new int[count];


            for (int i = 0; i < count; i++)
            {
                cleared[i] = arrayUnique[i];
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (b == a)
                return null;
            if (n <= 1)
                return null;

            A = new double[n];

            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }


            double sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    count++;
                }
            }

            if (count == 0)
                return new double[0];

            double average = sum / count;

            int elementsCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > average)
                {
                    elementsCount++;
                }
            }

            B = new double[elementsCount];
            int indexB = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > average)
                {
                    B[indexB] = A[i];
                    indexB++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int n = dices.Length;

            int s = 0;
            int[] mine = new int[n];
            for (int i = 0; i < n; i++)
            {
                int a = dices[i] - s;
                if (a < 1) a = 1;
                mine[i] = a;

                if (dices[i] == 6) s++;
            }
            for (int i = 0; i < n; i++)
            {
                int e = 6 - i;
                if (e < 1) e = 1;
                if (mine[i] > e) wins++;
            }

            // end

            return wins;

        }
    }
}

