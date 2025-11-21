from PySide6.QtWidgets import (
    QApplication, QMainWindow, QLabel, QGridLayout, QWidget)
import sys
import random


class Contenedor(QLabel):
    def __init__(self, color):
        super().__init__()
        self.setStyleSheet(f"background-color:{color}")


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # creamos un layout en cuadrícula
        cuadricula = QGridLayout()

        # bucles for para generar una cuadrícula
        for fila in range(5):
            for columna in range(5):
                # añadimos una caja de color aleatorio de 6 digitos
                # intento es una cadena que empieza con 0x y tiene entre 1 y 6 digitos hexadecimales
                intento = str(hex(random.randint(0, 16777215)))  # int(0xFFFFFF)

                # le quitamos a la cadena el 0x y nos aseguramos que tenga 6 digitos
                # añadiendo ceros a la izquierda si es necesario
                color=intento[2:].zfill(6)

                print("[",fila,"][", columna,"]",color, "-->", f"#{color}")
                cuadricula.addWidget(Contenedor(f"#{color}"), fila, columna)

        # cremos el widget dummy y le asignamos el layout horizontal
        widget = QWidget()
        widget.setLayout(cuadricula)

        self.setCentralWidget(widget)


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())