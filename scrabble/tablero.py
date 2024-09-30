# tablero.py

# Crear un tablero vacío
tablero = [[' ' for _ in range(15)] for _ in range(15)]

def mostrar_tablero():
    print("\nTablero:")
    for fila in tablero:
        print(" ".join(fila))

def colocar_letras(fichas_jugador):
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
            print(f"Letras colocadas: {letra} en ({fila}, {col})")
            break
        else:
            print("Posición inválida. Intenta de nuevo.")

        continuar = input("¿Deseas seguir colocando letras? (si/no): ").lower()
        if continuar != "si":
            print("Turno de la IA.")
            return

# Función para calcular la puntuación
def calcular_puntaje(palabra):
    puntaje = 0
    letra_puntos = {
        'A': 1, 'B': 3, 'C': 3, 'D': 2, 'E': 1, 'F': 4,
        'G': 2, 'H': 4, 'I': 1, 'J': 8, 'K': 5, 'L': 1,
        'M': 3, 'N': 1, 'Ñ': 8, 'O': 1, 'P': 3, 'Q': 10,
        'R': 1, 'S': 1, 'T': 1, 'U': 2, 'V': 5, 'W': 4,
        'X': 8, 'Y': 4, 'Z': 10
    }
    for letra in palabra.upper():
        puntaje += letra_puntos.get(letra, 0)
    return puntaje
