using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = array.SkipWhile(n => n != array.Max()).ToArray().Sum()-array.Max();
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int last_el = -1;
            foreach (int i in array)
            {
                if (i > 0) last_el = i;
            }
            int last_el_ind = 0;
            for (int i =0; i < array.Length; i++) if (array[i] > 0) last_el_ind= i;
            if (last_el == -1) return array;


            int[] fin = new int[array.Length + 1];
            bool fl = false;
            for (int i=0; i < array.Length; i++)
            {
                if (fl) fin[i + 1] = array[i];
                else
                {
                    fin[i] = array[i];
                    if (i == last_el_ind) {
                        fin[i + 1] = P;
                        fl = true;
                    }
                }

            }

            answer = fin;
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine("_______________________");
            Console.WriteLine(string.Join(", ", answer));
            Console.WriteLine("_______________________");

            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here

            // code here
            int minpl = 10000;
            int index = 0;
            int minindex = 0;
            foreach (int i in array)
            {
                if (i > 0)
                {
                    if (i < minpl)
                    { 
                        minpl = i; 
                        minindex = index;
                    }
                }
                index++;
            }
            if (minpl == 10000) 
            { 
                return array; 
            }
            
            else
            {
                bool fl = true;
                //Console.WriteLine(string.Join(", ", array));
                int[] ans = new int[array.Length - 1];
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != minindex && fl)
                    {
                        ans[i] = array[i];
                    }
                    else if (i == minindex) 
                    {
                        fl = false;
                    }
                    else
                    {
                        ans[i-1] = array[i];
                    }
                        ;
                }
                // end


                Console.WriteLine(string.Join(", ", array));
                Console.WriteLine("_______________________");
                Console.WriteLine(string.Join(", ", ans));
                Console.WriteLine("_______________________");
                return ans;
            }
        }
        public void Task4(double[] array)
        {

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
