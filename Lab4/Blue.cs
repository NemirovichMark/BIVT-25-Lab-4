using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int indexMax = 0;
            int indexNegative = -1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[indexMax]) indexMax = i;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    indexNegative = i;
                    break;
                }
            }
            if (indexNegative == -1) return;
            int chislo = 0;
            for (int i = indexMax+1; i < array.Length; i++)
            {
                chislo += array[i];
            }
            array[indexNegative] = chislo;
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            //int[] answer = null;

            // code here
            if (array.Length == 0) return null;
            int indexPositive = -1;
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] > 0)
                {
                    indexPositive = i;
                    break;
                }
            }
            int[] newArray = null;
            if (array.Length == 1 && array[0] > 0)
            {
                newArray = new int[2];
                newArray[0] = array[0];
                newArray[1] = P;
                return newArray;
            }
            if (indexPositive == -1) return array;
            newArray = new int[array.Length + 1];
            int n = 0;
            for (int i = 0; i <= indexPositive; i++)
            {
                newArray[n] = array[i];
                n++;
            }
            newArray[n] = P;
            n = newArray.Length - 1;
            for (int i=array.Length - 1; i > indexPositive; i--)
            {
                newArray[n] = array[i];
                n--;
            }
            // end

            return newArray;
        }
        public int[] Task3(int[] array)
        {
            //int[] answer = null;

            // code here
            int indexMin = -1;
            int indexVal = int.MaxValue;
            int[] newArray = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < indexVal)
                {
                    indexVal = array[i];
                    indexMin = i;
                }
            }
            if (indexMin == -1)
            {
                
                return newArray=array;

            }
            if (array.Length == 1 && array[0] > 0)
            {
                return newArray=new int[] { };
            }
            
            newArray = new int[array.Length - 1];
            for (int i = 0; i < indexMin; i++)
            {
                newArray[i] = array[i];
            }
            int n = array.Length - 2;
            for (int i=array.Length-1; i > indexMin; i--)
            {
                newArray[n] = array[i];
                n--;
            }
            
            // end

            return newArray;
        }
        public void Task4(double[] array)
        {

            // code here
            if (array.Length == 0)
            {
                return;
            }
            double Average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Average += array[i];
            }
            Average /= array.Length;
            for (int i=0;i<array.Length;i++)
            {
                array[i] -= Average;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length==B.Length)
            {
                for (int i=0; i < A.Length; i++)
                {
                    sum+=A[i]*B[i];
                }
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double Average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Average += array[i];
            }
            Average /= array.Length;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < Average)
                {
                    count++;
                }
            }
            indexes = new int[count];
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < Average)
                {
                    indexes[count] = i;
                    count++;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int countMax = 0;

            // code here
            int count1 = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1])
                {
                    count1++;
                }
                else
                {
                    countMax = Math.Max(countMax, count1);
                    count1 = 1;
                }
            }
            countMax = Math.Max(countMax, count1);
            int count2 = 1;
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] <= array[i - 1])
                {
                    count2++;
                }
                else
                {
                    countMax = Math.Max(countMax, count2);
                    count2 = 1;
                }
            }
            countMax = Math.Max(countMax, count2);
            // end

            return countMax;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            int[] newArray = null;
            newArray = new int[array.Length * 2];
            int n = 0;
            for (int i = 0; i < newArray.Length/2; i++)
            {
                newArray[n] = array[i];
                newArray[n + 1] = array[i];
                n += 2;
            }

            // end

            return newArray;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            double[] newArray = null;
            int valueMax = int.MinValue;
            int valueMin = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                valueMax = Math.Max(valueMax, array[i]);
                valueMin = Math.Min(valueMin, array[i]);
            }
            if (valueMax == valueMin) return newArray;
            newArray = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = (double)(array[i] - valueMin) / (valueMax - valueMin);
            }

            // end

            return newArray;
        }
        public int Task10(int[] array, int P)
        {
            

            // code here
            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexMin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[indexMin])
                    {
                        indexMin = j;
                    }
                }
                int term = array[i];
                array[i] = array[indexMin];
                array[indexMin] = term;
            }
            int left = 0;
            int right = array.Length - 1;
            int indexP = -1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == P)
                {
                    indexP = mid;
                    break;
                } 
                if (P < array[mid]) right = mid - 1;
                else left = mid + 1;
            }
            return indexP;
            
            // end

            //return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
           
            if (b <= 0) return null;
            if (a>c)return new int[0];
            array = new int[(c-a)/b+1] ;
            int n = 0;
            for (int term = a; term <= c; term += b)
            {
                array[n] = term;
                n++;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int summaMax = int.MinValue;           
            if (magazine.Length < 3)
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }
                return indexes;
            }
            int summaRepeat = int.MinValue;
            indexes = new int[3];
            for (int i=0;i<magazine.Length-2;i++)
            {
                summaMax = Math.Max(summaMax, magazine[i] + magazine[i + 1] + magazine[i + 2]);
                if (summaMax==magazine[i] + magazine[i + 1] + magazine[i + 2] && summaRepeat!=summaMax)
                {
                    indexes[0] = i;
                    indexes[1] = i + 1;
                    indexes[2] = i + 2;
                    summaRepeat=summaMax;
                }
            }
            // end

            return indexes;
        }
    }
}
