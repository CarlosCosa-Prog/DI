from PySide6.QtWidgets import QApplication, QMainWindow, QLabel 
from PySide6.QtWidgets import QVBoxLayout, QHBoxLayout, QWidget
import sys


class Contenedor(QLabel):
    def __init__(self, color):
        super().__init__()
        # Establecemos el color de fondo usando hojas de estilo
        self.setStyleSheet(f"background-color:{color}")


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # creamos diferentes layouts para mezclar
        layoutHor = QHBoxLayout()
        layoutVer1 = QVBoxLayout()
        layoutVer2 = QVBoxLayout()

        # añadimos una caja al principio del layaout 1
        layoutHor.addWidget(Contenedor("green"))
        # luego anidamos dos layouts verticales
        layoutHor.addLayout(layoutVer1)
        layoutHor.addLayout(layoutVer2)

        # en el primer layout vertical añadimos dos cajas
        layoutVer1.addWidget(Contenedor("blue"))
        layoutVer1.addWidget(Contenedor("red"))

        # en el segundo layout vertical añadimos tres cajas
        layoutVer2.addWidget(Contenedor("orange"))
        layoutVer2.addWidget(Contenedor("magenta"))
        layoutVer2.addWidget(Contenedor("purple"))

        # cremos el widget dummy y le asignamos el layout horizontal
        widget = QWidget()
        widget.setLayout(layoutHor)

        self.setCentralWidget(widget)


if __name__ == "__main__":
    app = QApplication(sys.argv)

    #Precaución, ahorael objeto es de la clase MainWindow
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())