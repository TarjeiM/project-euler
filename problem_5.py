# Smallest Multiple

num = 9699690

def divisible_by_1_through_20(number: int) -> bool:
    return number % 20 == 0 and number % 19 == 0 and number % 18 == 0 \
    and number % 17 == 0 and number % 16 == 0 and number % 15 == 0 \
    and number % 14 == 0 and number % 13 == 0 and number % 12 == 0 and number % 11 == 0

while not divisible_by_1_through_20(num):
    num += 1

print(num)

