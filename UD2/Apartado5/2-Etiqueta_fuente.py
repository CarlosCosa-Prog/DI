from PySide6.QtWidgets import QApplication, QMainWindow, QLabel
from PySide6.QtCore import QSize
import sys


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setMinimumSize(QSize(200, 200))

        # widget etiqueta
        etiqueta = QLabel("Soy una etiqueta")
        # recuperamos la fuente por defecto, atributo heredado de QWidget
        # y devuelve un objeto QFont
        fuente = etiqueta.font()
        # establecemos un tamaño, con un metodo de QFont
        fuente.setPointSize(24)
        # la asignamos a la etiqueta, con un metodo de QWidget
        etiqueta.setFont(fuente)

        self.setCentralWidget(etiqueta)

		
        
if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())
