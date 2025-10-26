using System.Diagnostics;
using System.Threading.Tasks;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            
            double plus = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    plus += array[i];
                    count += 1;
                }


            }
            if (count > 0)
            {
                double res = plus / count;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = res;
                    }

                }
                
            }
            return;
            

            
            
           

        }
        public int Task2(int[] array)

        {
            int sum = 0;
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    break;
                }
                sum += array[i]*array[i];
                c += 1;
                if (c == array.Length)
                {
                    sum = 0;
                }
            }

            return sum;
        }
        public int[] Task3(int[] array)
        {
            if (array == null || array.Length <= 1) 
            {
                return new int[0]; 
            }
            int indexmin = 0;
            int indexmax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[indexmax])
                {
                    indexmax = i;
                }
                if (array[i] < array[indexmin])
                {
                    indexmin = i;
                }
            }
            int start = Math.Min(indexmax, indexmin)+1;
            int end = Math.Max(indexmax, indexmin);
            int minus = 0;
            if (start>=end)
            {
                return new int[0];
            }
            for (int i = start; i < end; i++)
            {
                if (array[i] < 0)
                {
                    minus++;
                }
            }
            int[] res = new int[minus];
            int resindex = 0;
            for(int i = start; i < end; i++)
            {
                if (array[i] < 0)
                {
                    res[resindex] = array[i];
                    resindex++;
                }
            }
            
            return res;
        }
        public void Task4(int[] array)
        {
            if (array == null || array.Length <= 1)
            {
                return;
            }
            int max = 0;
            int index = -2;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }

            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    index = i;
                    break;
                }
            }
            if (index==-2)
            {
                return;
            }
            int maxi = array[max];
            array[max] = array[index];
            array[index] = maxi;
            
            
        }
        public int[] Task5(int[] array)
        {
            int max = 0;
            int c = 0;
            if(array==null|| array.Length < 1)
            {
                return new int[0];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == array[max])
                {
                    c++;
                }
            }
            int[] res = new int[c];
            int resindex = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == array[max])
                {
                    res[resindex] = i;
                    resindex++;    
                }
            }

            return res;
        }
        public void Task6(int[] array)
        {   

    int resindex = 1;
    int max = 0;
    if (array == null || array.Length == 0) 
    {
        return;
    }

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[max])
        {
            max = i;
        }
    }
            int maxi = array[max];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == maxi)
        {
            array[i] += resindex;
            resindex++;
        }
    
}

        }
        
public async Task Task7(int[] array)
{
    if (array == null || array.Length < 1)
    {
        return;
    }
    if (array.Length == 1)
            {
                array[0] = 0;
                return;
            }
   
    int maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }

    
    int currentSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
       
        int originalValue = array[i];

        if (originalValue == maxValue)
        {
            
            array[i] = currentSum;
        }
        
        currentSum += originalValue;
    }
}

    
        

        public int Task8(int[] array)
        {
            int length = 0;

            // code here

            // end

            return length;
        }
        public void Task9(int[] array)
        {
            
    if (array == null || array.Length <= 1)
    {
        return;
    }

    int n = array.Length;

    for (int i = 0; i < n; i += 2) 
    {
        int minIndex = i; 

        for (int j = i + 2; j < n; j += 2) 
            if (array[j] < array[minIndex])
            {
                minIndex = j; 
        }

        
        if (minIndex != i)
        {
            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }

            
        }
        public int[] Task10(int[] array)
        {
            if (array == null || array.Length == 0)
    {
        return new int[0];
    }
    if (array.Length == 1)
    {
        return new int[] { array[0] };
    }

    int elementsToRemove = 0;
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
        if (!isFirstOccurrence)
        {
            elementsToRemove++;
        }
    }

    int uniqueCount = array.Length - elementsToRemove;
    int[] cleaned = new int[uniqueCount];

    int cleanedIndex = 0;
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
            cleaned[cleanedIndex] = array[i];
            cleanedIndex++;
        }
    }

    return cleaned;
    
        }
        
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here

            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here

            // end

            return wins;

        }
    }
}