from PySide6.QtWidgets import (QMainWindow,QApplication, QWidget,
                               QGridLayout, QLabel, QPushButton,
                               QColorDialog, QFontDialog, QDialog,
                               QToolBar)
from pathlib import Path
from PySide6.QtGui import QIcon
from PySide6.QtCore import Qt
import sys


def absPath(file):
    return str(Path(__file__).parent.absolute() / file)

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        menu = self.menuBar()
        self.setMenuBar(menu)
        archivo = menu.addMenu("Archivo")
        archivo.addAction(QIcon(absPath("./imagenes/exit.png")), "Salir", self.close, "Ctrl + E")
        ver = menu.addMenu("Ver")
        ventana = ver.addAction("Ventana")
        ventana.triggered.connect(self.mostrar_ventana)

        widget = QWidget()
        layout = QGridLayout()
        widget.setLayout(layout)
        self.setCentralWidget(widget)

        self.label = QLabel("Texto de ejemplo")
        self.botonColor = QPushButton("Cambiar color")
        self.botonFuente = QPushButton("Cambiar fuente")
        self.label.setAlignment(Qt.AlignCenter)

        layout.addWidget(self.botonColor, 0, 0)
        layout.addWidget(self.botonFuente, 0, 1)
        layout.addWidget(self.label, 1, 0, 1, 2)

        self.botonColor.pressed.connect(self.cambiar_color)
        self.botonFuente.pressed.connect(self.cambiar_fuente)
        self.mostrar_barraHer()
    
    def cambiar_color(self):
        color = QColorDialog.getColor()

        if color.isValid():
            self.label.setStyleSheet(f"background-color:{color.name()}")
    
    def cambiar_fuente(self):
        cambio, fuente = QFontDialog.getFont()

        if cambio:
            self.label.setFont(fuente)

    def mostrar_ventana(self):
        ventana = segundaVentana()
        ventana.exec()

    def mostrar_barraHer(self):
        barraHerr = QToolBar()
        barraHerr.addAction(QIcon(absPath("./imagenes/exit.png")),self.close)

class segundaVentana(QDialog):
    def __init__(self):
        super().__init__()
        
        layout = QGridLayout()
        self.setLayout(layout)

        self.label = QLabel("Texto de ejemplo")
        self.botonColor = QPushButton("Cambiar color")
        self.botonFuente = QPushButton("Cambiar fuente")
        self.label.setAlignment(Qt.AlignCenter)

        layout.addWidget(self.botonColor, 0, 0)
        layout.addWidget(self.botonFuente, 0, 1)
        layout.addWidget(self.label, 1, 0, 1, 2)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())