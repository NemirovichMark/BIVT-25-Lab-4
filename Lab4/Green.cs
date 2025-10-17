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
            int[] negatives = ;

            // code here
            int max_val = 0;
            int max_pos = 0;

            int min_val = 0;
            int min_pos = 0;


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



            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    negatives.SetValue(value: array[i], index: i - left - 1);
                }
            }
                // end

                return negatives;
        }
        public void Task4(int[] array)
        {

            // code here

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here

            // end

        }
        public void Task7(int[] array)
        {

            // code here

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