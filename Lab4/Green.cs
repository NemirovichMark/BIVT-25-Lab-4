namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
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
            double avg = sum / count;
            for (int i = 0; i < array.Length; i++)
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

            // code here
            bool negative = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negative = true;
                    break;
                }
                sum += array[i] * array[i];
            }
            if (!negative)
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
            int maxx = int.MinValue;
            int minn = int.MaxValue;
            int ind_max = 0; 
            int ind_min = 0;
            if (array.Length == 0)
            {
                negatives = null;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                    ind_max = i;
                }
                if (array[i] < minn)
                {
                    minn = array[i];
                    ind_min = i;
                }
            }
            int start = Math.Min(ind_max, ind_min) + 1;
            int end = Math.Max(ind_max, ind_min) - 1;
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (array[i] < 0)
                    count++;
            }
            negatives = new int[count];
            int j = 0;
            for (int i = start; i <= end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[j] = array[i];
                    j++;
                }
            }

            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max_ind = 0;
            int first_neg = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max_ind])
                {
                    max_ind = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    first_neg = i;
                    break;
                }
            }
            if (first_neg != -1)
            {
                (array[max_ind], array[first_neg]) = (array[first_neg], array[max_ind]);
            }
            // end
        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max_el = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_el)
                {
                    max_el = array[i];
                }
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++ )
            {
                if (array[i] == max_el)
                {
                    count++;
                }
            }
            answer = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max_el)
                {
                    answer[j] = i;
                    j++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max_el = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_el)
                {
                    max_el = array[i];
                }
            }
            int j = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max_el)
                {
                    array[i] += j;
                    j++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max_el = int.MinValue;
            int[] same_array = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                same_array[i] = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_el)
                {
                    max_el = array[i];
                }
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;
                if (same_array[i] == max_el) { 
                    for (int j = 0; j < i; j++)
                    {
                        sum += same_array[j];
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
            length = 1;
            int max_length = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    length++;
                    if (length > max_length)
                    {
                        max_length = length;
                    }
                }
                else
                {
                    length = 1;
                }
            }
            length = max_length;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length - 2; i += 2)
            {
                for (int j = 0; j < array.Length - i - 2; j += 2)
                {
                    if (array[j] > array[j + 2])
                    {
                        (array[j], array[j + 2]) = (array[j + 2], array[j]);
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int count = 0;
            int[] same = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int j;
                for (j = 0; j < count; j++)
                {
                    if (same[j] == array[i])
                    {
                        break;
                    }
                }
                if (j == count)
                {
                    same[count] = array[i];
                    count++;
                }
            }
            cleared = new int[count];
            for (int i = 0; i < count; i++)
            {
                cleared[i] = same[i];
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n > 1 && a != b)
            {
                A = new double[n];
                double step = (b - a) / (n - 1);

                for (int i = 0; i < n; i++)
                {
                    A[i] = a + step * i;
                }

                double sum = 0;
                int count = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > 0)
                    {
                        sum += A[i];
                        count++;
                    }
                }

                if (count == 0)
                {
                    B = new double[0];
                }
                else
                {
                    double avg = sum / count;
                    int count2 = 0;

                    for (int i = 0; i < A.Length; i++)
                    {
                        if (A[i] > 0 && A[i] > avg)
                        {
                            count2++;
                        }
                    }
                    if (count2 == 0)
                    {
                        B = new double[0];
                    }
                    else
                    {
                        int j = 0;
                        B = new double[count2];
                        for (int i = 0; i < A.Length; i++)
                        {
                            if (A[i] > 0 && A[i] > avg)
                            {
                                B[j] = A[i];
                                j++;
                            }
                        }
                    }

                }
            }
            // end

            return B;
        }

        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int[] now = new int[dices.Length];
            for (int i = 0; i < now.Length; i++)
            {
                now[i] = dices[i];
            }
            for (int i = 0; i < now.Length; i++)
            {
                if (dices[i] == 6)
                {
                    for (int j = i + 1; j < dices.Length; j++)
                    {
                        now[j] = now[j] - 1;
                        if (now[j] < 1)
                        {
                            now[j] = 1;
                        }
                    }
                }
            }
            for (int i = 0; i < now.Length; i++)
            {
                int shuler_number = 6 - i;
                if (shuler_number < 1)
                {
                    shuler_number = 1;
                }

                if (now[i] > shuler_number)
                {
                    wins++;
                }
            }
            // end


        return wins;
        }
    }
}