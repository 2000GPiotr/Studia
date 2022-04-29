import decimal
import random

def vat_faktura(lista):
    suma = 0
    for i in lista:
        suma += i
    return 0.23*suma

def vat_paragon(lista):
    suma = 0
    for i in lista:
        suma += i*0.23
    return suma

# Decimal daje dokładniejsze wyniki
def vat_faktura_decimal(lista):
    suma = 0
    for i in lista:
        suma += decimal.Decimal(i)
    return decimal.Decimal(0.23)*suma

def vat_paragon_decimal(lista):
    suma = 0
    for i in lista:
        suma += decimal.Decimal(i) * decimal.Decimal(0.23)
    return suma

lista = [10, 20, 30, 5, 15, 20]
lista2 = [0.2, 0.5, 4.59, 6]

print(vat_paragon(lista))
print(vat_faktura(lista))
#te dwie funkcje dają różne wyniki
print(vat_paragon_decimal(lista))
print(vat_faktura_decimal(lista))

print("-----------------------")

print(vat_paragon(lista2))
print(vat_faktura(lista2))
print(vat_paragon_decimal(lista2))
print(vat_faktura_decimal(lista2))

print("------------------------")


for i in range (1,20):
    c=0
    l = 10
    list = []
    for i in range (1, l):
        list.append(random.random()*100)
    if(vat_faktura(list) != vat_paragon(list)):
        print(list)