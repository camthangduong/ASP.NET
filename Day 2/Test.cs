using System;
using Acme.Collections;
using System.Collections.Generic;
class Test {
    static IEnumerable<int> Range(int from, int to) {
        for (int i = from; i < to; i++) {
            yield return i;
        }
        yield break;
    }

    static void Main () {
        Stack s = new Stack();
        s.Push(1);
        s.Push(10);
        s.Push(100);

        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());

        // Yield
        foreach (int x in Range(-10, 10)) {
            Console.WriteLine(x);
        }
    }
}