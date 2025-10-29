using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here

            int pmin = -1, pmax = -1, max = -10000000, sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    pmin = i;
                    break;
                }
            }
            if (pmin == -1) return;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    pmax = i;
                }
            }
            if (pmax == array.Length - 1)
            {
                array[pmin] = 0;
            }
            else
            {
                for(int i = pmax + 1; i < array.Length; i++)
                {
                    sum += array[i];
                }
            }
            array[pmin] = sum;

            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here

            int im = -1;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    im = i;
                }
            }
            if (im == -1) return array;
            else
            {
                int[] na = new int[array.Length + 1];
                for(int i = 0; i <= im; i++)
                {
                    na[i] = array[i];
                }
                na[im + 1] = P;
                for(int i = im + 1; i < array.Length; i++)
                {
                    na[i + 1] = array[i];
                }
                return na;
            }

                // end

            
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here

            bool flag = false;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                return array;
            }
            else
            {
                int minm = int.MaxValue, indminm = 0;
                for(int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        if (array[i] < minm)
                        {
                            minm = array[i];
                            indminm = i;
                        }
                    }
                }
                int[] newarray = new int[array.Length - 1];
                for(int i = 0; i < indminm; i++)
                {
                    newarray[i] = array[i];
                }
                for(int i = indminm; i < newarray.Length; i++)
                {
                    newarray[i] = array[i + 1];
                }
                return newarray;
            }


                // end

                
        }
        public double[] Task4(double[] array)
        {

            // code here
            if(array == null || array.Length == 0)
            {
                return array ?? new double[0];
            }

            double sum = 0.0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double srzn = sum / array.Length;
            for(int i = 0; i < array.Length; i++)
            {
                array[i] -= srzn;
            }

            // end

            return array;
        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;
            if(A == null || B == null || A.Length != B.Length)
            {
                return 0;
            }
            // code here
            else
            {
                int minL = Math.Min(A.Length, B.Length);
                for (int i = 0; i < minL; i++)
                {
                    sum += A[i] * B[i];
                }

                // end

                return sum;
            }
            
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            if(array == null)
            {
                return indexes;
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                double sr = sum / (double)array.Length;
                int cnt = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < sr)
                    {
                        cnt++;
                    }
                }
                int[] newind = new int[cnt];
                cnt = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < sr)
                    {
                        newind[cnt++] = i;
                        
                    }
                }
                return newind;
            }
            

            // end

        }
        public int Task7(int[] array)
        {
            int count = 1;
            if(array.Length < 2)
            {
                return array.Length;
            }
            else
            {
                // code here
                int max = 1;
                int v = 1;
                int u = 1;
                for(int i = 1; i < array.Length; i++)
                {
                    if (array[i] >= array[i - 1])
                    {
                        v++;
                        max = Math.Max(max, v);
                    }
                    else
                    {
                        v = 1;
                    }
                    if (array[i] <= array[i - 1])
                    {
                        u++;
                        max = Math.Max(max, u);
                    }
                    else
                    {
                        u = 1;
                    }
                }

                // end

                return max;
            }
            
        }
        public int[] Task8(int[] array)
        {
            
            if(array == null)
            {
                return array;
            }
            
            // code here
            int[] answer = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                answer[i*2] = array[i];
                answer[i*2 + 1] = array[i];
            }
            return answer;
            
                // end

                
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;
            int max = -int.MaxValue, min = int.MaxValue;
            if(array == null)
            {
                return normalized;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
                if (max == min)
                {
                    return normalized;
                }
                else
                {
                    double[] newarray = new double[array.Length];
                    for(int i = 0; i < array.Length; i++)
                    {
                        newarray[i] = (array[i] - min) / (double)(max - min);
                    }
                    return newarray;
                }
            }
                
            // code here



            // end

            
        }
        public int Task10(int[] array, int P)
        {
            int index = -1;
            if(array == null)
            {
                return -1;
            }
            // code here
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1]) (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }

            int left_bound = 0, right_bound = array.Length - 1;
            

            while(left_bound <= right_bound)
            {
                int mid = (left_bound + right_bound) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P)
                {
                    left_bound = mid + 1;
                }
                else
                {
                    right_bound = mid - 1;
                }
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;
            if (b <= 0)
            {
                return array;
            }
            // code here
            else
            {
                int cnt = 0;
                for (int i = 0; (a + b * i) <= c; i++)
                {
                    cnt++;
                }
                int[] newarray = new int[cnt];
                for (int i = 0; (a + b * i) <= c && (i < cnt); i++)
                {
                    newarray[i] = a + b * i; 
                }
                
                return newarray;
            }
            
            

            // end

            
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;
            if(magazine.Length <= 3)
            {
                if(magazine.Length == 0)
                {
                    return null;
                }
                else
                {
                    int[] ans = new int[magazine.Length];
                    for(int i = 0; i < magazine.Length; i++)
                    {
                        ans[i] = i;
                    }
                    return ans;
                }
            }
            else
            {
                int[] ind = new int[3];
                int maxs = -1;
                for(int i = 0; i < magazine.Length - 2; i++)
                {
                    if (magazine[i] + magazine[i + 1] + magazine[i + 2] > maxs)
                    {
                        maxs = magazine[i] + magazine[i + 1] + magazine[i + 2];
                        ind[0] = i;
                        ind[1] = i + 1;
                        ind[2] = i + 2;
                    }
                }
                return ind;
            }

                
        }
    }
}
