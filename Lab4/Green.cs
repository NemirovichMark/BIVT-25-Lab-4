using System.Collections.Immutable;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Schema;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            double sum = 0;
            double n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    n++;
                    sum += array[i];
                }
            }
            double ans = sum / n;
            for (int i=0; i < array.Length; i++)
            {
                if (array[i] > 0){
                    array[i] = ans;
                }
            }
            Console.WriteLine(string.Join(", ", array));
            // code here

            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            int ineg = -1; 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    ineg = i;
                    break;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i < ineg) sum += array[i] * array[i];
            }
            return sum;
        }
        public int[] Task3(int[] array)
        {
            //int[] negatives = null;
            int min = int.MaxValue;
            int max = int.MinValue;
            int imax = 0, imin  = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    imax = i;
                    max = array[i];
                }
                if (array[i] < min)
                {
                    imin = i;
                    min = array[i];
                }
            }
            int b = int.Max(imax, imin);
            int a = int.Min(imax, imin);
            if (b - a <= 1)
            {
                return new int[0];
            }

            int count = 0;
            for (int i = a+1; i < b; i++)
            {
                if (array[i] < 0) count++;
            }
            int[] negatives = new int[count];

            int id = 0;
            for (int i = a + 1; i < b; i++)
            {
                if (array[i] < 0)
                {
                    negatives[id] = array[i];
                    id++;
                }
            }
            // code here

            // end

            return negatives;
        }
        public void Task4(int[] array)
        {
            int ineg = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    ineg = i;
                    break;
                }
            }
            if (ineg == -1) { 
                Console.WriteLine(0);
                return;
            }
            int maxi = int.MinValue, imax = 0;
            for (int i =0; i < array.Length; i++)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                    imax = i;
                }
            }
            (array[ineg], array[imax]) = (array[imax], array[ineg]);
            Console.WriteLine(string.Join(", ", array));
        }
        public int[] Task5(int[] array)
        {
            //int[] answer = null;
            int maxi = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                }
            }
            
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxi) count++;
            }
            int[] indexes = new int[count];
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxi)
                {
                    indexes[c] = i;
                    c++;
                }
            }
            // code here

            // end

            return indexes;
        }
        public void Task6(int[] array)
        {
            int maxi = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxi) maxi = array[i];
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxi)
                {
                    count++;
                    array[i] = array[i] + count;
                }
            }
            Console.WriteLine(string.Join(", "), array);
                // code here

                // end

        }
        public void Task7(int[] array)
        {
            int maxi = int.MinValue;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                }
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int help = array[i];
                if (array[i] == maxi)
                {
                    array[i] = sum;
                }
                sum += help;
            }
            Console.WriteLine(string.Join(", "), array);
            // code here

            // end

        }
        public int Task8(int[] array)
        {
            int length = 1;
            int max = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    length++;
                    if (length > max) max = length;
                    
                }
                else length = 1;
            }
            // code here

            // end

            return max;
        }
        public void Task9(int[] array)
        {
                        
            int[] a = new int[array.Length / 2 + array.Length % 2];
            if (array.Length < 2)
            {
                return;
            }
            for (int i = 0; i < array.Length - 1; i += 2)
            {
                int imin = i;
                for (int j = i + 2; j < array.Length; j += 2)
                {
                    if (array[j] < array[imin])
                    {
                        imin = j;
                    }
                }
                (array[imin], array[i]) = (array[i], array[imin]);
            }
            Console.WriteLine(string.Join(", ", array));
            // code here

            // end

        }
        public int[] Task10(int[] array)
        {
            int[] a = new int[array.Length];
            int count = 0;

            for (int i= 0; i < array.Length; i++)
            {
                bool check = false;
                for (int j = 0; j < count; j++)
                {
                    if (array[i] == a[j]){
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    a[count] = array[i];
                    count++;
                }
            }

            int[] cleared = new int[count];
            for (int i = 0; i < count; i++)
            {
                cleared[i] = a[i]; //тк в массиве а слишком много пустых ячеек
            }
            // code here

            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;
            if (n <= 1 || b == a) return B;
            A = new double[n];
            double step = (b - a) / (n - 1); 
            double sum = 0, count = 0;


            for (int i = 0; i < n; i++)
            {
                A[i] = a + i * step;
                if (A[i] > 0)
                {
                    count++;
                    sum += A[i];
                }
            }

            double check = sum / count;
            int countB = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > check)
                {
                    countB++;
                }
            }

            B = new double[countB];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > check)
                {
                    B[k] = A[i];
                    k++;
                }
            }

            return B;

        }
        public int Task12(int[] dices)
        {
            int wins = 0;
            int count_sharper = 0;
            int count_me = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                int dices_sharper = 6 - count_sharper;
                int dices_me = dices[i] - count_me;
                count_sharper++;
                if (dices_me < 1) dices_me = 1;
                if (dices_sharper < 1) dices_sharper = 1;
                if (dices_me > dices_sharper) wins++;
                if (dices[i] == 6) count_me++;
            }
            return wins;

        }
    }
}