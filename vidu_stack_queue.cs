using System;
using System.Collections;

public class run_stack_queue {
    public static void Main() {
        /*
        int[] a = new int[]{3,5,8};
        Stack s = new Stack(a);
        Stack s = new Stack(new int[]{4,7,9});
        s.Push(6); s.Push(2);
        s.Push(3);
        s.Clear();
        s.CopyTo(a, 0);
        s.ToArray();
        s.Contains();
        s.Count();

        Console.WriteLine(s.Peek());
        Console.WriteLine("============");
        Console.WriteLine(s.Pop());
        Console.WriteLine("============2");
        Console.WriteLine(s.Peek());
        

        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        */

        Queue qd = new Queue(32, 2);

        Queue q = new Queue();
        q.Enqueue(1); q.Enqueue(2); q.Enqueue(3);
        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());
        x = (3 + 4)*5 + 2*3 + 5
    }
}