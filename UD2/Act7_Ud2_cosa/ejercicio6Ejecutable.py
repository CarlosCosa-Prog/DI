from PySide6.QtWidgets import QApplication, QMainWindow
from ejercicio6 import Ui_MainWindow
import sys


class MainWindow(QMainWindow, Ui_MainWindow):
    def __init__(self):
        super().__init__()
        self.setupUi(self)

        # conectar cada CheckBox con la función que muestra su estado
        self.checkBox.stateChanged.connect(self.mostrar_estado)
        self.checkBox_2.stateChanged.connect(self.mostrar_estado)
        self.checkBox_3.stateChanged.connect(self.mostrar_estado)

    # función que muestra el estado de los CheckBox por consola
    def mostrar_estado(self):
        print("Estado de los CheckBox tras un cambio:")
        if self.checkBox.isChecked():
            print("Primer checkbox activado")
        if self.checkBox_2.isChecked():
            print("Segundo checkbox activado")
        if self.checkBox_3.isChecked():
            print("Tercer checkbox activado")
        print("-" * 30) # separador


if __name__ == '__main__':
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())
