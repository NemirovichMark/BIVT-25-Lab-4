namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            if (array == null || array.Length == 0) return;

            double s = 0;
            double avg = 0;
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    n++;
            }

            double[] array2 = new double[n]; // Создаем новый массив с количесвом элементов = n(сколько положительных в а)
            int m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array2[m] = array[i]; // Заполняем новый массив. Индексы разные (как и длина)  
                    m++;
                }

            }
            for (int i = 0; i < array2.Length; i++) 
            {
                s += array2[i];
            }
            avg = s / array2.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = avg;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            if (array == null  || array.Length == 0) return 0;

            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    n++;
                }
            }
            if (n == 0) { return 0; }
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] < 0) break;
                sum += (array[i] * array[i]);
            }
            // end
            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            if (array == null || array.Length == 0) return negatives = null;

            int count = 0;
            int maxEl = array[0];
            int minEl = array[0];
            int indexMax = 0;
            int indexMin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxEl)
                {
                    maxEl = array[i];
                    indexMax = i;
                }
                if (array[i] < minEl)
                {
                    minEl = array[i];
                    indexMin = i;
                }
            }
            for (int i = Math.Min(indexMax, indexMin) + 1; i < Math.Max(indexMin, indexMax); i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }
            int indexOfNeg = 0;

            negatives = new int[count];
            for (int i = Math.Min(indexMax, indexMin) + 1; i < Math.Max(indexMin, indexMax); i++)
            {
                if (array[i] < 0)
                {
                    negatives[indexOfNeg] = array[i];
                    indexOfNeg++;
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null && array.Length < 2)
            {
                return;
            } 
            int negativeIndex = -1;
            int max_Index = 0;
            int perekid = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativeIndex = i;
                    break;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max_Index])
                {
                    max_Index = i;
                }
            }
            if (negativeIndex != -1)
            {
                perekid = array[max_Index];
                array[max_Index] = array[negativeIndex];
                array[negativeIndex] = perekid;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0) return answer = null;

            int count = 0;
            int maxEl = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxEl)
                {
                    maxEl = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxEl)
                {
                    count++;
                }
            }
            answer = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxEl)
                {
                    answer[index] = i;
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

            int NumOfMaxEl = 1;
            int index = 0;
            int maxel = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxel)
                {
                    maxel = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxel)
                {
                    array[i] += NumOfMaxEl;
                    NumOfMaxEl++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here

            if (array == null || array.Length == 0) return;
            int maxel = array[0];
            int index = 0;
            int s = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxel)
                {
                    maxel = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxel)
                {
                    count++;
                }
            }
            int[] indexOfMax = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxel)
                {
                    indexOfMax[index] = i;
                    index++;
                }
            }




            int[] sums = new int[count];

            for (int i = 0; i < sums.Length; i++)
            {
                int currentMaxIndex = indexOfMax[i];
                int sumisdone = 0;

                // Суммируем все элементы до текущего максимального элемента
                for (int j = 0; j < currentMaxIndex; j++)
                {
                    sumisdone += array[j];
                }

                sums[i] = sumisdone;
            }

            for (int i = 0; i < indexOfMax.Length; i++)
            {
                array[indexOfMax[i]] = sums[i]; // IndexOfMax[0] - индекс первого макс числф, IndexOfMax[1] - индекс второго макс числа и тд
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here

            if (array == null || array.Length == 0) return 1;

            length = 1;
            int max_len = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    length++;
                    if (length > max_len)
                    {
                        max_len = length;
                    }
                }
                else
                {
                    length = 1;
                }
            }
            length = max_len;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            int buffer = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (i % 2 == 0 && array[i] > array[j] && j % 2 == 0)
                    {
                        buffer = array[i];
                        array[i] = array[j];
                        array[j] = buffer;
                        //(array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            if (array == null || array.Length == 0) return cleared = null;

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool ElIsUniq = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        ElIsUniq = false;
                        break;
                    }
                }
                if (ElIsUniq)
                {
                    count++;
                }
            }

            int index = 0;
            cleared = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                bool ElIsUniq = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        ElIsUniq = false;
                        break;
                    }
                }
                if (ElIsUniq)
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
            if (n <= 1 || a == b) return B = null;
            double s = 0;
            int cnt = 0;
            double avg = 0;
            int index = 0;
            int cntBiggerthanavg = 0;


            A = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                A[i] = a + (step * i);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    s += A[i];
                    cnt++;
                }
            }
            avg = s/ cnt;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > avg)
                {
                    cntBiggerthanavg++;
                }
            }

            B = new double[cntBiggerthanavg];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > avg)
                {
                    B[index] = A[i];
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
            int cnt6  = 0;
            int shuler = 0;
            int winsofshuler = 0;
            int znachenie = 0;

            int[] player = new int[dices.Length];

            for (int i = 0; i < dices.Length; i++)
            {

                znachenie = dices[i] - cnt6;

                if (znachenie < 1)
                {
                    znachenie = 1;
                }

                player[i] = znachenie;

                if (dices[i] == 6)
                {
                    cnt6++;
                }
            }

            for (int i = 0; i < dices.Length; i++)
            {

                shuler = 6 - winsofshuler;

                if (shuler < 1)
                {
                    shuler = 1;
                }

                if (player[i] > shuler)
                {
                    wins++;
                }

                winsofshuler++;
                // end
            }
                return wins;
            
        }
    }
}