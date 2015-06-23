//50%
using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        var result = 0;
        
        A = A.OrderBy(o => o).ToArray();
        
        for(var i = 0; i < A.Length + 1; i++){
        
            if((i + 1) != A[i]){
                result = i + 1;
                return result;
            }
        
        }
        
        return result;
    }
}


using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        var result = 1;
        
        if(A == null) throw new ArgumentNullException();
        
        A = A.OrderBy(o => o).ToArray();
        
        if(A.Length == 1)
            return A[0] + 1;
        
        for(int i = 0; i < A.Length + 1; i++){
        
            if((i + 1) != A[i]){
                result = i + 1;
                return result;
            }
        
        }
        
        return result;
    }
}}


using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        var result = 1;
        
        if(A == null) throw new ArgumentNullException();
        
        var sumArray = A.Sum();
        var sumWithoutMissing = Enumerable.Range(1, A.Length + 1).Sum();
        
        return sumWithoutMissing - sumArray;
    }
}