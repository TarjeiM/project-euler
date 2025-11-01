# Triangular, Pentagonal, and Hexagonal

limit = 1000000

def hex(n):
    return n*((2*n)-1)

def pen(n):
    return n*((3*n)-1)/2

hexList = [hex(n) for n in range(limit)]
penSet = set([pen(n) for n in range(limit)])

for num in hexList:
    if num in penSet:
        print(num)
