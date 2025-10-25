using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            double sum = 0;
            int count = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count += 1;
                }
            }


            double avg = sum / count;

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] > 0))
                {
                    array[i] = avg;
                }
            }
        }
            // end        }
        public int Task2(int[] array)
        {
            int sum = 0;
            bool check = false;


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0)
                    {
                        sum += (array[i] * array[i]);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max_val = -999999;
            int max_pos = 333;

            int min_val = 99999;
            int min_pos = 333;


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_val)
                {
                    max_val = array[i];
                    max_pos = i;
                }

                if (array[i] < min_val)
                {
                    min_val = array[i];
                    min_pos = i;
                }
            }

            int left = Math.Min(max_pos, min_pos);
            int right = Math.Max(max_pos, min_pos);
            int count = 0;

            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }

            var ints = new int[count];
            int j = 0;

            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    ints[j] = array[i];
                    j++;
                }
            }


            negatives = ints;
                // end

                return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            bool found = true;
            int max_pos = 33, neg_pos = 33, neg_value = 999;
            int max_value = -99999;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_value)
                {
                    max_value = array[i];
                    max_pos = i;
                }

                if (found && (array[i] < 0))
                {
                    neg_pos = i;
                    neg_value = array[i];
                    found = false;
                }
            }

            if (found == false)
            {
                array[neg_pos] = max_value;
                array[max_pos] = neg_value;
            }


            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max_val = -99999;
            int counter = 0;


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_val)
                {
                    max_val = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max_val)
                {
                    counter++;
                }
            }

            var ints = new int[counter];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max_val)
                {
                    ints[j] = i; j++;
                }
            }


            answer = ints;
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here

            int max_val = -99999;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_val) {
                    max_val = array[i];
                }
            }
            int ccounter = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] == max_val))
                {
                    array[i] = max_val + ccounter;
                    ccounter++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max_value = -9999;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_value)
                {
                    max_value = array[i];
                }
            }

            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];

                if (array[i] == max_value)
                {
                    array[i] = summ;
                }
                summ += temp;
                
            }

            // end

        }
        public int Task8(int[] array)
        {
            int length = 1;
            int cur_streak = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    cur_streak++;
                }
                else
                {
                    if (cur_streak > length)
                    {
                        length = cur_streak;
                    }
                    cur_streak = 1;
                }
            }

            if (cur_streak > length)
            {
                length = cur_streak;
            }

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