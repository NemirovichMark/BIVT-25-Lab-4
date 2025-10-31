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
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > 0 && array[i] < Minimal)
                {
                    Minimal = array[i];
                }
            }
            System.Console.WriteLine("----");
            System.Console.WriteLine(Minimal);
            if (Minimal != int.MaxValue)
            {
                bool finded = false;
                answer = new int[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] == Minimal && !finded)
                    {
                        finded = true;
                        if (i + 1 <= array.Length - 1)
                        {
                            answer[i] = array[i + 1];
                        }
                        continue;
                    }
                    if (!finded)
                    {
                        answer[i] = array[i];
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
            double summ = 0;
            double sr;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            sr = (double)summ / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] - sr;
            }

            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if(A.Length == B.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    sum += A[i] * B[i];
                }
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double summ = 0;
            double sr;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            sr = (double)summ / array.Length;
            int indexeslen = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    indexeslen++;
                }
            }
            indexes = new int[indexeslen];
            int cur = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < sr)
                {
                    System.Console.WriteLine(i);
                    indexes[cur] = i;
                    cur++;
                }
            }

            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int tmp = 1;
            int tmpz = 1;
            count = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    tmp++;
                    tmpz = 1;
                }
                else if (array[i] < array[i - 1])
                {
                    tmpz++;
                    tmp = 1;
                }
                else
                {
                    tmp++;
                    tmpz++;
                }

                count = Math.Max(count, Math.Max(tmp, tmpz));
            }

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length * 2];
            int curr = 0;
            for (int i = 0; i < answer.Length; i += 2)
            {
                answer[i] = array[curr];
                answer[i + 1] = array[curr];
                curr++;

            }

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            double minn = double.MaxValue;
            double maxx = double.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minn) minn = array[i];
                if (array[i] > maxx) maxx = array[i];
            }

            if (minn == maxx) return null;

            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (array[i] - minn) / (maxx - minn);
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            int n=array.Length;
            for (int i = 0; i < n - 1; i++){
                for (int j = 1; j < n - i; j++) {
                    if (array[j] < array[j - 1])
                        (array[j], array[j - 1]) = (array[j - 1], array[j]);
                }
            }
            int left=0,right=n-1,mid;
            while (left <= right) {
                mid=left+(right-left)/2;
                if (array[mid] == P) 
                    return mid;
                else if (array[mid] < P) 
                    left = mid + 1;
                else 
                    right = mid-1;
            }

            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b < 0)
                return null;
            int n = (c - a) / b + 1;
            if (n < 0)
                return Array.Empty<int>();
            array = new int[n];
            for (int i =a,j=0;i <= c; i += b,j++)
                array[j] = i;

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int max1 = int.MinValue,n=magazine.Length;
            if (n <= 3)
            {
                indexes = new int[n];
                for (int i = 0; i < n; i++)
                    indexes[i] = i;
                return indexes;
            }
            
            indexes = new int[3];
            for (int i = 1; i < n - 1; i++)
                if (magazine[i - 1] + magazine[i] + magazine[i + 1] > max1) 
                { 
                    indexes = [ i - 1, i, i + 1 ];
                    max1 = magazine[i - 1] + magazine[i] + magazine[i + 1];
                }

            // end

            return indexes;
        }
    }
}