from PySide6.QtWidgets import (QApplication, QMainWindow, QWidget,
                               QLabel)
import sys
# import del Path
from pathlib import Path
# import para utilizar los iconos
from PySide6.QtGui import QIcon

from PySide6.QtGui import QPixmap

# ruta abosluta para utilizar imagenes
def absPath(file):
    return str(Path(__file__).parent.absolute() / file)

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.resize(480,320)
        
        # creo el menu
        menu = self.menuBar()
        # añado el menu, las acciones y el separador
        menu_archivo = menu.addMenu("Archivo")

        # OPCION SALIR : icono, texto y atajo de teclado
        menu_archivo.addAction(QIcon(absPath("./imagenes/exit.png")),"Salir",self.close,"Ctrl + S")
        menu_archivo.addSeparator()

        # añado el submenu y las acciones del submenu
        submenu_archivo = menu_archivo.addMenu("Submenu")
        menu_pinguino = submenu_archivo.addAction(QIcon(absPath("./imagenes/pinguino.png")),"Pingüino")
        menu_patito = submenu_archivo.addAction(QIcon(absPath("./imagenes/patito.png")),"Patito")
        # creo la ventana Pinguino y Patito
        self.ventana_pinguino = ventana_pinguino()
        self.ventana_patito = ventana_patito()
        # llamada a las funciones
        menu_pinguino.triggered.connect(self.mostrar_pinguino)
        menu_patito.triggered.connect(self.mostrar_patito)

    # funciones para que se muestre la ventana
    def mostrar_pinguino(self):
        self.ventana_pinguino.show()

    def mostrar_patito(self):
        self.ventana_patito.show()

class ventana_pinguino(QWidget):
    def __init__(self):
        super().__init__()
        # Crea un QLabel dentro de la ventana para mostrar la imagen
        label = QLabel(self)
        # Carga la imagen en un objeto QPixmap usando la ruta absoluta
        pixmap = QPixmap(absPath('./imagenes/pinguino.jpg'))

        label.setPixmap(pixmap)
        label.setScaledContents(True)
        label.resize(self.size())

class ventana_patito(QWidget):
    def __init__(self):
        super().__init__()
        label = QLabel(self)
        pm = QPixmap(absPath("./imagenes/patito.jpg"))
        label.setPixmap(pm)
        label.setScaledContents(True)
        label.resize(self.size())

        

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())
