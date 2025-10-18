using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            if (vector == null || vector.Length == 0)
                return 0;

            double sumOfSquares = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sumOfSquares += vector[i] * vector[i];
            }

            double answer = Math.Sqrt(sumOfSquares);
            return answer;
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0)
                return 0;

            int count = 0;
            int lower = Math.Min(P, Q);
            int upper = Math.Max(P, Q);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > lower && array[i] < upper)
                {
                    count++;
                }
            }

            int answer = count;
           
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length < 2)
                return array;

            // Находим индекс максимального элемента
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            // Если максимальный элемент последний - изменений не производить
            if (maxIndex >= array.Length - 1)
                return array;

            // Находим минимальный элемент после максимального
            int minAfterMaxIndex = maxIndex + 1;
            for (int i = maxIndex + 2; i < array.Length; i++)
            {
                if (array[i] < array[minAfterMaxIndex])
                {
                    minAfterMaxIndex = i;
                }
            }

            // Меняем местами максимальный и минимальный после него
            int temp = array[maxIndex];
            array[maxIndex] = array[minAfterMaxIndex];
            array[minAfterMaxIndex] = temp;
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return array;

            // Находим максимальный элемент среди элементов с четными индексами
            int maxEvenIndex = 0;
            bool found = false;

            for (int i = 0; i < array.Length; i += 2)
            {
                if (!found || array[i] > array[maxEvenIndex])
                {
                    maxEvenIndex = i;
                    found = true;
                }
            }

            // Заменяем максимальный элемент значением его индекса
            if (found)
            {
                array[maxEvenIndex] = maxEvenIndex;
            }
            return array;
            // end
            

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here

            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here

            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here

            // end

        }
        public void Task9(int[] array)
        {

            // code here

            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here

            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here

            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here

            // end

            return restored;
        }
    }

}
