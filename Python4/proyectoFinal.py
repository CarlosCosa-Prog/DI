from random import randrange #import para la funcion aleatoria
# función para mostrar el tablero
# debe estar almacenado en una lista: tabla[row][column]
def muestraTablero(tablero):
    print("+-------" * 3,"+", sep="")
    for fila in range(3):
        print("|       " * 3, "|", sep="")
        for columna in range(3):
            print("|   " + str(tablero[fila][columna]) + "   ", end="")
        print("|")
        print("|       " * 3, "|", sep="")
        print("+-------" * 3,"+", sep="")

# creacion de la lista tablero con numeros del 1 al 9 
tablero =[[1, 2, 3],
          [4, 5, 6],
          [7, 8, 9]]

# función para comprobar el estado del tablero 
# - quedan huecos libres
# - comprueba si algún jugador ha ganado la partida (horizontal, vertial y diagonal) (while filas) (while columnas)
def compruebaHuecos():
    for fila in tablero: #recorre cada fila del tablero [1, 2, 3] --> [4, 5, 6] --> [7, 8, 9]
        for celda in fila: # recorre cada celda de cada fila
            if celda != '0' and celda != 'X':  # comprueba si la celda es distinta de 0 o X
                return True
    return False

def compruebaGanador():
    for fila in tablero:
        # comprueba horizontal
        if fila[0] == fila[1] == fila[2] and (fila[0] == 'X' or fila[0] == '0'):
            return True
        # comprueba vertical
        
        # comprueba diagonal
        
    return False

# función juega MÁQUINA (genera un valor aleatorio)
def juegaMa():
    numMa  = randrange(1, 10) # numero del  1 al 9
    tablero[(numMa-1)//3][(numMa-1)%3] = '0'
    print("La máquina ha elegido el numero: ", numMa)

# función juega USUARIO (número entre 0 y 10 (no incluidos) y que no se encuentre en la lista de numeros utilizados)
def juegaUs():
    numUs = (int(input("Elige un numero: ")))
    tablero[(numUs-1)//3][(numUs-1)%3] = 'X'

# función main
while True:
    muestraTablero(tablero)
    juegaUs()
    if compruebaGanador():
        muestraTablero(tablero)
        print("¡Felicidades! Has ganado.")
        break
#    juegaMa()
#    if compruebaGanador():
#        muestraTablero(tablero)
#        print("La máquina ha ganado.")
#        break