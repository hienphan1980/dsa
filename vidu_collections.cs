using System;
using System.Collections;

class run_thunghiem_Collection
{
    public static bool sosanh<T>(T o1, T o2) where T : int_T
    {
        return o1.val > o2.val;
    }
    static void Main()
    {
        Console.WriteLine("Chạy thử nghiệm Collection");
        SV s1 = new SV("A", 3);
        SV s2 = new SV("B", 4);
        bool b = sosanh<SV>(s1,s2) ;
        if (b)
        {
            Console.WriteLine("Dung");
        } else
        {
            Console.WriteLine("Sai");
        }

        GV g1 = new GV("C", 23);
    	GV g2 = new GV("A", 30);
    	bool c = sosanh<GV>(g1,g2) ;
        if (c)
            Console.WriteLine("Dung");
        else
            Console.WriteLine("Sai");
    }
}

public interface int_T
{
    public int val {get; set;}
}

public class SV : int_T 
{
    public string masv = "";
    public int val {get; set;}
    public SV(string _ma, int _dtb)
    {
        masv = _ma;
        val = _dtb;
    }
}

public class GV : int_T
{
    public string magv = "";
    public int val {get; set;}
    public GV(string _ma, int _tuoi)
    {
        magv = _ma;
        val = _tuoi;
    } 
}

