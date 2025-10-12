using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            // code here

            const int
                INDEX_NOT_FOUND = -1
            ;

            int
                first_negative_index = INDEX_NOT_FOUND
                ,
                max_item_index = INDEX_NOT_FOUND
                ,
                max_item = array[0]
                ,
                sum = 0
            ;

            // first_negative_index=
            // max_item=
            for (
                int i = 0, item;
                i < array.Length;
                i += 1
            )
            {
                item = array[i];

                if (INDEX_NOT_FOUND == first_negative_index && item < 0)
                {
                    first_negative_index = i;
                }

                max_item = Math.Max(max_item, item);
            }

            if (first_negative_index == INDEX_NOT_FOUND)
            {
                return;
            }

            // max_item_index=
            for (
                int i = 0;
                i < array.Length;
                i += 1
            )
            {
                if (array[i] != max_item)
                {
                    continue;
                }

                max_item_index = i;
                break;
            }

            // sum arr[max..]=
            for (
                int i = max_item_index + 1;
                i < array.Length;
                i += 1
            )
            {
                sum += array[i];
            }

            array[first_negative_index] = sum;

            // end
        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            const int
                INVALID_INDEX = -0x7F_C0_C0_D0
            ;

            int
                p_index = INVALID_INDEX
                ,
                answer_length = array.Length
            ;

            //  p_index=
            for (
                int i = array.Length - 1;
                i >= 0;
                i -= 1
            )
            {

                int item = array[i];

                if (item > 0)
                {
                    p_index = i + 1;
                    break;
                }

            }

            if (INVALID_INDEX == p_index)
            {
                p_index = answer_length;
            }
            else
            {
                answer_length += 1;
            }

            answer = new int[answer_length];

            //  my_array_t::copy_btw

            //  answer[0..p] = array[0..p]
            for (
                int i = 0;
                i < p_index;
                i += 1
            )
            {
                answer[i] = array[i];
            }

            if (answer_length != array.Length)
            {
                answer[p_index] = P;

                //  answer[p+1..] = array[p..]
                for (
                    int i = p_index + 1;
                    i < answer_length;
                    i += 1
                )
                {
                    answer[i] = array[i - 1];
                }
            }

            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here

            const int
                NOT_FOUND = 0x7A_CA_D0_D0
            ;

            int
                target_item = NOT_FOUND
                ,
                target_item_index = NOT_FOUND
                ,
                answer_lenght = array.Length;
            ;

            // item=
            // MY_min_by..
            foreach (
                int item
                in array
            )
            {

                if (item > 0)
                {

                    target_item = Math.Min(item, target_item);

                }

            }

            if (NOT_FOUND == target_item) goto ahh__solve_by_skip_method;

            for (
                int i = 0;
                i < array.Length;
                i += 1
            )
            {

                int item = array[i];

                if (target_item != item)
                {

                    continue;

                }

                target_item_index = i;

                break;
            }

        ahh__solve_by_skip_method:

            if (NOT_FOUND == target_item_index)
            {
                target_item_index = answer_lenght;
            }
            else
            {
                answer_lenght -= 1;
            }
            answer = new int[answer_lenght];


            for (
                int i = 0;
                i < target_item_index;
                i += 1
            )
            {

                answer[i] = array[i];

            }

            if (array.Length != answer_lenght)
            {
                for (
                    int i = target_item_index;
                    i < answer_lenght;
                    i += 1
                )

                // bruh

                {

                    answer[i] = array[i + 1];

                }
            }

            // end

            return answer;
        }
        public void Task4(double[] array)
        {
            // code here

            var avg = 0.0;

            foreach (var item in array) avg += item;
            avg /= array.Length;

            for (var i = 0; i < array.Length; i += 1) array[i] -= avg;

            // end
        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here

            if (A.Length != B.Length) return 0;
            for (var i = 0; i < A.Length; i += 1) sum += A[i] * B[i];

            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here

            var avg = 0.0;

            foreach (var item in array) avg += item;
            avg /= array.Length;

            int targets = 0;

            var ret = new int[array.Length];
            var ret_i = 0;

            for (var array_i = 0; array_i < array.Length; array_i += 1) if (array[array_i] < avg)
                {
                    targets += 1;
                    ret[ret_i] = array_i;
                    ret_i += 1;
                }

            indexes = new int[targets];

            for (var i = 0; i < targets; i += 1) indexes[i] = ret[i];

            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here

            int
                rising_count = 1
                ,
                falling_count = 1
            ;

            for (
                int i = 1;
                i < array.Length;
                i += 1
            )
            {
                int diff = array[i - 1] - array[i];

                if (diff >= 0)
                {
                    rising_count += 1;
                }
                else
                {
                    count = Math.Max(count, rising_count);
                    rising_count = 1;
                }

                if (diff <= 0)
                {
                    falling_count += 1;
                }
                else
                {
                    count = Math.Max(count, falling_count);
                    falling_count = 1;
                }
            }

            count = Math.Max(count, Math.Max(rising_count, falling_count));

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here

            answer = new int[array.Length << 1];

            for (
                int i = 0;
                i < array.Length;
                i += 1
            )
            {
                int item = array[i];
                int j = i << 1;

                answer[j] = item;

                j += 1;
                answer[j] = item;
            }

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here

            int
                max_item = array[0]
                ,
                min_item = array[0]
            ;

            foreach (
                int item
                in array
            )
            {
                max_item = Math.Max(max_item, item);
                min_item = Math.Min(min_item, item);
            }

            if (max_item != min_item)
            {
                double range = max_item - min_item;

                normalized = new double[array.Length];

                for (
                    int i = 0;
                    i < array.Length;
                    i += 1
                )
                {
                    normalized[i] = (array[i] - min_item) / range;
                }

            }

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here

            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <= 0) goto ahh__solve_by_skip_method;

            int items = Math.Max(0, (c - a + b) / b);

            array = new int[items];

            for (int i = 0; i < items; i += 1)
            {
                array[i] = a + b * i;
            }

            ahh__solve_by_skip_method:
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            // end

            return indexes;
        }
    }
}