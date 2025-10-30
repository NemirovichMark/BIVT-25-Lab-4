namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
for (int i = 0; i < vector.Length; i++)
{
    length += Math.Pow(vector[i], 2);
}
length = Math.Sqrt(length);
Console.WriteLine(length);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
foreach (int x in array)
    if (x > P && x < Q) count++;
return count;
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
if (array == null || array.Length == 0)
    return;
int maxIndex = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > array[maxIndex])
    {
        maxIndex = i;
    }
}
if (maxIndex == array.Length - 1) { return; }

int min = maxIndex + 1;
for (int i = maxIndex + 2; i < array.Length; i++)
{
    if (array[i] < array[min]) { min = i; }
}

(array[maxIndex], array[min]) = (array[min], array[maxIndex]);
Console.WriteLine(string.Join(",", array));
            // end

        }
        public void Task4(int[] array)
        {

            // code here
if (array != null && array.Length > 0)
{
    int maxIndex = 0;
    for (int i = 2; i < array.Length; i += 2)
    {
        if (array[i] > array[maxIndex])
            maxIndex = i;
    }
    array[maxIndex] = maxIndex;
}
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
index = -1;
if (array != null)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == P)
        {
            index = i;
            break;
        }
    }
}
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
int imax = int.MinValue;
int IxMax = -1;
for (int i = 0; i < array.Length; i++)
{
    if (imax < array[i])
    {
        imax = array[i];
        IxMax = i;
    }
}
if (IxMax == 0)
{
    return;
}
for (int i = 0; i + 1 < IxMax; i += 2)
{
    (array[i], array[i + 1]) = (array[i + 1], array[i]);
}
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
if (array != null)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] >= 0)
        {
            count++;

        }

    }
    answer = new int[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        {
            answer[index++] = array[i];
        }
    }
}
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
if (array == null || array.Length < 2)
{
    return;
}
for (int i = 1; i < array.Length; i++)
{
    int p = array[i];
    int j = i - 1;
    while (j >= 0 && array[j] < p)
    {
        array[j + 1] = array[j];
        j--;
    }

    array[j + 1] = p;
}
            // end

        }
        public void Task9(int[] array)
        {

            // code here
{
    int tepm, n = array.Length;
    for (int i = 0; i < n / 2; i++)
    {
        tepm = array[i];
        array[i] = array[n - i - 1];
        array[n - i - 1] = tepm;

    }
}
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
int[] C = null;

// code here
if (A.Length == 0)
    C = new int[A.Length];
if (B.Length == 0)
    C = new int[B.Length];
C = new int[A.Length + B.Length];
int ia = 0, ib = 0, ic = 0;
while (ia < A.Length || ib < B.Length)
{
    if (ia < A.Length)
        C[ic++] = A[ia++];
    if (ib < B.Length)
        C[ic++] = B[ib++];
}
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
if (n <= 0) { return null; }

if (n == 1)
{
    if (a == b)
    {
        return new double[] { a };
    }
    else
    {
        return null;
    }
}

if (a == b) { return null; }


array = new double[n];
if (a < b)
{
    double step = (b - a) / (n - 1);
    for (int i = 0; i < n; i++)
    {
        array[i] = a + i * step;
    }
}
else
{
    double step = (a - b) / (n - 1);
    for (int i = 0; i < n; i++)
    {
        array[i] = a - i * step;
    }
}
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
if (raw.Length < 3)
{
    restored = null;
}
else
{
    restored = new double[raw.Length];
    for (int i = 0; i < raw.Length; i++)
    {
        if (raw[i] == -1 && raw[(i - 1 + raw.Length) % raw.Length] != -1 && raw[(i + 1) % raw.Length] != -1)
        {
            restored[i] = (raw[(i + 1) % raw.Length] + raw[(i - 1 + raw.Length) % raw.Length]) / 2;
        }
        else
        {
            restored[i] = raw[i];
        }
    }
}
            // end

            return restored;
        }
    }

}
