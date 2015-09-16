using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        
        if(S == string.Empty)
            return 1;
        
        var stack = new Stack<char>();
        
        foreach(char c in S.ToCharArray())
        {
            if(c == '(' || c == '[' || c == '{')
                stack.Push(c);
                
            if(c == ')')
            {
                if(stack.Count > 0 && stack.Peek() == '(')
                    stack.Pop();
                else
                {
                    //Console.WriteLine("aaa");
                    //Console.WriteLine(stack.Peek());
                    //Console.WriteLine(stack.Count);
                    return 0;
                }
            }
            
            if(c == ']')
            {
                if(stack.Count > 0 && stack.Peek() == '[')
                    stack.Pop();
                else
                {
                    //Console.WriteLine("bbb");
                    //Console.WriteLine(stack.Peek());
                    //Console.WriteLine(stack.Count);
                    return 0;
                }
            }
            
            if(c == '}')
            {
                if(stack.Count > 0 && stack.Peek() == '{')
                    stack.Pop();
                else
                {
                    //Console.WriteLine("ccc");
                    //Console.WriteLine(stack.Peek());
                    //Console.WriteLine(stack.Count);
                    return 0;
                }
            }
        }
        
        if(stack.Count == 0)
            return 1;
        
        return 0;
    }
}