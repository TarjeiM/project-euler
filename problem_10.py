# Summation of Primes

def is_prime(number: int) -> bool:
    if number % 2 == 0 or number % 3 == 0:
        return False
    curr, limit = 5, number**0.5
    while curr <= limit:
        if number % curr == 0:
            return False
        curr += 2
    return True

total = 5

for i in range(5,2000000,2):
    if is_prime(i):
        total += i

print(total)
