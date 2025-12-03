from PySide6.QtWidgets import (QApplication, QMainWindow, QToolBar,
                               QDockWidget, QLabel)
from PySide6.QtGui import QAction, QIcon
from pathlib import Path
from PySide6.QtCore import Qt
import sys

def absPath(file):
    return str(Path(__file__).parent.absolute() / file)

# contenedor para establecer el color de fondo de los docks
class Contenedor(QLabel):
    def __init__(self,color):
        super().__init__()
        self.setStyleSheet(f"background-color:{color}")

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.resize(480,320)
        self.setCentralWidget(Contenedor("gray"))

        # llamo a las funciones de los docks para que se muestren al inicio
        self.construir_dock1()
        self.construir_dock2()
        self.construir_dock3()

        # MENU BAR
        #-------------------------------------------------
        menu = self.menuBar()
        menu.addMenu("Archivo")
        menu.addMenu("Ayuda")
        menu3 = menu.addMenu("Ver")

        accion1Menu3 = menu3.addAction("Mostrar DOCK 1")
        accion2Menu3 = menu3.addAction("Mostrar DOCK 2")
        accion3Menu3 = menu3.addAction("Mostrar DOCK 3")
        

        accion1Menu3.triggered.connect(self.construir_dock1)
        accion2Menu3.triggered.connect(self.construir_dock2)
        accion3Menu3.triggered.connect(self.construir_dock3)
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
        #-------------------------------------------------
        
    def construir_dock1(self):
        dock = QDockWidget()
        dock.setWindowTitle("DOCK 1")
        dock.setWidget(Contenedor("white"))
        self.addDockWidget(Qt.LeftDockWidgetArea, dock)
        dock.setMinimumSize(125, 100)
        
    def construir_dock2(self):
        dock = QDockWidget()
        dock.setWindowTitle("DOCK 2")
        dock.setWidget(Contenedor("yellow"))
        self.addDockWidget(Qt.RightDockWidgetArea, dock)
        dock.setMinimumSize(125, 100)

    def construir_dock3(self):
        dock = QDockWidget()
        dock.setWindowTitle("DOCK 3")
        dock.setWidget(Contenedor("blue"))
        self.addDockWidget(Qt.BottomDockWidgetArea, dock)
        dock.setMinimumSize(125, 100)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())