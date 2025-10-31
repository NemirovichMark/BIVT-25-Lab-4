namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
// PROBLEM ONE---------------------------------------------------------------------------------------------------------------------------------------------START

        for (int i = 0; i < vector.Length; i++)
            {
                length += vector[i] * vector[i];
            }

            length = Math.Sqrt(length);
            Console.WriteLine(length);
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
// PROBLEM TWO---------------------------------------------------------------------------------------------------------------------------------------------START

        for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > Math.Min(P, Q) && array[i] < Math.Max(P, Q))
                {
                    count++;
                }
            }
            Console.WriteLine(count);

//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
// PROBLEM THREE---------------------------------------------------------------------------------------------------------------------------------------------START

        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        int minIndex = maxIndex + 1;
        for (int i = maxIndex + 2; i < array.Length; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }
        

        if (array.Length == 0 || array.Length == 1 || maxIndex == array.Length - 1 || array[maxIndex] == array [minIndex] || array == null)
        {
        return;
        }

        (array[maxIndex], array[minIndex]) = (array[minIndex], array[maxIndex]);
        Console.WriteLine(string.Join(",", array));   

//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

        }
        public void Task4(int[] array)
        {

            // code here
// PROBLEM FOUR---------------------------------------------------------------------------------------------------------------------------------------------START

if (array.Length == 0)
{
return;
}
    
int maxIndex = 0;
for (int i = 2; i < array.Length; i+= 2)
{
    if (array[i] > array[maxIndex])
    {
        maxIndex = i;
    }
}
            
    array [maxIndex] = maxIndex;
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
// PROBLEM FIVE---------------------------------------------------------------------------------------------------------------------------------------------START

        index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == P)
            {
                return i;
            }
        }
            
        Console.WriteLine(index);
        
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
// PROBLEM SIX---------------------------------------------------------------------------------------------------------------------------------------------START

int max = 0;
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > array[max])
    {
        max = i;
    }
}

if (array.Length == 0 || max == 0)
{
    return;
}

for (int i = 0; i + 1 < max; i += 2)
        {
            (array[i], array[i+1]) = (array[i+1], array[i]);
        }

//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
// PROBLEM SEVEN---------------------------------------------------------------------------------------------------------------------------------------------START

int arraySizer = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 0)
    {
        arraySizer++;
    }
}

answer = new int[arraySizer];

int onlyPositive = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 0)
    {
        answer[onlyPositive] = array[i];
        onlyPositive++;
    }
}

//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
// PROBLEM EIGHT---------------------------------------------------------------------------------------------------------------------------------------------START

// Хочу использовать Array.Sort() :(((((((

int maxIndex = 0;
            
for (int i = 0; i < array.Length; i++)
 {
    int max = array[i];
    int imax = i;
    
    for (int k=i+1; k<array.Length; k++)
                {
                    if (array[k]> max)
                    {
                        max = array[k];
                        imax = k;
                    }
                }
    
 (array[i], array[imax] ) = (array[imax], array[i]); 
 }

//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

        }
        public void Task9(int[] array)
        {

            // code here
// PROBLEM NINE---------------------------------------------------------------------------------------------------------------------------------------------START

int i = 0;
int j = array.Length - 1;

while (i < j)
{
    (array[i], array[j]) = (array[j], array[i]);
            i++;
            j--;
}

//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
// PROBLEM TEN---------------------------------------------------------------------------------------------------------------------------------------------START

if (A.Length == 0 && B.Length == 0)
{
    C = new int[0];
    return C;
}

if (A.Length == 0 || B.Length == 0)
{
    C = A.Length == 0 ? new int[B.Length] : new int[A.Length];

    int[] remainArray = A.Length == 0? B : A;
    for (int x = 0; x < remainArray.Length; x++)
    {
        C[x] = remainArray[x];
    }
    return C;
}

C = new int[A.Length + B.Length];

int i = 0, j = 0, k = 0;

while (i < A.Length || j < B.Length)
{
    if (i < A.Length)
    {
        C[k++] = A[i++];
    }
    if (j < B.Length)
    {
        C[k++] = B[j++];
    }
}

//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
// PROBLEM ELEVEN---------------------------------------------------------------------------------------------------------------------------------------------START

        if (a == b)
        {
            if (n == 1)
            {
                    array = new double[] { a };
             }
            
        }
            
            else if (n >= 2)
            {
                array = new double[n];
                double distance = (b - a) / (n - 1);

                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * distance;
                }
            }

//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
// PROBLEM TWELVE---------------------------------------------------------------------------------------------------------------------------------------------START

int n = raw.Length;
restored = new double[n];
for (int i = 0; i < n; i++)
{
    restored[i] = raw[i];
}
            
bool allCorrupt = true;
for (int i = 0; i < n; i++)
{
    if (raw[i] != -1)
    {
        allCorrupt = false;
        break;
    }
}

if (allCorrupt)
{
    return restored;
}


if (n < 3)
{
    return null;
}

for (int i = 0; i < n; i++)
{
    if (raw[i] == -1)
    {
        double first = raw[(i - 1 + n) % n];
        double next = raw[(i + 1) % n];

            if (first != -1 && next != -1)
            {
                restored[i] = (first + next) / 2.0;
            }
    }
}
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return restored;
        }
    }

}





