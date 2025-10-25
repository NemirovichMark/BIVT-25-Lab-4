namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double SumOfPositives = 0;
            int countOfPositives = 0;
            foreach (double num in array)
            {
                if (num > 0)
                {
                    SumOfPositives += num;
                    countOfPositives++;
                }
            }
            if (countOfPositives == 0)
            {
                return;
            }
            double AverageOfPositives = SumOfPositives / countOfPositives;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = AverageOfPositives;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;
            bool foundNegative = false;
            // code here
            foreach (int num in array)
            {
                if (num >= 0)
                {
                    sum += num * num;
                }
                else
                {
                    foundNegative = true;
                    break;
                }
            }
            if (foundNegative)
            {
                return sum;
            }
            return 0;
            // end
        }
        public int[] Task3(int[] array) // главное работает, не важно, как выглядит
        {
            int[] negatives = null;
            int max = int.MinValue;
            int min = int.MaxValue;
            int maxIndex = -1;
            int minIndex = -1;
            int LenOfNegatives = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            if (minIndex > maxIndex)
            {
                for (int i = maxIndex + 1; i < minIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        LenOfNegatives++;
                    }
                }
            }
            else
            {
                for (int i = minIndex + 1; i < maxIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        LenOfNegatives++;
                    }
                }
            }
            if (LenOfNegatives == 0)
            {
                return new int[0];
            }
            negatives = new int[LenOfNegatives];
            if (minIndex > maxIndex)
            {
                for (int i = maxIndex + 1, j = 0; i < minIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[j] = array[i];
                        j++;
                    }
                }
            }
            else
            {
                for (int i = minIndex + 1, j = 0; i < maxIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[j] = array[i];
                        j++;
                    }   
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = int.MinValue;
            int index = -1;
            bool idk = false;
            int firstNiggativeIndex = -1;
            int firstNiggative = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
                if (array[i] < 0 && idk == false) 
                {
                    firstNiggativeIndex = i;
                    firstNiggative = array[i];
                    idk = true;
                }
            }
            if (firstNiggativeIndex == -1)
            {
                return;
            }
            array[firstNiggativeIndex] = max;
            array[index] = firstNiggative;
            // end

        }
        public int[] Task5(int[] array)
        {
            // code here
            int countOfMax = 0;
            int max = int.MinValue;
            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            foreach (int num in array)
            {
                if (num == max)
                {
                    countOfMax++;
                }
            }
            int[] answer = new int[countOfMax];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[j] = i;
                    j++;
                }
            }
            return answer;
            // end
        }
        public void Task6(int[] array)
        {

            // code here
            int MaxNum = int.MinValue;
            int a = 1;
            foreach (int num in array)
            {
                if (num > MaxNum)
                {
                    MaxNum = num;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == MaxNum)
                {
                    array[i] = MaxNum + a;
                    a++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int sum = 0;
            int Max = int.MinValue;
            int temp = 0;
            foreach (int num in array)
            {
                if (num > Max)
                {
                    Max = num;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                temp = array[i];
                if (array[i] == Max)
                {
                    array[i] = sum;
                }
                sum += temp;

            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int currentLength = 1;
            for (int i = 0; i < (array.Length - 1); i++)
            {
                if (array[i] > array[i + 1])
                {
                    currentLength++;
                    if (currentLength > length)
                    {
                        length = currentLength;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }
            if (length == 0)
            {
                length = 1;
            }
            // end

            return length;
        }
        public void Task9(int[] array) // прост модифицированный шаблон пузырька, хз запомню ли его, без вложенности решить нельзя
        {

            // code here
            for (int i = 0; i < array.Length - 2; i+=2)
            {
                for (int j = 0; j < array.Length - 2 - i; j+=2)
                {
                    if (array[j] > array[j + 2])
                    {
                        int temp = array[j];
                        array[j] = array[j + 2];
                        array[j + 2] = temp;
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array) // без вложенности тоже решить нельзя
        {
            int[] cleared = new int[0];

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < cleared.Length; j++)
                {
                    if (array[i] == cleared[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                int[] newCleared = new int[cleared.Length + 1];
                    for (int k = 0; k < cleared.Length; k++)
                    {
                        newCleared[k] = cleared[k];
                    }
                    newCleared[cleared.Length] = array[i];
                    cleared = newCleared;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n) // надо бы формулировку задания улучшить вамде
        {
            // code here
            double[] A = new double[n];
            double sum = 0;
            int count = 0;
            if (n <= 1)
            {
                return null;
            }
            if (a == b)
            {
                return null;
            }
            {
                for (int i = 0; i < n; i++)
                {
                    if (n == 1)
                    {
                        A[i] = a;
                    }
                    else
                    {
                        A[i] = a + (b - a) * i / (n - 1);
                    }
                    if (A[i] > 0)
                    {
                        sum += A[i];
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                return new double[0];
            }
            int countAboveAverage = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > (sum / count))
                {
                    countAboveAverage++;
                }
            }
            double[] B = new double[countAboveAverage];
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > (sum / count))
                {
                    B[k] = A[i];
                    k++;
                }
            }
            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int myCurse = 0;
            int secCurse = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                int myValue = dices[i] - myCurse;
                if (myValue < 1)
                {
                    myValue = 1;
                }

                int secValue = 6 - secCurse;
                if (secValue < 1)
                {
                    secValue = 1;
                }

                if (myValue > secValue)
                {
                    wins++;
                }

                if (dices[i] == 6)
                {
                    myCurse++;
                }
                secCurse++;
            }
            // end

            return wins;

        }
    }
}

