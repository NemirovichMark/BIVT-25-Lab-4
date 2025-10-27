namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here

            if (array == null || array.Length == 0) return;

            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0) { sum += array[i]; count++; }

            if (count == 0) return;
            double avg = sum / count;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0) array[i] = avg;

            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here

            if (array == null || array.Length == 0) return 0;

            int firstNeg = -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0) { firstNeg = i; break; }

            if (firstNeg == -1) return 0;
            for (int i = 0; i < firstNeg; i++)
                sum += array[i] * array[i];

            // end

            return sum;
        }
    public int[] Task3(int[] array){
        
    int[] negatives = null;

    // code here

    if (array == null || array.Length == 0) return System.Array.Empty<int>();

    int maxI = 0, minI = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[maxI]) maxI = i;
        if (array[i] < array[minI]) minI = i;
    }

    int left = System.Math.Min(maxI, minI);
    int right = System.Math.Max(maxI, minI);

    int count = 0;
    for (int i = left + 1; i < right; i++)
        if (array[i] < 0) count++;

    if (count == 0) return new int[0];

    negatives = new int[count];
    int index = 0;
    for (int i = left + 1; i < right; i++)
        if (array[i] < 0) negatives[index++] = array[i];

    // end

    return negatives;
}
        public void Task4(int[] array)
        {

            // code here

            if (array == null || array.Length == 0) return;

            int maxI = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxI]) maxI = i;

            int negI = -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0) { negI = i; break; }

            if (negI == -1) return;
            int t = array[maxI];
            array[maxI] = array[negI];
            array[negI] = t;

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here

            if (array == null || array.Length == 0) return null;

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] > max) max = array[i];

            int count = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == max) count++;

            answer = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == max) answer[j++] = i;

            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here

            if (array == null || array.Length == 0) return;

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] > max) max = array[i];

            int add = 1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == max) array[i] += add++;

            // end

        }
        public void Task7(int[] array)
        {

            // code here

            if (array == null || array.Length == 0) return;

            int n = array.Length;
            int[] orig = new int[n];
            for (int i = 0; i < n; i++)
                orig[i] = array[i]; 

            int max = orig[0];
            for (int i = 1; i < n; i++)
                if (orig[i] > max) max = orig[i];

            int s = 0;
            for (int i = 0; i < n; i++)
            {
                if (orig[i] == max)
                    array[i] = s;
                s += orig[i];
            }

            // end

        }

        public int Task8(int[] array)
        {
            int length = 0;

            // code here

            if (array == null || array.Length == 0) return 0;

            int cur = 1, best = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i]) cur++;
                else cur = 1;
                if (cur > best) best = cur;
            }
            length = best;

            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here

            if (array == null || array.Length == 0) return;

            int m = (array.Length + 1) / 2;
            int[] ev = new int[m];
            int p = 0;
            for (int i = 0; i < array.Length; i += 2) ev[p++] = array[i];

            for (int i = 0; i < m - 1; i++)
                for (int j = i + 1; j < m; j++)
                    if (ev[i] > ev[j])
                    {
                        int t = ev[i];
                        ev[i] = ev[j];
                        ev[j] = t;
                    }

            p = 0;
            for (int i = 0; i < array.Length; i += 2) array[i] = ev[p++];

            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here

            if (array == null || array.Length == 0) return null;

            int n = array.Length;
            int[] tmp = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                bool seen = false;
                for (int j = 0; j < count; j++)
                    if (tmp[j] == array[i]) { seen = true; break; }
                if (!seen) tmp[count++] = array[i];
            }

            cleared = new int[count];
            for (int i = 0; i < count; i++) cleared[i] = tmp[i];

            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here

            if (n <= 1) return null;
            if (a == b) return null;

            A = new double[n];
            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++) A[i] = a + step * i;

            double sum = 0; int cnt = 0;
            for (int i = 0; i < n; i++)
                if (A[i] > 0) { sum += A[i]; cnt++; }

            if (cnt == 0) return System.Array.Empty<double>();

            double avg = sum / cnt;
            int k = 0;
            for (int i = 0; i < n; i++)
                if (A[i] > 0 && A[i] > avg) k++;

            B = new double[k];
            int pos = 0;
            for (int i = 0; i < n; i++)
                if (A[i] > 0 && A[i] > avg) B[pos++] = A[i];

            // end

            return B;
        }
public int Task12(int[] dices)
{
    //code here
    if (dices == null || dices.Length == 0) return 0;

    int n = dices.Length;

   
    int sixesSoFar = 0;
    int[] mine = new int[n];
    for (int i = 0; i < n; i++)
    {
        int adjusted = dices[i] - sixesSoFar;
        if (adjusted < 1) adjusted = 1;
        mine[i] = adjusted;

        if (dices[i] == 6) sixesSoFar++;
    }

    
    int wins = 0;
    for (int i = 0; i < n; i++)
    {
        int cheater = 6 - i;
        if (cheater < 1) cheater = 1;

        if (mine[i] > cheater) wins++;
    }

    return wins;
    //end
}

    }
}
