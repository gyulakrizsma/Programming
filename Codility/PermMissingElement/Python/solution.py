# you can use print for debugging purposes, e.g.
# print "this is a debug message"

def solution(A):
    
    sumArray = sum(A)
    sumShould = sum(range(1, len(A) + 2))
    
    return sumShould - sumArray