namespace Lab4
{
    
    public class Purple
    {
        private void SwapImpl(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        
        private void SwapImpl(double[] array, int i, int j)
        {
            double temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        private void ReverseImpl(int[] array, int start, int endExclusive)
        {
            int left = start, right = endExclusive - 1;
            while (left < right)
            {
                SwapImpl(array, left, right);
                ++left;
                --right;
            }
        }

        private void SelectionSort(int[] arr, bool isReverse = false)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; ++i)
            {
                int selectedIdx = i;
                for (int j = i + 1; j < n; ++j)
                {
                    if ((isReverse && arr[j] > arr[selectedIdx]) || (!isReverse && arr[j] < arr[selectedIdx]))
                    {
                        selectedIdx = j;
                    }
                }
                if (selectedIdx != i)
                {
                    SwapImpl(arr, i, selectedIdx);
                }
            }
        }
        
        private void SelectionSort(double[] arr, bool isReverse = false)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; ++i)
            {
                int selectedIdx = i;
                for (int j = i + 1; j < n; ++j)
                {
                    if ((isReverse && arr[j] > arr[selectedIdx]) || (!isReverse && arr[j] < arr[selectedIdx]))
                    {
                        selectedIdx = j;
                    }
                }
                if (selectedIdx != i)
                {
                    SwapImpl(arr, i, selectedIdx);
                }
            }
        }
        public void Task1(double[] array)
        {
            if (array.Length == 0)
            {
                return;
            }
            double maxVal = array[0];
            double avg = array[0];
            int maxElemIdx = 0;
            for (int i = 1; i < array.Length; ++i)
            {
                avg += array[i];
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                    maxElemIdx = i;
                }
            }
            avg /= array.Length;
            for (int i = maxElemIdx + 1; i < array.Length; ++i)
            {
                array[i] = avg;
            }
        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int n = array.Length;
            int even = (n + 1) / 2;
            int odd = n / 2;
            
            int[] evenArr = new int[even];
            int[] oddArr = new int[odd];

            for (int i = 0; i < n; ++i)
            {
                if (i % 2 == 0)
                {
                    evenArr[i / 2] = array[i];
                }
                else
                {
                    oddArr[i / 2] = array[i];
                }
            }
            
            return (evenArr, oddArr);
        }

        public int[] Task3(int[] array, int P)
        {
            int n = array.Length;
            if (n == 0) return new int[] { P };

            double avg = 0;
            for (int i = 0; i < n; ++i)
            {
                avg += array[i];
            }
            avg /= n;
            double minDiff = Math.Abs(avg - array[0]);
            int elemId = 0;
            for (int i = 1; i < n; ++i)
            {
                if (Math.Abs(array[i] - avg) < minDiff)
                {
                    elemId = i;
                    minDiff = Math.Abs(array[i] - avg);
                }
            }
            
            int[] answer = new int[n + 1];
            for (int i = 0; i <= elemId; ++i)
            {
                answer[i] = array[i];
            }
            answer[elemId + 1] = P;
            for (int i = elemId + 1; i < n; ++i)
            {
                answer[i + 1] = array[i];
            }
            return answer;
        }
        public void Task4(int[] array)
        {
            int n = array.Length;
            if (n == 0)
            {
                return;
            }
            int[] tmp = new int[n];
            int idx = 0;
            for (int i = 0; i < n; ++i)
            {
                if (array[i] >= 0)
                {
                    tmp[idx++] = array[i];
                }
            }
            for (int i = 0; i < n; ++i)
            {
                if (array[i] < 0)
                {
                    tmp[idx++] = array[i];
                }
            }
            for (int i = 0; i < n; ++i)
            {
                array[i] = tmp[i];
            }
        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int n = A.Length;
            int m = B.Length;

            if (m == 0 || k < 0 || k > n)
            {
                int[] cp = new int[n];
                for (int i = 0; i < n; ++i)
                {
                    cp[i] = A[i];
                }
                return cp;
            }
            
            int[] answer  = new int[n + m];
            for (int i = 0; i < k; i++)
            {
                answer[i] = A[i];
            }
            for (int i = 0; i < m; i++)
            {
                answer[k + i] = B[i];
            }
            for (int i = k; i < n; i++)
            {
                answer[m + i] = A[i];
            }
            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            if (A == null || B == null || A.Length != B.Length)  return (null, null);
            int n = A.Length;
            int[] sum = new int[n], dif = new int[n];

            for (int i = 0; i < n; ++i)
            {
                if (A[i] == null || B[i] == null)  continue;
                sum[i] = A[i] + B[i];
                dif[i] = A[i] - B[i];
            }

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            if (array.Length == 0) return null;

            int n = array.Length;
            int min = array[0], max = array[0];
            for (int i = 1; i < n; ++i)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            if (min == max) return null;

            double range = (double)(max - min);
            double[] normalized = new double[n];
            for (int i = 0; i < n; ++i)
            {
                // a*min + b = -1; a*max + b = 1
                // a*(max − min) = 2 => a = 2/(max - min)
                // => b = -1 - a*min = -(max + min)/(max - min)
                // y = (2/(max - min))*x - (max + min)/(max - min)
                // = 2*(x - min)/(max - min) - 1
                normalized[i] = (2.0 * (array[i] - min) / range) - 1.0;
            }
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int aLen = A.Length, bLen = B.Length;
            int[] sa = new int[aLen];
            int[] sb = new int[bLen];
            for (int i = 0; i < aLen; i++)
            {
                sa[i] = A[i];
            }
            for (int i = 0; i < bLen; i++)
            {
                sb[i] = B[i];
            }
            SelectionSort(sa, true/*reverse*/);
            SelectionSort(sb, true/*reverse*/);
            int ap = 0, bp = 0, cp = 0;
            int[] C = new int[aLen + bLen];
            while (ap < aLen && bp < bLen)
            {
                if (sa[ap] >= sb[bp])
                {
                    C[cp++] = sa[ap++];
                }
                else
                {
                    C[cp++] = sb[bp++];
                }
            }

            while (ap < aLen)
            {
                C[cp++] = sa[ap++];
            }

            while (bp < bLen)
            {
                C[cp++] = sb[bp++];
            }
            return C;
        }
        public void Task9(int[] array)
        {
            if (array.Length == 0) return;
            int n = array.Length;
            int maxVal = array[0];
            int idx = 0;
            for (int i = 1; i < n; ++i)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                    idx = i;
                }
            }
            if (idx == 0 || idx == n) return;
            ReverseImpl(array, 0, n);
            ReverseImpl(array, 0, idx);
            ReverseImpl(array, idx, n);
        }
        public void Task10(int[] array, int N)
        {
            if (array.Length == 0 || N >= array.Length) return;
            for (int j = N - 2, i = N; 0 <= j && i < array.Length; ++i, --j)
            {
                array[i] = array[j];
            }
        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            // y = cosx + xsinx
            if (n > 1 && a >= b)
            {
                return (null, null);
            }

            if (n <= 2)
            {
                return (Array.Empty<double>(), Array.Empty<double>());
            }

            double step = (b - a) / (n - 1);
            if (step <= 0)
            {
                return (null, null);
            }
            
            double yPrev = Math.Cos(a) + a * Math.Sin(a);
            double xCurr = a + step;
            double yCurr = Math.Cos(xCurr) + xCurr * Math.Sin(xCurr);
            int extrCount = 0;

            for (int i = 1; i < n - 1; ++i)
            {
                double xNext = a + (i + 1) * step;
                double yNext = Math.Cos(xNext) + xNext * Math.Sin(xNext);

                if ((yCurr > yPrev && yCurr > yNext) || (yCurr < yPrev && yCurr < yNext))
                {
                    ++extrCount;
                }

                yPrev = yCurr;
                yCurr = yNext;
            }
            double[] xext = new double[extrCount];
            double[] yext = new double[extrCount];

            yPrev = Math.Cos(a) + a * Math.Sin(a);
            xCurr = a + step;
            yCurr = Math.Cos(xCurr) + xCurr * Math.Sin(xCurr);
            int idx = 0;

            for (int i = 1; i < n - 1; ++i)
            {
                double xNext = a + (i + 1) * step;
                double yNext = Math.Cos(xNext) + xNext * Math.Sin(xNext);

                if ((yCurr > yPrev && yCurr > yNext) || (yCurr < yPrev && yCurr < yNext))
                {
                    double xAt = a + i * step;
                    xext[idx] = xAt;
                    yext[idx] = yCurr;
                    idx++;
                }

                yPrev = yCurr;
                yCurr = yNext;
            }

            return (xext, yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            if (raw == null || raw.Length == 0)
            {
                return (null, null, null);
            }

            int n = raw.Length;
            double avgAll = 0;
            for (int i = 0; i < n; ++i)
            {
                avgAll += raw[i];
            }
            avgAll /= n;
            
            bool[] removed = new bool[n];
            int brightCount = 0, dimCount = 0, simpleCount = 0;
            double simpleSum = 0;

            for (int i = 0; i < n; ++i)
            {
                double v = raw[i];
                if (v > 2 * avgAll)
                {
                    removed[i] = true;
                    ++brightCount;
                }
                else if (v < 0.5 * avgAll)
                {
                    removed[i] = true;
                    ++dimCount;
                }
                else
                {
                    simpleSum += v;
                    ++simpleCount;
                }
            }
            
            double[] bright = new double[brightCount];
            double[] dim = new double[dimCount];
            int bi = 0, di = 0;
            for (int i = 0; i < n; ++i)
            {
                double v = raw[i];
                if (v > 2 * avgAll)
                {
                    bright[bi++] = v;
                }
                else if (v < 0.5 * avgAll)
                {
                    dim[di++] = v;
                }
            }
            double avgSimple = simpleCount > 0 ? simpleSum / simpleCount : avgAll;
            
            double[] normal = new double[n];
            for (int i = 0; i < n; i++)
            {
                normal[i] = removed[i] ? 0.5 * (avgSimple + raw[i]) : raw[i];
            }
            
            SelectionSort(normal, true /*reverse*/);

            return (bright, normal, dim);
        }
    }
}