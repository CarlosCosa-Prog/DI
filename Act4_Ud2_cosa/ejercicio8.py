from PySide6.QtWidgets import (QApplication, QMainWindow, QLabel,
                               QPushButton, QVBoxLayout, QWidget,
                               QDialog, QGridLayout)
import sys
from pathlib import Path
from PySide6.QtCore import Qt

def absPath(file):
    return str(Path(__file__).parent.absolute() / file)

class Dialogo(QDialog):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Preferenecias")
        self.resize(300, 200)

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.resize(480,320)

        menu = self.menuBar()
        menu.addMenu("Configuración")

        # creación del layout que contendrá el label y el boton
        layout = QVBoxLayout()
        contenedor = QWidget()
        contenedor.setLayout(layout)
        self.setCentralWidget(contenedor)

        label = QLabel("Hola")
        label.setAlignment(Qt.AlignCenter)

        boton = QPushButton("Preferencias...")
        boton.clicked.connect(self.mostrar_dialog)
        
        # añado el label y el boton al layout para que se muestren
        layout.addWidget(label)
        layout.addWidget(boton)

        # CONTENIDO DEL QDIALOG
        layoutG = QGridLayout()
        label1 = QLabel("Nombre de usuario: ")
        label2 = QLabel("Color de fondo: ")
        label3 = QLabel("Tipo de letra: ")

        layoutG.addWidget(label1,0,0)
        layoutG.addWidget(label2,0,1)
        layoutG.addWidget(label3,0,2)

        

    def mostrar_dialog(self):
        dialogo = Dialogo()
        dialogo.exec()  # abre el dialogo en modo modal (bloquea la ventana principal hasta que se cierre)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())