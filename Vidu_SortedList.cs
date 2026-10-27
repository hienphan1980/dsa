using System;
using System.Collections;
using System.Collections.Generic;


public class Vidu_SortedList{
    public static void Main() {
        
        SortedList<string, int> sl = new SortedList<string, int>();
        sl.Add("S001", 34);
        sl.Add("ABC", 24);
        sl.Add("WE", 12);
        sl.Add("HH", 45);
        sl.Add("BA",30);
        
        foreach (var pt in sl){
            Console.WriteLine("K: {0}; V: {1}",pt.Key, pt.Value);
        }
        Console.WriteLine("==============================");
        
        bool b ;
        
        b = sl.ContainsKey("HH");
        b = sl.ContainsValue(24);
        
        sl.Remove("WE");
        sl.RemoveAt(1);
        
        
        foreach (var pt in sl){
            Console.WriteLine("K: {0}; V: {1}",pt.Key, pt.Value);
        }
        
    }
}

