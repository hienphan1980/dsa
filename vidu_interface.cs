using System;
using System.Collections;

public class run_intf {
    public static void Main() {
        Console.WriteLine("Su dung Interface");
        tron t = new tron (5.0);
        tamgiac tg = new tamgiac(4.0, 5.0, 6.0);
        bool b = sosanh(t, tg);
        if (b) 
        	Console.WriteLine("Trong dai hon tamgiac");
        else 
        	Console.WriteLine("Khong dung");
    }
    public static bool sosanh(hinhhoc h1, hinhhoc h2) {
    	return (h1.chuvi() > h2.chuvi());
	}
}

public interface hinhhoc
{
    double chuvi();
    double dientich();
}
public class tron: hinhhoc {
	double bk;
	public tron (double _bk) {
		bk = _bk;
	}
	public double chuvi() {
		return bk*2*3.14;
	}
	public double dientich() {
		return 0.0;
	}
}


public class tamgiac: hinhhoc {
	double a,b,c;
	public tamgiac(double _a, double _b, double _c) {
		a = _a; b = _b; c = _c;
	}
	public double chuvi() {
		return a + b + c;
	}
	public double dientich() {
		return 0.0;
	}
}