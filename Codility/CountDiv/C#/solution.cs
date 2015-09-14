using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int A, int B, int K) {
        if(B == A)
        {
            if(B % K == 0)
                return 1;
            else
                return 0;
        }
        else
        {
            var offset = 0;
            
            if(A % K == 0)
                offset++;
            
            return (B / K) - (A / K) + offset;
        }
    }
}