import unittest

from Zadanie import is_palindrom


class Test1(unittest.TestCase):

    znaneWartosci = [("Kobyła ma mały bok", True),
                     ("Kobyła, ma:; mały. bok!!", True),
                     ("Eine güldne, gute Tugend: Lüge nie!", True),
                     ("Koqqbyła ma mały bok", False),
                     ("Kobyłna, ma:; mały. bok!!", False),
                     ("Eine gülndne, gute Tugend: xLüge snie!", False)]

    def runTest(self):
        """Proste palindromy 1"""
        for arg, res in self.znaneWartosci:
            r = is_palindrom(arg)
            self.assertEqual(r, res)


class Test2(unittest.TestCase):

    znaneWartosci = [("Ala", True),
                     ("Ola", False),
                     ("Tolalot", True)]

    def runTest(self):
        """Proste palindromy 2"""
        for arg, res in self.znaneWartosci:
            r = is_palindrom(arg)
            self.assertEqual(r, res)


class Test3(unittest.TestCase):

    znaneWartosci = [("A  l:{]a", True),
                     ("O%#l a", False),
                     ("To8l!$a^l7%^8ot", True)]

    def runTest(self):
        """Proste palindromy 3"""
        for arg, res in self.znaneWartosci:
            r = is_palindrom(arg)
            self.assertEqual(r, res)

alltests = unittest.TestSuite([Test1(), Test2(), Test3()])
unittest.TextTestRunner().run(alltests)
