import random

def uprosc_zdanie (tekst, dl_slowa, dl_tekstu):
    slowa = tekst.split(' ')
    for i in slowa:
        if(len(i) > dl_slowa):
            slowa.remove(i)
    while(len(slowa) > dl_tekstu):
        del slowa[random.randint(0, len(slowa)-1)]
    return ' '.join(slowa)

t = "Litwo! Ojczyzno moja! ty jesteś jak zdrowie\
Ile cię trzeba cenić, ten tylko się dowie,\
Kto cię stracił. Dziś piękność twą w całej ozdobie\
Widzę i opisuję, bo tęsknię po tobie. \
Panno święta, co Jasnej bronisz Częstochowy\
I w Ostrej świecisz Bramie! Ty, co gród zamkowy\
Nowogródzki ochraniasz z jego wiernym ludem!\
Jak mnie dziecko do zdrowia powróciłaś cudem"

# https://wolnelektury.pl/katalog/lektura/pan-tadeusz.html

print(uprosc_zdanie(t, 7, 25))