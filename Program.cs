using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the viralAdvertising function below.
    static int viralAdvertising(int n)

    {
        var shared = 5;
        var liked = 2;
        var cumulative = 0;
        var rang = n;
        IEnumerable<int> numbers = Enumerable.Range(1, rang);
        foreach (int i in numbers)
        {
            liked = (int)(shared / 2);
            cumulative += liked;
            shared = liked * 3;

        }
        return cumulative;

    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int result = viralAdvertising(n);

        Console.WriteLine(result);
        Console.ReadKey();

    }
}
