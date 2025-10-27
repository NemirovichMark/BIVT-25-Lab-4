using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Xml;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            // code here
            double summ = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                    summ += array[i];
                }
            }
            summ = summ / count;
            for (int i  = 0; i< array.Length; i++)
            {
                if (array[i] > 0) { array[i] = summ;} ;
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            {

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0) 
                    { 
                        return sum; 
                    }
                    sum += array[i] * array[i];
                }
                
                return 0;
            }

            // end

            return sum;
        }

        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            int max = int.MinValue;
            int min = int.MaxValue;
            int maxIndex = -1;
            int minIndex = -1;
            int LenOfNegatives = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            if (minIndex > maxIndex)
            {
                for (int i = maxIndex + 1; i < minIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        LenOfNegatives++;
                    }
                }
            }
            else
            {
                for (int i = minIndex + 1; i < maxIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        LenOfNegatives++;
                    }
                }
            }
            if (LenOfNegatives == 0)
            {
                return new int[0];
            }
            negatives = new int[LenOfNegatives];
            if (minIndex > maxIndex)
            {
                for (int i = maxIndex + 1, j = 0; i < minIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[j] = array[i];
                        j++;
                    }
                }
            }
            else
            {
                for (int i = minIndex + 1, j = 0; i < maxIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[j] = array[i];
                        j++;
                    }   
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            {
                int index_max = 0;
                int index_negative = -1; 
                int max_n = array[0]; 
                
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max_n)
                    {
                        max_n = array[i];
                        index_max = i;
                    }
                }
                
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        index_negative = i;
                        break; 
                    }
                }
                
                if (index_negative != -1)
                {
                    int temp = array[index_max];
                    array[index_max] = array[index_negative];
                    array[index_negative] = temp;
                }
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            {
                if (array == null || array.Length == 0)
                    return new int[0];

                // code here
                int max_n = array[0];
                int count = 1;
    
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max_n)
                    {
                        max_n = array[i];
                        count = 1;
                    }
                    else if (array[i] == max_n)
                    {
                        count++;
                    }
                }
    
                answer = new int[count];
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == max_n)
                    {
                        answer[j] = i;
                        j++;
                    }
                }
                
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {
            // code here
                    {
                        
                        int max_n = array[0];
                        for (int i = 1; i < array.Length; i++)
                        {
                            if (array[i] > max_n)
                            {
                                max_n = array[i];
                            }
                        }
                        
                        int orderNumber = 1;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == max_n)
                            {
                                array[i] += orderNumber;
                                orderNumber++;
                            }
                        }
                    }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            {
                
                int max_n = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max_n)
                    {
                        max_n = array[i];
                    }
                }
                
                int[] sums = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == max_n)
                    {
                        int sum = 0;
                        for (int j = 0; j < i; j++)
                        {
                            sum += array[j];
                        }
                        sums[i] = sum;
                    }
                }
                
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == max_n)
                    {
                        array[i] = sums[i];
                    }
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int currentLength = 1;
            for (int i = 0; i < (array.Length - 1); i++)
            {
                if (array[i] > array[i + 1])
                {
                    currentLength++;
                    if (currentLength > length)
                    {
                        length = currentLength;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }
            if (length == 0)
            {
                length = 1;
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length - 2; i+=2)
            {
                for (int j = 0; j < array.Length - 2 - i; j+=2)
                {
                    if (array[j] > array[j + 2])
                    {
                        int temp = array[j];
                        array[j] = array[j + 2];
                        array[j + 2] = temp;
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;
            // code here

                cleared = new int[0];
    
                for (int i = 0; i < array.Length; i++)
                {
                    bool isDuplicate = false;
                    for (int j = 0; j < cleared.Length; j++)
                    {
                        if (array[i] == cleared[j])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    if (!isDuplicate)
                    {
                        int[] newCleared = new int[cleared.Length + 1];
                        for (int k = 0; k < cleared.Length; k++)
                        {
                            newCleared[k] = cleared[k];
                        }
                        newCleared[cleared.Length] = array[i];
                        cleared = newCleared;
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
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }

            double sum = 0; int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i]; cnt++;
                }
            }
            if (cnt == 0)
            {
                return System.Array.Empty<double>();
            }

            double avg = sum / cnt;
            int k = 0;
            for (int i = 0; i < n; i++)
                if (A[i] > 0 && A[i] > avg)
                {
                    k++;
                }

            B = new double[k];
            int pos = 0;
            for (int i = 0; i < n; i++)
                if (A[i] > 0 && A[i] > avg)
                {
                    B[pos++] = A[i];
                }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int n = dices.Length;

            int s = 0;
            int[] mine = new int[n];
            for (int i = 0; i < n; i++)
            {
                int a = dices[i] - s;
                if (a < 1) a = 1;
                mine[i] = a;

                if (dices[i] == 6) s++;
            }
            for (int i = 0; i < n; i++)
            {
                int e = 6 - i;
                if (e < 1) e = 1;
                if (mine[i] > e) wins++;
            }
            // end

            return wins;

        }
    }
}
