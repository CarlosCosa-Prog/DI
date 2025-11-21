from PySide6.QtWidgets import QApplication, QMainWindow, QLabel, QVBoxLayout, QWidget, QHBoxLayout
import sys
class Contenedor(QLabel):
        def __init__(self, color):
            super().__init__()
            self.setStyleSheet(f"background-color:{color}")

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        # empezamos creando un layout vertical
        # el QHBoxLayout ordena los elementos en sentido horizontal por lo que 
        layout = QHBoxLayout()

        # probamos a establecerlo como widget central (no es posible porque los layout no heredan de QWidget)
        # self.setCentralWidget(layout)
        
        # creaumos un dummy widget para hacer de contenedor
        widget = QWidget()
        # le asignamos el layout
        widget.setLayout(layout)
        # establecemos el dummy widget como widget central
        self.setCentralWidget(widget)

        # añadimos unas cuantas cajas
        layout.addWidget(Contenedor("red"))
        layout.addWidget(Contenedor("yellow"))
        layout.addWidget(Contenedor("red"))

        # para eliminar los bordes
        layout.setContentsMargins(0,0,0,0)
        layout.setSpacing(0) 
        


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())