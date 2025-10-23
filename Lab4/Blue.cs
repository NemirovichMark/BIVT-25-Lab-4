using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int summa = 0;
            int mx_ind = 0;
            int max = int.MinValue;
            int len = array.Length;
            for (int i = 0; i < len; i++) {
                if (max < array[i])
                {
                    max = array[i];
                    mx_ind = i;
                }
            }
            if (mx_ind < len - 1)
            {
                for (int i = mx_ind + 1; i < len; i++) {
                    summa += array[i];
                }
            }
            for (int i = 0; i < len; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = summa;
                    break;
                }

            }
            
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            //int[] answer = null;

            int len = array.Length;
            var answer = new int[len + 1];
            int ind = -1;
            for(int i = 0; i < len; i++)
            {
                if (array[i] > 0)
                    ind = i;
            }
            if (ind == -1)
                return array;
            for (int i =0; i <= ind; i++)
            {
                answer[i] = array[i];
            }
            answer[ind + 1] = P;
            for (int i = ind + 1; i < len; i++)
            {
                answer[i+1] = array[i];
            }


               
                // code here

                // end

                return answer;
        }
        public int[] Task3(int[] array)
        {
            //int[] answer = null;
            
            // code here
            int ind = -1, minim = int.MaxValue;
            
            int len = array.Length;
            var answer = new int[len - 1];
            for (int i = 0; i < len; i++)
            {
                if (array[i] < minim && array[i] > 0)
                {
                    minim = array[i];
                    ind = i;
                }
            }
            if (ind == -1)
                return array;
            for (int i = 0; i < ind; i++)
            {
                answer[i] = array[i];
            }
            for (int i = ind + 1; i < len; i++)
            {
                answer[i-1] = array[i];
            }
            
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double len = array.Length, sred = 0, summa = 0;
            for (int i = 0; i < len; i++)
            {
                summa += array[i];
            }
            sred = summa / len;
            for (int i = 0; i < len; i++)
            {
                array[i] = array[i] - sred;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            if (A.Length != B.Length)
                return 0;
            int sum = 0, len = A.Length;

            // code here
            for (int i = 0; i < len; i++)
            {
                sum += A[i] * B[i];
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;
            double len = array.Length, summa = 0, sred = 0;
            for (int i = 0; i < len; i++)
            {
                summa += array[i];
            }
            sred = summa / len;
            int count = 0;
            for (int i = 0; i < len; i++)
            {
                if (array[i] < sred)
                    count++;
            }
            indexes = new int[count];
            int j = 0;
            for (int i = 0; i < len; i++)
            {
                if (array[i] < sred)
                {
                    indexes[j++] = i;
                    
                }
            }
           
            return indexes;
        }
        public int Task7(int[] array)
        {
            int count1 = 1, maxim1 = 1, count2 = 1, maxim2 = 1, len = array.Length;
            if (len == 0) return 0;

            for (int i = 1; i < len; i++)
            {
                if (array[i] - array[i - 1] >= 0)
                {
                    count1++;
                    if (count1 > maxim1)
                        maxim1 = count1;
                }
                else
                {
                    count1 = 1;
                }
            }
            for (int i = 1; i < len; i++)
            {
                if (array[i] - array[i - 1] <= 0)
                {
                    count2++;
                    if  (count2 > maxim2)
                        maxim2 = count2;
                }
                else
                {
                    count2 = 1;
                }
            }


            if (maxim1 > maxim2)
                return maxim1;
            else
                return maxim2;
        }
        public int[] Task8(int[] array)
        {
            int len = array.Length;
            var answer = new int[len*2];
            int ind = 0;
            for(int i = 0; i < len; i++)
            {
                answer[ind] = array[i];
                answer[++ind] = array[i];
                ind++;

            }
            return answer;
        }
        public double[] Task9(int[] array)
        {
            int len = array.Length;
            double[] normalized = new double [len];
            int min = int.MaxValue, max = int.MinValue;
            for (int i = 0; i < len; i++)
            {
                if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }
            if (min == max)
                return null;
            for (int i = 0; i < len; i++)
            {
                normalized[i] = (double)(array[i] - min) / (max - min);
            }
            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;
            int len = array.Length;
            for (int i = 0; i < len - 1; i++) 
            {
                for (int j = 0; j < len - 1; j++) 
                {
                    if (array[j] > array[j + 1])
                    {
                        int x = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = x;
                    }
                }
            }
            int left = 0, right = len - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (array[middle] == P)
                    return middle;
                else if (array[middle] < P)
                    left = middle + 1;
                else
                    right = middle - 1;

            }
            return -1;
         
            // code here

            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            if (b <= 0)
                return null;
            
            if (a > c)
                return new int[0]; 

            int count = 0;
            for (int i = a; i <= c; i += b)
            {
                count += 1;


            }

            if (count == 0)
                return new int[0];
            int[] array = new int[count];
            int ind = 0;
            for (int i = a; i <= c; i += b)
            {
                array[ind++] = i;

            }

            return array;


        }
            
        public int[] Task12(int[] magazine)
        {
            int len = magazine.Length;
            if (len <= 3)
            {
                int[] array = new int[len];
                for (int i = 0; i < len; i++)
                {
                    array[i] = i;
                }
                return array;
            }
            int max_summa_troek = 0;
            int first_ind = 0;
            for (int i =0; i<len-2; i++)
            {
                if (magazine[i] +  magazine[i+1] +  magazine[i+2] > max_summa_troek)
                {
                    max_summa_troek = magazine[i] + magazine[i+1] + magazine[i+2];
                    first_ind = i;
                }

            }
            int[] indexes = new int[3];
            int ind = 0;
            for (int i = first_ind; i <= first_ind + 2; i++)
            {
                indexes[ind++] = i;

            }
            
            

            return indexes;
        }
    }
}