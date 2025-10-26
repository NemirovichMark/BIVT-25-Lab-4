namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here

            int n = array.Length;
            int max = int.MinValue;
            int maxindex = -1;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxindex = i;
                }
            }
            for (int i = maxindex+1; i < n; i++)
            {
                sum += array[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = sum;
                    break;
                }
            }

            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here

            int n = array.Length;
            int index = -1;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    index = i;
                }
            }
            if (index == -1)
            {
                answer = new int[n];
                for (int i = 0; i < n; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[n+1];
                for (int i = 0; i <= index; i++)
                {
                    answer[i] = array[i];
                }
                answer[index + 1] = P;
                for (int i = index + 1; i < n; i++)
                {
                    answer[i+1] = array[i];
                }
            }

            //for (int i = 0; i < answer.Length;i++)
            //{
            //    Console.Write(answer[i] + " ");
            //}
            //Console.WriteLine();

            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here

            int n = array.Length;
            int min = int.MaxValue;
            int index = -1;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0 && array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            if (index == -1)
            {
                answer = new int[n];
                for (int i = 0; i < n; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[n - 1];
                for (int i = 0; i < index; i++)
                {
                    answer[i] = array[i];
                }
                for (int i = index+1; i < n; i++)
                {
                    answer[i-1] = array[i];
                }
            }

            // 0 1 2 3 4 5 6 7 8 9
            // 0 1 2 4 5 6 7 8 9

            //for (int i = 0; i < answer.Length; i++)
            //{
            //    Console.Write(answer[i] + " ");
            //}
            //Console.WriteLine();

            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here

            int n = array.Length;
            double sum = 0;
            double sr = 0;

            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }
            sr = sum / n;
            for (int i = 0; i < n; i++)
            {
                array[i] -= sr;
            }

            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            Console.Write("A = ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.Write("B = ");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i] + " ");
            }
            Console.WriteLine();

            int na = A.Length;
            int nb = B.Length;
            int n = na;
            if (na > nb)
                n = nb;
            int c = 0;

            for (int i = 0; i < n; i++)
            {
                c = A[i] * B[i];
                sum += c;
                c = 0;
            }

            Console.WriteLine(sum);
            
            // ???

            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here

            int n = array.Length;
            double sum = 0;
            double sr = 0;
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }
            sr = sum / n;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < sr)
                {
                    index++;
                }
            }
            indexes = new int[index];
            for (int i = 0, i2 = 0; i < n; i++)
            {
                if (array[i] < sr)
                {
                    indexes[i2] = i;
                    i2++;
                }
            }

            //Console.Write("array = ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            //Console.Write("indexes = ");
            //for (int i = 0; i < indexes.Length; i++)
            //{
            //    Console.Write(indexes[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here

            int n = array.Length;
            int s = 0;
            int l = 1;

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] == array[i+1])
                {
                    l++;
                }
                else
                {
                    l = 1;
                }
                if (count < l)
                {
                    count = l;
                }
            }

            l = 1;
            
            for (int i = 0; i < n-1; i++)
            {
                if (Math.Sign(array[i+1] - array[i]) == Math.Sign(array[i] - array[i+1]))
                {
                    l++;
                }
                else
                {
                    l = 1;
                }

                if (count < l)
                {
                    count = l;
                }
            }
            if (n <= 1)
            {
                count = n;
            }

            Console.Write(count);
            Console.WriteLine();

            //??????????????????????????????????????

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here

            int n = array.Length;
            answer = new int[n * 2];
            for (int i = 0; i < n; i++)
            {
                answer[2 * i] = array[i];
                answer[2 * i + 1] = array[i];
            }

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here

            int n = array.Length;
            double min = int.MaxValue;
            double max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            if (max != min)
            {
                normalized = new double[n];
                for (int i = 0; i < n; i++)
                {
                    normalized[i] = (array[i] - min) / (max - min);
                }

            }

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here

            index = -1;
            int n = array.Length;
            int a = 0;
            int left = 0;
            int right = n;
            int mid = n/2;

            for (int i = 1; i < n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        a = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = a;
                    }
                }
            }

            for (int i = 0; i <= Math.Log2(n); i++)
            {
                if (array[mid] < P)
                {
                    left = mid;
                    mid = (left + right) / 2;
                }
                else if (array[mid] > P)
                {
                    right = mid;
                    mid = (right + left) / 2;
                }
                else
                {
                    index = mid;
                    break;
                }
            }

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(index);
            //Console.WriteLine(P);

            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here

            int n = (c - a + b) / b;
            if (a < c && b > 0 || a > c && b < 0 || a == b && b == c)
            {
                array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = b * i + a;
                }
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            int n = magazine.Length;
            int max = int.MinValue;
            int index = 0;
            bool f = true;

            if (n <= 3)
            {
                f = false;
                indexes = new int[n];
                for (int i = 0; i < n; i++)
                {
                    indexes[i] = i;
                }
            }
            for (int i = 1; i < n - 1 && f; i++)
            {
                if (magazine[i - 1] + magazine[i] + magazine[i + 1] > max)
                {
                    max = magazine[i - 1] + magazine[i] + magazine[i + 1];
                    index = i;
                }
            }
            if (n > 3)
            {
                indexes = new int[3];
                indexes[0] = index - 1;
                indexes[1] = index;
                indexes[2] = index + 1;
            }

            // end

            return indexes;
        }
    }
}

