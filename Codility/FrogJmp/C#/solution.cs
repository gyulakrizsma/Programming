using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int Y, int D) {
        if(X == Y)
            return 0;
        
        if((Y-X) <= D)
            return 1;
        
        double x = (double)X;
        double y = (double)Y;
        double d = (double)D;
        
        var result = (double)((y-x)/d);
        
        return (int)Math.Ceiling(result);
    }
}