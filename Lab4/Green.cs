namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            if (array.Length == 0)
            {
                return;
            }
            double sum = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
            }
            if (count > 0)
            {
                double avg = sum / count;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = avg;
                    }
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            bool otric = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    otric = true;
                    break;
                }
            }
            if (!otric)
            {
                return 0;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    break;
                }
                sum += array[i] * array[i];
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            if (array == null || array.Length == 0)
            {
                return negatives;
            }

            int min = 0;
            int max = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            int start = Math.Min(min, max);
            int end = Math.Max(min, max);

            if (end - start <= 1)
            {
                return new int[0];
            }
            int count = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }
            negatives = new int[count];
            int curr = 0;

            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[curr] = array[i];
                    curr++;
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            if (array.Length == 0)
            {
                return;
            }
            int maxind = 0;
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxind = i;
                }
            }
            int neg = -1;
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
                int nig = array[maxind];
                array[maxind] = array[neg];
                array[neg] = nig;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            if (array.Length == 0)
            {
                answer = new int[0];
                return answer;
            }
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    count++;
                }
            }
            answer = new int[count];
            int ind = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[ind] = i;
                    ind++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array.Length == 0)
            {
                return;
            }
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int maxi = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += maxi;
                    maxi++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return;
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int[] ind = new int[array.Length];
            ind[0] = 0;
            for (int i = 1; i < array.Length; i++)
            {
                ind[i] = ind[i - 1] + array[i - 1];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] = ind[i];
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            if (array.Length == 0)
            {
                return 0;
            }
            if (array.Length == 1)
            {
                return 1;
            }

            int cur = 1;
            int max = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    cur++;
                    if (cur > max)
                    {
                        max = cur;
                    }
                }
                else
                {
                    cur = 1;
                }
            }

            length = max;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            if (array.Length <= 1)
            {
                return;
            }
            for (int i = 0; i < array.Length; i += 2)
            {
                for (int j = 0; j < array.Length - 2; j += 2)
                {
                    if (j + 2 < array.Length && array[j] > array[j + 2])
                    {
                        int arr = array[j];
                        array[j] = array[j + 2];
                        array[j + 2] = arr;
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            if (array == null || array.Length == 0)
            {
                cleared = new int[0];
                return cleared;
            }
            int[] arr = new int[array.Length];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool dub = false;
                for (int j = 0; j < count; j++)
                {
                    if (arr[j] == array[i])
                    {
                        dub = true;
                        break;
                    }
                }
                if (!dub)
                {
                    arr[count] = array[i];
                    count++;
                }
            }
            cleared = new int[count];
            for (int i = 0; i < count; i++)
            {
                cleared[i] = arr[i];
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n == 1 || n == 0 || a == b)
            {
                return B;
            }
            A = new double[n];
            int j = 0;
            double max = Math.Sqrt((a - b)*(a - b))/(n - 1);
            for (double i = Math.Min(a, b); i <= Math.Max(a, b) + 0.00001; i += max)
            {
                A[j++] = i;
            }
            int array = 0;
            int arr = 0;
            double wow = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    wow += A[i];
                    arr++;
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > (wow) / (arr))
                {
                    array++;
                }
            }
            B = new double[array];
            j = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > (wow) /(arr))
                {
                    B[j++] = A[i];
                }
            }
            if (B == null) return [];
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int min = 0;
            int max = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                int mini = Math.Max(dices[i]-min,1);
                int maxi = Math.Max(6-max,1);
                if (mini > maxi)
                {
                    wins++;
                }
                if (dices[i] == 6)
                {
                    min++;
                }
                max++;
            }
            // end

            return wins;

        }
    }
}
