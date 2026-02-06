from PySide6.QtWidgets import QApplication, QMainWindow, QMessageBox
from ejercicio1 import Ui_MainWindow
import sys


class MainWindow(QMainWindow, Ui_MainWindow):
    def __init__(self):
        super().__init__()
        self.setupUi(self)

        # conectar cada boton con la función
        self.pushButton.clicked.connect(self.boton_uno)
        self.pushButton_2.clicked.connect(self.boton_dos)
        self.pushButton_3.clicked.connect(self.boton_tres)
        self.pushButton_4.clicked.connect(self.boton_cuatro)

    # llamada de la función mostrar mensaje según el boton que s emuestra
    def boton_uno(self):
        self.mostrar_mensaje("Uno")

    def boton_dos(self):
        self.mostrar_mensaje("Dos")

    def boton_tres(self):
        self.mostrar_mensaje("Tres")

    def boton_cuatro(self):
        self.mostrar_mensaje("Cuatro")

    # función para mostrar el mensaje a la que se le pasa el texto a mostrar
    def mostrar_mensaje(self, texto):
        QMessageBox.information(
            self,
            "Diálogo",
            f"Has pulsado el botón {texto}"
        )


if __name__ == '__main__':
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())
