class DzieleniePrzezZeroException(Exception):
    def __init__(self):
        super.__init__("Nie dziel przez zero !!!!!!")


class Wyrazenie:
    def __init__(self, w1, w2):
        self.wyr1 = w1
        self.wyr2 = w2
    
    def __add__(w1, w2):
        return Dodaj(w1, w2)
    
    def __mul__(w1, w2):
        return Razy(w1, w2)        

class Razy(Wyrazenie):
    def __str__(self):
        if((type(self.wyr1) is Dodaj or type(self.wyr1) is Odejmij) and (type(self.wyr2) is Dodaj or type(self.wyr2) is Odejmij)):
            return("(" + str(self.wyr1) + ")" + " * " + "(" + str(self.wyr2) + ")")
        if(type(self.wyr1) is Dodaj or type(self.wyr1) is Odejmij):
            return("(" + str(self.wyr1) + ")" + " * " + str(self.wyr2))
        elif(type(self.wyr2) is Dodaj or type(self.wyr2) is Odejmij):
            return(str(self.wyr1) + " * " + "(" + str(self.wyr2) + ")")
        else:
            return (str(self.wyr1) + " * " + str(self.wyr2))

    def oblicz(self, zmienne):
        return self.wyr1.oblicz(zmienne) * self.wyr2.oblicz(zmienne)

    def uprosc(self):
        if(self.wyr1 is Stala and self.wyr2 is Stala):
            return self.wyr1.const * self.wyr2.const

class Podziel(Wyrazenie):
    def __str__(self):
        if((type(self.wyr1) is Dodaj or type(self.wyr1) is Odejmij) and (type(self.wyr2) is Dodaj or type(self.wyr2) is Odejmij)):
            return("(" + str(self.wyr1) + ")" + " / " + "(" + str(self.wyr2) + ")")
        if(type(self.wyr1) is Dodaj or type(self.wyr1) is Odejmij):
            return("(" + str(self.wyr1) + ")" + " / " + str(self.wyr2))
        elif(type(self.wyr2) is Dodaj or type(self.wyr2) is Odejmij):
            return(str(self.wyr1) + " / " + "(" + str(self.wyr2) + ")")
        else:
            return (str(self.wyr1) + " / " + str(self.wyr2))

    def oblicz(self, zmienne):
        return self.wyr1.oblicz(zmienne) / self.wyr2.oblicz(zmienne)

    def uprosc(self):
        if(self.wyr1 is Stala and self.wyr2 is Stala):
            return self.wyr1.const / self.wyr2.const


class Dodaj(Wyrazenie):
    def __str__(self):
        return(str(self.wyr1) + " + " + str(self.wyr2))
    
    def oblicz(self, zmienne):
        return self.wyr1.oblicz(zmienne) + self.wyr2.oblicz(zmienne)

    def uprosc(self):
        if(self.wyr1 is Stala and self.wyr2 is Stala):
            return self.wyr1.const + self.wyr2.const

class Odejmij(Wyrazenie):
    def __str__(self):
        return(str(self.wyr1) + " - " + str(self.wyr2))
    
    def oblicz(self, zmienne):
        return self.wyr1.oblicz(zmienne) - self.wyr2.oblicz(zmienne)

    def uprosc(self):
        if(self.wyr1 is Stala and self.wyr2 is Stala):
            return self.wyr1.const - self.wyr2.const

class Stala(Wyrazenie):
    def __init__(self, c):
        self.const = c

    def __str__(self):
        return(str(self.const))

    def oblicz(self, zmienne):
        return self.const

class Zmienna(Wyrazenie):
    def __init__(self, v):
        self.var = v
    
    def __str__(self):
        return(str(self.var))

    def oblicz(self, zmienne):
        return zmienne[self.var]

vals = {"x": 2, "y": 5, "z": 10}

wyr1 = Razy(Zmienna("x"), Dodaj(Stala(3), Zmienna("y")))
print(wyr1)
print(wyr1.oblicz(vals))

wyr2 = Podziel(Dodaj(Stala(3), Zmienna("x")), Zmienna("z"))
print(wyr2)
print(wyr2.oblicz(vals))

wyr3 = Razy(Dodaj(Stala(3), Zmienna("y")), Odejmij(Stala(3), Dodaj(Stala(3), Zmienna("x"))))
print(wyr3)
print(wyr3.uprosc)
print(wyr3.oblicz(vals))

wyr4 = wyr1 + wyr2
print(wyr4)
print(wyr4.oblicz(vals))

wyr5 = wyr2 * wyr3
print(wyr5)
print(wyr5.oblicz(vals))

wyr6 = Podziel(Zmienna("x"), Stala(0))
print(wyr6)
