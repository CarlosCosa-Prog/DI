from PySide6.QtWidgets import QApplication, QMainWindow, QLabel
from PySide6.QtCore import QSize, Qt
from PySide6.QtGui import QFont, QPixmap
from pathlib import Path
import sys

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setMinimumSize(QSize(480, 320))
        self.setWindowTitle("Ejemplo con fuente personalizada e imagen")

        etiqueta = QLabel()
        etiqueta.setAlignment(Qt.AlignCenter)  # Centrar el contenido

        # Fuente personalizada (para cuando haya texto)
        fuente = QFont("Comic Sans MS", 24)
        etiqueta.setFont(fuente)

        # Cargar imagen
        imagen = QPixmap("/home/ciclosm/Escritorio/horario.png")
        etiqueta.setPixmap(imagen)
        self.setCentralWidget(etiqueta)

        print(self.absPath("/home/ciclosm/Escritorio/horario.png"))
        imagen = QPixmap(self.absPath("/home/ciclosm/Escritorio/horario.png"))

    # Devuelve la ruta absoluta a un fichero desde el propio script
    def absPath(self, file):
        return str(Path(__file__).parent.absolute() / file)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())
