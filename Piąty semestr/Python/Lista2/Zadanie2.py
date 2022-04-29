def pierwiastek(n):
    res = 0
    i=1
    while(res<=n):
        res += 2*i-1
        i+=1
    
    return i-2

liczby = [1, 2, 3, 4, 5, 8, 9, 10, 15, 16, 17, 24, 25, 35, 36, 49, 63, 64, 81, 100]

for i in liczby:
    print(i, pierwiastek(i))