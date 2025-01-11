# Large Sum

numbers = [x[0:50] for x in open("C:\\Users\\Tarjei\\Desktop\\Project Euler\\problem_13_input.txt","r").readlines()]

total = numbers[0]
carry = 0

for i in range(1,len(numbers)):
    partial_sum = []
    while len(numbers[i]) < len(total):
        numbers[i] = "0" + numbers[i]
    for j in range(-1,-len(total)-1,-1):
        temp = int(total[j]) + int(numbers[i][j]) + carry
        pos_sum = temp if temp < 10 else temp - 10
        carry = 0 if temp < 10 else 1
        partial_sum.insert(0,str(pos_sum))
    if carry != 0:
        partial_sum.insert(0,str(carry))
    total = ''.join(partial_sum)

print(total)