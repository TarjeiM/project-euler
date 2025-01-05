# 10001st Prime

curr = 2
num = 1
primes = [2]

def is_prime(number: int) -> bool:
    for i in range(2, (number//2)+2):
        if number % i == 0:
            return False
    return True

while len(primes) < 10001:
    curr += 1
    if is_prime(curr):
        primes.append(curr)

print(primes[-1])
