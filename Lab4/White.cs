namespace Lab4
{
    public class White
    {
        // 1. Длина вектора
        public double Task1(int[] vector)
        {
            if (vector == null || vector.Length == 0)
                return 0;
            double sum = 0;
            foreach (var x in vector)
                sum += (double)x * x;
            return System.Math.Sqrt(sum);
        }

        // 2. Кол-во элементов строго между P и Q
        public int Task2(int[] array, int P, int Q)
        {
            if (array == null || array.Length == 0)
                return 0;
            int min = System.Math.Min(P, Q);
            int max = System.Math.Max(P, Q);
            int count = 0;
            foreach (var x in array)
                if (x > min && x < max)
                    count++;
            return count;
        }

        // 3. Поменять местами максимальный и мин. после него
        public void Task3(int[] array)
        {
            if (array == null || array.Length == 0)
                return;

            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIdx])
                    maxIdx = i;

            // если после максимального нет элементов — не делать ничего
            if (maxIdx >= array.Length - 1)
                return;

            int minIdx = -1;
            int minVal = int.MaxValue;
            for (int i = maxIdx + 1; i < array.Length; i++)
            {
                if (array[i] < minVal)
                {
                    minVal = array[i];
                    minIdx = i;
                }
            }

            if (minIdx == -1)
                return;

            // Если все элементы после максимального равны (minIdx будет установлен, но может быть равен max value),
            // условие "если ... все элементы равны – изменений не производить" фактически означает,
            // что если найденный минимальный равен максимальному, не менять.
            if (array[maxIdx] == array[minIdx])
                return;

            int tmp = array[maxIdx];
            array[maxIdx] = array[minIdx];
            array[minIdx] = tmp;
        }

        // 4. Максимальный с четным индексом -> индекс
        public void Task4(int[] array)
        {
            if (array == null || array.Length == 0)
                return;

            int maxIdx = -1;
            int maxVal = int.MinValue;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                    maxIdx = i;
                }
            }
            if (maxIdx != -1)
                array[maxIdx] = maxIdx;
        }

        // 5. Найти индекс числа P
        public int Task5(int[] array, int P)
        {
            if (array == null || array.Length == 0)
                return -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == P)
                    return i;
            return -1;
        }

        // 6. Поменять местами соседние до максимального
        public void Task6(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIdx])
                    maxIdx = i;

            // переставляем пары (0,1),(2,3),... расположенные до максимального элемента
            for (int i = 0; i + 1 < maxIdx; i += 2)
            {
                int tmp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = tmp;
            }
        }

        // 7. Удалить все отрицательные
        public int[] Task7(int[] array)
        {
            if (array == null)
                return new int[0];

            int count = 0;
            foreach (var x in array)
                if (x >= 0) count++;

            int[] answer = new int[count];
            int idx = 0;
            foreach (var x in array)
                if (x >= 0) answer[idx++] = x;

            return answer;
        }

        // 8. Сортировка по убыванию (устойчивый алгоритм — пузырьковая)
        public void Task8(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }

        // 9. Развернуть массив
        public void Task9(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            int n = array.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[n - 1 - i];
                array[n - 1 - i] = tmp;
            }
        }

        // 10. Объединить два массива поочередно
        public int[] Task10(int[] A, int[] B)
        {
            if ((A == null || A.Length == 0) && (B == null || B.Length == 0))
                return new int[0];
            if (A == null || A.Length == 0)
                return (int[])B.Clone();
            if (B == null || B.Length == 0)
                return (int[])A.Clone();

            int lenA = A.Length;
            int lenB = B.Length;
            int[] C = new int[lenA + lenB];
            int i = 0, j = 0, k = 0;
            while (i < lenA && j < lenB)
            {
                C[k++] = A[i++];
                C[k++] = B[j++];
            }
            while (i < lenA) C[k++] = A[i++];
            while (j < lenB) C[k++] = B[j++];

            return C;
        }

        // 11. Массив равноудаленных элементов по диапазону
        // По условию задания: если a == b и n == 1 вернуть массив из одного элемента, во всех остальных случаях вернуть null.
        public double[] Task11(double a, double b, int n)
        {
            if (n <= 0)
                return null;
            if (a == b)
            {
                if (n == 1)
                    return new double[] { a };
                else
                    return null;
            }
            // В соответствии с условием: во всех остальных случаях вернуть null
            return null;
        }

        // 12. Восстановление поврежденных данных (закольцованный массив)
        public double[] Task12(double[] raw)
        {
            if (raw == null || raw.Length < 3)
                return null;

            int n = raw.Length;
            bool allNeg = true;
            for (int i = 0; i < n; i++)
            {
                if (raw[i] != -1.0)
                {
                    allNeg = false;
                    break;
                }
            }
            if (allNeg)
                return (double[])raw.Clone();

            double[] restored = (double[])raw.Clone();

            for (int i = 0; i < n; i++)
            {
                if (restored[i] == -1.0)
                {
                    double left = restored[(i - 1 + n) % n];
                    double right = restored[(i + 1) % n];
                    if (left != -1.0 && right != -1.0)
                    {
                        restored[i] = (left + right) / 2.0;
                    }
                }
            }

            return restored;
        }
    }
}
