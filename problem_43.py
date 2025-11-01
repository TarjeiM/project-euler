# Sub-string Divisibility

import itertools

res = 0

digits = "0123456789"
divisors = [2, 3, 5, 7, 11, 13, 17]
permutations = itertools.permutations(digits)

for perm in permutations:
    permutation = "".join(perm)
    start = 1
    has_property = True
    for divisor in divisors:
        substring = permutation[start:start+3]
        number = int(substring)
        if number % divisor != 0:
            has_property = False
            break
        start += 1
    if has_property:
        print(permutation)
        res += int(permutation)

print("res:", res)
