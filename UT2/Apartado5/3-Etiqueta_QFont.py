from PySide6.QtWidgets import QApplication, QMainWindow, QLabel
from PySide6.QtCore import QSize
from PySide6.QtGui import QFont  # nuevo
import sys


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setMinimumSize(QSize(200, 200))

        # widget etiqueta
        etiqueta = QLabel("Soy una etiqueta")

        # Añadimos la libreria "from PySide6.QtGui import QFont  # nuevo"
		# cargamos una fuente del sistema, creando un objeto QFont
        fuente = QFont("Comic Sans MS", 24)
		# la asignamos a la etiqueta, con un metodo de QWidget
        etiqueta.setFont(fuente)
        
        self.setCentralWidget(etiqueta)
	
        
if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())

        