using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double summ = 0;
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    summ += array[i];
                    n++;
                }
            }
            double sr = summ / n;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = sr;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int negativ = 0;
            if (array == null)
            {
                return 0; 
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    break;
                sum+= (array[i] * array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativ++;
                }
                    
            }
            if (negativ == 0)
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
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int indexMin = 0;
            int indexMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == min)
                {
                    indexMin = i;
                    break;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    indexMax = i;
                    break;
                }
            }

            int start, end;
            if (indexMin < indexMax)
            {
                start = indexMin + 1;
                end = indexMax - 1;
            }
            else
            {
                start = indexMax + 1;
                end = indexMin - 1;
            }
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (array[i] < 0)
                    count++;
            }
            negatives = new int[count];
            int index = 0;

            for (int i = start; i <= end; i++)
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
            int indexMax=0;int indexNegative=-1;
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    indexMax=i;
                    break;
                }
            }
            int negative = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negative = array[i];
                    break;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    indexNegative=i;
                    break;
                }
            }
            if (indexNegative != -1) 
            {
                array[indexNegative] = max;
                array[indexMax] = negative;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int countMax = 0;
            int max= int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    countMax++;
                }
            }
            answer = new int[countMax];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
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
            int max = int.MinValue;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int numb = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i]=max+numb;
                    numb++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int[] array1 = new int[array.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = array[i];
            }
            int max=int.MinValue;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                }
            }
            
            for (int i = 0; i < array1.Length; i++)
            {
                int sum = 0;
                if (array1[i] == max)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sum += array1[j];
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
            // 9 8 7 7 6 5 5 5 4 3 2 1 1 1, 8 
            int n = 1;
            int max = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    n++;
                    if (n > max)
                    {
                        max = n;
                    }
                }
                else
                {
                    n = 1;
                }
            }
            length = max;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            int index = 0;
            int[] array2 = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array2[index] = array[i];
                    index++;
                }
            }

            for (int i = 0; i < array2.Length - 1; i++)
            {
                for (int j = 0; j < array2.Length - 1 - i; j++)
                {
                    if (array2[j] > array2[j + 1])
                    {
                        int temp = array2[j];
                        array2[j] = array2[j + 1];
                        array2[j + 1] = temp;
                    }
                }
            }

            for (int i = 0, j = 0; i < array.Length; i += 2, j++)
            {
                array[i] = array2[j];
            }

            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int length = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                bool isFirstOccurrence = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        isFirstOccurrence = false;
                        break;
                    }
                }

                if (isFirstOccurrence)
                {
                    int count = 0;
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] == array[i])
                        {
                            count++;
                        }
                    }

                    if (count > 1)
                    {
                        length = length - count + 1;
                    }
                }
            }

            cleared = new int[length];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool isFirstOccurrence = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        isFirstOccurrence = false;
                        break;
                    }
                }

                if (isFirstOccurrence)
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
            if (n <= 1 || a==b)
            {
                return null;
            }

            A = new double[n];
            if (n == 0 || n == 1)
            {
                return null;
            }

            A = new double[n];
            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                A[i] = a + i * step;
            }
            double summ = 0;
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    summ += A[i];
                    count++;
                }
            }
            double sr = 0;
            if (count > 0)
            {
                sr = summ / count;
            }
            int index = 0;
            int c = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > sr)
                {
                    c++;
                }
            }
            B = new double[c];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > sr)
                {
                    B[index] = A[i];
                    index++;
                }
            }

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int[] badguy = new int[dices.Length];
            int badguycubes = 6;
            for (int i = 0; i < badguy.Length;i++)
            {
                badguy[i] = badguycubes;
                badguycubes--;
            }
            for (int i = 0; i < badguy.Length; i++)
            {
                if (badguy[i] < 1)
                {
                    badguy[i] = 1;
                }
            }
            
            int[] myCursedCubes= new int[dices.Length];
            int countSix = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                myCursedCubes[i] = dices[i] - countSix;
                if (myCursedCubes[i] < 1)
                {
                    myCursedCubes[i] = 1;
                }
                if (dices[i] == 6)
                {
                    countSix++;
                }
            }

            for (int i = 0; i < dices.Length; i++)
            {
                if (myCursedCubes[i] > badguy[i])
                {
                    wins++;
                }
            }


            // end

            return wins;

        }
    }
}