from PySide6.QtWidgets import QApplication, QMainWindow, QHBoxLayout,QWidget, QPushButton
# from PySide6.QtCore import QSize, Qt
import sys

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        layout = QHBoxLayout()
        boton1 = QPushButton("Botó 1")
        boton2 = QPushButton("Botó 2")
        boton3 = QPushButton("Botó 3")
        boton4 = QPushButton("Botó 4")

        # creo un dummy widget para hacer de contenedor
        widget = QWidget()
        # le asignamos el layout
        widget.setLayout(layout)
        # establecemos el dummy widget como widget central
        self.setCentralWidget(widget)

        # añadimos unas cuantas cajas
        layout.addWidget(boton1)
        layout.addWidget(boton2)
        layout.addWidget(boton3)
        layout.addWidget(boton4)


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())