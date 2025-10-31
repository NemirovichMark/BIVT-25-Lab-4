using System.Runtime.Intrinsics.Arm;
using System.Runtime.Serialization.Formatters;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            int count = 0;

            foreach (int num in array)
            {
                if (num > 0)
                {
                    sum += num;
                    count++;
                }
            }
            if (count == 0)
            {
                return;
            }
            double average = sum / count;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = average;
                }

            }

            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;
            sum = 0;

            double k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    k = 1;

            }
            if (k == 0)
            {
                return 0;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    break;
                sum += array[i] * array[i];

            }

            return sum;

        }

        public int[] Task3(int[] array)
        {
            int[] negatives = null;
            // code here

            int min = 1000; int max = -1000;
            int imax = 0; int imin = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > max)
                {
                    max = array[i];
                    imax = i;
                }

                if (array[i] < min)
                {
                    min = array[i];
                    imin = i;
                }
            }
            int n = 0;
            int st = Math.Min(imin, imax);
            int fn = Math.Max(imin, imax);
            for (int i = st + 1; i < fn; i++)
            {
                if (array[i] < 0)
                {
                    n++;
                }
            }
            negatives = new int[n];
            n = 0;
            for (int i = st + 1; i < fn; i++)
            {
                if (array[i] < 0)
                {
                    negatives[n++] = array[i];
                }
            }

            return negatives;
        }

        public void Task4(int[] array)
        {

            // code here
            int max = 0;
            int neg = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max])
                    max = i;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    neg = i;
                    break;
                }

            }
            if (neg != -1)
            {
                (array[max], array[neg]) = (array[neg], array[max]);
            }


            // end

        }
        public int[] Task5(int[] array)
        {
            // code here

            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                    count++;
            }
            int[] answer = new int[count];//создать массив для минимальных
            count = 0;
            for (int i = 0; i < array.Length; i++)//выделяем в отдельным массив 
            {
                if (array[i] == max)
                {
                    answer[count] = i;
                    count++;
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
                    max = array[i];
            }
            int number = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += number;
                    number++;
                }
            }

            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            int[] array2= new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array2[i] == max)
                {
                    int sum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sum += array2[j];
                    }
                    array[i] = sum;

                }
            }

            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            if (array.Length == 0)
                return 0;
            if (array == null)
                return 0;

            if (array.Length == 1)
                return 1;

            int maxLenght = 1;
            int nowLenght = 1;

            for( int i=0;i<array.Length-1;i++)
            {
                if (array[i] > array[i+1])
                {
                    nowLenght++;
                    if (nowLenght > maxLenght) 
                        maxLenght = nowLenght;
                }
                else
                {
                    nowLenght = 1;
                }
            }
            length = maxLenght;

            // end

            return length;
        }
        public void Task9(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            for (int i = 0; i < array.Length; i += 2)
            {
                int minIndex = i;

                for (int j = i + 2; j < array.Length; j += 2)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool noRepeats = true;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        noRepeats = false;
                        break;
                    }
                }

                if (noRepeats == true)
                {
                    count++;
                }
            }

            cleared = new int[count];
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool noRepeats = true;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        noRepeats = false;
                        break;
                    }
                }

                if (noRepeats == true)
                {
                    cleared[k] = array[i];
                    k++;
                }
            }

            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here

            A = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }
            double ss = 0;
            int n2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] >= 0)
                {
                    ss += A[i];
                    n2++;
                }
            }
            ss = ss / n2;
            n2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > ss)
                {
                    n2++;
                }
            }
            B = new double[n2];
            int g = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > ss)
                {
                    B[g++] = A[i];
                }
            }
            if ((n <= 1) || (a == b))
            {
                return null;
            }

            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here

            int[] shul = new int[dices.Length];
            for (int i = 0; i <= 4 & i < dices.Length; i++)
            {
                shul[i] = 6 - i;
            }
            for (int i = 5; i < dices.Length; i++)
            {
                shul[i] = 1;
            }
            int k = 6;
            for (int i = 0; i < dices.Length - 1; i++)
            {
                if (dices[i] == k)
                {
                    for (int j = i + 1; j < dices.Length; j++)
                    {
                        dices[j] = dices[j] - 1;
                    }
                    k--;
                }
            }
            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[i] > shul[i])
                    wins++;
            }
            // end

            return wins;
        }
    }
}
