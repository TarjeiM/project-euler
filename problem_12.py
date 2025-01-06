# Highly Divisible Triangular Number

def get_factors(x: int) -> int:
    factors, factor = 0, 1
    while factor**2 <= x:
        if x % factor == 0:
            factors += 1
            if factor**2 != x:
                factors += 1
        factor += 1
    return factors

number = i = 0

while True:
    number += i
    if get_factors(number) > 500:
        print(number)
        break
    i += 1