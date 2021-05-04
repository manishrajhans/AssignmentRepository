using System;

namespace JaggedArray
{
	public class Demo
	{
		public static void Main()
		{
			int[][] A = new int[3][]; //Jagged Array => similar to MultiDimesional Array
            			A[0] = new int[]{ 1,2,3};
			A[1] = new int[] { 1, 5, 9,10 };
			A[2] = new int[] { 4, 2, 8, 3,34};

			for(int i = 0; i<A.Length; i++)
            			{
				for(int j = 0; j<A[i].Length; j++)
               				 {
					Console.Write("{0} ",A[i][j]);
               				 }
				Console.WriteLine();
           			 }
		}
	}
}