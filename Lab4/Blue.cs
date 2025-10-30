using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int mx = -100000000;
            int mx_ind = 0;
            int sum_mx = 0;
            for (int i = 0; i < array.Length; i++) 
                { 
                if (array[i] > mx)
                {
                    mx = array[i];
                    mx_ind = i; 
                }
                }
            if (mx_ind == array.Length - 1)
            {
                sum_mx = 0;
            }
            else
            {
                for (int i = mx_ind + 1; i < array.Length; i++)
                {
                    sum_mx += array[i];
                }
            }
            for (int i = 0; i < array.Length; i++) {
                if (array[i] < 0)
                {
                    array[i] = sum_mx;
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;
            // code here
            int temp = 0;
            int cnt = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    temp = i;
                    cnt++;
                }
            }

            if (cnt < 1)
            {
                answer = array;
                return answer;
            }
            int[] temp_arr = new int[array.Length + 1];
            for (int i = 0; i <= temp; i++)
            {
                temp_arr[i] = array[i];
            }
            temp_arr[temp + 1] = P;
            for (int i = temp + 1; i < array.Length; i++)
            {
                temp_arr[i + 1] = array[i];
            }

            answer = temp_arr;
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int minx = 10000;
            int cnt = 0;
            int temp = 0;
            int[] temp_arr = new int[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    cnt++;
                    if (array[i] < minx)
                    {
                        minx = array[i];
                        temp = i;
                    }
                }
            }
            if (cnt < 1) {
                answer = array;
                return answer;
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == temp)
                {
                    continue;
                }
                temp_arr[count++] = array[i];
            }
            answer = temp_arr;
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double sred = 0;
            foreach (double i in array)
            { 
                sred += i; 
            }
            sred = sred / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] - sred;
            }

            // end 

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;
            if (A == null || B == null || A.Length != B.Length)
            {
                return 0;
            }
            // code here
            else
            {
                int minL = Math.Min(A.Length, B.Length);
                for (int i = 0; i < minL; i++)
                {
                    sum += A[i] * B[i];
                }

                // end

                return sum;
            }
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double sred = 0;
            foreach (int i in array)
            {
                sred += i;
            }
            sred = sred / (array.Length);
            int cnt = 0;
            foreach (int i in array)
            {
                if (i < sred)
                {
                    cnt += 1;
                }
            }
            int[] temp = new int[cnt];
            int cnt2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sred)
                {
                    temp[cnt2++] = i;
                }
            }
            indexes = temp;
             // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            if (array.Length < 2)
            {
                return array.Length;
            }
            int cnt1 = 1;
            int cnt2 = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i+1] >= array[i])
                {
                    cnt1++;
                    count = Math.Max(cnt1, count);
                }
                else
                {
                    cnt1 = 1;
                }
                if (array[i + 1] <= array[i])
                {
                    cnt2++;
                    count = Math.Max(cnt2, count);
                }
                else
                {
                    cnt2 = 1;
                }
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            int[] temp = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                temp[2 * i] = array[i];
                temp[2 * i + 1] = array[i];
            }
            answer = temp;
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int mx = -1000000;
            int min = 10000000;
            foreach (int i in array)
            {
                if (i > mx)
                {
                    mx = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }
            if (array.Length < 2 || mx == min || array == null)
            {
                return normalized;
            }
            double[] temp = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = (double)(array[i] - min) / (mx - min);
            }
            // end
            normalized = temp;
            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            int[] temp_arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                temp_arr[i] = array[i];
            }
            for (int i = 0; i < temp_arr.Length - i - 1; i++)
            {
                for (int j = 0; j < temp_arr.Length - 1; j++)
                {
                    if (temp_arr[j] > temp_arr[j + 1])
                    {
                        (temp_arr[j], temp_arr[j + 1]) = (temp_arr[j + 1], temp_arr[j]);
                    }
                }
            }
            index--;
            int left = 0;
            int right = temp_arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (temp_arr[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (temp_arr[mid] < P)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;
            int a1 = a; int b1 = b; int c1 = c;
            // code here
            if (b <= 0)
            {
                return array;
            }
            int cnt = 0;
            while (a1 <= c1)
            {
                a1 += b1;
                cnt += 1;
            }
            array = new int[cnt];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = a + b * i;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if (magazine.Length <= 3)
            {
                if (magazine.Length == 0)
                {
                    return indexes;
                }
                else
                {
                    int[] temp = new int[magazine.Length];
                    for (int i = 0; i < magazine.Length; i++)
                    {
                        temp[i] = i;
                    }
                    indexes = temp;
                    return indexes;
                }
            }
            int mx = -1000;
            int[] temp_ind = new int[3];
            for (int i = 0; i < magazine.Length - 2; i++)
            {
                if (magazine[i] + magazine[i + 1] + magazine[i + 2] > mx)
                {
                    mx = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    temp_ind[0] = i;
                    temp_ind[1] = i + 1;
                    temp_ind[2] = i + 2;
                }
            }
            indexes = temp_ind;
            // end

            return indexes;
        }
    }
}
