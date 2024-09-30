import random

def robar_fichas(cantidad, saco):
    fichas = []
    for _ in range(cantidad):
        if saco:
            fichas.append(saco.pop())
    return fichas

def mostrar_tablero(tablero):
    for fila in tablero:
        print(" ".join(fila))

def colocar_letras(tablero, fichas_jugador):
    while True:
        letra = input("Introduce una letra de tus fichas: ").upper()
        if letra not in fichas_jugador:
            print("No tienes esa letra. Intenta de nuevo.")
            continue

        fila = int(input("Fila (0-14): "))
        col = int(input("Columna (0-14): "))

        if 0 <= fila < 15 and 0 <= col < 15 and tablero[fila][col] == ' ':
            tablero[fila][col] = letra
            fichas_jugador.remove(letra)
        else:
            print("Posición inválida. Intenta de nuevo.")
            continue

        continuar = input("¿Deseas seguir colocando letras? (si/no): ").lower()
        if continuar != "si":
            break
