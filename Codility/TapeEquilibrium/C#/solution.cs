// 50%
using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int result = Int32.MaxValue;
        int part1;
        int part2;
        int substract;
        
        for(var i = 0; i < A.Length - 1; i++){
        
           part1 = A.Take(i + 1).Sum();
           part2 = A.Skip(i + 1).Take(A.Length).Sum();
           
           substract = Math.Abs(part1 - part2);
           
           if(result > substract)
            result = substract;
        }
        
        return result;
    }
}

// SECOND SOLUTION 100%
using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int result = Int32.MaxValue;
        int substract;
        int sumRight = A.Skip(1).Sum();
        int sumLeft = A[0];
        
        for(var P = 1; P < A.Length; P++){
           
           substract = Math.Abs(sumLeft - sumRight);
           
           sumRight -= A[P];
           sumLeft += A[P];
           
           if(result > substract)
            result = substract;
        }
        
        return result;
    }
}