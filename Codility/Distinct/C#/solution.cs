using System;
using System.Collections;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        
        var hash = new Hashtable();
        
        
        foreach(int a in A)
        {
            if(!hash.ContainsKey(a))
                hash.Add(a, 0);
        }
        
        return hash.Count;
        
    }
}