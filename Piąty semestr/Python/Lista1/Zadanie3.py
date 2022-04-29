def tabliczka(x1, x2, y1, y2):
    print(" ".rjust(len(repr(y2))), end=' ')
    
    for x in range(x1, x2+1):
        print(repr(x).rjust(len(repr(x*y2))), end=' ')
    print()
    
    for y in range(y1, y2+1):
        print(repr(y).rjust(len(repr(y2))), end=' ')
        for x in range(x1, x2+1):
            print(repr(y*x).rjust(len(repr(x*y2))), end=' ')
        print()

tabliczka(3, 5, 2, 4)

print('\n' + "-------------------" + '\n')

tabliczka(20, 30, 40, 50)