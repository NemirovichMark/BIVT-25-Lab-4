using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int max = array[0];
            int index = 0;
            int first = 0;
            bool flag = false;
            for (int i=0; i<array.Length;i++ ) {
                if ( max < array[i])
                {
                    max = array[i];
                    index = i;
                }

                if (array[i] < 0 && !flag )
                {
                    first = i;
                    flag = true;
                }
            }
            
            int sum = 0;
            for (int i = index + 1; i < array.Length && flag; i++)
            {
                sum += array[i];
            }
            if (flag)
                array[first] = sum;
            
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            // code here
            int index = -1; 
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0) {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                int[] answer = new int[array.Length + 1];
                int j = 0;
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i <= index)
                        answer[i] = array[i];
                    if (i == index)
                    {
                        answer[i + 1] =  P;
                        i++;
                        j = i;
                    } else if (i > index)
                    {
                        answer[i] = array[j];
                        j++;
                    }
                }
                return answer;
            }
            
            return array;

            // end

         
        }
        public int[] Task3(int[] array)
        {

            // code here


            int index = -1;
            int min = Int32.MaxValue;; 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 &&  array[i]<min  )
                { 
                    min = array[i];
                    index = i;
                }
                
            }
            
            int[] answer = new int[array.Length - 1];
            
            if (index != -1)
            {
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i < index)
                        answer[i] = array[i];
                    else if (i == index)
                        j = i;
                    else
                    {
                        answer[j] = array[i];
                        j++;
                    }
                }

                return answer;
            }

            return array;
            // end

         }
        public void Task4(double[] array)
        {

            // code here
            
            double sum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sum /= array.Length;
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i]  -=  sum;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here

            if (A.Length != B.Length)
                return 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i] * B[i];
            }
            
            return sum;
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            

            // code here
            double sum = 0;
            
            for (int i=0; i<array.Length; i++)
                    sum += array[i];
            
            if (array.Length != 0)
            {    
                sum /= (double)array.Length;
            }
            
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sum)
                    count++;
            }
            
            int[] indexes = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sum)
                {
                    indexes[j] = i;
                    j++;
                }
            }
            return indexes;
            
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            if (array.Length == 0)
                return 0;
            if (array.Length == 1)
                return 1;
            if (array.Length > 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int temp = 1;
                    bool rise = false;
                    bool fall = false; 
                    for (int j = i; j < array.Length - 1; j++)
                    {
                        if (array[j] == array[j + 1]) {
                            temp++;
                        } 
                        else if (array[j] > array[j + 1] && !fall)
                        {
                            rise = true;
                            temp++;
                        } 
                        else if (array[j] < array[j + 1] && !rise)
                        {
                            fall = true;
                            temp++;
                        }
                        else
                            break;
                    }

                    if (count < temp)
                        count = temp;
                }
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            

            // code here
            int[] answer = new int[array.Length * 2];
            int j = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = array[j];
                if (i + 1 != answer.Length)
                    answer[i + 1] = array[j];
                j++;
                i++;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {

            // code here
            double min = array[0];
            double max = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            
            if (min == max)
            {
                return null;
            }
            
            double[] normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (array[i] - min) / (max - min);
            }
            
            return normalized;
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }

            int left = 0;
            int right = array.Length - 1;
            index = -1; 

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P)
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

            // code here
            int count = 0;
            int value = a;
            if (b < 0)
                return null;
            if (a > c)
                return new int[0];
            for (int x = a; x <= c; x += b)
                count++;
            
            array = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
                value += b;
            }
            
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int len =  magazine.Length;
            if (len <= 3)
            {
                indexes = new int[len];
                for (int i = 0; i < len; i++)
                    indexes[i] = i;
                return indexes;
                
            }
            
            int sum =magazine[0] + magazine[1] + magazine[2];
            
            indexes = new int[3]{0,1,2};

            for (int i = 1; i < len - 2; i++)
            {
                int newSum = magazine[i] + magazine[i + 1] + magazine[i + 2];
                
                if (newSum> sum)
                {
                    sum = newSum;
                    indexes[0] = i;
                    indexes[1] = i + 1;
                    indexes[2] = i + 2;
                }
            }
            // end

            return indexes;
        }
    }
}