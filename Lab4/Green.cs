namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            // Находим сумму и количество положительных элементов
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

            // Если есть положительные элементы, заменяем их средним
            if (count > 0)
            {
                double average = sum / count;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = average;
                    }
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    break;
                }
                sum += array[i] * array[i];
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            if (array == null || array.Length < 3) return new int[0];

            int maxIndex = 0, minIndex = 0;

            // Находим индексы максимального и минимального элементов
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
                if (array[i] < array[minIndex]) minIndex = i;
            }

            int start = Math.Min(maxIndex, minIndex);
            int end = Math.Max(maxIndex, minIndex);

            // Считаем количество отрицательных элементов между ними
            int count = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0) count++;
            }
            // Формируем массив отрицательных элементов
            negatives = new int[count];
            int index = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[index] = array[i];
                    index++;
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            int maxIndex = 0;
            int firstNegativeIndex = -1;

            // Находим индекс максимального элемента и первого отрицательного
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
                if (firstNegativeIndex == -1 && array[i] < 0) firstNegativeIndex = i;
            }

            // Если нашли отрицательный элемент, меняем местами
            if (firstNegativeIndex != -1)
            {
                int temp = array[maxIndex];
                array[maxIndex] = array[firstNegativeIndex];
                array[firstNegativeIndex] = temp;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = array[0];

            // Находим максимальный элемент
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            // Считаем количество максимальных элементов
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) count++;
            }

            // Собираем индексы
            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    result[index] = i;
                    index++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            int max = array[0];

            // Находим максимальный элемент
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            // Увеличиваем максимальные элементы на их порядковые номера
            int order = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += order;
                    order++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            int max = array[0];
            // Находим максимальный элемент
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            // Заменяем максимальные элементы суммой элементов до них
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    int sum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sum += array[j];
                    }
                    array[i] = sum;
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            if (array == null || array.Length == 0) return 0;
            if (array.Length == 1) return 1;

            int currentLength = 1;
            length = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    currentLength++;
                    if (currentLength > length) length = currentLength;
                }
                else
                {
                    currentLength = 1;
                }
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length < 3) return;

            // Сортировка пузырьком для элементов с четными индексами
            for (int i = 0; i < array.Length; i += 2)
            {
                for (int j = i + 2; j < array.Length; j += 2)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            if (array == null) return new int[0];
            if (array.Length == 0) return new int[0];

            // Считаем количество уникальных элементов
            int uniqueCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique) uniqueCount++;
            }

            // Формируем массив без повторений
            cleared = new int[uniqueCount];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    cleared[index] = array[i];
                    index++;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 0) return new double[0];

            // Создаем массив A
            A = new double[n];
            if (n == 1)
            {
                A[0] = a;
            }
            else
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    A[i] = a + i * step;
                }
            }

            // Находим среднее положительных
            double sumPositive = 0;
            int countPositive = 0;
            foreach (double num in A)
            {
                if (num > 0)
                {
                    sumPositive += num;
                    countPositive++;
                }
            }

            if (countPositive == 0) return new double[0];

            double averagePositive = sumPositive / countPositive;

            // Формируем массив B
            int countB = 0;
            foreach (double num in A)
            {
                if (num > 0 && num > averagePositive) countB++;
            }

            B = new double[countB];
            int index = 0;
            foreach (double num in A)
            {
                if (num > 0 && num > averagePositive)
                {
                    B[index] = num;
                    index++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            if (dices == null || dices.Length == 0) return 0;

            // Применяем прокатку
            int[] adjusted = new int[dices.Length];
            Array.Copy(dices, adjusted, dices.Length);

            for (int i = 0; i < adjusted.Length; i++)
            {
                if (adjusted[i] == 6)
                {
                    for (int j = i + 1; j < adjusted.Length; j++)
                    {
                        if (adjusted[j] > 1) adjusted[j]--;
                    }
                }
            }

            // Считаем победы против шулера (все кубики = 6)
            foreach (int dice in adjusted)
            {
                if (dice > 6) wins++;
            }
            // end

            return wins;

        }
    }
}
