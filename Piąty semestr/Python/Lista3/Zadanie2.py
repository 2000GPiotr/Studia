import math
import timeit

def dzielniki(n):
    res = []
    for i in range(1,math.floor(n/2+1)):
        if(n%i==0):
            res.append(i)
    return res

def czy_doskonala(n):
    sum = 0
    for i in dzielniki(n):
        sum+=i
    return n==sum

def doskonale_imperatywna(n):
    res = []
    for i in range(1,n+1):
        if(czy_doskonala(i)==True):
            res.append(i)
    return res

def doskonale_skladana(n):
    return[i for i in range(1,n+1) if czy_doskonala(i)]

def doskonale_funkcyjna(n):
    return list(filter(czy_doskonala,range(1,n+1)))

n = 10000
m = 10000

print(doskonale_imperatywna(n))
print(doskonale_funkcyjna(n))
print(doskonale_skladana(n))

tb = timeit.default_timer()
doskonale_imperatywna(m)
te = timeit.default_timer()
print("Iteracyjnie: ", te-tb)

tb = timeit.default_timer()
doskonale_skladana(m)
te = timeit.default_timer()
print("Lista: ", te-tb)

tb = timeit.default_timer()
doskonale_funkcyjna(m)
te = timeit.default_timer()
print("Funkcyjnie: ", te-tb)