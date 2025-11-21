from PySide6.QtWidgets import QApplication, QMainWindow, QComboBox
from PySide6.QtCore import QSize, Qt
import sys
class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
    
        desplegable = QComboBox()
        self.setCentralWidget(desplegable)
        desplegable.addItems(["Opcion 1", "Opcion 2", "Opcion 3"])

        # conectar el combo box para que utiliza las funciones
        desplegable.currentIndexChanged.connect(self.indice_cambiado)
        desplegable.currentTextChanged.connect(self.texto_cambiado)

        print("Indice actual ->", desplegable.currentIndex())
        print("Texto actual ->", desplegable.currentText())

    def indice_cambiado(self, indice):
        print ("Nuevo indice ->", indice)
    def texto_cambiado(self, texto):
        print("Nuevo texto ->",texto)

        

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())
