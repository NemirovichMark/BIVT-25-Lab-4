using System.Runtime.InteropServices;

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

            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here

            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here

            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here

            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here

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