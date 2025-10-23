using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int indexMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    indexMax = i;
                    break;
                }
            }
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i>indexMax)
                {
                    summ += array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <0)
                {
                    array[i] = summ;
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int indexPositive = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    indexPositive = i;
                }
            }
            
            
            if (indexPositive == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }

            }
            else
            {
                answer = new int[array.Length + 1];
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i <= indexPositive)
                    {
                        answer[i]=array[i];
                    }
                    else if (i == indexPositive + 1)
                    {
                        answer[i] = P;
                    }
                    else
                    {
                        answer[i] = array[i - 1];
                    }

                }
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here

            int indexMin = 0;
            int min = int.MaxValue;
            int countPositive = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < min)
                {
                    min = array[i];
                    countPositive++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == min && array[i] > 0) 
                {
                    indexMin = i;
                    break;  
                }
            }

            if (countPositive == 0)
            {
                answer = new int[array.Length];
                for (int i = 0; i < answer.Length; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[array.Length - 1];

                for (int i = 0; i < answer.Length; i++)
                {
                    if (i < indexMin)
                    {
                        answer[i] = array[i];
                    }
                    else
                    {
                        answer[i] = array[i + 1];
                    }
                }
            }
            //end
            return answer;
        }
        public void Task4(double[] array)
        {
            // code here
            int count = 0;
            double summ = 0;
            double sr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
                count++;
            }
            sr = summ / count;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= sr;
            }

            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length != B.Length)
            {
                return sum;
            }
            else
            {
                for (int i = 0; i < A.Length; i++)
                {
                    sum += A[i] * B[i];
                }
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double sr = 0;
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                count++;
            }
            sr = sum / count;
            int lessSr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    lessSr++;
                }
            }
            indexes = new int[lessSr];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    indexes[index++] = i;
                }
            }

            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            count++;

            int currPlus = 1;
            int currMin = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currPlus++;
                    currMin++;
                }
                else if (array[i] > array[i - 1])
                {
                    currPlus++;
                    currMin = 1;
                }
                else
                {
                    currMin++;
                    currPlus = 1;
                }

                if (currPlus > count)
                {
                    count = currPlus;
                }

                if (currMin > count)
                {
                    count = currMin;
                }
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer= new int[array.Length*2];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                answer[index] = array[i];
                answer[index + 1] = array[i];
                index += 2;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            if (array == null || array.Length == 0)
            {
                return normalized;
            }

            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
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

            if (min == max)
            {
                return null;
            }

            normalized = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (double)(array[i] - min) / (max - min);
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            int low = 0;
            int high=array.Length - 1;
            index = -1;
            while (low <= high)
            {
                int mid = low+(high-low) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                if (array[mid] < P)
                {
                    low= mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <= 0)
            {
                return null;
            }
            int element = a;
            int countElem = 0;
            while (element <= c)
            {
                element += b;
                countElem++;
            }
            element = a;
            array = new int[countElem];
            for (int i =0; i < countElem; i++)
            {
                array[i] = element;
                element += b;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if (magazine.Length < 3)
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }
            }
            else
            {
                indexes = new int[3];
                int maxGold = 0;
                int maxIndex = 0;
                for (int i = 0; i <= magazine.Length - 3; i++)
                {
                    int currentGold = magazine[i] + magazine[i + 1] + magazine[i + 2];

                    if (currentGold > maxGold)
                    {
                        maxGold = currentGold;
                        maxIndex = i; 
                    }
                }

                
                indexes[0] = maxIndex;
                indexes[1] = maxIndex + 1;
                indexes[2] = maxIndex + 2;
            }

            // end

            return indexes;
        }
    }
}