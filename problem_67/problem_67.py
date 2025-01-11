# Maximum Path Sum II

f = open("C:\\Users\\Tarjei\\Desktop\\Project Euler\\problem_67\\problem_67.txt","r").readlines()

f = [x.split() for x in f]
f = [[int(y) for y in x] for x in f]

for row in f:
    while len(row) < 100:
        row.append(0)

c = [[0] * 100 for x in range(100)]

for i in range(100):
    for j in range(100):
        c[i][j] = f[i][j] + max(c[i-1][j-1],c[i-1][j])

print(max(c[99]))