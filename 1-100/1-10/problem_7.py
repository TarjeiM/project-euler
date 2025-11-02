# 10001st Prime

curr = 2
num = 1
primes = [2,3]

def is_prime(number: int) -> bool:
    if number % 2 == 0 or number % 3 == 0:
        return False
    curr, limit = 5, number**0.5
    while curr <= limit:
        if number % curr == 0:
            return False
        curr += 2
    return True

while len(primes) < 10001:
    curr += 1
    if is_prime(curr):
        primes.append(curr)

print(primes[-1])
