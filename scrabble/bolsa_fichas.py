import random

class BolsaDeFichas:
    def __init__(self):
        self.fichas = {
            'A': 9, 'B': 2, 'C': 2, 'D': 4, 'E': 12, 'F': 2, 'G': 3,
            'H': 2, 'I': 6, 'J': 1, 'K': 1, 'L': 4, 'M': 2, 'N': 6,
            'Ñ': 1, 'O': 8, 'P': 2, 'Q': 1, 'R': 5, 'S': 6, 'T': 6,
            'U': 6, 'V': 2, 'W': 1, 'X': 1, 'Y': 1, 'Z': 1, ' ': 2
        }
        self.bolsa = self.crear_bolsa()
        self.mezclar_fichas()

    def crear_bolsa(self):
        return [letra for letra, cantidad in self.fichas.items() for _ in range(cantidad)]

    def mezclar_fichas(self):
        random.shuffle(self.bolsa)

    def sacar_fichas(self, cantidad):
        if cantidad > len(self.bolsa):
            raise ValueError("No hay suficientes fichas en la bolsa.")
        return [self.bolsa.pop() for _ in range(cantidad)]

class Jugador:
    def __init__(self, nombre):
        self.nombre = nombre
        self.fichas = []

    def recibir_fichas(self, nuevas_fichas):
        self.fichas.extend(nuevas_fichas)

    def mostrar_fichas(self):
        return self.fichas
