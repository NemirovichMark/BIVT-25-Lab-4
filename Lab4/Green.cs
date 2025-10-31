namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            int c = 0;
            double S = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    S += array[i];
                    c++;
                }
            }
            double SR = S / c;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = SR;
                }
            }

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    a = i;
                    break;
                }
            }
            for (int i = 0; i < a; i++)
            {
                sum += array[i] * array[i];
            }

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

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
                }
                else if (min_i > max_i + 1)
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

            return negatives;
        }
        public void Task4(int[] array)
        {

            int maxIndex = 0;
            int NegativeIndex = -1;


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    NegativeIndex = i;
                    break;
                }
            }

            if (NegativeIndex != -1)
            {
                int temp = array[maxIndex];
                array[maxIndex] = array[NegativeIndex];
                array[NegativeIndex] = temp;
            }



        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;
            answer = new int[0];
            if (array.Length > 0)
            {
                int max_i = 0;
                int max_n = array[0];
                int c = 0;
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
            return answer;
        }
        public void Task6(int[] array)
        {
            if (array.Length > 0)
            {
                int max_i = 0;
                int max_n = array[0]; 
                int c = 1;
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
        }
        public void Task7(int[] array)
        {
            if (array.Length > 0)
            {
                int max_i = 0;
                int max_n = array[0];
                int s = 0;
                int a = 0;
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

        }
        public int Task8(int[] array)
        {
            int length = 0;
            length = 1;
            if (array.Length > 0)
            {
                int c = 1;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        c++;
                    }
                    else
                    {
                        c = 1;
                    }
                    if (length < c)
                    {
                        length = c;
                    }
                }
            }
            return length;
        }
        public void Task9(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 2; j++)
                {
                    if (array[j] > array[j + 2] && j % 2 == 0)
                    {
                        int a = array[j];
                        array[j] = array[j + 2];
                        array[j + 2] = a;
                    }
                }
            }

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            cleared = new int[array.Length];
            int[] unique = new int[array.Length];
            int uniqueCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool F = false;

                for (int j = 0; j < uniqueCount; j++)
                {
                    if (array[i] == unique[j])
                    {
                        F = true;
                        break;
                    }
                }

                if (!F)
                {
                    unique[uniqueCount] = array[i];
                    uniqueCount++;
                }
            }

            cleared = new int[uniqueCount];
            for (int i = 0; i < uniqueCount; i++)
            {
                cleared[i] = unique[i];
            }

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

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

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            int c = 0, c1 = 0, dice_enemy, dice;

            for (int i = 0; i < dices.Length; i++)
            {
                dice_enemy = 6 - c;
                dice = dices[i] - c1;
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
                    c1++;
                }

            }

            return wins;

        }
    }
}
