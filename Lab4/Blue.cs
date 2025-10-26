using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int maxElement = array[0];

            int indexMaxElement = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    indexMaxElement = i;
                }
            }
            
            int sum = 0;

            for (int i = indexMaxElement + 1; i < array.Length; i++)
            {
                sum += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = sum;
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            //индекс последнего положительного элемента
            int lastPositiveElementIndex = -1; //-1 как индикатор отсутствия положительных элементов 
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    lastPositiveElementIndex = i;
            }

            //если нет положительных элементов, возвращаем
            //копию исходного массива
            if (lastPositiveElementIndex == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }

                return answer;
            }
            
            answer = new int[array.Length + 1];
            //копируем элементы до последнего положительного
            for (int i = 0; i <= lastPositiveElementIndex; i++)
            {
                answer[i] = array[i];
            }
            
            answer [lastPositiveElementIndex + 1] = P;

            // -1 -2 -3 4 -5 -6 -7 исходный
            // -1 -2 -3 4  0 -5 -6 -7answer
            for (int i = lastPositiveElementIndex + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int indexMinPossitiveElement = -1;
            int minPossitiveElement = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < minPossitiveElement)
                {
                    minPossitiveElement = array[i];
                    indexMinPossitiveElement = i;
                }
            }
            
            if (indexMinPossitiveElement == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }

                return answer;
            }
            
            answer = new int[array.Length - 1];

            for (int i = 0; i < indexMinPossitiveElement; i++)
            {
                answer[i] = array[i];
            }

            for (int i = indexMinPossitiveElement + 1; i < array.Length; i++)
            {
                answer[i - 1] = array[i];
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here

            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here

            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here

            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here

            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            // end

            return indexes;
        }
    }
}