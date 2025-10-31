namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int counter = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    counter++;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    array[i] = sum / counter;
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int anegIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    anegIndex = i;
                    break;
                }
            }

            for (int i = 0; i < anegIndex; i++)
            {
                sum += array[i] * array[i];
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int amax = -10000, amin = 10000, amaxIndex = 0, aminIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > amax)
                {
                    amax = array[i];
                }
                else if (array[i] < amin)
                {
                    amin = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == amax)
                {
                    amaxIndex = i;
                    break;
                }
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == amin)
                {
                    aminIndex = i;
                    break;
                }
            }
            
            if (aminIndex > amaxIndex)
            {
                int counter = 0;
                for (int i = amaxIndex + 1; i < aminIndex; i++)
                {
                    if (array[i] < 0)
                        counter++;
                }
                
                negatives = new int[counter];
                counter = 0;
                for (int i = amaxIndex + 1; i < aminIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[counter] = array[i];
                        counter++;
                    }
                }
            } else if (aminIndex < amaxIndex)
            {
                int counter = 0;
                for (int i = aminIndex + 1; i < amaxIndex; i++)
                {
                    if (array[i] < 0)
                        counter++;
                }
                
                negatives = new int[counter];
                counter = 0;
                for (int i = aminIndex + 1; i < amaxIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[counter] = array[i];
                        counter++;
                    }
                }
            }
            else
                negatives = new int[0];
            
            
            // end
            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int amax = -1000;
            int amax_index = 0;
            int smth = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > amax)
                {
                    amax = array[i];
                    amax_index = i;
                }
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    smth = array[i];
                    array[i] = amax;
                    array[amax_index] = smth;
                    break;
                }
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int amax = -1000;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > amax)
                    amax = array[i];
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == amax)
                    counter++;
            }
            
            answer = new int[counter];
            counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == amax)
                {
                    answer[counter] = i;
                    counter++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int amax = -1000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > amax)
                    amax = array[i];
            }

            int counter = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == amax)
                    array[i] += counter++;
            }
            // end
            Console.WriteLine("---START---");
            Console.WriteLine(amax);
        }
        public void Task7(int[] array)
        {

            // code here
            int amax = -1000, sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > amax)
                    amax = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] == amax)
                    array[i] = sum - amax;
            }
            // end
        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int maxLength = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    length++;
                    if (maxLength < length) 
                        maxLength = length;
                }
                else
                    length = 0;
            }

            length = maxLength + 1;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 2; j++)
                {
                    if (array[j] > array[j + 2] && j % 2 == 0)
                    {
                        int temp = array[j];
                        array[j] = array[j + 2];
                        array[j + 2] = temp;
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            cleared = new int[array.Length];
            int[] unique = new int[array.Length];
            int uniqueCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool alreadyExists = false;
                
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (array[i] == unique[j])
                    {
                        alreadyExists = true;
                        break;
                    }
                }
                
                if (!alreadyExists)
                {
                    unique[uniqueCount] = array[i];
                    uniqueCount++;
                }
            }
            
            cleared = new int[uniqueCount];
            for (int i = 0; i < uniqueCount; i++)
            {
                cleared[i] =  unique[i];
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n == 1 || n == 0 || a == b)
            {
                return B;
            }
            
            A = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }

            double sum = 0;
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    counter++;
                }
            }

            double avg = sum / counter;

            counter = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > avg)
                    counter++;
            }

            
            B = new double[counter];
            counter = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > avg)
                    B[counter++] = A[i];
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int min = 0;
            int max = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                int mini = Math.Max(dices[i]-min,1);
                int maxi = Math.Max(6-max,1);
                if (mini > maxi)
                    wins++;
                if (dices[i] == 6)
                    min++;
                max++;
            }
            // end

            return wins;

        }
    }
}
