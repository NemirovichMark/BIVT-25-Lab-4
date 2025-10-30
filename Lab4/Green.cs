using System.ComponentModel.DataAnnotations;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here

            double LenArr = array.Length, summa = 0, CountPositive = 0;
            foreach (double elem in array)
                if (elem > 0)
                {
                    summa += elem;
                    CountPositive++;
                }
            double SrArif = summa / CountPositive;


            for (int i = 0; i < LenArr; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = SrArif;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            Console.WriteLine(string.Join(", ", array));
            int a = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] < 0) && (a == -1)) a = i;
            }
            for (int i = 0; i < a; i++)
            {
                sum += array[i] * array[i];
            }
            Console.WriteLine(sum);
            
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max = 0, min = 0;

            // Находим индексы максимального и минимального элементов
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max])
                    max = i;
                if (array[i] < array[min])
                    min = i;
            }

            // Определяем порядок (чтобы всегда идти от меньшего индекса к большему)
            int start = Math.Min(max, min);
            int end = Math.Max(max, min);

            // Создаём пустой массив для отрицательных
            negatives = new int[0];

            // Перебираем элементы между max и min (исключая их)
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    // Увеличиваем массив на 1 элемент
                    Array.Resize(ref negatives, negatives.Length + 1);
                    // Добавляем найденный отрицательный элемент в конец массива
                    negatives[negatives.Length - 1] = array[i];
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int maxIndex = 0;
            int firstNegativeIndex = -1;

            // 1. Находим индекс максимального элемента
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }

            // 2. Находим индекс первого отрицательного элемента
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    firstNegativeIndex = i;
                    break;
                }
            }

            // 3. Если отрицательного нет — ничего не делаем
            if (firstNegativeIndex == -1)
                return;

            // 4. Меняем их местами
            int temp = array[maxIndex];
            array[maxIndex] = array[firstNegativeIndex];
            array[firstNegativeIndex] = temp;

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = int.MinValue, count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                }

            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                    count++;
            }
                answer = new int[count];
            for (int i = 0, b = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[b] = i;
                    b++;
                }
            }
           
                Console.WriteLine(string.Join(" ", array));
            Console.WriteLine(string.Join(" ", answer));
            Console.WriteLine(max);
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= max)
                {
                    max = array[i];

                }
            }
            Console.WriteLine(string.Join(" ", array));
            int c = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] == max))
                {
                    c++;
                    array[i] += c;

                }

            }
            Console.WriteLine(string.Join(" ", array));
            //Console.WriteLine(max);
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] == max)
                {
                    array[i] = sum - array[i];
                }
            }

            // end

        }
        public int Task8(int[] array)
        {
            int length = 1;

            // code here
            int max = 1;

            if (array.Length < 2)
                return 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    max++; // продолжаем убывание
                    if (max > length)
                        length = max;
                }
                else
                {
                    max = 1; // сбрасываем при нарушении убывания
                }
            }


            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 2; j++)
                {
                    if ((array[j] > array[j + 2]) && (j % 2 == 0))
                    {
                        (array[j], array[j + 2]) = (array[j + 2], array[j]);
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here

            // code here
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                c = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == c)
                    {
                        array[j] = -10000;
                    }
                }
            }
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != -10000)
                {
                    n++;
                }
            }
            cleared = new int[n];
            n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != -10000)
                {
                    cleared[n++] = array[i];
                }
            }
            // end

            return cleared;
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 1 || a == b)
            {
                return B;
            }
            A = new double[n];
            double hd = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                A[i] = a + i * hd;
            }
            double sum = 0;
            int m = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    m++;
                }
            }
            double avg = sum / m;
            m = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] > avg))
                {
                    m++;
                }
            }
            B = new double[m];
            m = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] > avg))
                {
                    B[m++] = A[i];
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int n = dices.Length;

            int s = 0;
            int[] mine = new int[n];
            for (int i = 0; i < n; i++)
            {
                int a = dices[i] - s;
                if (a < 1) a = 1;
                mine[i] = a;

                if (dices[i] == 6) s++;
            }
            for (int i = 0; i < n; i++)
            {
                int e = 6 - i;
                if (e < 1) e = 1;
                if (mine[i] > e) wins++;
            }
            // end

            return wins;
            // end

            return wins;

        }
    }
}
