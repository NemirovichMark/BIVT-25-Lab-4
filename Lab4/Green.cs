using System.Timers;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            double k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    k++;
                }
            }
            double sr = sum / k;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = sr;
                }
            }

            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code 
            int flag = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    flag = i;
                    break;
                }
            }
            for (int i = 0; i < flag; i++)
            {
                sum = sum + array[i] * array[i];
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int min = 1000000000;
            int max = -1000000000;
            int mini = 0;
            int maxi = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    mini = i;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    maxi = i;
                }

            }
            int k = 0;
            if (mini < maxi)
            {
                for (int i = mini + 1; i < maxi; i++)
                {
                    if (array[i] < 0)
                    {
                        k += 1;
                    }
                }
            }
            else if (mini > maxi)
            {
                for (int i = maxi + 1; i < mini; i++)
                {
                    if (array[i] < 0)
                    {
                        k += 1;
                    }
                }
            }
            int[] array2 = new int[k];
            int el = 0;
            Console.WriteLine(string.Join(" ", array2));
            if (mini < maxi)
            {
                for (int i = mini + 1; i < maxi; i++)
                {
                    if (array[i] < 0)
                    {
                        array2[el] = array[i];
                        el++;
                    }

                }
            }
            else if (mini > maxi)
            {
                el = 0;
                for (int i = maxi + 1; i < mini; i++)
                {
                    if (array[i] < 0)
                    {
                        array2[el] = array[i];
                        el++;
                    }

                }
            }
            negatives = array2;
            
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = -1000000000;
            int maxi = 0;
            int otri = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxi = i;
                }
            }
           
            for ( int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 )
                {
                    otri = i;
                    break;
                }
               
            }
            if (otri != -1 )
            {
                array[maxi] = array[otri];
                array[otri] = max;
            }
          
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = -10000000;
            int k = 0;
            for ( int i = 0; i < array.Length; i++)
            {
                if (array[i] > max )
                {
                    max = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    k+=1;
                }
            }
            int el = 0;
            int[] array2 = new int[k];
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i] == max)
                {
                    array2[el] = i;
                    el++;
                }
            }
            answer = array2;
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = -10000000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int k = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] +=k;
                    k += 1;
                }
            }
        }
        
        public void Task7(int[] array)
        {

            // code here
            int max = -10000000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int k = 1;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] == max)
                {
                    array[i] = sum-max;
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int len = 1;
            int max = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i + 1] < array[i])
                {
                    len += 1; 
                }
                if (len > max)
                {
                    max = len;
                }
                if (array[i + 1] >= array[i])
                {
                    len = 1;
                }

            }
            length = max;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (i % 2 == 0 && array[i] > array[j] && j % 2 == 0)
                    {
                        a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                        
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int n = array.Length;
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                bool duplicated = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        duplicated = true;
                        break;
                    }
                }
                if (!duplicated)
                {
                    cnt++;
                }
            }
            cleared = new int[cnt];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                bool duplicated = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        duplicated = true;
                        break;
                    }
                }
                if (!duplicated)
                {
                    cleared[k++] = array[i];
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 1 || a == b)
            {
                return null;
            }

            A = new double[n];
            if (n == 0 || n == 1)
            {
                return null;
            }

            A = new double[n];
            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                A[i] = a + i * step;
            }
            double summ = 0;
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    summ += A[i];
                    count++;
                }
            }
            double sr = 0;
            if (count > 0)
            {
                sr = summ / count;
            }
            int index = 0;
            int c = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > sr)
                {
                    c++;
                }
            }
            B = new double[c];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > sr)
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
            int step = 6;
            int curse = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                int pstep = Math.Max(1, dices[i] - curse);
                if (pstep > step) wins++;

                if (dices[i] == 6) curse++;

                step = Math.Max(1, step - 1);
            }


            // end

            return wins;

        }
    }
}
