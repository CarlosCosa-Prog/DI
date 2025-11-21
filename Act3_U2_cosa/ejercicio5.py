from PySide6.QtWidgets import QApplication, QMainWindow, QWidget, QGridLayout, QPushButton
# from PySide6.QtCore import QSize, Qt
import sys

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__() 
    
        cuadricula = QGridLayout()
        
        # fila 1
        boton1 = QPushButton("0,0")
        boton2 = QPushButton("0,1")
        boton3 = QPushButton("0,2")
        boton4 = QPushButton("0,3")
        cuadricula.addWidget(boton1, 0, 0)
        cuadricula.addWidget(boton2, 0, 1)
        cuadricula.addWidget(boton3, 0, 2)
        cuadricula.addWidget(boton4, 0, 3)

        # fila 2
        boton5 = QPushButton("1,0-3")
        cuadricula.addWidget(boton5, 1, 0, 1, 4)

        # fila 3
        boton6 = QPushButton("2,0-1")
        boton7 = QPushButton("2,2-3")
        cuadricula.addWidget(boton6, 2, 0, 1, 2)
        cuadricula.addWidget(boton7, 2, 2, 1, 2)
        
        widget = QWidget()
        widget.setLayout(cuadricula)
        self.setCentralWidget(widget)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())