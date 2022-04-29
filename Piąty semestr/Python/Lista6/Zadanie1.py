import re

adres = '([a-zA-Z]+.)*[a-zA-Z]+'

automat = re.compile('http://' + adres)

import urllib.request

host = "http://www.ii.uni.wroc.pl"

with urllib.request.urlopen(host) as f:
    tekst = f.read().decode('utf-8')

[ url.group() for url in automat.finditer(tekst) ]