namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double s = 0, avg = 0; int m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s += array[i];
                    m++;
                }
            }
            if (m > 0) avg = s / m;


            double[] t = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) t[i] = avg;
                else t[i] = array[i];
            }


            for (int i = 0; i < t.Length; i++)
            {
                array[i] = t[i];
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int a = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] < 0) && (a == -1)) a = i;
            }

            for (int i = 0; i < a; i++)
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
            int min = 100000;
            int max = -100000;
            int n = -1, x = -1;
            negatives = new int[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    n = i;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    x = i;
                }
            }

            if (x > n)
            {
                for (int i = n + 1; i < x; i++)
                {
                    if (array[i] < 0)
                    {
                        Array.Resize(ref negatives, negatives.Length + 1);
                        negatives[negatives.Length - 1] = array[i];
                    }
                }
            }
            else
            {
                for (int i = x + 1; i < n; i++)
                {
                    if (array[i] < 0)
                    {
                        Array.Resize(ref negatives, negatives.Length + 1);
                        negatives[negatives.Length - 1] = array[i];
                    }
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = -100000;
            int imax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    imax = i;
                }
            }

            int neg = 1;
            int ineg = -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0)
                {
                    neg = array[i];
                    ineg = i;
                    break;
                }
            if (ineg >= 0)
            {
                int temporary = array[imax];
                array[imax] = array[ineg];
                array[ineg] = temporary;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[0];
            int max = -1000000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    Array.Resize(ref answer, answer.Length + 1);
                    answer[answer.Length - 1] = i;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int n = 1;
            int max = -100000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += n;
                    n++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = array[0];
            int[] sum = new int[array.Length];
            sum[0] = 0;
            for (int i = 1; i < array.Length; i++)
            {
                sum[i] = array[i - 1] + sum[i - 1];
            }


            for (int i = 0; i < array.Length; i++)
                if (array[i] > max) max = array[i];

            for (int i = 0; i < array.Length; i++)
                if (array[i] == max) array[i] = sum[i];
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            length = 1;
            int l = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] < array[i])
                {
                    l++;
                    if (l + 1 > length)
                        length = l + 1;
                }
                else
                    l = 0;
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int ielement = (array.Length + 1) / 2;
            int[] element = new int[ielement];

            int index = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                element[index] = array[i];
                index++;
            }

            for (int i = 0; i < element.Length; i++)
            {
                for (int j = 0; j < element.Length - 1 - i; j++)
                {
                    if (element[j] > element[j + 1])
                    {
                        int t0 = element[j];
                        element[j] = element[j + 1];
                        element[j + 1] = t0;
                    }
                }
            }

            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = element[i / 2];
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool t = true;
                for (int j = 0; j < i; j++)
                    if (array[i] == array[j]) t = false;
                if (t) c++;
            }

            int index = 0;
            cleared = new int[c];
            for (int i = 0; i < array.Length; i++)
            {
                bool t = true;
                for (int j = 0; j < i; j++)
                    if (array[i] == array[j]) t = false;
                if (t)
                {
                    cleared[index] = array[i];
                    index++;
                }
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
            int step = 6;
            int curse = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                int pstep = Math.Max(1, dices[i] - curse);
                if (pstep > step) wins++;

                if (dices[i] == 6) curse++;

                step = Math.Max(1, step - 1);
            }


            // end

            return wins;

        }
    }
}