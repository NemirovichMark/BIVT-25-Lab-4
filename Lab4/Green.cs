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

            // code 
            int siz2e = (array.Length + 1) / 2;
            int[] new_a = new int[siz2e];

            int count = 0;
            for (int i = 0; i <  array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    new_a[count] = array[i];
                    count++;
                }
            }
            int j = 1;
            int size = new_a.Length;

            while (j < size)
            {
                if (new_a[j - 1] <= new_a[j])
                {
                    j++;
                } else
                {
                    int temp = new_a[j - 1];
                    new_a[j - 1] = new_a[j];
                    new_a[j] = temp;
                    if (j > 1)
                    {
                        j--;
                    }
                }
            }

            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] = new_a[count];
                    count++;
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here

            int unique = 0;
            int[] temp = new int[unique];
            for (int i = 0; i < array.Length; i++)
            {
                bool ch = true;
                for (int j = 0; j < temp.Length; j++)
                {
                    if (array[i] == temp[j])
                    {
                        ch = false;
                        break;
                    }
                }

                if (ch)
                {
                    unique++;
                    int[] temp2 = new int[unique];
                    for (int i2 = 0; i2 < temp.Length; i2++)
                    {
                        temp2[i2] = temp[i2];
                    }

                    temp2[temp.Length] = array[i];

                    temp = temp2;
                }
            }

            cleared = temp;

            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            if (n <= 0)
                return new double[] { };

            if (n == 1)
                return new double[] { };

            A = new double[n];
            double step = (n == 1) ? 0.0 : (b - a) / (n - 1);

            for (int idx = 0; idx < n; idx++)
            {
                A[idx] = a + idx * step;
            }

            double summ = 0;
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    summ += A[i];
                    count++;
                }
            }

            if (count == 0)
                return new double[] { };
            double avg = summ / count;

            int second_c = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > avg)
                {
                    second_c++;
                }
            }

            if (second_c == 0)
                return new double[] { };
            B = new double[second_c];
            int cur_pos_B = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > avg)
                {
                    B[cur_pos_B] = A[i];
                    cur_pos_B++;
                }
            }

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