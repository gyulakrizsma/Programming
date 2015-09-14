using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        
        var nulls = new List<int>();
        //var ones = new List<int>();
        var result = 0;
        
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] == 0)
                nulls.Add(i);
        }
        
        var nullLength = nulls.Count - 1;
        
        foreach(int n in nulls)
        {
            result += A.Length - n - 1 - nullLength;
            nullLength--;
        }
        
        if(result > 1000000000 || result < 0)
            return -1;
        
        return result;
    }
}