using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        var bitmap = new bool[A.Length + 1];
        bitmap[0] = true;
        
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] >= bitmap.Length)
                return 0;
            
            if(!bitmap[A[i]])
            {
                bitmap[A[i]] = true;
            }
        }
        
        foreach(bool a in bitmap)
        {
            if(!a)
                return 0;
        }
        return 1;
    }
}