# Number Letter Counts

special = {
    10: 3, 11: 6, 12: 6, 13: 8, 14: 8, 15: 7, 16: 7, 17: 9, 18: 8, 19: 8
}
ones = [0, 3, 3, 5, 4, 4, 3, 5, 5, 4]
tens = [0, 3, 6, 6, 5, 5, 5, 7, 6, 6]

def get_2_digit_letter_count(num: int) -> int:
    if num < 10:
        return ones[num]
    if num < 20:
        return special[num]
    dig1, dig2 = str(num)
    return tens[int(dig1)] + ones[int(dig2)]
    
def get_3_digit_letter_count(num: int) -> int:
    if num < 100:
        return get_2_digit_letter_count(num)
    dig = int(str(num)[0])
    rest = int(str(num)[1:])
    return ones[dig] + 7 + (get_2_digit_letter_count(rest) + 3 if rest != 0 else 0)

total = 0

for i in range(1,1000):
    total += get_3_digit_letter_count(i)

print(total + 11)
