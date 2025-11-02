# Lattice Paths

from math import factorial

n, r = 40, 20

paths = factorial(n) / (factorial(r) * factorial(n-r))

print(int(paths))