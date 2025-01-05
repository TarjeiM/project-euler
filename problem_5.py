# Smallest Multiple

num = 9699690

def divisible_by_1_through_20(number: int) -> bool:
    for i in range(20,10,-1):
        if number % i != 0:
            return False
    return True

while not divisible_by_1_through_20(num):
    num += 1

print(num)

