using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        var counter = 0;
        
        if(S == string.Empty)
            return 1;
            
        foreach(char c in S.ToCharArray())
        {
            if(c == '(')
                counter++;
            else if(c == ')')
            {
                if(counter == 0)
                    return 0;
                counter--;
            }
        }
        
        if(counter == 0)
            return 1;
        
        return 0;
    }
}