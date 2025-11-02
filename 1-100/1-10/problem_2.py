# Even Fibonacci Numbers

total = 0

curr = 1
prev = 1

while curr <= 4000000:
    if curr % 2 == 0:
        total += curr
    temp = prev
    prev = curr
    curr += temp

print(total)

