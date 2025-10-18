namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            if (vector == null || vector.Length == 0)
                return 0;
            
            double sumOfSquares = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sumOfSquares += vector[i] * vector[i];
            }
            
            length = Math.Sqrt(sumOfSquares);
            // end

            return length;
        }

        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            if (array == null || array.Length == 0)
                return 0;
            
            int lower = Math.Min(P, Q);
            int upper = Math.Max(P, Q);
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > lower && array[i] < upper)
                {
                    count++;
                }
            }
            // end

            return count;
        }

        public void Task3(int[] array)
        {
            // code here
            if (array == null || array.Length < 2)
                return;
            
            // إيجاد الفهرس الأقصى
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            
            // إذا كان العنصر الأقصى هو الأخير، لا شيء لتغييره
            if (maxIndex >= array.Length - 1)
                return;
            
            // إيجاد الحد الأدنى بعد الأقصى
            int minAfterMaxIndex = maxIndex + 1;
            for (int i = maxIndex + 2; i < array.Length; i++)
            {
                if (array[i] < array[minAfterMaxIndex])
                {
                    minAfterMaxIndex = i;
                }
            }
            
            // التبديل
            int temp = array[maxIndex];
            array[maxIndex] = array[minAfterMaxIndex];
            array[minAfterMaxIndex] = temp;
            // end
        }

        public void Task4(int[] array)
        {
            // code here
            if (array == null || array.Length == 0)
                return;
            
            int maxEvenIndex = 0;
            bool found = false;
            
            // البحث في الفهارس الزوجية فقط
            for (int i = 0; i < array.Length; i += 2)
            {
                if (!found || array[i] > array[maxEvenIndex])
                {
                    maxEvenIndex = i;
                    found = true;
                }
            }
            
            // الاستبدال بقيمة الفهرس
            if (found)
            {
                array[maxEvenIndex] = maxEvenIndex;
            }
            // end
        }

        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            if (array == null)
            {
                index = -1;
                return index;
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    return index;
                }
            }
            
            index = -1;
            // end

            return index;
        }
    }
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

