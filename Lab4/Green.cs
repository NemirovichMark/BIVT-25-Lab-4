namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;

            double sum = 0;
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    k++;
                }
            }

            if (k == 0) return;

            double avg = sum / k;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = avg;
                }
            }
            // end
        }

        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            if (array == null || array.Length == 0) return 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) break;
                sum += array[i] * array[i];
            }
            // end

            return sum;
        }

        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            if (array == null || array.Length == 0) return null;

            int maxI = 0, minI = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxI]) maxI = i;
                if (array[i] < array[minI]) minI = i;
            }

            int left = System.Math.Min(maxI, minI);
            int right = System.Math.Max(maxI, minI);

            int count = 0;
            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0) count++;
            }

            if (count == 0) return System.Array.Empty<int>();

            negatives = new int[count];
            int j = 0;
            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    negatives[j] = array[i];
                    j++;
                }
            }
            // end

            return negatives;
        }

        public void Task4(int[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;

            int maxI = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxI]) maxI = i;
            }

            int negI = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negI = i;
                    break;
                }
            }

            if (negI == -1) return;

            int t = array[maxI];
            array[maxI] = array[negI];
            array[negI] = t;
            // end
        }

        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0) return null;

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) count++;
            }

            answer = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[j] = i;
                    j++;
                }
            }
            // end

            return answer;
        }

        public void Task6(int[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            int add = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += add;
                    add++;
                }
            }
            // end
        }

        public void Task7(int[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    int sum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sum += array[j];
                    }
                    array[i] = sum;
                }
            }
            // end
        }

        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            if (array == null || array.Length == 0) return 0;

            int cur = 1;
            int max = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i]) cur++;
                else cur = 1;
                if (cur > max) max = cur;
            }

            length = max;
            // end

            return length;
        }

        public void Task9(int[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;

            int count = (array.Length + 1) / 2;
            int[] even = new int[count];
            int k = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                even[k] = array[i];
                k++;
            }

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (even[i] > even[j])
                    {
                        int t = even[i];
                        even[i] = even[j];
                        even[j] = t;
                    }
                }
            }

            k = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = even[k];
                k++;
            }
            // end
        }

        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            if (array == null || array.Length == 0) return null;

            int n = array.Length;
            int[] temp = new int[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                bool same = false;
                for (int j = 0; j < count; j++)
                {
                    if (array[i] == temp[j])
                    {
                        same = true;
                        break;
                    }
                }
                if (!same)
                {
                    temp[count] = array[i];
                    count++;
                }
            }

            cleared = new int[count];
            for (int i = 0; i < count; i++)
            {
                cleared[i] = temp[i];
            }
            // end

            return cleared;
        }

        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 1) return null;

            A = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }

            double sum = 0;
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    k++;
                }
            }

            if (k == 0) return System.Array.Empty<double>();

            double avg = sum / k;

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > avg) count++;
            }

            B = new double[count];
            int c = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > avg)
                {
                    B[c] = A[i];
                    c++;
                }
            }
            // end

            return B;
        }

        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            if (dices == null || dices.Length == 0) return 0;

            int[] me = new int[dices.Length];
            for (int i = 0; i < dices.Length; i++)
            {
                me[i] = dices[i];
            }

            for (int i = 0; i < me.Length; i++)
            {
                if (me[i] == 6)
                {
                    for (int j = i + 1; j < me.Length; j++)
                    {
                        me[j] = System.Math.Max(1, me[j] - 1);
                    }
                }
            }

            for (int i = 0; i < me.Length; i++)
            {
                if (me[i] > 6) wins++;
            }
            // end

            return wins;
        }
    }
}
