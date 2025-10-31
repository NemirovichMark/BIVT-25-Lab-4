namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            if (array == null || array.Length == 0) 
                return;
double sum = 0;
int count = 0;
foreach (double x in array)
    if (x > 0) 
    { 
        sum += x; count++; 
    }
    if (count == 0) 
        return;
double avg = sum / count;
for (int i = 0; i < array.Length; i++)
    if (array[i] > 0) array[i] = avg;

        }
        
        public int Task2(int[] array)
        {
            int sum = 0;

            if (array == null || array.Length == 0) return 0;
 int sum = 0;
 for (int i = 0; i < array.Length; i++)
 {
     if (array[i] < 0) break;
     sum += array[i] * array[i];
 }
 return sum;
            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

             int maxIdx = 0, minIdx = 0;
 for (int i = 1; i < array.Length; i++)
 {
     if (array[i] > array[maxIdx]) maxIdx = i;
     if (array[i] < array[minIdx]) minIdx = i;
 }
 int start = Math.Min(minIdx, maxIdx) + 1;
 int end = Math.Max(minIdx, maxIdx);
 if (end - start <= 0) return new int[0];
 List<int> res = new List<int>();
 for (int i = start; i < end; i++)
     if (array[i] < 0) res.Add(array[i]);
 return res.ToArray();

            return negatives;
        }
        public void Task4(int[] array)
        {

            int maxIdx = 0;
 for (int i = 1; i < array.Length; i++)
     if (array[i] > array[maxIdx]) maxIdx = i;
 int firstNeg = -1;
 for (int i = 0; i < array.Length; i++)
     if (array[i] < 0) { firstNeg = i; break; }
 if (firstNeg == -1) return;
 (array[maxIdx], array[firstNeg]) = (array[firstNeg], array[maxIdx]);

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;          
            int max = array.Max();
            List<int> idx = new List<int>();
            for (int i = 0; i < array.Length; i++)
                if (array[i] == max) idx.Add(i);
            return idx.ToArray();
            return answer;
        }
        public void Task6(int[] array)
        {

             int max = array.Max();
  int count = 1;
  for (int i = 0; i < array.Length; i++)
      if (array[i] == max) array[i] += count++;

        }
        public void Task7(int[] array)
        {

          int max = array.Max();
int[] copy = (int[])array.Clone();
for (int i = 0; i < array.Length; i++)
{
    if (copy[i] == max)
    {
        int sum = 0;
        for (int j = 0; j < i; j++)
            sum += copy[j];
        array[i] = sum;
    }
}

        }
        public int Task8(int[] array)
        {
            int length = 0;

         int maxLen = 1, curr = 1;
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < array[i - 1]) curr++;
    else { maxLen = Math.Max(maxLen, curr); curr = 1; }
}
return Math.Max(maxLen, curr);

            return length;
        }
        public void Task9(int[] array)
        {
 int n = array.Length;
 List<int> evens = new List<int>();
 for (int i = 0; i < n; i += 2) evens.Add(array[i]);
 evens.Sort();
 for (int i = 0, j = 0; i < n; i += 2, j++) array[i] = evens[j];

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;      
            List<int> res = new List<int>();
            foreach (int x in array)
                if (!res.Contains(x)) res.Add(x);
            return res.ToArray();

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

               if (n <= 0) return new double[0];
    double[] A = new double[n];
    if (n == 1) A[0] = a;
    else
    {
        double step = (b - a) / (n - 1);
        for (int i = 0; i < n; i++)
            A[i] = a + i * step;
    }
    double[] positives = A.Where(x => x > 0).ToArray();
    if (positives.Length == 0) return new double[0];
    double avg = positives.Average();
    return positives.Where(x => x > avg).ToArray();
}

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;
 if (dices == null || dices.Length == 0) return 0;
 int n = dices.Length;
 int[] player = (int[])dices.Clone();
 for (int i = 0; i < n; i++)
 {
     if (player[i] == 6)
     {
         for (int j = i + 1; j < n; j++)
             player[j] = Math.Max(1, player[j] - 1);
     }
 }
 int wins = 0;
 for (int i = 0; i < n; i++)
 {
     int opponent = Math.Max(1, 6 - i);
     if (player[i] > opponent) wins++;
 } if (dices == null || dices.Length == 0) return 0;
 int n = dices.Length;
 int[] player = (int[])dices.Clone();
 for (int i = 0; i < n; i++)
 {
     if (player[i] == 6)
     {
         for (int j = i + 1; j < n; j++)
             player[j] = Math.Max(1, player[j] - 1);
     }
 }
 int wins = 0;
 for (int i = 0; i < n; i++)
 {
     int opponent = Math.Max(1, 6 - i);
     if (player[i] > opponent) wins++;
 }

            return wins;

        }
    }
}
