from PySide6.QtWidgets import QApplication, QMainWindow, QWidget ,QPushButton, QSizePolicy, QVBoxLayout
from PySide6.QtCore import Qt
import sys



class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        # Creamos un layout vertical            
        layout = QVBoxLayout()
        
        boton1 = QPushButton("Fijo")
        boton1.setSizePolicy(QSizePolicy.Fixed, QSizePolicy.Fixed)
        boton2 = QPushButton("Expansivo")
        boton2.setSizePolicy(QSizePolicy.Expanding, QSizePolicy.Expanding)
        
        layout.addWidget(boton1, aligment=Qt.AlignRight | Qt.AlignVCenter)

        layout.addWidget(boton1)
        layout.addWidget(boton2)
        
       
        # Creamos un dummy widget para hacer de contenedor
        # Esto es necesario porque los layouts no pueden ser asignados directamente
        # a una ventana principal
        widget = QWidget()

        # Le asignamos el layout
        widget.setLayout(layout)

        # Establecemos el dummy widget como widget central
        self.setCentralWidget(widget)


if __name__ == "__main__":
    app = QApplication(sys.argv)

    #Precaución, ahorael objeto es de la clase MainWindow
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())




b1 = QPushButton("Fixe")
b1.setSizePolicy(QSizePolicy.Fixed, QSizePolicy.Fixed)
b2 = QPushButton("Expansiu")
b2.setSizePolicy(QSizePolicy.Expanding, QSizePolicy.Expanding)
layout.addWidget(b1)
layout.addWidget(b2)