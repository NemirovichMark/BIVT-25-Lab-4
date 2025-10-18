using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here

	    int last_max = array[0]-1;
	    int sum_alr = 0;
	    int neg_ind = -1;
	    for (int i = 0; i < array.Length; i++){
	      if (array[i] < 0 && neg_ind == -1){
		neg_ind = i;
	      }
	      if (array[i] > last_max){
		sum_alr = 0;
		last_max = array[i];
	      }
	      else{
		sum_alr+=array[i];
	      }
	    }
	    if (neg_ind!=-1)
	      array[neg_ind] = sum_alr;

            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here

	    answer = new int[array.Length+1];
	    int target = -1;
	    for (int i = array.Length; i>0; i--){
	      if (array[i-1] > 0){
		target = i;
		break;
	      }
	    }
	    int done = 0;
	    for (int i = 0; i < array.Length; i++){
	      if (i==target){
		answer[i] = P;
		done = 1;
	      }
	      answer[i+done] = array[i];
	    }
	    if (target == array.Length){
	      answer[array.Length] = P;
	    }
	    if (target == -1){
	      answer = array;
	    }

            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here


	    int target = -1;
	    for (int i = 0; i < array.Length; i++){
	      if (array[i]>0 && (target == -1 || array[target] > array[i])){
		target = i;
	      }
	    }
	    int shift = 0;
	    if (target != -1)
	      shift = 1;
	    answer = new int[array.Length - shift];

	    int done = 0;
	    for (int i = 0; i < array.Length; i++){
	      if (i == target){
		done = 1;
		continue;
	      }
	      answer[i-done] = array[i];
	    }


            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here

	    double avg = 0;
	    foreach (double item in array){
	      avg+=item;
	    }
	    avg/=array.Length;
	    for (int i = 0; i < array.Length; i++){
	      array[i]-=avg;
	    }

            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here

	    if (A.Length != B.Length) return 0;
	    for (int i = 0; i < Math.Min(A.Length, B.Length); i++){
	      sum+=A[i]*B[i];
	    }

            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here

	    double avg = 0;
	    foreach (int item in array){
	      avg+=(double)item;
	    }

	    avg/=array.Length;

	    int count = 0;

	    foreach (int item in array){
	      if (item<avg) count++;
	    }

	    indexes = new int[count];

	    for (int i = 0; i < array.Length; i++){
	      if (array[i]<avg){
		indexes[indexes.Length-count] = i;
		count--;
	      }
	    }

            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here

	    int ans = 0;
	    int cur = 1;
	    for (int i = 0; i < array.Length-1; i++){
	      if (array[i] >= array[i+1]){
		cur+=1;
	      }else{
		ans = Math.Max(ans, cur);
		cur = 1;
	      }
	    }
	    ans = Math.Max(ans, cur);

	    cur = 1;
	    for (int i = 0; i < array.Length-1; i++){
	      if (array[i] <= array[i+1]){
		cur+=1;
	      }else{
		ans = Math.Max(ans, cur);
		cur = 1;
	      }
	    }
	    ans = Math.Max(ans, cur);
	    count = ans;

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here

	    answer = new int[array.Length*2];
	    for (int i = 0; i < array.Length; i++){
	      answer[i*2] = array[i];
	      answer[i*2+1] = array[i];
	    }

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here

	    int min = array[0];
	    int max = array[0];

	    for (int i = 0; i < array.Length; i++){
	      min = Math.Min(min, array[i]);
	      max = Math.Max(max, array[i]);
	    }

	    if (min == max){return normalized;}

	    normalized = new double[array.Length];

	    for (int i = 0; i < array.Length; i++){
	      normalized[i] = (double)(array[i]-min)/(max-min);
	    }
	    

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here

	    int[] arr = new int[array.Length];
	    for (int j = 0; j < array.Length; j++){
	      arr[j] = array[j];
	    }
	    int i = 1, n = arr.Length;

	    
	    while (i < n){      // Использовал GnomeSort из лекции, так как он реализуется без вложенных циклов
	      if (i == 0 || arr[i] >= arr[i - 1]) 
		i++;
	      else{
		(arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
		i--;
	      }
	    }

	    index = -1;
	    int target = P, low = 0, high = arr.Length - 1;
	    while (low <= high)
	    {
	      int mid = (low + high) / 2;
	      if (arr[mid] == target)
	      {
		index = mid;
		break;
	      }
	      else if (arr[mid] < target)
		low = mid + 1;
	      else
		high = mid - 1;
	    }

            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here

	    if (b>0){
	      array = new int[Math.Max(0, (c-a)/b+1)];

	      for (int i = 0; i < array.Length; i++){
		array[i] = a+b*i;
	      }
	    }

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

	    if (magazine.Length == 1){
	      indexes = new int[1] {0};
	      return indexes;
	    }

	    if (magazine.Length == 2){
	      indexes = new int[2] {0, 1};
	      return indexes;
	    }

	    int ans = 0;
	    int sum = magazine[0]+magazine[1]+magazine[2];
	    for (int i = 1; i < magazine.Length-2; ++i){
	      if (sum < magazine[i] + magazine[i+1] + magazine[i+2]){
		ans = i;
		sum = magazine[i] + magazine[i+1] + magazine[i+2];
	      }
	    }
	    indexes = new int[3] {ans, ans+1, ans+2};


            // end

            return indexes;
        }
    }
}
