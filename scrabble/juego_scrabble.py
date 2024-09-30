import random
from bolsa_fichas import BolsaDeFichas, Jugador
from tablero import mostrar_tablero, colocar_letras, calcular_puntaje

# Turno del jugador
def turno_jugador(fichas_jugador):
    print("\nEs tu turno:")
    mostrar_tablero()
    print("Tus fichas:", fichas_jugador)

    accion = input("Acción (poner/pasar): ").lower()

    if accion == "pasar":
        print("Has pasado tu turno.")
        return False

    elif accion == "poner":
        colocar_letras(fichas_jugador)
        return True

# Turno de la IA (simplemente pasa)
def turno_ia():
    print("\nTurno de la IA.")
    mostrar_tablero()
    print("La IA ha pasado su turno. (Lógica de la IA no implementada)")

# Inicialización del juego
def main():
    bolsa = BolsaDeFichas()

    nombre_jugador1 = input("Ingrese el nombre del jugador 1: ")
    jugador1 = Jugador(nombre_jugador1)

    jugador1.recibir_fichas(bolsa.sacar_fichas(7))
    print(f"{jugador1.nombre} tiene las fichas: {jugador1.mostrar_fichas()}")

    while True:
        if not turno_jugador(jugador1.fichas):
            turno_ia()

if __name__ == "__main__":
    main()
