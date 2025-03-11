# Quadratic Primes

def is_prime(number) -> bool:
    if number < 0:
        return False
    if number % 2 == 0 or number % 3 == 0:
        return False
    curr, limit = 5, number**0.5
    while curr <= limit:
        if number % curr == 0:
            return False
        curr += 2
    return True

def get_number_of_primes(a, b) -> int:
    n = 0
    res = 0
    while is_prime(n**2 + a*n + b):
        res += 1
        n += 1
    return res

max_primes = [0, 0, 0]

for a in range(-999, 1000):
    for b in range(-1000,1001):
        number_of_primes = get_number_of_primes(a, b)
        if number_of_primes > max_primes[0]:
            max_primes = number_of_primes, a, b

print(max_primes[1] * max_primes[2])

