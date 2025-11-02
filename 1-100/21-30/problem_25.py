# 1000-digit Fibonacci Number

prev, curr, idx = 2, 3, 4

while (len(str(curr)) < 1000):
    temp = curr
    curr += prev
    prev = temp
    idx += 1

print(idx)