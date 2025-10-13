using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            bool Zamena = false;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && Zamena == false)
                {
                    int test = array[i] = array.Skip(array.ToList().IndexOf(array.Max()) + 1).Sum();
                    Zamena = true;
                }
            }

            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;
            bool Zamena = false;

            // code here
            answer = array;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0 && Zamena == false)
                {
                    answer.ToList().Insert(i, P);
                    System.Console.WriteLine(i.ToString() + "/" + (answer.Length - 1).ToString());
                    Zamena = true;
                }
            }
            System.Console.WriteLine(string.Join(", ", answer));

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