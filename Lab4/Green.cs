namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
            }
            double average = sum / count;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    array[i] = average;
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int negativeIndex = 0;
            for (int i = 0; i < array.Length; i++) //ищем индекс первого отриц. эл-та
            {
                if (array[i] < 0)
                {
                    negativeIndex = i;
                    break;
                }
            }

            for (int i = 0; i < negativeIndex; i++) //перебираем до этого индекса
                sum += array[i]*array[i];
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max = array[0];
            int min = array[0];
            int indexMax = 0;
            int indexMin = 0;
            
            for (int i = 0; i < array.Length; i++) //нашли максимальный и минимальный элементы, а также их индексы
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexMax = i;
                }
                
                if (array[i] < min)
                {
                    min = array[i];
                    indexMin = i;
                }
            }

            int startIndex = Math.Min(indexMax, indexMin); //учли ситуацию, когда мин. и макс. индекс идут в разном порядке
            int endIndex = Math.Max(indexMax, indexMin);

            int countNegatives = 0;
            
            for (int i = startIndex + 1; i < endIndex; i++) //считали количество отрицательных элементов
            {                                               //startIndex + и i < ( а не <=) так как не учитываем границы
                if (array[i] < 0)
                    countNegatives++;
            }

            negatives = new int[countNegatives]; //создали пустой список от количества отрицательных элементов

            int indexNegative = 0; //индекс для нового массива
            
            for (int i = startIndex + 1; i < endIndex; i++) //перебираем в старом массиве от начального до конечного индекса
            {                                               //startIndex + и i < ( а не <=) так как не учитываем границы
                if (array[i] < 0) 
                {
                    negatives[indexNegative] = array[i]; //записываем в новый массив элемент из старого в ячейку с номером indexNegative
                    indexNegative++; //переходим на следующую ячейку
                }
            }
                
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            //ищем максимальный элемент и его индекс
            int max = array[0];
            int indexMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexMax = i;
                }
            }
           
            //ищем первый отрицательный элемент
            int firstNegativeIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    firstNegativeIndex = i;
                    break;
                }
            }
            
            if (firstNegativeIndex >= 0) //если в массиве есть отрицательные числа, то firstNegativeIndex меняется и цикл работает, иначе ничего не происходит
            {
                int temporary = array[indexMax];
                array[indexMax] = array[firstNegativeIndex];
                array[firstNegativeIndex] = temporary;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int maxElement = array[0];
            for (int i = 0; i < array.Length; i++) //ищем максимум
            {
                if (array[i] > maxElement)
                    maxElement = array[i];
            }

            //ищем количество максимальных элементов
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxElement)
                    count++;
            }
            
            //answer становится длины count
            answer = new int[count];

            //answerIndex это позиция в массиве answer
            int answerIndex = 0; 
            
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] == maxElement) //если элемент из старого списка является максимальным
                {
                    answer[answerIndex] = i; //в списке answer мы его кладем под номером answerIndex
                    answerIndex++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here

            // end

        }
        public void Task7(int[] array)
        {

            // code here

            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here

            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here

            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here

            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here

            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here

            // end

            return wins;

        }
    }
}