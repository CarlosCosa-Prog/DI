from PySide6.QtWidgets import (QMainWindow, QApplication, QComboBox,
                               QWidget)
import sys

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        lista = QComboBox()
        self.setCentralWidget(lista)
        lista.addItems(["Enero","Febrero","Marzo"])
        lista.currentIndexChanged.connect(self.posicion)
        lista.currentTextChanged.connect(self.mes)

    def posicion(self,indice):
        print("Posicion:", indice + 1)
    
    def mes(self,mes):
        print("Mes:", mes)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())