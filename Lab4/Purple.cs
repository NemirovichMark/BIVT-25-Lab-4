namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            double sum = 0;
            double maxElement = array[0];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    index = i;
                }
            }

            double average = sum / array.Length;

            for (int i = index + 1; i < array.Length; i++)
                array[i] = average;
        }

        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            int lenOfFirst = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;
            even = new int[lenOfFirst];
            odd = new int[array.Length - lenOfFirst];

            int evenI = 0;
            int oddI = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[evenI] = array[i];
                    evenI++;
                }
                else
                {
                    odd[oddI] = array[i];
                    oddI++;
                }
            }
            
            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            

            return answer;
        }
        public void Task4(int[] array)
        {
            int countOfNegative = 0;
            
            int[] copy = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    countOfNegative++;
                
                copy[i] = array[i];
            }
            
            int[] negativeElements = new int[countOfNegative];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativeElements[j] =  array[i];
                    j++;
                }
            }
            
            for (int i = 0; i < array.Length; i++)
                array[i] = 0;

            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (copy[i] >= 0)
                {
                    array[k] = copy[i];
                    k++;
                }
            }

            for (int i = 0; i < negativeElements.Length; i++)
            {
                array[k] = negativeElements[i];
                k++;
            }
            
        }
        
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here

            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here

            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here

            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here

            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here

            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here

            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here

            // end

            return (bright, normal, dim);
        }
    }
}