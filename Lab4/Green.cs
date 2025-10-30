using System.Diagnostics.Contracts;
using System.Net.Security;
using System.Runtime.ExceptionServices;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int c = 0;
            double s = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] > 0)
                {
                    s += array[i];
                    c++;
                }
            }
            s /= c;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = s;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            bool check = true;
            for (int i = 0; i < array.Length; i++) 
            { 
                if (array[i] < 0)
                {
                    check = false;
                    break;
                }
                sum += array[i] * array[i];
            }
            if (check)
            {
                sum = 0;
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            negatives = new int[0];
            if (array.Length > 2)
            {
                int min_i = 0, max_i = 0, min_n = array[0], max_n = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (min_n > array[i])
                    {
                        min_i = i;
                        min_n = array[i];
                    }
                    if (max_n < array[i])
                    {
                        max_i = i;
                        max_n = array[i];
                    }
                }
                int c = 0;
                if (min_i + 1 < max_i)
                {
                    for (int i = min_i + 1; i < max_i; i++)
                    {
                        if (array[i] < 0)
                        {
                            c++;
                        }
                    }
                    negatives = new int[c];
                    c = 0;
                    for (int i = min_i + 1; i < max_i; i++)
                    {
                        if (array[i] < 0)
                        {
                            negatives[c] = array[i];
                            c++;
                        }
                    }
                } else if (min_i > max_i + 1) 
                {
                    for (int i = max_i + 1; i < min_i; i++)
                    {
                        if (array[i] < 0)
                        {
                            c++;
                        }
                    }
                    negatives = new int[c];
                    c = 0;
                    for (int i = max_i + 1; i < min_i; i++)
                    {
                        if (array[i] < 0)
                        {
                            negatives[c] = array[i];
                            c++;
                        }
                    }
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            if (array.Length > 0)
            {
                int max_i = 0, max_n = array[0], neg_i = 0;
                bool neg = true;
                for (int i = 0; i < array.Length; i++)
                {
                    if (neg && array[i] < 0)
                    {
                        neg = false;
                        neg_i = i;
                    }
                    if (max_n < array[i]) 
                    {
                        max_i = i;
                        max_n = array[i];
                    }
                }
                if (!neg)
                {
                    array[max_i] = array[neg_i];
                    array[neg_i] = max_n;
                }
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[0];
            if (array.Length > 0)
            {
                int max_i = 0, max_n = array[0], c = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (max_n < array[i])
                    {
                        max_i = i;
                        max_n = array[i];
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (max_n == array[i])
                    {
                        c++;
                    }
                }
                answer = new int[c];
                c = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (max_n == array[i])
                    {
                        answer[c] = i;
                        c++;
                    }
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array.Length > 0)
            {
                int max_i = 0, max_n = array[0], c = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (max_n < array[i])
                    {
                        max_i = i;
                        max_n = array[i];
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (max_n == array[i])
                    {
                        array[i] += c;
                        c++;
                    }
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            if (array.Length > 0)
            {
                int max_i = 0, max_n = array[0], s = 0, a = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (max_n < array[i])
                    {
                        max_i = i;
                        max_n = array[i];
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (max_n == array[i])
                    {
                        a = array[i];
                        array[i] = s;
                        s += a;
                    }
                    else
                    {
                        s += array[i];
                    }
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            length = 1;
            if (array.Length > 0)
            {
                int c = 1;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        c++;
                    } else
                    {
                        c = 1;
                    }
                    if (length < c)
                    {
                        length = c;
                    }
                }
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length; i += 2)
            {
                for (int j = i + 2; j < array.Length; j += 2)
                {
                    if (array[i] > array[j])
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int c = 0;
            bool check = true; 
            for (int i = 0; i < array.Length; i++)
            {
                check = true;
                for (int j = 0; j < i; j ++)
                {
                    if (array[j] == array[i])
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    c++;
                }
            }
            cleared = new int[c];
            c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                check = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    cleared[c] = array[i];
                    c++;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (b == a || n <= 1)
            {
                return B;
            }
            A = new double[n];
            double step = (b - a) / (n - 1), s = 0;
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    s += A[i];
                    c++;
                }
            }
            s /= c;
            c = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > s)
                {
                    c++;
                }
            }
            B = new double[c];
            c = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > s)
                {
                    B[c] = A[i];
                    c++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int c = 0, c2 = 0, dice_enemy, dice;
            for (int i = 0; i < dices.Length; i++)
            {
                dice_enemy = 6 - c;
                dice = dices[i] - c2;
                if (dice < 1)
                {
                    dice = 1;
                }
                if (dice_enemy < 1)
                {
                    dice_enemy = 1;
                }
                if (dice > dice_enemy)
                {
                    wins++;
                }
                c++;
                if (dices[i] == 6)
                {
                    c2++;
                }

            }
            // end

            return wins;

        }
    }
}