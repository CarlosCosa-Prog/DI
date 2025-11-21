from PySide6.QtWidgets import (QApplication, QMainWindow, 
            QWidget, QHBoxLayout, QVBoxLayout, QLabel)
import sys

class Contenedor(QLabel):
    def __init__(self,color):
        super().__init__()
        self.setStyleSheet(f"background-color:{color}")

class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Ejemplo Layouts Multiples")

        # Creación de layouts, uno horizontal (1) y dos verticales (2 y 3)
        layout1=QHBoxLayout()
        layout2=QVBoxLayout()
        layout3=QVBoxLayout()

        # Añadimos widgets al layout2
        layout2.addWidget(Contenedor("red"))
        layout2.addWidget(Contenedor("yellow"))
        layout2.addWidget(Contenedor("purple"))

        # Incluimos layouts2 dentro del Layout1, es importante el orden
        layout1.addLayout(layout2)
        
        # Añadimos widgets al layout1
        layout1.addWidget(Contenedor("green"))
        
        # Añadimos widgets al layout3
        layout3.addWidget(Contenedor("red"))
        layout3.addWidget(Contenedor("purple"))

        # Incluimos layouts3 dentro del Layout1,
        layout1.addLayout(layout3)

        #Quitar margenes o poner margenes
        layout1.setContentsMargins(5,5,5,5)
        layout2.setContentsMargins(0,0,0,0)
        layout3.setContentsMargins(0,0,0,0)
    
        #Quitar o poner margenes externos
        layout1.setSpacing(5)
        layout2.setSpacing(5)
        layout3.setSpacing(5)
        
        # Un Layout no se puede mostrar como Widget central
        # asi que lo metemos en un widget dummy
        widget=QWidget()
        widget.setLayout(layout1)
        self.setCentralWidget(widget)


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())