#import matplotlib.pyplot as plt

WartośćXk = [5.5, 8.5, 10.5, 13, 17, 20.5, 24.5, 28, 32.5, 37.5, 40.5, 42.5, 45, 47,
             49.5, 50.5, 51, 51.5, 52.5, 53, 52.8, 52, 51.5, 53, 54, 55, 56,
             55.5, 54.5, 54, 55, 57, 58.5, 59, 61.5, 62.5, 63.5, 63, 61.5,
             59, 55, 53.5, 52.5, 50.5, 49.5, 50, 51, 50.5, 49, 47.5, 46, 45.5, 45.5,
             45.5, 46, 47.5, 47.5, 46, 43, 41, 41.5, 41.5, 41, 39.5, 37.5, 34.5,
             31.5, 28, 24, 21, 18.5, 17.5, 16.5, 15, 13, 10, 8, 6, 6, 6, 5.5,
             3.5, 1, 0, 0, 0.5, 1.5, 3.5, 5, 5, 4.5, 4.5, 5.5, 6.5, 6.5, 5.5]
Wartośćyk = [41, 40.5, 40, 40.5, 41.5, 41.5, 42, 42.5, 43.5, 45, 47, 49.5, 53, 57, 59,
             59.5, 61.5, 63, 64, 64.5, 63, 61.5, 60.5, 61, 62, 63, 62.5, 61.5, 60.5,
             60, 59.5, 59, 58.5, 57.5, 55.5, 54, 53, 51.5, 50, 50, 50.5, 51, 50.5,
             47.5, 44, 40.5, 36, 30.5, 28, 25.5, 21.5, 18, 14.5, 10.5, 7.50, 4,
             2.50, 1.50, 2, 3.50, 7, 12.5, 17.5, 22.5, 25, 25, 25, 25.5, 26.5,
             27.5, 27.5, 26.5, 23.5, 21, 19, 17, 14.5, 11.5, 8, 4, 1, 0, 0.5, 3,
             6.50, 10, 13, 16.5, 20.5, 25.5, 29, 33, 35, 36.5, 39, 41]


def nifs3(zbiorWartosci):
    tk = [k / 95 for k in range(96)]
    h = tk[1] - tk[0]
    Mojalambda = h / (h + h)
    M = []
    q = []
    u = []
    p = []
    d = []

    for i in range(96):
        M.append(0)
        q.append(0)
        u.append(0)
        p.append(0)
        d.append(0)

    def ilorazRoznicowy(start, end, listaWartosci):
        if (len(listaWartosci) == 1):
            return listaWartosci[0]
        else:
            licznik = ilorazRoznicowy(start + 1, end, listaWartosci[1:]) - ilorazRoznicowy(start, end - 1,
                                                                                           listaWartosci[:-1])
            mianownik = tk[end] - tk[start]
            return licznik / mianownik

    for i in range(1, 95):
        d[i] = 6 * ilorazRoznicowy(i - 1, i + 1, [zbiorWartosci[i - 1], zbiorWartosci[i], zbiorWartosci[i + 1]])
        print(i)
        print(6*d[i])

    for i in range(1, 95):
        p[i] = Mojalambda * q[i - 1] + 2
        q[i] = (Mojalambda - 1) / p[i]
        u[i] = (d[i] - Mojalambda * u[i - 1]) / p[i]
        #print(u[i])

    M[94] = u[94]
    for i in range(93, 0, -1):
        M[i] = u[i] + (q[i] * M[i + 1])
       # print(i,M[i])

    def sk(x):
        k = 0
        for i in range(1, 95 + 1):
            if tk[i - 1] <= x <= tk[i]:
                k = i
                break

        a = (1 / 6) * M[k - 1] * ((tk[k] - x) ** 3)
        b = (1 / 6) * M[k] * ((x - tk[k - 1]) ** 3)
        c = (zbiorWartosci[k - 1] - ((1 / 6) * M[k - 1] * (h ** 2))) * (tk[k] - x)
        e = (zbiorWartosci[k] - ((1 / 6) * M[k] * (h ** 2)))*(x - tk[k - 1])
        #print((h ** -1) * (a + b + c + e))
        return (h ** -1) * (a + b + c + e)

    return sk


fx = nifs3(WartośćXk)
fy = nifs3(Wartośćyk)

M = 96
uk = [k/M for k in range(0, M + 1)]
sx = [fx(u) for u in uk]
sy = [fy(u) for u in uk]
