from PySide6.QtWidgets import QApplication, QMainWindow, QSpinBox
import sys


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # creamos un campo numérico entero y le ponemos un valor inicial
        numero = QSpinBox()
        numero.setValue(3)
        self.setCentralWidget(numero)

        # Probamos algunas opciones
        # Valor minimo que se puede poner
        numero.setMinimum(0)
        # Valor máximo que se puede poner
        numero.setMaximum(10)
        # Otra forma de establecer rango, equivalente a las dos anteriores
        numero.setRange(0, 10)
        # Incremento/decremento al pulsar las flechas
        numero.setSingleStep(1)

        # Probamos algunas señales
        numero.valueChanged.connect(self.valor_cambiado)

    def valor_cambiado(self, numero):
        # al presionar enter recuperamos el texto a partir del widget central
        print("Valor cambiado ->", numero)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())