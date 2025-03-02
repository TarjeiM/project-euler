# Digit Factorials

from math import factorial

def get_factorial_sum(n: int):
    res = 0
    while n != 0:
        res += factorial(n%10)
        n //= 10
    return res

total = 0

for i in range(3, 1000000):
    if get_factorial_sum(i) == i:
        total += i