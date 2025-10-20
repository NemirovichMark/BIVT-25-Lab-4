using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Lab4
{
  public class Blue
  {
    public void Task1(int[] array)
    {

      // code here
      int minus = -1;
      int mxi = 0;
      for (int i=0; i<array.Length; i++)
      {
        if (array[i] < 0)
        {
          minus = i;
          break;
        }
      }
      for (int i = 0; i < array.Length; i++)
        if (array[i] > array[mxi])
          mxi = i;
      int S = 0;
      for (int i = mxi+1; i < array.Length; i++)
        S += array[i];

      if (minus != -1)
        array[minus] = S;
      // end

    }
    public int[] Task2(int[] array, int P)
    {
      int[] answer = null;

      // code here
      int a = 0;
      bool flag = false;
      for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
        {
          flag = true;
          a = i;
        }
      int len = 0;
      if (flag)
        len = array.Length + 1;
      else
        len = array.Length;

      answer = new int[len];

      for (int i=0;  i<len; i++)
      {
        if ((i == a) && (flag))
        {
          answer[i] = array[i];
          answer[i+1] = P;
          i++;
          continue;
        }
        if ((i > a) && (flag))
        {
          answer[i] = array[i-1];
          continue;
        }
        answer[i] = array[i];
      }
      // end

      return answer;
    }
    public int[] Task3(int[] array)
    {
      int[] answer = null;

      // code here
      int a = 0;
      bool flag = false;
      for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
        {
          flag = true;
          a = i;
          break;
        }
      for (int i = 0; i < array.Length; i++)
        if ((array[a] > array[i]) && (array[i] > 0))
        {
          flag = true;
          a = i;
        }
      int len = 0;
      if (flag)
        len = array.Length - 1;
      else
        len = array.Length;

      answer = new int[len];

      for (int i = 0; i < len; i++)
      {
        if ((i >= a) && (flag))
        {
          answer[i] = array[i + 1];
          continue;
        }
        answer[i] = array[i];
      }
      // end

      return answer;
    }
    public void Task4(double[] array)
    {

      // code here

      double S = 0;
      for (int i = 0; i < array.Length; i++)
        S += array[i];
      S /= array.Length;

      for (int i = 0;i < array.Length; i++)
        array[i] -= S;

      // end

    }
    public int Task5(int[] A, int[] B)
    {
      int sum = 0;

      // code here
      
      if (A.Length == B.Length)
        for (int i = 0; i < Math.Min(A.Length, B.Length); i++)
          sum += A[i]*B[i];
      
      // end

      return sum;
    }
    public int[] Task6(int[] array)
    {
      int[] indexes = null;

      // code here

      double S = 0;
      for (int i = 0; i < array.Length; i++)
        S += array[i];
      S /= array.Length;

      int len = 0;
      foreach (int i in array)
        if (i < S)
          len++;

      indexes = new int[len];

      len = 0;
      for (int i = 0; i < array.Length; i++)
        if (array[i] < S)
          indexes[len++] = i;

      // end

      return indexes;
    }
    public int Task7(int[] array)
    {
      int count = 0;

      // code here

      int k = 1;
      for (int i = 1; i < array.Length; i++)
      {
        if (array[i] >= array[i - 1])
          k++;
        else
        {
          count = Math.Max(count, k);
          k = 1;
        }
      }
      count = Math.Max(count, k);

      k = 1;
      for (int i = 1; i < array.Length; i++)
      {
        if (array[i] <= array[i - 1])
          k++;
        else
        {
          count = Math.Max(count, k);
          k = 1;
        }
      }

      count = Math.Max(count, k);

      // end

      return count;
    }
    public int[] Task8(int[] array)
    {
      int[] answer = null;

      // code here

      int j = 0;
      answer = new int[2 * array.Length];
      for (int i = 0; i < array.Length; i++)
      {
        answer[j++] = array[i];
        answer[j++] = array[i];
      }

      // end

      return answer;
    }
    public double[] Task9(int[] array)
    {
      double[] normalized = null;

      // code here

      int mx = array[0], mn = array[0];
      foreach (int a in array)
      {
        mx = Math.Max(mx, a);
        mn = Math.Min(mn, a);
      }

      if (mx == mn)
        return normalized;

      normalized = new double[array.Length];
      for (int i = 0; i < array.Length; i++)
        normalized[i] = (((double)(array[i] - mn)) / ((double)(mx - mn)));

      // end

      return normalized;
    }
    public int Task10(int[] array, int P)
    {
      int index = 0;

      // code here

      for (int i = array.Length-1; i>0; i--)
      {
        int mxi = 0;
        for (int j = 0; j <= i; j++)
          if (array[j] > array[mxi])
            mxi = j;

        if (mxi != i)
          (array[mxi], array[i]) = (array[i], array[mxi]);
      }

      index = -1;
      int l = 0, r = array.Length - 1;
      while (l <= r)
      {
        int m = (l + r) / 2;
        if (array[m] == P) {
          index = m;
          break;
        } else if (array[m] < P)
          l = m + 1;
        else
          r = m - 1;
      }

      // end

      return index;
    }
    public int[] Task11(int a, int b, int c)
    {
      int[] array = null;

      // code here

      if (b < 0)
        return array;

      int k = 0;
      for (int i = a; i <= c; i += b)
        k++;
      
      array = new int[k];

      int j = a;
      for (int i = 0; i < k; i++)
      {
        array[i] = j;
        j += b;
      }

      // end

      return array;
    }

    public int[] Task12(int[] magazine)
    {
      int[] indexes = null;

      // code here

      if (magazine.Length <= 3)
      {
        indexes = new int[magazine.Length];
        for (int i = 0; i < magazine.Length; i++)
          indexes[i] = i;
        return indexes;
      }

      int room1 = 0, room2 = 1, room3 = 2;


      indexes = new int[3];

      for (int i=2; i<magazine.Length; i++)
      {
        int currentRoom1 = i - 2, currentRoom2 = i - 1, currentRoom3 = i;
        int sumGold = magazine[room1] + magazine[room2] + magazine[room3];
        int currentSumGold = magazine[currentRoom1] + magazine[currentRoom2] + magazine[currentRoom3];

        if (currentSumGold > sumGold)
        {
          room1 = currentRoom1;
          room2 = currentRoom2;
          room3 = currentRoom3;
        }

      }
      
      indexes[0] = room1;
      indexes[1] = room2;
      indexes[2] = room3;

      // end

      return indexes;
    }
  }
}
