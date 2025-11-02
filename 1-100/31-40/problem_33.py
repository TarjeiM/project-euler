# Digit Cancelling Fractions

import fractions

num, den = 1, 1

for numerator in range(10,100):
    num_dig = {*str(numerator)}
    for denominator in range(numerator+1,100):
        den_dig = {*str(denominator)}
        if "0" in num_dig or "0" in den_dig:
            continue
        set_union = num_dig & den_dig
        if len(set_union) != 1:
            continue
        temp_num = int(num_dig.pop()) if len(num_dig) == 1 else int((num_dig - den_dig).pop())
        temp_den = int(den_dig.pop()) if len(den_dig) == 1 else int((den_dig - num_dig).pop())
        if (numerator/denominator) == (temp_num/temp_den):
            num *= temp_num
            den *= temp_den

print(fractions.Fraction(numerator=num,denominator=den).denominator)


