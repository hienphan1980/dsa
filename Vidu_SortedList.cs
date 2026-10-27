using System;
using System.Collections;

public class Vidu_SortedList{
    public static void Main() {
        SortedList<string, int> sl = new SortedList<string, int>();
        sl.add('S001', 34);
        sl.add('ABC', 24);
        sl.add('WE', 12);
        sl.add('HH', 45);
        sl.add('BA',30);
        
        foreach (pt in sl){
            Console.WriteLine("K: {0}; V: {1}",pt.Key, pt.Value);
        }
    }
}

