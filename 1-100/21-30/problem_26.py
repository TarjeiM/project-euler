# Reciprocal Cycles

from decimal import *
getcontext().prec = 4000

def find_recurring_cycle(text):
    n = len(text)
    for length in range(1, n // 2 + 1):  
        substring = text[:length]
        repetitions = n // length
        remainder = n % length
        if text.startswith(substring * repetitions + text[:remainder]):
            return substring
    return None

res = (0, 0)

for i in range(2,1000):
    num = str(Decimal(1)/Decimal(i))[2:]
    rec = find_recurring_cycle(num)
    if rec and len(rec) > res[1]:
        res = (i, len(rec))

print(res[0])
    