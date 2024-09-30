from bolsa_fichas import BolsaDeFichas
from tablero import ScrabbleBoard
from validacion_palabra import cargar_diccionario, es_palabra_valida
from control_turnos import mostrar_tablero, colocar_letras, robar_fichas

def main():
    # Inicialización de la bolsa de fichas
    bolsa = BolsaDeFichas()
    bolsa.mezclar_fichas()

    # Inicialización del tablero
    tablero = ScrabbleBoard()

    # Cargar el diccionario
    diccionario = cargar_diccionario('diccionario.txt')

    # Inicialización de los jugadores
    fichas_jugador1 = bolsa.sacar_fichas(7)
    fichas_jugador2 = bolsa.sacar_fichas(7)

    while True:
        print("\nTurno del Jugador 1")
        mostrar_tablero(tablero.board)
        colocar_letras(tablero.board, fichas_jugador1)
        
        palabra = input("Introduce la palabra que formaste: ")
        posiciones = [(int(input("Fila: ")), int(input("Columna: "))) for _ in palabra]

        if es_palabra_valida(palabra, diccionario):
            puntaje = tablero.calcular_puntaje_palabra(palabra, posiciones)
            print(f"¡Puntaje para '{palabra}': {puntaje} puntos!")
        else:
            print("Palabra no válida.")
        
        # Turno del Jugador 2 o IA
        print("\nTurno del Jugador 2")
        colocar_letras(tablero.board, fichas_jugador2)
