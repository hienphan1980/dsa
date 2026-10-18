using System;
using System.Collections;

public class vidu_array {
	public static void Main() {
		int[] m1 = new int[] {2, 5, 3, 8};
		//int[] m2 = new int[4]; 
		
		Console.WriteLine(m1[2]);
		
		int[,] m3 = new int[,] {
			{1, 2, 5, 3},
			{4, 8, 6, 9}
		};
		
		Console.WriteLine(m3[1,2]);
		
		int[][] m4 = new int[][] {
			new int[]{1, 2, 5, 3},
			new int[]{4, 8, 6}
		};
		Console.WriteLine("--------------");
		Console.WriteLine(m4[0][2]);
		Console.WriteLine(m4[1]);
		int[] m5 = m4[1];
		Console.WriteLine(m5[1]);
		Console.WriteLine("---------------------");
		foreach (int x in m5) {
			Console.WriteLine(x);
		}
		Console.WriteLine("---------------------");
		for (int i = 0; i < m5.Length; i++)  {
			Console.WriteLine(m5[i]);
		}
	}
}
