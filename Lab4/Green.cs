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
                    count += 1;
                }
            }

            double srednie = sum / count;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = srednie;
                }
            }
            // end

            //return array;

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    flag = true;
                    break;
                }
          
                sum += array[i]*array[i];
            }
            // end

            return flag ? sum: 0;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here

            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = -100000000;
            int min = 100000000;
            int max_index = -1;
            int min_index = -1;
            bool first = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_index = i;
                }
                if (first && array[i] < 0)
                {
                    min = array[i];
                    min_index = i;
                    first = false;
                }
            }

            if (first == false && max_index != min_index)
            {
                array[max_index] = min;
                array[min_index] = max;
            }

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;
            //answer.

            // code here
            int max = -100000000;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    count = 1;
                } else if (array[i] >= max)
                {
                    count += 1;
                }
            }

            answer = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[j] = i;
                    j += 1;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = -100000000;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int j = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += j;
                    j += 1;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = -100000000;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    count = 1;
                }
                else if (array[i] >= max)
                {
                    count += 1;
                }
            }

            int[] answer = new int[count];
            int sum = 0;
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[j] = sum;
                    j += 1;
                }
                sum += array[i];
            }

            j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] = answer[j];
                    j += 1;
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here

            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here

            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here

            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here

            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here

            // end

            return wins;

        }
    }
}