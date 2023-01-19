
n = 0

for i in range (0, 10):
    for j in range (0, 10):
        for k in range (0, 4):
            print('{0:04}'.format(n) + " ", end = '')
            n += 1
        print()
    print()
