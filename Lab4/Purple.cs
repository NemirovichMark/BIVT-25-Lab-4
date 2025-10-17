namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            int max_element_pos = 0;
            double element_sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                element_sum += array[i];
                if (array[i] > array[max_element_pos]) max_element_pos = i;
            }
            double mid = element_sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (i > max_element_pos)
                {
                    array[i] = mid;
                }
            }

            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int s = 0;
            for (int i = 0; i<array.Length; i++)
            {
                if (s == 0)
                {

                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here

            // end

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
