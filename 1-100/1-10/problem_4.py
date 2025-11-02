# Largest Palindrome Product

result = 0

for i in range(999,0,-1):
    for j in range(999,0,-1):
        number = i * j
        number_as_str = str(number)
        if number_as_str[0] == number_as_str[-1]:
            if number_as_str == number_as_str[::-1]:
                result = max(result, number)

print(result)
        