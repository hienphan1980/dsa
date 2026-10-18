using System;
using System.Collections;
using System.Collections.Generic;

public class vidu_array {
	
	public static void chinh(int[] m){
		m[0] = 0;
	} 
	
	public static void Main() {
		int[] m1 = new int[]{3,5,6,2,4};
		chinh(m1);
		Console.WriteLine(m1[0]);
		
		ArrayList al = new ArrayList();
		al.Add(4); al.Add(7);
		foreach (int x in al) 
			Console.WriteLine(x);
		
		Console.WriteLine("==============");
		List<int> l1 = new List<int>();
		l1.AddRange(new int[]{3,2,7,8});
		l1.RemoveAt(0);
		Console.WriteLine(1);
	}
}