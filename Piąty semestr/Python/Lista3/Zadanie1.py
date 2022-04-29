import math
import timeit

def czy_pierwsza(n):
    ok = True
    if(n==2):
        return True
    if(n==1):
        return False
    
    for i in range(2,math.floor(math.sqrt(n))+1):
        if(n%i==0):
            return False
    return True

def pierwsze_imperatywna(n):
    res = []
    for i in range(1,n+1):
        if(czy_pierwsza(i)):
            res.append(i)
    return res

def pierwsze_funkcyjna(n):
    return list(filter(czy_pierwsza,range(1,n+1)))

def pierwsze_skladana(n):
    return[i for i in range(1,n+1) if czy_pierwsza(i)]

n = 100
m = 10000000

print(pierwsze_imperatywna(n))
print(pierwsze_funkcyjna(n))
print(pierwsze_skladana(n))

tb = timeit.default_timer()
pierwsze_imperatywna(m)
te = timeit.default_timer()
print("Iteracyjnie: ", te-tb)

tb = timeit.default_timer()
pierwsze_skladana(m)
te = timeit.default_timer()
print("Lista: ", te-tb)

tb = timeit.default_timer()
pierwsze_funkcyjna(m)
te = timeit.default_timer()
print("Funkcyjnie: ", te-tb)