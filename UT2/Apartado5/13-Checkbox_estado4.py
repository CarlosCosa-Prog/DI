from PySide6.QtWidgets import QApplication, QMainWindow, QCheckBox  # edited
from PySide6.QtCore import Qt
import sys


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # creamos una casilla y la establecemos de widget central
        casilla = QCheckBox("Casilla de verificación")
        self.setCentralWidget(casilla)

        # la podemos desactivar
        casilla.setEnabled(False)

        # señal para detectar cambios en la casilla
        casilla.stateChanged.connect(self.estado_cambiado)
        
        
    # función que muestra el estado de la casilla
    def estado_cambiado(self, estado):
        if estado ==  2:
            print("Casilla marcada")
        elif estado == 0:
            print("Casilla desmarcada")
        else:
            print("Casilla neutra")


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())


        