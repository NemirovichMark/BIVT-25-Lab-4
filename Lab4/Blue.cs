using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int sum = 0,firstneg=-1,max1=int.MinValue,n=array.Length;
            bool f = true;
            for (int i = 0; i < n; i++) {
                if (array[i] > max1)
                {
                    max1 = array[i];
                    sum = 0;
                }
                sum += array[i];
                if (f)
                {
                    if (array[i] < 0)
                    {
                        firstneg =i;
                        f = false;
                    }
                }
            }
            sum -= max1;
            if (firstneg != -1) array[firstneg] = sum;
        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = new int[array.Length+1];

            // code here
            int minindex = -1,n=array.Length,swapindex=0;
            for (int i = 0; i < n; i++)
                if (array[i] > 0)
                    minindex = i;
            if (minindex == -1)
                return array;
            for(int i = 0, a = 0; i < answer.Length; i++)
            {
                if (i != minindex)
                {
                    answer[i] = array[a];
                    a++;
                }
                else
                {
                    answer[i] = P;
                    swapindex = i;
                }
            }
            (answer[swapindex], answer[swapindex + 1]) = (answer[swapindex + 1], answer[swapindex]);
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {   
            // code here
            int min1=int.MaxValue,n=array.Length,minindex=-1;
            int[] answer = new int[n-1];
            for (int i = 0; i < n; i++)
                if (array[i] > 0 && array[i] < min1)
                { min1 = array[i];minindex = i; }
            if (minindex == -1)
                return array;
            for (int i = 0, a = 0; i < n; i++)
            {
                if (i != minindex)
                { answer[a] = array[i]; a++; }
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double sum = 0, n = array.Length;
            for (int i = 0; i < n; i++)
                sum += array[i];
            double avg = sum / n;
            for (int i = 0;i < n; i++)  
                array[i] -= avg;
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            if (A.Length != B.Length)
                return 0;

            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i] * B[i];
            }
            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            int sum = 0, cnt = 0;
            for (int i = 0;i<array.Length;i++)
                sum+= array[i];

            double avg=(double) sum/array.Length;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < avg) cnt++;
            indexes= new int[cnt];
            for (int i = 0,a=0;i<array.Length;i++)
                if (array[i] < avg) { indexes[a] = i; a++; }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            if (array.Length == 0) return 0;
            if (array.Length == 1) return 1;

            int max1 = 1;
            int inc = 1;
            int dec = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                    inc++;
                else
                    inc = 1;

                if (array[i] <= array[i - 1])
                    dec++;

                else
                    dec = 1;

                max1 = Math.Max(max1, Math.Max(inc, dec));
            }

            return max1;

        }
        public int[] Task8(int[] array)
        {
            int[] answer = new int[array.Length*2];

            // code here
            for (int i = 0,a = 0,c=0; i < answer.Length; i++)
            {
                answer[i] = array[a];
                c++;
                if(c == 2)
                {
                    c = 0;
                    a++;
                }
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int max1=int.MinValue,min1=int.MaxValue,n=array.Length;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < min1)
                    min1 = array[i];
                if (array[i] > max1) 
                    max1 = array[i];
            }
            if (min1 == max1)
                return normalized;
            normalized = new double[n];
            for (int i = 0; i < n; i++)
            {
                normalized[i] = (double)(array[i]-min1)/(max1-min1);
            }

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = -1,n=array.Length;

            // code here
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

            // code here
            
            if (b < 0)
                return null;
            int n = (c - a) / b + 1;
            if (n < 0)
                return Array.Empty<int>();
            int [] array = new int[n];
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
