from PySide6.QtWidgets import QApplication, QMainWindow, QCheckBox  # edited
from PySide6.QtCore import QSize, Qt
import sys


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # creamos una casilla y la establecemos de widget central
        casilla = QCheckBox("Casilla de verificación")
        self.setCentralWidget(casilla)

        # señal para detectar cambios en la casilla
        casilla.stateChanged.connect(self.estado_cambiado)
        
    # Función con codigo correcto que muestra el estado de la casilla
    def estado_cambiado(self, estado):
        if estado ==  2:
            print("Casilla marcada")
        elif estado == 0:
            print("Casilla desmarcada")
        else:
            print("Casilla neutra")

    # Código que no funciona correctamente        
    #def estado_cambiado(self, estado):
    #    if estado == Qt.Checked:
    #        print("Casilla marcada")
    #    if estado == Qt.Unchecked:
    #        print("Casilla desmarcada")
    #    if estado == Qt.PartiallyChecked:
    #        print("Casilla neutra")

    

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())