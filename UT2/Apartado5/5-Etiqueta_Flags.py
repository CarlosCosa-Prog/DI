from PySide6.QtWidgets import QApplication, QMainWindow, QLabel
from PySide6.QtCore import QSize, Qt  # editado
from PySide6.QtGui import QFont  # nuevo
import sys


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setMinimumSize(QSize(350, 200))

        # widget etiqueta
        etiqueta = QLabel("Soy una etiqueta")

        # Añadimos la libreria "from PySide6.QtGui import QFont  # nuevo"
		# cargamos una fuente del sistema, creando un objeto QFont
        fuente = QFont("Comic Sans MS", 24)
		# la asignamos a la etiqueta, con un metodo de QWidget
        etiqueta.setFont(fuente)

        # Añadimos la libreria "from PySide6.QtCore import QSize, Qt  # editado"
        # establecemos unas flags de alineamiento
        etiqueta.setAlignment(Qt.AlignHCenter | Qt.AlignVCenter)
        
        # mostramos los valores enteros y binarios de las constantes
        print(int(Qt.AlignHCenter), int(Qt.AlignVCenter), int(Qt.AlignHCenter | Qt.AlignVCenter))
        print(bin(Qt.AlignHCenter), bin(Qt.AlignVCenter), bin(Qt.AlignHCenter | Qt.AlignVCenter))
        
        self.setCentralWidget(etiqueta)
	
        
if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())