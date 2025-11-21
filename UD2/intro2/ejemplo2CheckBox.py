from PySide6.QtWidgets import QApplication, QMainWindow, QCheckBox
from PySide6.QtCore import QSize, Qt
import sys

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        casilla = QCheckBox("Casilla de verificacion")
        self.setCentralWidget(casilla)
        casilla.stateChanged.connect(self.estado_cambiado)
        casilla.setCheckState(Qt.PartiallyChecked)
        #casilla.setEnabled(False)
    
    def estado_cambiado(self, estado):
        if (estado == 2):
            print("Casilla marcada")
        if (estado == 0):
            print("Casilla desmarcada")
        if (estado == 1):
            print("Casilla parcialmente desmarcada")

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())