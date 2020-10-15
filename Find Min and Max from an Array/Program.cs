using System;

namespace Find_Min_and_Max_from_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arr = { 1000, 11, 445, 1, 330, 3000 };
			int arr_size = 6;
			Pair minmax = getMinMax(arr, 0, arr_size - 1);
			Console.Write("\nMinimum element is {0}", minmax.min);
			Console.Write("\nMaximum element is {0}", minmax.max);
		}

		public class Pair
		{
			public int min;
			public int max;
		}

		static Pair getMinMax(int[] arr, int low, int high)
		{
			Pair minmax = new Pair();
			Pair mml = new Pair();
			Pair mmr = new Pair();
			int mid;

			// If there is only on element
			if (low == high) { 
				minmax.max = arr[low]; 
				minmax.min = arr[low]; 
				return minmax; 
			} 

			// If there are two elements
			if (high == low + 1) { 
				if (arr[low] > arr[high]) { 
					minmax.max = arr[low]; 
					minmax.min = arr[high]; 
				} else { 
					minmax.max = arr[high]; 
					minmax.min = arr[low]; 
				} 
				return minmax; 
			} 

			/* If there are more than 2 elements */
			mid = (low + high) / 2;
			mml = getMinMax(arr, low, mid);
			mmr = getMinMax(arr, mid + 1, high);

			// compare minimums of two 
			minmax.min = Math.Min(mml.min, mmr.min);
			minmax.max = Math.Max(mml.max, mmr.max);
			return minmax;
		}
	}
}
