using System;
using System.Collections.Generic;

namespace Module.Models;

public static class Swapper {
    public static void Swap<T> (ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static void PrintCollections<T> (IEnumerable<T> collection){
        Console.WriteLine(string.Join(", ", collection));
    }
}