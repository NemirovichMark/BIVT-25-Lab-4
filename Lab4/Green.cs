namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count += 1;
                }
            }

            double srednie = sum / count;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = srednie;
                }
            }
            // end

            //return array;

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    flag = true;
                    break;
                }
          
                sum += array[i]*array[i];
            }
            // end

            return flag ? sum: 0;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max = -100000;
            int min = 1000000;
            int max_index = 0;
            int min_index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_index = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    min_index = i;
                }
            }
            int start = Math.Min(min_index, max_index);
            int end = Math.Max(max_index, min_index);
            int cnt = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    cnt++;
                }
            }
            negatives = new int[cnt];

            int index = 0;

            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[index] = array[i];
                    index++;
                }
            }

            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = -100000000;
            int min = 100000000;
            int max_index = -1;
            int min_index = -1;
            bool first = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_index = i;
                }
                if (first && array[i] < 0)
                {
                    min = array[i];
                    min_index = i;
                    first = false;
                }
            }

            if (first == false && max_index != min_index)
            {
                array[max_index] = min;
                array[min_index] = max;
            }

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;
            //answer.

            // code here
            int max = -100000000;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    count = 1;
                } else if (array[i] >= max)
                {
                    count += 1;
                }
            }

            answer = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[j] = i;
                    j += 1;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = -100000000;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int j = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += j;
                    j += 1;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = -100000000;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    count = 1;
                }
                else if (array[i] >= max)
                {
                    count += 1;
                }
            }

            int[] answer = new int[count];
            int sum = 0;
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[j] = sum;
                    j += 1;
                }
                sum += array[i];
            }

            j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] = answer[j];
                    j += 1;
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;
            int current = 1;
            length = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    current++;
                    if (current > length)
                    {
                        length = current;
                    }
                }
                else
                {
                    current = 1;
                }
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {
            // code here
            if (array == null || array.Length <= 2)
                return;

            List<int> sp = new List<int>();
            for (int i = 0; i < array.Length; i += 2)
            {
                sp.Add(array[i]);
            }

            sp.Sort();
            int index = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = sp[index];
                index++;
            }
            // end
        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            if (array == null || array.Length == 0)
            {
                cleared = new int[0];
                return cleared;
            }

            List<int> result = new List<int>();
            HashSet<int> viddeli = new HashSet<int>();

            foreach (int num in array)
            {
                if (!viddeli.Contains(num))
                {
                    result.Add(num);
                    viddeli.Add(num);
                }
            }

            cleared = result.ToArray();
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            if (n <= 1) return null;
            if (a == b) return null;

            A = new double[n];
            double step = (n == 1) ? 0.0 : (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }

            double sum = 0.0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    count++;
                }
            }

            if (count == 0) return new double[0];

            double avgPos = sum / count;

            var listB = new System.Collections.Generic.List<double>();
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > avgPos)
                    listB.Add(A[i]);
            }

            B = listB.ToArray();
            return B;
        }

        public int Task12(int[] dices)
        {
            if (dices == null || dices.Length == 0) return 0;

            int n = dices.Length;
            int wins = 0;

            int box = 0;
            int[] player = new int[n];
            for (int i = 0; i < n; i++)
            {
                player[i] = dices[i] - box;
                if (player[i] < 1) player[i] = 1;

                if (dices[i] == 6) box++;
            }

            for (int i = 0; i < n; i++)
            {
                int val = 6 - i;
                if (val < 1) val = 1;

                if (player[i] > val) wins++;
            }

            return wins;
        }

    }
}