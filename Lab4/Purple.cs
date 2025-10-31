namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            if (array.Length == 0) return;
            double max = array[0];
            int maxIndex = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            double average = sum / array.Length;
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                array[i] = average;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int evenCount = (array.Length + 1) / 2;
            int oddCount = array.Length / 2;
            even = new int[evenCount];
            odd = new int[oddCount];
            for (int i = 0, e = 0, o = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[e++] = array[i];
                }
                else
                {
                    odd[o++] = array[i];
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            if (array.Length == 0) return new int[0];
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double avg = (double)sum / array.Length;
            int closestIndex = 0;
            double minDiff = System.Math.Abs(array[0] - avg);
            for (int i = 1; i < array.Length; i++)
            {
                double diff = System.Math.Abs(array[i] - avg);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    closestIndex = i;
                }
            }
            answer = new int[array.Length + 1];
            for (int i = 0, j = 0; i < answer.Length; i++)
            {
                if (i == closestIndex + 1)
                {
                    answer[i] = P;
                }
                else
                {
                    answer[i] = array[j++];
                }
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int posCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) posCount++;
            }
            int negCount = array.Length - posCount;
            int[] positives = new int[posCount];
            int[] negatives = new int[negCount];
            for (int i = 0, p = 0, n = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) positives[p++] = array[i];
                else negatives[n++] = array[i];
            }
            for (int i = 0; i < posCount; i++) array[i] = positives[i];
            for (int i = 0; i < negCount; i++) array[posCount + i] = negatives[i];
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k < 0 || k > A.Length)
            {
                answer = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    answer[i] = A[i];
                }
                return answer;
            }
            answer = new int[A.Length + B.Length];
            int idx = 0;
            for (int i = 0; i < k; i++)
            {
                answer[idx++] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                answer[idx++] = B[i];
            }
            for (int i = k; i < A.Length; i++)
            {
                answer[idx++] = A[i];
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length != B.Length)
            {
                return (null, null);
            }
            int len = A.Length;
            sum = new int[len];
            dif = new int[len];
            for (int i = 0; i < len; i++)
            {
                sum[i] = A[i] + B[i];
                dif[i] = A[i] - B[i];
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            int min = array[0], max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }
            if (min == max) return null;
            normalized = new double[array.Length];
            double range = (double)(max - min);
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = -1.0 + 2.0 * ((double)array[i] - min) / range;
            }
            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            int aLen = A.Length;
            int bLen = B.Length;
            int[] aCopy = new int[aLen];
            int[] bCopy = new int[bLen];
            for (int i = 0; i < aLen; i++) aCopy[i] = A[i];
            for (int i = 0; i < bLen; i++) bCopy[i] = B[i];
            for (int i = 1; i < aLen; i++)
            {
                int key = aCopy[i];
                int j = i - 1;
                while (j >= 0 && aCopy[j] < key)
                {
                    aCopy[j + 1] = aCopy[j];
                    j--;
                }
                aCopy[j + 1] = key;
            }
            for (int i = 1; i < bLen; i++)
            {
                int key = bCopy[i];
                int j = i - 1;
                while (j >= 0 && bCopy[j] < key)
                {
                    bCopy[j + 1] = bCopy[j];
                    j--;
                }
                bCopy[j + 1] = key;
            }
            C = new int[aLen + bLen];
            int iA = 0, iB = 0, k = 0;
            while (iA < aLen && iB < bLen)
            {
                if (aCopy[iA] >= bCopy[iB])
                {
                    C[k++] = aCopy[iA++];
                }
                else
                {
                    C[k++] = bCopy[iB++];
                }
            }
            while (iA < aLen) C[k++] = aCopy[iA++];
            while (iB < bLen) C[k++] = bCopy[iB++];
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            if (array.Length == 0) return;
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            int shift = maxIndex;
            if (shift == 0) return;
            int n = array.Length;
            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
            {
                temp[(i + shift) % n] = array[i];
            }
            for (int i = 0; i < n; i++) array[i] = temp[i];
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            if (N < 1 || N > array.Length) return;
            int leftCount = N - 1;
            int rightCount = array.Length - N;
            int mirrorCount = leftCount < rightCount ? leftCount : rightCount;
            for (int i = 0; i < mirrorCount; i++)
            {
                array[N + i] = array[N - 2 - i];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (n <= 0 || a > b || (a == b && n > 1)) return (null, null);
            X = new double[n];
            Y = new double[n];
            double step = (n == 1) ? 0 : (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                X[i] = a + i * step;
                Y[i] = System.Math.Cos(X[i]) + X[i] * System.Math.Sin(X[i]);
            }
            int extCount = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    extCount++;
                }
            }
            Xext = new double[extCount];
            Yext = new double[extCount];
            int idx = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    Xext[idx] = X[i];
                    Yext[idx] = Y[i];
                    idx++;
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            if (raw.Length == 0) return (new double[0], new double[0], new double[0]);
            double sum = 0;
            for (int i = 0; i < raw.Length; i++) sum += raw[i];
            double avg = sum / raw.Length;

            int brightCount = 0, dimCount = 0, normalCount = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * avg) brightCount++;
                else if (raw[i] < 0.5 * avg) dimCount++;
                else normalCount++;
            }

            bright = new double[brightCount];
            dim = new double[dimCount];
            normal = new double[normalCount];

            for (int i = 0, b = 0, d = 0, m = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * avg) bright[b++] = raw[i];
                else if (raw[i] < 0.5 * avg) dim[d++] = raw[i];
                else normal[m++] = raw[i];
            }

            double newAvg = 0;
            if (normalCount > 0)
            {
                double s = 0;
                for (int i = 0; i < normalCount; i++) s += normal[i];
                newAvg = s / normalCount;
            }

            int totalNormal = normalCount + brightCount + dimCount;
            double[] normalFinal = new double[totalNormal];
            int idxF = 0;
            for (int i = 0; i < normalCount; i++) normalFinal[idxF++] = normal[i];
            for (int i = 0; i < brightCount; i++) normalFinal[idxF++] = 0.5 * (newAvg + bright[i]);
            for (int i = 0; i < dimCount; i++) normalFinal[idxF++] = 0.5 * (newAvg + dim[i]);
            for (int i = 1; i < normalFinal.Length; i++)
            {
                double key = normalFinal[i];
                int j = i - 1;
                while (j >= 0 && normalFinal[j] < key)
                {
                    normalFinal[j + 1] = normalFinal[j];
                    j--;
                }
                normalFinal[j + 1] = key;
            }

            normal = normalFinal;
            // end

            return (bright, normal, dim);
        }
    }
}
