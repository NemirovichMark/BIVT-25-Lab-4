namespace Lab4
{
    public class White
    {
        // 1. Длина вектора
        public double Task1(int[] vector)
        {
            double length = 0;
            foreach (var x in vector)
                length += x * x;
            return Math.Sqrt(length);
        }
        return length;

        // 2. Кол-во элементов строго между P и Q
        public int Task2(int[] array, int P, int Q)
        {
            int min = Math.Min(P, Q);
            int max = Math.Max(P, Q);
            int count = 0;
            foreach (var x in array)
                if (x > min && x < max)
                    count++;
            return count;
        }

        // 3. Поменять местами максимальный и мин. после него
        public void Task3(int[] array)
        {
            if (array == null || array.Length == 0) return;
            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIdx])
                    maxIdx = i;

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

            if (minIdx != -1 && array[maxIdx] != array[minIdx])
            {
                int temp = array[maxIdx];
                array[maxIdx] = array[minIdx];
                array[minIdx] = temp;
            }
        }

        // 4. Максимальный с четным индексом -> индекс
        public void Task4(int[] array)
        {
            if (array == null || array.Length == 0) return;
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
            int index = 0;
            if (array == null)
            for (int i = 0; i < array.Length; i++)
                if (array[i] == P)
                    return i;
            return index;
        }

        // 6. Поменять местами соседние до максимального
        public void Task6(int[] array)
        {
            if (array == null || array.Length < 2) return;
            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIdx])
                    maxIdx = i;
            for (int i = 1; i < maxIdx; i += 2)
            {
                int temp = array[i - 1];
                array[i - 1] = array[i];
                array[i] = temp;
            }
        }

        // 7. Удалить все отрицательные
        public int[] Task7(int[] array)
        {
            int[] answer = null;
            if (array == null) return null;
            return array.Where(x => x >= 0).ToArray();
        }
            return answer;
        // 8. Сортировка по убыванию
        public void Task8(int[] array)
        {
            if (array == null) return;
            Array.Sort(array, (a, b) => b.CompareTo(a));
        }

        // 9. Развернуть массив
        public void Task9(int[] array)
        {
            if (array == null) return;
            Array.Reverse(array);
        }

        // 10. Объединить два массива поочередно
        public int[] Task10(int[] A, int[] B)
        {
            int[] c = null;
            if ((A == null || A.Length == 0) && (B == null || B.Length == 0))
                return new int[0];
            if (A == null || A.Length == 0)
                return (int[])B.Clone();
            if (B == null || B.Length == 0)
                return (int[])A.Clone();

            int[] C = new int[A.Length + B.Length];
            int i = 0, j = 0, k = 0;
            while (i < A.Length && j < B.Length)
            {
                C[k++] = A[i++];
                C[k++] = B[j++];
            }
            while (i < A.Length)
                C[k++] = A[i++];
            while (j < B.Length)
                C[k++] = B[j++];
            return C;
        }

        // 11. Массив равноудаленных элементов по диапазону (исправлено!)
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;
            if (n < 1) return null;
            if (a == b && n == 1)
                return new double[] { a };
            if (a == b || n < 2)
                return null;

            double[] array = new double[n];
            double step = (b - a) / n;
            if (a < b)
            {
                for (int i = 0; i < n; i++)
                    array[i] = a + step * (i + 0.5);
            }
            else
            {
                for (int i = 0; i < n; i++)
                    array[i] = a - step * (i + 0.5);
            }
            return array;
        }

        // 12. Восстановление поврежденных данных (исправлено!)
        public double[] Task12(double[] raw)
        {
            double[] restored = null;
            if (raw == null || raw.Length < 3)
                return null;

            if (raw.All(x => x == -1))
                return null;

            double[] restored = (double[])raw.Clone();
            int n = restored.Length;
            bool changed = false;
            for (int i = 0; i < n; i++)
            {
                if (restored[i] == -1)
                {
                    double? left = null;
                    double? right = null;
                    // ищем первый не -1 слева
                    for (int l = i - 1; l >= 0; l--)
                        if (restored[l] != -1) { left = restored[l]; break; }
                    // ищем первый не -1 справа
                    for (int r = i + 1; r < n; r++)
                        if (restored[r] != -1) { right = restored[r]; break; }
                    if (left.HasValue && right.HasValue)
                    {
                        restored[i] = (left.Value + right.Value) / 2.0;
                        changed = true;
                    }
                }
            }
            // если ничего не восстановлено, вернуть null
            if (!changed)
                return null;
            return restored;
        }
    }
}

