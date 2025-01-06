# Special Pythagorean Triplet

for a in range(1,500):
    for b in range(a+1,500):
        c = (a**2 + b**2)**0.5
        if a + b + c == 1000:
            print(f"{a*b*c:.0f}")
            break
