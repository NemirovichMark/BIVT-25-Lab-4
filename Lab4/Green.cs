using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double s = 0, sr = 0;
            int schet = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s += array[i];
                    schet++;
                }
            }
            if (schet > 0)
            {
                sr = s / schet;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = sr;
                }
                Console.Write(array[i]);
            }
            Console.WriteLine();
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            if (array == null || array.Length == 0) return 0;
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    n++;
                }
            }
            if (n == 0) return 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) break;
                sum += (array[i] * array[i]);
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            if (array == null || array.Length == 0) return negatives = null;
            double maxi = array[0];
            double mini = array[0];
            int ind_maxi = 0, ind_mini = 0, count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                    ind_maxi = i;
                }
                if (array[i] < mini)
                {
                    mini = array[i];
                    ind_mini = i;
                }
            }
            for (int i = Math.Min(ind_maxi, ind_mini) + 1; i < Math.Max(ind_maxi, ind_mini); i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }
            int ind_neg = 0;
            negatives = new int[count];
            for (int i = Math.Min(ind_maxi, ind_mini) + 1; i < Math.Max(ind_maxi, ind_mini); i++)
            {
                if (array[i] < 0)
                {
                    negatives[ind_neg] = array[i];
                    ind_neg++;
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null && array.Length < 2) return;
            int ind_neg = -1, ind_max = 0;
            int perestanovka = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    ind_neg = i;
                    break;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[ind_max])
                {
                    ind_max = i;
                }
            }
            if (ind_neg != -1)
            {
                perestanovka = array[ind_max];
                array[ind_max] = array[ind_neg];
                array[ind_neg] = perestanovka;
            }


            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0) return answer = null;
            int maxel = array[0];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxel)
                {
                    maxel = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxel)
                {
                    count++;
                }
            }
            answer = new int[count];
            int ind_polo = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxel)
                {
                    answer[ind_polo] = i;
                    ind_polo++;
                }
            }

            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            int maxel = array[0];
            int pribav = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxel)
                {
                    maxel = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxel)
                {
                    array[i] += pribav;
                    pribav++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            int maxel = array[0];
            int count = 0;
            for ( int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxel)
                {
                    maxel = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxel)
                {
                    count++;
                }
            }
            int[] ind_max = new int[count];
            int peremen = 0;
            for ( int i = 0;i < array.Length;i++)
            {
                if (array[i] == maxel)
                {
                    ind_max[peremen] = i;
                    peremen++;
                }
            }
            int[] sums = new int[count];
            for ( int i = 0; i < sums.Length; i++)
            {
                int vspom = ind_max[i];//Переменная которая отвечает за 1,2,3, и тд максимальный индекс
                int sumis = 0;//Переменная которая отвечает за сумму до максимальных эелементов
                for (int j = 0; j < vspom; j++)
                {
                    sumis += array[j];
                }
                sums[i] = sumis;
            }
            for (int i = 0; i < ind_max.Length; i++)
            {
                array[ind_max[i]] = sums[i];
            }

            // end

        }
        public int Task8(int[] array)
        {
            int length = 1;

            // code here
            int count = 1;
            if (array == null || array.Length == 0) return 1;
            for ( int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    length++;
                    if (length > count)
                    {
                        count = length;
                    }
                }
                else
                    length = 1;
            }
            length = count;

            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            for ( int i = 0; i < array.Length;i++)
            {
                for ( int j = i+1; j < array.Length;j++)
                {
                    if (array[i] > array[j] && i % 2 == 0 && j % 2 == 0)
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            if (array == null || array.Length == 0) return cleared = null;

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool ElIsUniq = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        ElIsUniq = false;
                        break;
                    }
                }
                if (ElIsUniq)
                {
                    count++;
                }
            }

            int index = 0;
            cleared = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                bool ElIsUniq = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        ElIsUniq = false;
                        break;
                    }
                }
                if (ElIsUniq)
                {
                    cleared[index] = array[i];
                    index++;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 1 || a == b) return B = null;
            double s = 0;
            int cnt = 0;
            double avg = 0;
            int index = 0;
            int cntBiggerthanavg = 0;


            A = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                A[i] = a + (step * i);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    s += A[i];
                    cnt++;
                }
            }
            avg = s / cnt;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > avg)
                {
                    cntBiggerthanavg++;
                }
            }

            B = new double[cntBiggerthanavg];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > avg)
                {
                    B[index] = A[i];
                    index++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int cnt6 = 0;
            int shuler = 0;
            int winsofshuler = 0;
            int znachenie = 0;

            
            int[] player = new int[dices.Length];

            for (int i = 0; i < dices.Length; i++)
            {

                znachenie = dices[i] - cnt6;

                if (znachenie < 1)
                {
                    znachenie = 1;
                }

                player[i] = znachenie;

                if (dices[i] == 6)
                {
                    cnt6++;
                }
            }

            for (int i = 0; i < dices.Length; i++)
            {

                shuler = 6 - winsofshuler;

                if (shuler < 1)
                {
                    shuler = 1;
                }

            
                if (player[i] > shuler)
                {
                    wins++;
                }

                winsofshuler++;
                
            }
            return wins;
            // end






        }
    }
}
