# you can use print for debugging purposes, e.g.
# print "this is a debug message"
import sys

def solution(A):
    result = sys.maxint
    
    sumRight = sum(A[1:])
    sumLeft = A[0]
    substract = 0
    
    for p in range(1, len(A)):
        substract = abs(sumLeft - sumRight)
        
        sumRight -= A[p]
        sumLeft += A[p]
        
        if(result > substract):
            result = substract
    
    
    return result