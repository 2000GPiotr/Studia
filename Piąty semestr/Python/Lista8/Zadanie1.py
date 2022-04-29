import sqlite3

from sqlalchemy.ext.declarative import declarative_base
from sqlalchemy import Table, Column, Integer, ForeignKey, String, DateTime


db = sqlite3.connect(':memory:')


Base = declarative_base()

class Osoba(Base):
    __tablename__ = 'Osoba'
    id = Column(Integer, primary_key=True)
    imie = Column(String(20), nullable=False)
    wiek = Column(Integer, default=18)
    created = Column(DateTime,
        default=datetime.datetime.utcnow)