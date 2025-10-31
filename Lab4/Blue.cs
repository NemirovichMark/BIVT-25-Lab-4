using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            int max_el_ind = 0;
            int max_el = array[0];
            // code here
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] > max_el)
                {
                    max_el = array[i];
                    max_el_ind = i;
                }
            }
            int sum = 0;
            if (max_el_ind == array.Length) sum = 0;
            else
            {
                for (int i = max_el_ind + 1; i < array.Length; i++)
                {
                    sum += array[i];
                }
            }
            //int[] ints = new int[array.Length];
            bool fl = false;
            int j = 0;
            foreach (int i in array) 
            {
                if (fl) continue;
                else if (i < 0)
                {
                    fl = true;
                    array[j] = sum;
                }
                j++;
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
            double sr = 0;
            foreach (double i in array)
            {
                sr += i;
            }
            sr /= array.Length;
            for (int i = 0; i < array.Length ; i++)
            {
                array[i] = array[i]-sr;
            }

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length != B.Length) return 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i] * B[i];
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;
            double sr = 0;
            // code here
            foreach (int i in array)
            {
                sr += i;
            }
            sr /= array.Length;

            int count = 0;
            foreach (int i in array)
            {
                if (i < sr) 
                {
                    count++;
                    Console.WriteLine($"{i} < {sr}");

                }
                ;
            }
            int[] m = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {

                    m[j] = i;
                    j++;
                }  
            }
            // end
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine(array.Length);
            Console.WriteLine(string.Join(", ", m));
            Console.WriteLine(m.Length);
            Console.WriteLine("__________________________");
            return m;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here

            int ans = 0;
            int cur = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    cur += 1;
                }
                else
                {
                    ans = Math.Max(ans, cur);
                    cur = 1;
                }
            }
            ans = Math.Max(ans, cur);

            cur = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1])
                {
                    cur += 1;
                }
                else
                {
                    ans = Math.Max(ans, cur);
                    cur = 1;
                }
            }
            ans = Math.Max(ans, cur);
            count = ans;

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here

            answer = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                answer[i * 2] = array[i];
                answer[i * 2 + 1] = array[i];
            }

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here

            int min = array[0];
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
                max = Math.Max(max, array[i]);
            }

            if (min == max) { return normalized; }

            normalized = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (double)(array[i] - min) / (max - min);
            }


            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here

            int[] arr = new int[array.Length];
            for (int j = 0; j < array.Length; j++)
            {
                arr[j] = array[j];
            }
            int i = 1, n = arr.Length;


            while (i < n)
            {      // Использовал GnomeSort из лекции, так как он реализуется без вложенных циклов
                if (i == 0 || arr[i] >= arr[i - 1])
                    i++;
                else
                {
                    (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                    i--;
                }
            }

            index = -1;
            int target = P, low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == target)
                {
                    index = mid;
                    break;
                }
                else if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here

            if (b > 0)
            {
                array = new int[Math.Max(0, (c - a) / b + 1)];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = a + b * i;
                }
            }

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            if (magazine.Length == 1)
            {
                indexes = new int[1] { 0 };
                return indexes;
            }

            if (magazine.Length == 2)
            {
                indexes = new int[2] { 0, 1 };
                return indexes;
            }

            int ans = 0;
            int sum = magazine[0] + magazine[1] + magazine[2];
            for (int i = 1; i < magazine.Length - 2; ++i)
            {
                if (sum < magazine[i] + magazine[i + 1] + magazine[i + 2])
                {
                    ans = i;
                    sum = magazine[i] + magazine[i + 1] + magazine[i + 2];
                }
            }
            indexes = new int[3] { ans, ans + 1, ans + 2 };


            // end

            return indexes;
        }
    }
}
