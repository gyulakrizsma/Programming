# you can use print for debugging purposes, e.g.
# print "this is a debug message"
import math

def solution(X, Y, D):
    if(X == Y):
        return 0
    
    if((Y-X) < D):
        return 1
    
    return int(math.ceil((Y-X)/float(D)))