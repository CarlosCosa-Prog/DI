from PySide6.QtWidgets import QApplication, QMainWindow, QLabel
from PySide6.QtCore import QSize
from PySide6.QtGui import QFont, QPixmap  # editado
from pathlib import Path
import sys



class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setMinimumSize(QSize(350, 200))

        # widget etiqueta
        etiqueta = QLabel("Soy una etiqueta")
        
        # incluimos la libreria "from PySide6.QtGui import QPixmap  # editado"
        # incluimos la libreria "from pathlib import Path"
        # creamos la imagen, creando una instancia de QPixmap
        print(absPath("./Imagenes/k-pop.png"))
        imagen = QPixmap(absPath("./Imagenes/k-pop.png"))
        # la asginamos a la etiqueta
        etiqueta.setPixmap(imagen)
        # hacemos que se escale con la ventana
        etiqueta.setScaledContents(True)
        # establecemos el widget central
        self.setCentralWidget(etiqueta)
                

def absPath(file):
    # Devuelve la ruta absoluta a un fichero desde el propio script
    return str(Path(__file__).parent.absolute() / file)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())