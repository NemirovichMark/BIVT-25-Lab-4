using System.Runtime.Intrinsics.Arm;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int countPos = 0;
            double sumPos = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sumPos += array[i];
                    countPos++;
                }
            }

            double average = sumPos / countPos;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = average;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int countNeg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    countNeg++;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    sum += array[i] * array[i];
                }
                else
                {
                    break;
                }
            }

            if (countNeg == 0)
            {
                sum = 0;
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int maxi = int.MinValue, mini = int.MaxValue;
            int indMax = 0, indMin = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                    indMax = i;
                }
                else if (array[i] < mini)
                {
                    mini = array[i];
                    indMin = i;
                }
            }

            int len = Math.Abs(indMax - indMin) - 1;
            if (len == -1) len = 0;
            int[] newArray = new int[len];

            for (int i = 0; i < array.Length; )
            {
                if (array[i] == maxi || array[i] == mini)
                {
                    for (int j = 0; j < len; j++)
                    {
                        newArray[j] = array[i+1];
                        i++;
                    }
                    break;
                }
                i++;
            }

            int countNeg = 0;

            for (int i = 0; i < len; i++)
            {
                if (newArray[i] < 0)
                {
                    countNeg++;
                }
            }

            negatives = new int[countNeg];
            int k = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] < 0)
                {
                    negatives[k] = newArray[i];
                    k++;
                }
            }

            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int iMax = -1, iNeg = -1, maxi = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                    iMax = i;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    iNeg = i;
                    break;
                }
            }

            if (iMax != -1 && iNeg != -1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == iMax || i == iNeg)
                    {
                        (array[iMax], array[iNeg]) = (array[iNeg], array[iMax]);
                        break;
                    }
                }
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int maxi = int.MinValue, countMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxi)
                {
                    countMax++;
                }
            }

            answer = new int[countMax];
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxi)
                {
                    answer[k] = i;
                    k++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int[] arrayMax = null;
            int maxi = int.MinValue, countMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxi)
                {
                    countMax++;
                }
            }

            arrayMax = new int[countMax];
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxi)
                {
                    arrayMax[k] = k + 1;
                    k++;
                }
            }

            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxi)
                {
                    array[i] += arrayMax[c];
                    c++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int maxi = int.MinValue, countMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxi)
                {
                    countMax++;
                }
            }

            int sum = 0;
            int[] sums = new int[countMax];
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxi)
                {
                    sums[k] = sum;
                    k++;
                }
                sum += array[i];
            }

            k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxi)
                {
                    array[i] = sums[k];
                    k++;
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int[] arrayMax = new int[array.Length * array.Length];
            int count = 1, k = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i+1])
                {
                    count++;
                }
                else
                {
                    arrayMax[k] = count;
                    count = 1;
                    k++;
                }
            }

            int maxi = int.MinValue;

            for (int i = 0; i < arrayMax.Length; i++)
            {
                if (arrayMax[i] > maxi)
                {
                    maxi = arrayMax[i];
                }
            }

            length = maxi;
            if (maxi == int.MinValue || array.Length == 1) length = 1;
            // end

            return length;
        }
        public void Task9(int[] array)
        {
            // code here
            int count = 0;
            if (array.Length % 2 == 0)
            {
                count = array.Length / 2;
            }
            else
            {
                count = (array.Length + 1) / 2;
            }

            int[] iEven = new int[count];
            int k = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                iEven[k] = array[i];
                k++;
            }

            for (int i = 0; i < iEven.Length - 1; i++)
            {
                for (int j = i + 1; j < iEven.Length; j++)
                {
                    if (iEven[i] > iEven[j])
                    {
                        (iEven[j], iEven[i]) = (iEven[i], iEven[j]);
                    }
                }
            }

            k = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = iEven[k];
                k++;
            }

            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool noRepeats = true;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        noRepeats = false;
                        break;
                    }
                }

                if (noRepeats == true)
                {
                    count++;
                }
            }

            cleared = new int[count];
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool noRepeats = true;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        noRepeats = false;
                        break;
                    }
                }

                if (noRepeats == true)
                {
                    cleared[k] = array[i];
                    k++;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 1 || b == a)
            {
                return null;
            }

            A = new double[n];
            double step = (b - a) / (n - 1);
            double sum = 0;
            int countPos = 0;

            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }

            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    countPos++;
                }
            }

            double average = sum / countPos;
            countPos = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > average)
                {
                    countPos++;
                }
            }

            B = new double[countPos];
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > average)
                {
                    B[k] = A[i];
                    k++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int sixCount = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                int shulerDice = 6 - i;
                int playerDice = dices[i] - sixCount;

                if (shulerDice < 1)
                {
                    shulerDice = 1;
                }

                if (playerDice < 1)
                {
                    playerDice = 1;
                }

                if (playerDice > shulerDice)
                {
                    wins++;
                }

                if (dices[i] == 6)
                {
                    sixCount++;
                }
            }
            // end

            return wins;

        }
    }
}