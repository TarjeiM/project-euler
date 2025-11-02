# Largest Prime Factor

number = 600851475143
prime_factors = []

while number > 1:
    i = 2
    while number / i != number // i:
        i += 1
    number /= i
    prime_factors.append(i)

print(max(prime_factors))