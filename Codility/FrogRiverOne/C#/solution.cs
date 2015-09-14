using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A) {
        var steps = 0;
        bool[] bitmap = new bool[X + 1];
        
        if(A.Length == 0)
            return -1;
        
        for(int i = 0; i < A.Length; i++){
            
            if(!bitmap[A[i]])
            {
                bitmap[A[i]] = true;
                steps++;
                
                if(steps == X)
                    return i;
            }
        
        }
        return -1;
    }
}