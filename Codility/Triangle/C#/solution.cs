using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        
        if(A.Length < 3)
            return 0;
            
        var list = A.OrderBy(o => o)
                    .ToArray();
        
        for(int i = 0; i < list.Length - 2; i++)
        {
            // We know that the second condition is always true
            // because of the sorting and the third is also always true
            // casue A[R] >= A[Q] so A[R] + A[P] > A[Q]
            if((list[i] + list[i + 1] > list[i + 2]))
                return 1;
        }
        
        return 0;
        
    }
}