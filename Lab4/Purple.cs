using System.Globalization;
using System.Security.AccessControl;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            int max_element_pos = 0;
            double element_sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                element_sum += array[i];
                if (array[i] > array[max_element_pos]) max_element_pos = i;
            }
            double mid = element_sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (i > max_element_pos)
                {
                    array[i] = mid;
                }
            }

            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int arr_len = array.Length;
            if (arr_len % 2 == 0)
            {
                even = new int[arr_len / 2];
                odd = new int[arr_len / 2];
                int test = 0;
            }
            else
            {
                int test = 0;
                even = new int[arr_len / 2 + 1];
                odd = new int[arr_len / 2];
            }
            //System.Console.WriteLine($"{arr_len} {even.Length} {odd.Length}");

            //int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) even[i / 2] = array[i];
                else odd[i / 2] = array[i];
            }
            // end
            return (even, odd);
        }
        
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            double sum = 0, min_abs_diff = double.MaxValue;
            int closest_element_index = 0, arr_len = array.Length;

            for (int i = 0; i < arr_len; i++) //sum of array elements
            {
                sum += array[i];
            }
            double mean = sum / arr_len; //arithmetic mean of array

            for (int i = 0; i < arr_len; i++) //index of value closest to mean value
            {
                double abs_diff = Math.Abs(mean - array[i]);
                if (abs_diff < min_abs_diff)
                {
                    closest_element_index = i;
                    min_abs_diff = abs_diff;
                }
            }
            answer = new int[arr_len + 1];
            for (int i = 0; i < closest_element_index+1; i++)
            {
                answer[i] = array[i];
            }
            answer[closest_element_index+1] = P;
            for (int i = closest_element_index+1; i < arr_len; i++)
            {
                answer[i+1] = array[i];
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int arr_len = array.Length, negaive_count = 0;

            foreach (int i in array) //count negative numbers (negative number array len)
            {
                if (i < 0) negaive_count++;
            }
            int[] negative_nums = new int[negaive_count];
            int[] non_negative_nums = new int[arr_len - negaive_count];
            int neg_index = 0, pos_index = 0;

            for (int i = 0; i < arr_len; i++) //fill pos and neg number arrays
            {
                if (array[i] < 0)
                {
                    negative_nums[neg_index] = array[i];
                    neg_index++;
                }
                else
                {
                    non_negative_nums[pos_index] = array[i];
                    pos_index++;
                }
            }
            //refill og array with non-negative nums, then with negative nums
            for (int i = 0; i < arr_len - negaive_count; i++) 
            {
                array[i] = non_negative_nums[i];
            }
            for (int i = 0; i < negaive_count; i++)
            {
                array[arr_len - negaive_count + i] = negative_nums[i];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            answer = new int[A.Length + B.Length];
            if (k <= A.Length)
            {
                for (int i = 0; i < k; i++) //filling array with elements A elements
                {
                    answer[i] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[k + i] = B[i];
                }
                for (int i = 0; i < A.Length - (k); i++)
                {
                    answer[k + B.Length + i] = A[k + i];
                }
            }
            else
            {
                answer = A;
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length == B.Length)
            {
                sum = new int[A.Length]; //len A == len B 
                dif = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            double max_element = double.MinValue, min_element = double.MaxValue;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[0] == array[i]) count++;
                if (array[i] > max_element) max_element = array[i];
                if (array[i] < min_element) min_element = array[i];
            }
            if (count == array.Length)
            {
                return normalized;
            }
            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = 2*(array[i] - min_element) / (max_element - min_element)-1;
            }
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                C[A.Length + i] = B[i];
            }
            for (int i = 0; i<C.Length; i++)
            {
                bool swap = false;
                for (int j = 0; j < C.Length - 1 - i; j++)
                {
                    if (C[j] < C[j + 1])
                    {
                        (C[j], C[j + 1]) = (C[j + 1], C[j]);
                    }
                    swap = true;
                }
                if (swap == false) break;
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int max_element_i = 0, len = array.Length;
            for (int i = 0; i < len; i++)
            {
                if (array[i] > array[max_element_i]) max_element_i = i;
            }
            int[] temp = new int[len];
            for (int n = 0; n < max_element_i; n++)
            {
                temp[n] = array[len - max_element_i + n];
            }
            for (int n = max_element_i; n < len; n++)
            {
                temp[n] = array[n - max_element_i];
            }
            for (int i = 0; i < len; i++)
            {
                array[i] = temp[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {
        // code here
        int k = 2;
        for (int i = N; i < array.Length; i++)
        {
            if (i - k < 0) break; //break if no element to mirror
            array[i] = array[i - k]; //mirroring_element = mirrored_element
            k += 2;
        }
        // end
        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            X = new double[n];
            Y = new double[n];

            double step = 0;
            if (n == 1) step = (a + b) / 2;
            else step = (b - a) / (n - 1);
            System.Console.WriteLine(step);

            if (step != 0 && b>=a)
            {
                int index = 0;
                for (double x = a; x <= b + 0.0001; x += step)
                {
                    //System.Console.WriteLine(index);
                    double y = Math.Cos(x) + x * Math.Sin(x);
                    //System.Console.WriteLine($"x {x}; y {y};");
                    X[index] = x;
                    Y[index] = y;
                    index++;
                }

                int k = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if (((Y[i - 1] < Y[i]) && (Y[i + 1] < Y[i])) || ((Y[i - 1] > Y[i]) && (Y[i + 1] > Y[i]))) k++;
                }
                //System.Console.WriteLine(k);
                if (true)//(k != 0)
                {
                    Xext = new double[k];
                    Yext = new double[k];
                    index = 0;
                }
                for (int i = 1; i < n - 1; i++)
                {
                    if (((Y[i - 1] < Y[i]) && (Y[i + 1] < Y[i])) || ((Y[i - 1] > Y[i]) && (Y[i + 1] > Y[i])))
                    {
                        Xext[index] = X[i];
                        Yext[index] = Y[i];
                        index++;
                    }
                }
            }
            // end
            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            //caclulate mean
            double sum = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                sum += raw[i];
            }
            double mean = sum / raw.Length;
            System.Console.WriteLine(mean);

            //count bright and dim stars and create corrseponding arrays
            int c_bright = 0, c_dim = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > mean * 2)
                {
                    c_bright++;
                    //raw[i] = -1;
                }
                if (raw[i] < mean / 2)
                {
                    c_dim++;
                    //raw[i] = -2;
                }
            }
            bright = new double[c_bright];
            dim = new double[c_dim];

            //filling bright and dim arrays
            c_bright = 0;
            c_dim = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > mean * 2)
                {
                    bright[c_bright] = raw[i];
                    raw[i] = -1;
                    c_bright++;
                }
                else if (raw[i] < (mean / 2))
                {
                    dim[c_dim] = raw[i];
                    raw[i] = -2;
                    c_dim++;
                }
            }

            //calculate new mean
            sum = 0;
            int count = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] != -1 && raw[i] != -2)
                {
                    sum += raw[i];
                    count++;
                }
            }
            mean = sum / count;

            //create normal array
            normal = new double[raw.Length];
            for(int i = 0; i < raw.Length; i++)
            {
                normal[i] = raw[i]; 
            }

            //calculate and insert new values in normal array
            c_bright = 0;
            c_dim = 0;
            for (int i = 0; i < normal.Length; i++)
            {
                if (normal[i] == -1)
                {
                    normal[i] = (bright[c_bright] + mean) / 2;
                    c_bright++;
                }
                if (normal[i] == -2)
                {
                    normal[i] = (dim[c_dim] + mean) / 2;
                    c_dim++;
                }
            }

            //sorting normal
            for (int i = 0; i < normal.Length; i++)
            {
                bool swap = false;
                for (int j = 0; j < normal.Length - 1 - i; j++)
                {
                    if (normal[j] < normal[j + 1])
                    {
                        (normal[j], normal[j + 1]) = (normal[j + 1], normal[j]);
                        swap = true;
                    }
                }
                if (swap == false) break;
            }
            // end

            return (bright, normal, dim);
        }

    }
}
