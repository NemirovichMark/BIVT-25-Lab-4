namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            // code here
            double mean, sum = 0.0, max = array[0];
            int lenght = array.Length;
            for (int i = 0; i < lenght; i++)
            {
                if (array[i] > max)
                    max = array[i];
                sum += array[i];
            }

            mean = sum / lenght;
            var afterMax = false;
            for (int i = 0; i < lenght; i++)
            {
                if (afterMax)
                    array[i] = mean;
                if (array[i] == max)
                    afterMax = true;
            }

            Console.WriteLine(array);
            // end
        }

        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            var lenght = array.Length;
            var evenArray = new int[(int)Math.Ceiling(lenght / 2.0)];
            var oddArray = new int[lenght / 2];

            for (int i = 0; i < lenght; i++)
            {
                if (i % 2 == 0)
                    evenArray[i - i / 2] = array[i];
                else
                    oddArray[i - i / 2 - 1] = array[i];
            }

            Console.WriteLine(evenArray);
            Console.WriteLine(oddArray);
            // end

            return (evenArray, oddArray);
        }

        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int sum = 0, minElem = 0;
            double minDelta = 999999, mean;
            var arrayLenght = array.Length;

            foreach (var elem in array)
                sum += elem;
            mean = sum / (float)arrayLenght;

            for (int i = 0; i < arrayLenght; i++)
            {
                if (Math.Abs(mean - array[i]) < minDelta)
                {
                    minElem = array[i];
                    minDelta = Math.Abs(mean - array[i]);
                }
            }

            answer = new int[arrayLenght + 1];
            var minFound = false;
            int j = 0;

            for (int i = 0; i < arrayLenght; i++)
            {
                answer[j] = array[i];
                if (array[i] == minElem && !minFound)
                {
                    j++;
                    answer[j] = P;
                    minFound = true;
                }

                j++;
            }
            // end

            return answer;
        }

        public void Task4(int[] array)
        {
            // code here
            var countNegativ = 0;
            var ansArray = new int[array.Length];

            foreach (var elem in array)
            {
                if (elem < 0)
                    countNegativ++;
            }

            var currentPositionNegativElem = array.Length - countNegativ;
            var countUseNegativ = 0;
            for (var i = 0; i < array.Length; i++)
            {
                var currentElem = array[i];
                if (currentElem >= 0)
                    ansArray[i - countUseNegativ] = currentElem;
                else
                {
                    ansArray[currentPositionNegativElem] = currentElem;
                    currentPositionNegativElem++;
                    countUseNegativ++;
                }
            }

            for (int i = 0; i < array.Length; i++)
                array[i] = ansArray[i];
            // end
        }

        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k < A.Length)
            {
                answer = new int[A.Length + B.Length];
                for (var i = 0; i < k && i < A.Length; i++)
                    answer[i] = A[i];
                for (var i = 0; i < B.Length; i++)
                    answer[k + i] = B[i];
                for (var i = k; i < A.Length; i++)
                    answer[B.Length + i] = A[i];
            }
            else
                return A;
            // end

            return answer;
        }

        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length == B.Length)
            {
                sum = new int[A.Length];
                dif = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            }
            // end

            return (sum, dif);
        }

        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            var maxElem = array[0];
            var minElem = array[0];
            var prevElem = array[0];
            var isDifferent = false;
            
            foreach (var elem in array)
            {
                if (prevElem != elem)
                    isDifferent = true;
                if (elem > maxElem)
                    maxElem = elem;
                if (elem < minElem)
                    minElem = elem;
                prevElem = elem;
            }

            if (isDifferent)
            {
                normalized = new double[array.Length];
                for (var i = 0; i < array.Length; i++)
                    normalized[i] = (2 * (array[i] - minElem) / (double)(maxElem - minElem)) - 1;
            }
            // end

            return normalized;
        }

        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            int idxA = 0, idxB = 0, totalIdx = 0, curIdx = 0;
            C = new int[A.Length + B.Length];
            Array.Sort(A);
            Array.Sort(B);

            while (idxA < A.Length && idxB < B.Length)
            {
                if (A[idxA] < B[idxB])
                    C[totalIdx] = A[idxA++];
                else
                    C[totalIdx] = B[idxB++];
                totalIdx++;
            }

            for (var i = idxA; i < A.Length; i++)
                C[totalIdx + curIdx++] = A[i];

            curIdx = 0;
            for (var i = idxB; i < B.Length; i++)
                C[totalIdx + curIdx++] = B[i];

            for (var i = 0; i < C.Length / 2; i++)
                (C[i], C[^(i + 1)]) = (C[^(i + 1)], C[i]);
            // end

            return C;
        }

        public void Task9(int[] array)
        {
            // code here
            int maxElem = array[0], idxMaxElem = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElem)
                {
                    maxElem = array[i];
                    idxMaxElem = i;
                }
            }

            var temp = new int[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                var newPos = (i + idxMaxElem) % array.Length;
                temp[newPos] = array[i];
            }

            for (var i = 0; i < array.Length; i++)
                array[i] = temp[i];
            // end
        }

        public void Task10(int[] array, int N)
        {
            // code here
            for (var i = N - 1; N > 0 && i < array.Length; i++)
            {
                array[i] = array[N - 1];
                N--;
            }
            // end
        }

        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            double step = (b - a) / (n - 1);
            if (step == 0 || a > b)
                return (null, null);
            var tempXext = new double[n];
            var tempYext = new double[n];
            X = new double[n];
            Y = new double[n];
            var countExt = 0;

            for (var i = 0; i < n; i++)
            {
                var xElem = a + step * i;
                X[i] = xElem;
                Y[i] = Math.Cos(xElem) + xElem * Math.Sin(xElem);
            }

            for (var i = 1; i < X.Length - 1; i++)
            {
                if (Y[i - 1] < Y[i] && Y[i + 1] < Y[i])
                {
                    tempXext[countExt] = X[i];
                    tempYext[countExt++] = Y[i];
                }

                if (Y[i - 1] > Y[i] && Y[i + 1] > Y[i])
                {
                    tempXext[countExt] = X[i];
                    tempYext[countExt++] = Y[i];
                }
            }

            Xext = new double[countExt];
            Yext = new double[countExt];
            for (var i = 0; i < countExt; i++)
            {
                Xext[i] = tempXext[i];
                Yext[i] = tempYext[i];
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            int brightIdx = 0, normalIdx = 0, dimIdx = 0;
            var rawLength = raw.Length;
            double mean, sum = 0;
            bright = new double[rawLength];
            normal = new double[rawLength];
            dim = new double[rawLength];

            foreach (var elem in raw)
                sum += elem;
            mean = sum / rawLength;

            foreach (var elem in raw)
            {
                if (elem > 2 * mean)
                    bright[brightIdx++] = elem;
                else if (elem < 0.5 * mean)
                    dim[dimIdx++] = elem;
                else
                    normal[normalIdx++] = elem;
            }

            var brightClean = new double[brightIdx];
            var dimClean = new double[dimIdx];

            for (int i = 0; i < dimIdx; i++)
                dimClean[i] = dim[i];

            for (int i = 0; i < brightIdx; i++)
                brightClean[i] = bright[i];

            sum = 0;
            foreach (var elem in normal)
                sum += elem;
            mean = sum / normalIdx;

            while (dimIdx > 0)
            {
                normal[normalIdx] = (dim[dimIdx - 1] + mean) / 2;
                dimIdx--;
                normalIdx++;
            }

            while (brightIdx > 0)
            {
                normal[normalIdx] = (bright[brightIdx - 1] + mean) / 2;
                brightIdx--;
                normalIdx++;
            }

            Array.Sort(normal);
            for (var i = 0; i < normal.Length / 2; i++)
                (normal[i], normal[^(i + 1)]) = (normal[^(i + 1)], normal[i]);

            dim = dimClean;
            bright = brightClean;
            // end

            return (bright, normal, dim);
        }
    }
}