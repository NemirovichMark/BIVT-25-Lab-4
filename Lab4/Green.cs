using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double s = 0;
            int cow = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0)
                {
                    s += array[i];
                    cow += 1;
                }
            s = s / cow;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0)
                    array[i] = s;
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    return sum;
                sum += array[i] * array[i];
            }
            // end

            return 0;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max = int.MinValue, maxid = array.Length, min = int.MaxValue, minid = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxid = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    minid = i;
                }
            }
            int len = 0;
            int j = 0;
            if (maxid > minid)
            {
                for (int i = minid + 1; i < maxid; i++)
                    if (array[i] < 0)
                        len++;
                negatives = new int[len];
                for (int i = minid + 1; i < maxid; i++)
                    if (array[i] < 0)
                        negatives[j++] = array[i];
            }
            else if (minid > maxid)
            {
                for (int i = maxid + 1; i < minid; i++)
                    if (array[i] < 0)
                        len++;
                negatives = new int[len];
                for (int i = maxid + 1; i < minid; i++)
                    if (array[i] < 0)
                        negatives[j++] = array[i];
            }
            else negatives = new int[len];
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int otr = array.Length;
            int max = int.MinValue, maxid = array.Length;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > max)
                {
                    max = array[i];
                    maxid = i;
                }
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0)
                {
                    otr = i;
                    break;
                }
            if (otr != array.Length & maxid != array.Length)
                (array[maxid], array[otr]) = (array[otr], array[maxid]);
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = int.MinValue, maxid = array.Length, cow = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    cow = 0;
                    max = array[i];
                    maxid = i;
                }
                if (array[i] == max)
                    cow++;
            }
            answer = new int[cow];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max == array[i])
                {
                    answer[j++] = i;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = int.MinValue, j = 1;
            for (int i = 0; i < array.Length; i++)
                if (max < array[i])
                    max = array[i];
            for (int i = 0; i < array.Length; i++)
                if (array[i] == max)
                    array[i] += j++;
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = int.MinValue, s = 0, t = 0;
            for (int i = 0; i < array.Length; i++)
                if (max < array[i])
                    max = array[i];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    t = array[i];
                    array[i] = s;
                    s += t;
                }
                else
                    s += array[i];
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 1;

            // code here
            int cow = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    cow++;
                if (cow > length)
                    length = cow;
                if (array[i] >= array[i - 1])
                    cow = 1;
            }
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
            int f = 0, cow = 0;

            for (int i = 0; i < array.Length; i++)
            {
                f = 1;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                        f = 0;
                }
                if (f == 1)
                    cow++;
            }

            int k = 0;
            cleared = new int[cow];
            for (int i = 0; i < array.Length; i++)
            {
                f = 1;
                for (int j = 0; j < i; j++)
                    if (array[i] == array[j])
                        f = 0;
                if (f == 1)
                    cleared[k++] = array[i];
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (a == b | n <= 1)
                return B;

            A = new double[n];
            int j = 0, cow = 0, cow2 = 0;
            double sum = 0;

            for (double i = Math.Min(a, b); i <= Math.Max(a, b) + 0.0001; i += (Math.Max(a, b) - Math.Min(a, b)) / (n - 1))
            {
                A[j++] = i;
                if (i > 0)
                {
                    cow++;
                    sum += i;
                }
            }

            for (int i = 0; i < n; i++)
                if (A[i] > 0 & A[i] > sum / cow)
                    cow2++;

            B = new double[cow2];
            j = 0;

            for(int i = 0; i < n; i++)
                if (A[i] > 0 & A[i] > sum / cow)
                    B[j++] = A[i];
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int[] shul = new int[dices.Length];
            for (int i = 0; i <= 4 & i < dices.Length; i++)
                shul[i] = 6 - i;
            for (int i = 5; i < dices.Length; i++)
                shul[i] = 1;
            int cow = 6;
            for (int i = 0; i < dices.Length - 1; i++)
                if (dices[i] == cow)
                {
                    for (int j = i + 1; j < dices.Length; j++)
                        dices[j] = dices[j] - 1;
                    cow--;
                }
            for (int i = 0; i < dices.Length; i++)
                if (dices[i] > shul[i])
                    wins++;
            // end

            return wins;

        }
    }
}