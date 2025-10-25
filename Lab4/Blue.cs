using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int indmx = 0;
            int mx = array[0];
            int sm = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    indmx = i;
                }
            }
            for (int i = indmx + 1; i < array.Length; i++)
            {
                sm += array[i];
            }
            for (int n = 0; n < array.Length; n++)
            {
                if (array[n] < 0)
                {
                    array[n] = sm;
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int pos = -10;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    pos = i;
                }
            }
            if (pos != -10)
            {
                answer = new int[array.Length + 1];
                for (int i = 0; i <= pos; i++)
                { 
                    answer[i] = array[i];
                }
                answer[pos + 1] = P;
                for (int i = pos + 1; i < array.Length; i++)
                {
                    answer[i + 1] = array[i];
                }
            }
            else
            {
                answer = new int[array.Length];
                for (int i = 0; i < answer.Length; i++)
                {
                    answer[i] = array[i];
                }
            }
            // end

                return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int mn = int.MaxValue;
            int indmn = -10;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < mn)
                { 
                    mn = array[i];
                    indmn = i;
                }
            }

            if (indmn != -10)
            {
                answer = new int[array.Length - 1];
                for (int i = 0; i < indmn; i++)
                {  answer[i] = array[i]; }
                for (int i = indmn + 1; i < array.Length; i++)
                { answer[i - 1] = array[i]; }
            }

            else
            { 
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                { answer[i] = array[i];}    
            }
            // end

                return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double sm = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sm += array[i];
            }
            double sr = sm / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] - sr;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length != B.Length)
            { return 0; }
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i] * B[i];
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double sm = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sm += array[i];
            }
            double sr = sm / array.Length;

            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                { cnt++; }    
            }

            int ind = 0;
            indexes = new int[cnt];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                { 
                    indexes[ind] = i;
                    ind++;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int k = 0;
            int pstcnt = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[k])
                {
                    pstcnt++;
                    k++;
                }
                else
                {
                    if (count < pstcnt)
                    { count = pstcnt; }
                    k = i;
                    pstcnt = 1;
                }
            }
            if (count < pstcnt)
            { count = pstcnt; }

            int ngtcnt = 1;
            k = 0;
            for (int r = 1; r < array.Length; r++)
            {
                if (array[r] <= array[k])
                {
                    ngtcnt++;
                    k++;
                }
                else
                {
                    if (count < ngtcnt)
                        count = ngtcnt;
                    k = r;
                    ngtcnt = 1;
                }
            }
            if (count < ngtcnt)
                count = ngtcnt;
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length * 2];
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            { 
                answer[n] = array[i];
                answer[++n] = array[i];
                n++;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            double mx = int.MinValue;
            double mn = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            { 
                if  (array[i] >= mx)
                    {  mx = array[i]; }
                if (array[i] <= mn)
                    { mn = array[i]; }
            }
            if (mn != mx)
            {
                double[] array2 = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {  
                    array2[i] = (array[i] - mn) / (mx - mn);
                }
                normalized = array2;
            }

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = array.Length - 1; i > 0; i--)
            {
                int mxind = 0;
                for (int k = 1; k < i + 1; k++)
                {
                    if (array[k] > array[mxind])
                        mxind = k;
                }
                if (mxind != i)
                {
                    int n = array[mxind];
                    array[mxind] = array[i];
                    array[i] = n;
                }
            }

            int ll = 0, h = array.Length - 1;
            while (ll <= h)
            {
                int sr = (h + ll) / 2;
                if (array[sr] == P)
                { 
                    return index = sr; 
                }
                else if (array[sr] < P) 
                { 
                    ll = sr + 1; 
                }
                else 
                { 
                    h = sr - 1; 
                }
            }
            return -1;
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <= 0)
            { return array; }

            int cnt = 0;
            int k = a;
            while (k <= c)
            {
                k += b;
                cnt++;
            }

            array = new int[cnt];
            int n = a;
            for (int i = 0; i < cnt; i++)
            {
                array[i] = n;
                n += b;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int[] ind = new int[3];
            int mx = int.MinValue;
            if (magazine.Length < 3)
                {
                    int[] indRooms = new int[magazine.Length];
                    for (int i = 0; i < magazine.Length; i++)
                    {
                        indRooms[i] = i;
                    }
                    indexes = indRooms;
                }
            else
            {
                for (int i = 0; i < magazine.Length - 2; i++)
                { 
                    if (magazine[i] + magazine[i + 1] + magazine[i + 2] > mx)
                    {
                        mx = magazine[i] + magazine[i + 1] + magazine[i + 2];
                        ind[0] = i;
                        ind[1] = i + 1;
                        ind[2] = i + 2;
                    }
                }
                indexes = ind;
            }
                // end

                return indexes;
        }
    }
}
