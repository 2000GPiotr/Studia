from matplotlib import markers
import pandas as pd
import matplotlib.pyplot as plt
import datetime
import numpy as np

strconv = lambda x : int(x.replace(' ',''))/10


cov = pd.read_csv('Zakazenia30323112020.csv', encoding='windows-1250', sep=';', converters={"Nowe przypadki" : strconv})
temp = pd.read_csv("Temperatura.csv", encoding='windows-1250', sep=';')

cov["Date"] = cov["Data"].apply(lambda x : datetime.datetime.strptime(x, "%d.%m.%Y").date())
temp["Date"] = temp["Date"].apply(lambda x : datetime.datetime.strptime(x, "%d.%m.%Y").date())

cieplo_cov = cov.loc[datetime.date(2020, 8, 20) >= cov["Date"]]
cieplo_temp = temp.loc[datetime.date(2020, 8, 20) >= temp["Date"]]

zimno_cov = cov.loc[datetime.date(2020, 8, 20) <= cov["Date"]]
zimno_temp = temp.loc[datetime.date(2020, 8, 20) <= temp["Date"]]

fig = plt.figure()
ax = fig.add_subplot(2, 1, 1)

ax.plot("Date", "Nowe przypadki", data=cieplo_cov, marker="o", markersize=2)
ax.plot("Date", "Temperatura", data=cieplo_temp, marker="x", markersize=2)
ax.set_title('Ocieplanie')
ax.legend(["Nowe przypadki", "Temperatura"])
ax.set_xlabel('Data')
ax.set_ylabel('Liczba przypadków w dziesiątkach \n Temperatura')

ax1 = fig.add_subplot(3, 1, 3)
ax1.plot("Date", "Nowe przypadki", data=zimno_cov, marker="o", markersize=2)
ax1.plot("Date", "Temperatura", data=zimno_temp, marker="x", markersize=2)
ax1.set_title('Ochładzanie')
ax1.legend(["Nowe przypadki", "Temperatura"])
ax1.set_xlabel('Data')
ax1.set_ylabel('Liczba przypadków w dziesiątkach \n Temperatura')


plt.show()
