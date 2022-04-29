"""
Doskonale.py
====================================
Rozwiązuje zadanie o dzielnikach
"""

import math
import timeit


def dzielniki(n):
    """
    Zwraca listę dzielników do n
 
    :param n: ograniczenie dla tworzonej listy dzielników
    :return: res - lista dzielników do n
    """
    res = []
    for i in range(1, math.floor(n/2+1)):
        if(n % i == 0):
            res.append(i)
    return res


def czy_doskonala(n):
    """
    Sprawdza czy liczba jest doskonała
    
    :param: n: liczba do sprawdzenia
    :return: True gdy liczba jest doskonała, False wpp
    """
    sum = 0
    for i in dzielniki(n):
        sum += i
    return n == sum


def doskonale_imperatywna(n):
    """
    Imperatywnie zwraca listę liczb doskonałych
    :param: n: ograniczenie
    :return: Lista Liczb doskonałych
    """
    res = []
    for i in range(1, n+1):
        if(czy_doskonala(i)):
            res.append(i)
    return res


def doskonale_skladana(n):
    """
    Zwraca listę skłądaną liczb doskonałych
    :param: n: ograniczenie
    :return: Lista Liczb doskonałych
    """
    return[i for i in range(1, n+1) if czy_doskonala(i)]


def doskonale_funkcyjna(n):
    """
    Funkcyjnie twozry listę liczb doskonałych
    :param: n: ograniczenie
    :return: Lista Liczb doskonałych
    """
    return list(filter(czy_doskonala, range(1, n+1)))

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
