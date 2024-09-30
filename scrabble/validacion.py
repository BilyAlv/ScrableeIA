def cargar_diccionario(ruta_archivo):
    try:
        with open(ruta_archivo, 'r', encoding='utf-8') as file:
            diccionario = set(line.strip().lower() for line in file)
        return diccionario
    except FileNotFoundError:
        print(f"El archivo '{ruta_archivo}' no se encontró.")
        return set()

def es_palabra_valida(palabra, diccionario):
    return palabra.lower() in diccionario
