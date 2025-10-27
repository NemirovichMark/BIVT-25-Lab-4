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

            // code here
            bool finded = false;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0 && !finded)
                {
                    answer = new int[array.Length + 1];
                    answer[i + 1] = P;
                    finded = true;
                }
            }
            if (!finded)
            {
                return array;
            }
            finded = false;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0 && !finded)
                {
                    finded = true;
                    answer[i] = array[i];
                }
                else if (!finded)
                {
                    answer[i + 1] = array[i];
                }
                else
                {
                    answer[i] = array[i];
                }
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int Minimal = int.MaxValue;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > 0 && array[i] < Minimal)
                {
                    Minimal = array[i];
                }
            }
            if (Minimal != int.MaxValue)
            {
                bool finded = false;
                answer = new int[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (!finded)
                    {
                        answer[i] = array[i];
                    }
                    else if (array[i] == Minimal && !finded)
                    {
                        finded = true;
                        answer[i] = array[i + 1];
                        continue;
                    }
                    else
                    {
                        answer[i] = array[i + 1];
                    }

                }
            }
            else
            {
                return array;
            }

 
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