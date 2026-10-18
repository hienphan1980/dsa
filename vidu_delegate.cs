using System;
using System.Collections;

public class run_delegate {
	public static int CongDon(int x, int y) {
		return x + y;
	}
		
	public static int CongBinh(int x, int y) {
		return (x*x) + (y*y);
	}
	
	
		
	public static void Main() {
		int[] m = new int[]{3,6,1,5};
		// tinh cong tat ca phan tu trong m 
		// theo CongBinh
		//chuanCong cc = new chuanCong(CongBinh);
		chuanCong cc = new chuanCong(CongDon);
		int tong = 0;
		foreach (int x in m) {
			tong = cc(tong, x);
		}
		Console.WriteLine(tong);
		
		
	}
}

public delegate int chuanCong(int x, int y);