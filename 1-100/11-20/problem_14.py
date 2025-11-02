# Longest Collatz Sequence

def get_chain_length(x: int) -> int:
    chain_length = 1
    while x != 1:
        if x % 2 == 0:
            x /= 2
        else:
            x = x*3+1
        chain_length += 1
    return chain_length

res = (0, 0)

for i in range(999999,0,-1):
    temp = get_chain_length(i)
    if temp > res[0]:
        res = (temp, i)

print(res[1])