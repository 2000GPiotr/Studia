def kompresja(tekst):
    (a, b) = (tekst[0], 0)
    res = []
    for i in tekst:
        if(i==a):
            b+=1
        else:
            res.append((a, b))
            a = i
            b = 1
    res.append((a, b))
    return res

def dekompresja(tekst):
    res = ""
    for i in tekst:
        res += (i[0])*i[1]
    return res

t = "adgaaastccccchsruuuut"
z = kompresja(t)
d = dekompresja(z)

print(t)
print(z)
print(d)