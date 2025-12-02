from PySide6.QtWidgets import (QApplication, QMainWindow, QToolBar)
from PySide6.QtGui import QAction, QIcon
from pathlib import Path
import sys

def absPath(file):
    return str(Path(__file__).parent.absolute() / file)

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # MENU BAR
        #-------------------------------------------------
        menu = self.menuBar()
        menu1 = menu.addMenu("Archivo")
        menu2 = menu.addMenu("Ayuda")
        menu3 = menu.addMenu("Ver")

        submenu1 = ad
        #-------------------------------------------------
        
        # BARRA DE HERRAMIENTAS
        #-------------------------------------------------
        barraHer = QToolBar()
        self.addToolBar(barraHer)
        
        acSalir = QAction(QIcon(absPath("./imagenes/exit.png")),"Salir",self)
        acSalir.triggered.connect(self.close)
        barraHer.addAction(acSalir)

        acInfo = QAction(QIcon(absPath("./imagenes/info.png")),"Info", self)
        barraHer.addAction(acInfo)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())