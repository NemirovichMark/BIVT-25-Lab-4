using System;
using System.ComponentModel.DataAnnotations;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double summ = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    summ += array[i];
                    count++;
                }
            }
            double avg = summ / count;
            for (int i =0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = avg;
                }
            }
            // end
        }
        public int Task2(int[] array)
        {
            int sum = 0;
            int k=0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    k = i;
                    break;
                }
            }
            for (int i = 0; i < k; i++)
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
            int max = int.MinValue;
            int min=int.MaxValue;
            int indexMax = -1;
            int indexMin = -1;
            int count = 0;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexMax = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    indexMin = i;
                }
            }
            int start = Math.Min(indexMin, indexMax);
            int end = Math.Max(indexMin, indexMax);
            for (int i = start+1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }
            negatives = new int[count];
            int index = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[index] = array[i];
                    index++;
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = int.MinValue;
            int indmax = -1;
            int indotr = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    indotr = i;
                    break;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indmax = i;
                }
            }
            if (indotr != -1 && indmax != -1 && indotr != indmax)
            {
                (array[indmax], array[indotr]) = (array[indotr], array[indmax]);
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = int.MinValue;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    count++;
                }
            }
            answer = new int[count];
            int intmax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[intmax] = i;
                    intmax++;
                }
            }

            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = int.MinValue;
            int index = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
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
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int[] answer = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                answer[i] = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (answer[i] == max)
                {
                    int sum = 0;
                    for (int j=0; j<i; j++)
                    {
                        sum += answer[j];
                    }
                    array[i] = sum;
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 1;
            int currentlength = 1;
            // code here
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i+1])
                {
                    currentlength++;
                    if (currentlength > length)
                    {
                        length = currentlength;
                    }
                }
                else { currentlength = 1; }
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int length = (array.Length+1) / 2;
            int[] chet = new int[length];
            int index = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                chet[index] = array[i];
                index++;
            }
            int temp = 0;
            for (int j = 0; j < chet.Length; j++)
            {
                for (int i = 0; i < chet.Length - 1; i++)
                {
                    if (chet[i] > chet[i + 1])
                    {
                        temp = chet[i];
                        chet[i] = chet[i + 1];
                        chet[i + 1] = temp;

                    }
                }
            }
            for (int i=0; i<chet.Length; i++)
            {
                array[2 * i] = chet[i];
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int count = 0;
            int[] nepov = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < count; j++)
                {
                    if (array[i] == nepov[j])
                    {
                        flag = 1;
                        break;

                    }
                }
                if (flag == 0)
                {
                    nepov[count] = array[i];
                    count++;
                }
            }
            cleared = new int[count];
            for (int i = 0; i < count; i++)
            {
                cleared[i] = nepov[i];
            }
                // end

                return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            double step = Math.Abs(a - b) / (n-1);
            double start = Math.Min(a, b);
            double end = Math.Max(a, b);
            double sum = 0;
            int count = 0;
            A = new double[n];
            if (b == a)
                return null;
            if (n <= 1)
                return null;
            for (int i = 0; i < n; i++)
            {
                A[i] = start + step * i;
            }
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
            int Blength = 0;
            double avg = sum / count;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > avg)
                {
                    Blength++;
                }
            }
            int index = 0;
            B = new double[Blength];
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > avg)
                {
                    B[index] = A[i];
                    index++;
                }
            }
            // end
            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int[] shuler = new int[dices.Length];
            for (int i = 0; i < dices.Length; i++)
            {
                shuler[i] = 6 - i;
                if (shuler[i] < 1)
                {
                    shuler[i] = 1;
                }
            }
            int countCursed = 0;
            int real = 0;
            int changed = 0;
            for (int i = 0; i<dices.Length;i++)
            {
                real = dices[i];
                changed = real - countCursed;
                if (real == 6)
                {
                    countCursed++;
                }
                if (changed < 1)
                {
                    changed = 1;
                }
                if (changed > shuler[i])
                {
                    wins++;
                }
            }
            // end

            return wins;

        }
    }
}