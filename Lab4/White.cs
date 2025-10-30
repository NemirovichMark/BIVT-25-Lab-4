namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            //length = Math.Sqrt()
            for (int i = 0; i < vector.Length; i++)
            {
                length += vector[i] * vector[i];
            }

            return Math.Sqrt(length);
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;
            int lower = Math.Min(P, Q);
            int upper = Math.Max(P, Q);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > lower && array[i] < upper)
                {
                    count++;
                }
                
            }


            return count;
        }
        public void Task3(int[] array)
        {
            int maxx = int.MinValue;
            int MaxIdx = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                    MaxIdx = i;
                }
            }
            if (MaxIdx == array.Length - 1)
            {
                return;
            }
            int minn = int.MaxValue;
            int MinIdx = -1;
            for (int i = MaxIdx + 1; i <  array.Length; i++)
            {
                if (array[i] < minn)
                {
                    minn = array[i];
                    MinIdx = i;
                }
            }
            if (MinIdx == -1 || MinIdx == MaxIdx)
            {
                return;
            }

            int q = array[MaxIdx];
            array[MaxIdx] = array[MinIdx];
            array[MinIdx] = q;

        }
        public void Task4(int[] array)
        {
            int index = -1;
            int mxx = int.MinValue;
            for (int i = 0; i < array.Length; i ++)
            {
                if (i % 2 == 0 && mxx < array[i])
                {
                    index = i;
                    mxx = array[i];
                    
                }

            }
            array[index] = index;
           
        }
        public int Task5(int[] array, int P)
        {
            int index = 0;
            bool Flag = false;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    Flag = true;
                    break;
                }

            }
            if (!Flag)
            {
                index = -1;
            }

            return index;
        }
        public void Task6(int[] array)
        {
            int maxx = int.MinValue;
            int IdxMax = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxx < array[i])
                {
                    maxx = array[i];
                    IdxMax = i;
                }
            }
            if (IdxMax == 0)
            {
                return;
            }
            for (int i = 0; i + 1 < IdxMax; i += 2)
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
            }
        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                count++;
            }
            answer = new int[count];
            int idx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[idx] = array[i];
                    idx++;
                }
            }



            return answer;
        }
        public void Task8(int[] array)
        {

           for (int i = 0; i < array.Length; i++)
            {
                bool hasSwapped = false;
                for (int j = 1; j < array.Length - i; j++)
                {
                    if (array[j] > array[j - 1])
                    {
                        (array[j], array[j - 1]) = (array[j - 1], array[j]);
                        hasSwapped = true;
                    }
                }
                if (!hasSwapped) break;
            }

        }
        public void Task9(int[] array)
        {
            int L = array.Length;
            for (int i = 0; i < L / 2; i++ )
            {
                int temp = array[i];
                array[i] = array[L - 1 - i];
                array[L - 1 - i] = temp;
            }


        }
        public int[] Task10(int[] A, int[] B)
        {
            //int[] C = null;
            int[] C = new int[A.Length + B.Length];
            if (A == null)
            {
                for (int i = 0; i < C.Length; i++)
                {
                    C[i] = B[i];
                }
                return C;
            }

            if (B == null)
            {
                for (int i = 0; i < C.Length; i++)
                {
                    C[i] = A[i];
                }
                return C;
            }
            


            int indexA = 0, indexB = 0;

            for (int i  = 0; i < C.Length; i ++)
            {
                if (i % 2 == 0)
                {
                    if (indexA < A.Length)
                    {
                        C[i] = A[indexA];
                        indexA++;
                    }
                    else
                    {
                        C[i] = B[indexB];
                        indexB++;
                    }
                    
                }
                if (i % 2 != 0)
                {
                    if (indexB < B.Length)
                    {
                        C[i] = B[indexB];
                        indexB++;
                    }
                    else
                    {
                        C[i] = A[indexA];
                        indexA++;
                    }
                    
                }
            }

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            
            if (n == 0) return null;
            double[] array = new double[n];
            if (n == 1)
            {
                if (a == b)
                {
                    array[0] = a;
                    return array;
                }
                else return null;

            }
            double step = (b - a) / (n - 1);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = a + i * step;
            }
            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;
            if (raw.Length < 3) return null;
            restored = new double[raw.Length];
            bool allbad = true;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] != -1)
                {
                    allbad = false;
                    break;
                }
            }
            if (allbad)
            {
                for (int i = 0; i < raw.Length; i++)
                {
                    restored[i] = raw[i];
                }
                return restored;
            }

            restored[0] = raw[0];
            restored[raw.Length - 1] = raw[raw.Length - 1];
            for (int i = 1; i < raw.Length - 1; i++)
            {
                if (raw[i] == -1)
                {
                    if (raw[i - 1] != -1 && raw[i + 1] != -1)
                    {
                        restored[i] = (raw[i - 1] + raw[i + 1]) / 2;
                    }
                    else
                    {
                        restored[i] = raw[i];
                    }
                }
                else
                {
                    restored[i] = raw[i];
                }
            }


            return restored;
        }
    }
}



