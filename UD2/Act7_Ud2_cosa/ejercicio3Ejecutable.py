from PySide6.QtWidgets import QApplication, QMainWindow
from ejercicio3 import Ui_MainWindow
import sys


class MainWindow(QMainWindow, Ui_MainWindow):
    def __init__(self):
        super().__init__()
        self.setupUi(self)

        # conectar los campos con la función
        self.lineEdit.editingFinished.connect(self.mostrar_datos)
        self.spinBox.valueChanged.connect(self.mostrar_datos)
        self.doubleSpinBox.valueChanged.connect(self.mostrar_datos)

    # función para mostrar los datos introducidos en el formulario por consola
    def mostrar_datos(self):
        texto = self.lineEdit.text()
        entero = self.spinBox.value()
        decimal = self.doubleSpinBox.value()

        print("Texto:", texto)
        print("Entero:", entero)
        print("Decimal:", decimal)
        print("-" * 20)


if __name__ == '__main__':
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())
