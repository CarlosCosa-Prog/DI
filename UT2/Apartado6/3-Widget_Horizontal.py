from PySide6.QtWidgets import QApplication, QMainWindow, QLabel, QHBoxLayout, QWidget
import sys


class Contenedor(QLabel):
    def __init__(self, color):
        super().__init__()
        # Establecemos el color de fondo usando hojas de estilo
        self.setStyleSheet(f"background-color:{color}")


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # Creamos un layout vertical            
        layout = QHBoxLayout()
        layout.addWidget(Contenedor("green"))

        # le añadimos unas cuantas cajas
        layout.addWidget(Contenedor("green"))
        layout.addWidget(Contenedor("blue"))
        layout.addWidget(Contenedor("red"))

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