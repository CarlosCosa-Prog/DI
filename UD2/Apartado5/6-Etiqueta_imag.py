from PySide6.QtWidgets import QApplication, QMainWindow, QLabel
from PySide6.QtCore import QSize
from PySide6.QtGui import QFont, QPixmap  # editado
import sys


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setMinimumSize(QSize(350, 200))

        # widget etiqueta
        etiqueta = QLabel("Soy una etiqueta")

        # incluimos la libreria "from PySide6.QtGui import QPixmap  # editado"
        # creamos la imagen, creando una instancia de QPixmap
        imagen = QPixmap("./Apartado5/Imagenes/k-pop.png")
        # la asginamos a la etiqueta
        etiqueta.setPixmap(imagen)
        # establecemos el widget central
        self.setCentralWidget(etiqueta)


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())

    

