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
            int firstNegativeIndex = -1; //начинаем с -1 чтобы затем сделать проверку на существование отрицательных элементов
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
                int temporary = array[indexMax]; //временная переменная
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
            int maxElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                    maxElement = array[i];
                    
            }
            
            int number = 1; //порядковый номер
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxElement)
                {
                    array[i] += number; // прибавляем к макс. элементу его порядковый номер
                    number++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int maxElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                    maxElement = array[i];
            }
            
            int [] prefixSum = new int [array.Length];
            prefixSum[0] = 0;
            //перебираем с 1 так как сумма элементов до первого элемента равна 0
            for (int i = 1; i < array.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + array[i - 1];
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxElement)
                {
                    array[i] = prefixSum[i];
                }
            }
            
            //1     2     3    4    2       1      4     1   
            //0     1     3    6    10      12     13    17
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            
            //количество убывающих элементов
            int count = 1;
            
            //максимальное количество убывающих элементов
            int maxCount = 1;
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    count++;
                    if (count > maxCount)
                        maxCount = count;
                }
                else
                    count = 1;
            }
            length = maxCount;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            //длина массива четных индексов
            int evenElementLength = (array.Length + 1)/2;
            
            int[] evenElements = new int[evenElementLength];
            
            int index = 0; //индекс элемента из evenElements
            
            for (int i = 0; i < array.Length; i += 2 )
            {
                    evenElements[index] = array[i];
                    index++;
            }

            int temprorary = 0; //временная переменная
            //просто идеи до конца списка
            for (int i = 0; i < evenElements.Length; i++)
            {
                //а тут попарно сравниваем по два элемента и максимальный сдвигаем вправо
                for (int j = 0; j < evenElements.Length - 1; j++)
                {
                    if (evenElements[j] > evenElements[j + 1])
                    {
                        //Меняем элементы местами
                        temprorary = evenElements[j];
                        evenElements[j] = evenElements[j + 1];
                        evenElements[j + 1] = temprorary;
                    }
                }
                // Если на каком-то проходе не было обменов, массив отсортирован
            }
            //возвращение отсортированных элементов
            for (int i = 0; i < evenElements.Length; i ++)
            {
                array[i*2] = evenElements[i];
            }

            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int count = 0;
            //список неповторяющихся элементов
            int [] resultList = new int [array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                bool dublicated = false;
                for (int j = 0; j < count; j++)
                {
                    if (resultList[j] == array[i])
                    {
                        dublicated = true;
                        break;
                    }
                }
                
                if (dublicated == false)
                {
                    resultList[count] = array[i];
                    count++;
                }
            }
            cleared =  new int[count];
            for (int i = 0; i < count; i++)
            {
                cleared[i]= resultList[i];
            }
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