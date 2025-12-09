from PySide6.QtWidgets import (QApplication, QMainWindow, QColorDialog,
                               QFontDialog, QLabel, QGridLayout, QPushButton,
                               QWidget, QToolBar, QDialog, QDockWidget)
import sys
from pathlib import Path
from PySide6.QtCore import Qt
from PySide6.QtGui import QIcon

def absPath(file):
    return str(Path(__file__).parent.absolute() / file)

class contenedor(QLabel):
    def __init__(self,color):
        super().__init__()
        self.setStyleSheet(f"background-color:{color}")

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Cambiar color y fuente")
        self.resize(500,300)

        menu = self.menuBar()
        self.setMenuBar(menu)
        archivo = menu.addMenu("Archivo")
        archivo.addAction(QIcon(absPath("./imagenes/exit.png")),"Salir", self.close, "Ctrl+E")
        ver = menu.addMenu("Ver")
        action1Ver = ver.addAction("Mostrar segunda ventana")
        action1Ver.triggered.connect(self.mostrar_segundaVentana)
        info = menu.addAction("Ayuda")
        info.setStatusTip("Mostrar info")

        widget = QWidget()
        layout = QGridLayout()
        widget.setLayout(layout)
        self.setCentralWidget(widget)
        
        label = QLabel("Texto de ejemplo")
        label.setAlignment(Qt.AlignCenter)
        boton1 = QPushButton("Cambiar color")
        boton2 = QPushButton("Cambiar fuente")
        self.label = label
        self.boton1 = boton1
        self.boton2 = boton2
        layout.addWidget(boton1,0,0)
        layout.addWidget(boton2,0,1)
        layout.addWidget(label,1,0,1,2)

        boton1.pressed.connect(self.cambiar_color)
        boton2.pressed.connect(self.cambiar_fuente)
        self.mostrar_barraHer()
    
    def cambiar_color(self):
        color = QColorDialog.getColor()
        if color.isValid():
            self.label.setStyleSheet(f"background-color:{color.name()}")
    
    def cambiar_fuente(self):
        cambio, fuente = QFontDialog.getFont()
        if cambio:
            self.label.setFont(fuente)
    
    def mostrar_barraHer(self):
        barraHer = QToolBar()
        self.addToolBar(barraHer)
        barraHer.addAction(QIcon(absPath("./imagenes/exit.png")),"Salir", self.close)
    
    def mostrar_segundaVentana(self):
        self.ventana = segundaVentana()
        self.ventana.show()

class segundaVentana(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Contenedores")
        
        dock1 = QDockWidget()
        dock1.setFixedSize(125,100)
        #dock1.setFeatures(QDockWidget.NoDockWidgetFeatures)
        dock2 = QDockWidget()
        dock2.setFixedSize(125,100)
        dock3 = QDockWidget()
        dock3.setFixedSize(300,100)
        dock3.setFeatures(QDockWidget.NoDockWidgetFeatures)
        
        self.addDockWidget(Qt.LeftDockWidgetArea, dock1)
        self.addDockWidget(Qt.RightDockWidgetArea, dock2)
        self.addDockWidget(Qt.BottomDockWidgetArea, dock3)
        
        dock1.setWindowTitle("Dock 1")
        dock2.setWindowTitle("Dock 2")
        dock3.setWindowTitle("Dock 3")

        dock1.setWidget(contenedor("green"))
        dock2.setWidget(contenedor("blue"))
        dock3.setWidget(contenedor("red"))




if __name__ == "__main__":
    app = QApplication()

    with open(absPath("estilos.qss"), "r") as f:
        app.setStyleSheet(f.read())

    window = mainWindow()
    window.show()
    sys.exit(app.exec())