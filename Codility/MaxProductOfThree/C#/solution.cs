using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        var list = A.OrderBy(o => o)
                    .ToArray();
        
        var length = list.Length;
        
        var prod1 = list[length -1] * list[length -2] * list[length -3];
        var prod2 = list[0] * list[1] * list[length -1];
        
        return prod1 > prod2 ? prod1 : prod2;
    }
}