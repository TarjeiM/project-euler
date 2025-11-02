# Digit Fifth Powers

res = 0

for i in range(2,200000):
    digits = [int(x)**5 for x in str(i)]
    if (i == sum(digits)):
        res += i

print(res)




