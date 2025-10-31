using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            //getting max (eto ne chat gpt, mne udobno pisat takie komentarii)
            
            int max_i = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int el = array[i];
                if (el > array[max_i])
                {
                    max_i = i;
                }
            }



            //finding sum
            int sum = 0-array[max_i];
            for (int i=max_i; i < array.Length; i++) {
                sum += array[i];
            }

            //replacing element
            for (int i=0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = sum;
                    break;
                }
            }

            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;




            int last_pol_i = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    last_pol_i = i;
                }
            }

            int len = array.Length+1;

            

            answer = new int[len];



            


            for (int i = 0; i < array.Length; i++)
            {
                if (i <= last_pol_i)
                {
                    answer[i] = array[i];
                }
                else
                {
                    answer[i + 1] = array[i];
                }
            }

            if (last_pol_i != -1)
            {
                answer[last_pol_i + 1] = P;
            }
            else
            {
                return array;
            }




            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here

            int min_pol_i = -1;



            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (min_pol_i == -1 || array[i] < array[min_pol_i])
                    {
                        min_pol_i = i;
                    }
                }

            }



            if (min_pol_i != -1)
            {

            }
            else
            {
                return array;
            }

            int len = array.Length - 1;



            answer = new int[len];


            for (int i =0; i <answer.Length; i++)
            {
                if (i < min_pol_i)
                {
                    answer[i] = array[i];
                }
                else
                {
                    answer[i] = array[i+1];
                }
            }


            



            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here



            double sum = 0.0;
            for (int i=0; i < array.Length; i++)
            {
                sum += array[i];
            }


            double avg = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= avg;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            if (A.Length != B.Length)
            {
                return sum;
            }

            // code here

            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i]*B[i];
            }

            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here


            double sum = 0.0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }


            double avg = sum / array.Length;

            int count_less = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                {
                    count_less++;
                }
            }


            indexes = new int[count_less];
            int pointer = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                {
                    indexes[pointer] = i;
                    pointer++;
                }
            }

            // end

            return indexes;
        }

        public int Task7(int[] array)
        {
            int count = 0;


            //code here
            if (array.Length < 2)
                return array.Length;

            int max = 1, inc = 1, dec = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                    inc++;
                else
                    inc = 1;

                if (array[i] <= array[i - 1])
                    dec++;
                else
                    dec = 1;

                int cur = inc > dec ? inc : dec;
                if (cur > max)
                    max = cur;
            }

            count = max;

            //end
            return count;
        }




        public int[] Task8(int[] array)
        {
            int[] answer = null;

            

            // code here
            answer = new int[array.Length*2];

            for (int i = 0; i < array.Length; i++)
            {
                answer[i*2] = array[i];
                answer[i * 2+1] = array[i];
            }


            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;
            double max = array[0];
            double min = array[0];
            // code here
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];

                if (array[i] < min) min = array[i];
            }

            if (max == min) return null;

            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (array[i] - min) / (max - min);
            }

            // end

            return normalized;
        }

        public int Task10(int[] array, int P)
        {
            int index = 0;
            // code here

            for (int i = 0; i < array.Length - 1; i++)
            {


                for (int j = 0; j < array.Length - i - 1; j++)
                {

                    if (array[j] > array[j + 1])
                    {

                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }


            int l = 0;
            int r = array.Length - 1;
            index = -1;


            // end
            while (l <= r)
            {
                int m = (l + r) / 2;
                if (array[m] == P)
                {
                    index = m;
                    break;
                }
                if (array[m] < P)
                    l = m + 1;
                else
                    r = m - 1;
            }



            return index;
        }

        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;
            // code here
            if (b <= 0) return null;

            int cnt = 0;
            int val = a;
            while (val <= c)
            {
                cnt++;
                val += b;
            }

            array = new int[cnt];
            val = a;
            for (int i = 0; i < cnt; i++)
            {
                array[i] = val;
                val += b;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            if (magazine.Length < 3)
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                    indexes[i] = i;
                return indexes;
            }

            int maxSum = 0;
            int maxIdx = 0;


            for (int i = 0; i <= magazine.Length - 3; i++)
            {
                int sum = magazine[i] + magazine[i + 1] + magazine[i + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxIdx = i;
                }
            }

            // end

            indexes = new int[3];
            indexes[0] = maxIdx;
            indexes[1] = maxIdx + 1;
            indexes[2] = maxIdx + 2;


            return indexes;
        }

    }
}