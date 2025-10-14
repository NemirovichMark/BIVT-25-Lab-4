using System.Runtime.InteropServices;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            // code here

            var avg = 0.0;
            var max_item = array[0];
            var max_item_index = array.Length;

            foreach (var item in array)
            {
                max_item = Math.Max(max_item, item);
                avg += item;
            }
            avg /= array.Length;

            for (var i = 0; i < array.Length; i += 1) if (array[i] == max_item)
                {
                    max_item_index = i;
                    break;
                }

            for (var i = max_item_index + 1; i < array.Length; i += 1) array[i] = avg;

            // end
        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;
            // code here

            even = new int[(array.Length >> 1) + (array.Length % 2)];
            odd = new int[array.Length >> 1];
            var selector = new int[][] { even, odd };
            for (var i = 0; i < array.Length; i += 1) selector[i % selector.Length][i >> 1] = array[i];

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