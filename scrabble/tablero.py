class ScrabbleBoard:
    def __init__(self):
        self.size = 15
        self.board = [[' ' for _ in range(self.size)] for _ in range(self.size)]
        self.premium_squares = self.set_premium_squares()
        self.puntos_letras = {
            'A': 1, 'B': 3, 'C': 3, 'D': 2, 'E': 1, 'F': 4, 'G': 2, 'H': 4, 'I': 1, 'J': 8,
            'K': 5, 'L': 1, 'M': 3, 'N': 1, 'O': 1, 'P': 3, 'Q': 10, 'R': 1, 'S': 1, 'T': 1,
            'U': 1, 'V': 4, 'W': 4, 'X': 8, 'Y': 4, 'Z': 10
        }

    def set_premium_squares(self):
        # Define los multiplicadores de palabra y letra (código previamente dado)
        premium = {
            'PT': [(0, 0), (0, 7), (0, 14), (7, 0), (7, 14), (14, 0), (14, 7), (14, 14)],
            'PD': [(1, 1), (1, 13), (2, 2), (2, 12), (3, 3), (3, 11), (4, 4), (4, 10)],
            'LT': [(1, 5), (1, 9), (5, 1), (5, 5), (5, 9), (9, 1)],
            'LD': [(0, 3), (0, 11), (2, 6), (2, 8), (3, 0), (3, 7), (3, 14)]
        }
        return premium

    def calcular_puntaje_palabra(self, palabra, posiciones):
        puntaje = 0
        multiplicador_palabra = 1

        palabra = palabra.upper()
        for i, letra in enumerate(palabra):
            letra_puntaje = self.puntos_letras.get(letra, 0)
            x, y = posiciones[i]
            casilla = (x, y)

            if casilla in self.premium_squares['LT']:
                letra_puntaje *= 3
            elif casilla in self.premium_squares['LD']:
                letra_puntaje *= 2

            if casilla in self.premium_squares['PT']:
                multiplicador_palabra *= 3
            elif casilla in self.premium_squares['PD']:
                multiplicador_palabra *= 2

            puntaje += letra_puntaje

        return puntaje * multiplicador_palabra
