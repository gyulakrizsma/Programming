using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        var list = A.Where(l => l > 0)
                    .Distinct()
                    .OrderBy(o => o)
                    .ToArray();
        
        var min = 1;
    
        foreach(int i in list)
        {
            if(i == min)
            {
                min++;
            }
            else
                return min;
        }
        
        return min;
    }
}