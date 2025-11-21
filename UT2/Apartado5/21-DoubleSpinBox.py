from PySide6.QtWidgets import QApplication, QMainWindow, QDoubleSpinBox
import sys


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # creamos un campo numérico entero y le ponemos un valor inicial
        numero = QDoubleSpinBox()
        numero.setValue(3.1415)
        # Podemos añadir un prefijo o sufijo al número
        numero.setPrefix("$")
        self.setCentralWidget(numero)

        # Probamos algunas opciones
        # Valor minimo que se puede poner
        numero.setMinimum(0.00)
        # Valor máximo que se puede poner
        numero.setMaximum(10.00)
        # Otra forma de establecer rango, equivalente a las dos anteriores
        numero.setRange(0.00, 10.00)
        # Incremento/decremento al pulsar las flechas
        numero.setSingleStep(0.25)

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