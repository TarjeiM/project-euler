# Sum Square Difference

def sum_of_squares(start: int, end: int) -> int:
    total = 0
    for i in range(start, end+1):
        total += i**2
    return total

def square_of_sums(start: int, end: int) -> int:
    total = 0
    for i in range(start, end+1):
        total += i
    return total**2

print(square_of_sums(1,100) - sum_of_squares(1,100))
