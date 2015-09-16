using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        var dict = new Dictionary<int, int>();
        
        foreach(int a in A)
        {
            if(dict.ContainsKey(a))
            {
               dict[a] = dict[a] + 1;
            }
            else
            {
                dict.Add(a, 1);
            }
        }
        
        /*foreach(KeyValuePair<int, int> d in dict)
        {
            Console.WriteLine("{0} and {1}", d.Key, d.Value);
        }*/
        
        var max = -1;
        var dominator = -1;
        
        foreach(KeyValuePair<int, int> d in dict)
        {
            if(d.Value > max)
            {
                max = d.Value;
                dominator = d.Key;
            }
        }
        
        if(max <= A.Length / 2)
            return -1;
        
        //Console.WriteLine(dominator);
        
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] == dominator)
                return i;
        }
        
        return -1;
    }
}