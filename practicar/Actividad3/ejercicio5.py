from PySide6.QtWidgets import (QMainWindow, QApplication, QGridLayout, QPushButton, QWidget)
import sys
class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        layout = QGridLayout()
        widget = QWidget()
        widget.setLayout(layout)
        self.setCentralWidget(widget)
        
        boton1 = QPushButton("1")
        boton2 = QPushButton("2")
        boton3 = QPushButton("3")
        boton4 = QPushButton("4")

        boton5 = QPushButton("5")

        boton6 = QPushButton("6")
        boton7 = QPushButton("7")

        layout.addWidget(boton1,0,0)
        layout.addWidget(boton2,0,1)
        layout.addWidget(boton3,0,2)
        layout.addWidget(boton4,0,3)

        layout.addWidget(boton5,1,0,1,0)
        
        layout.addWidget(boton6,2,0,1,2)
        layout.addWidget(boton7,2,2,1,2)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())