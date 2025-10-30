namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double s = 0;
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s+= array[i];
                    n += 1;
                }
            }
            s /= n;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = s;
                }
            }
            

            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;
            int n = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    n = i;
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                sum += (array[i]*array[i]);
            }

            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int z = 0;
            int[] negatives = null;
            int max = -1000000;
            int min = 100000;
            int x = 0;
            int y = 0;
            

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max =  array[i];
                    x = i;
                }

                if (array[i] < min)
                {
                    min = array[i];
                    y = i;
                }
            }
            
            int start = Math.Min(x, y);
            int end = Math.Max(x, y);

            for (int i = start+1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    z += 1;
                }
            }
            
            negatives = new int[z];
            int j = 0;
            for (int i = start+1; i < end; i++)
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
            int a = -100000;
            int b = 0;
            int c = 0;
            bool flag =  false;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > a)
                {
                    a = array[i];
                    c = i;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && !flag)
                {
                    b = i;
                    flag = true;
                }
            }

            if (flag == true)
            {
                (array[c], array[b]) = (array[b], array[c]);
            }
            
            
            

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int a = -10000;
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > a)
                    a =  array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == a)
                    j++;
            }
            answer = new int[j];
            int h = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == a)
                {
                    answer[h] = i;
                    h++;
                }
            }

            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int a = -10000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > a)
                    a =  array[i];
            }

            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == a)
                {
                    array[i] += ++j;
                }
            }
            

            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int a = -10000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > a)
                    a =  array[i];
            }
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {   
                s+=array[i];
                if (array[i] == a)
                {
                    array[i] = s - array[i];
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int cur = 1, best = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i]) 
                    cur++;
                else 
                    cur = 1;
                if (cur > best) 
                    best = cur;
            }
            length = best;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int n = (array.Length + 1)/2;
            int[] chet = new int[n];
            for (int i = 0; i < n; i++)
            {
                chet[i] = array[2*i];
            }
            Array.Sort(chet);
            for (int i = 0; i < n; i++)
            {
                array[2*i] = chet[i];
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            if (array == null || array.Length == 0) return cleared = null;

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool ElIsUniq = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        ElIsUniq = false;
                        break;
                    }
                }
                if (ElIsUniq)
                {
                    count++;
                }
            }

            int index = 0;
            cleared = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                bool ElIsUniq = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        ElIsUniq = false;
                        break;
                    }
                }
                if (ElIsUniq)
                {
                    cleared[index] = array[i];
                    index++;
                }
            }

            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 1 || a == b) return B = null;
            double s = 0;
            int cnt = 0;
            double avg = 0;
            int index = 0;
            int cntBiggerthanavg = 0;


            A = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                A[i] = a + (step * i);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    s += A[i];
                    cnt++;
                }
            }
            avg = s/ cnt;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > avg)
                {
                    cntBiggerthanavg++;
                }
            }

            B = new double[cntBiggerthanavg];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > avg)
                {
                    B[index] = A[i];
                    index++;
                }
            }
            

            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int min = 0;
            int max = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                int mini = Math.Max(dices[i]-min,1);
                int maxi = Math.Max(6-max,1);
                if (mini > maxi)
                    wins++;
                if (dices[i] == 6)
                    min++;
                max++;
            }

            // end

            return wins;

        }
    }
}
