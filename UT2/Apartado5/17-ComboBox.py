from PySide6.QtWidgets import QApplication, QMainWindow, QComboBox  # edited
import sys


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # creamos un desplegable
        desplegable = QComboBox()
        self.setCentralWidget(desplegable)

        # añadimos opciones al desplegable, si la primera es vacia, no hay opción 
        # seleccionada, en otro caso, la primera será la opción por defecto
        desplegable.addItems(["", "Opción 1", "Opción 2", "Opción 3"])

        # consultamos el valor actual, índice y texto
        print("Índice actual ->", desplegable.currentIndex())
        print("Texto actual ->", desplegable.currentText())

        desplegable.currentIndexChanged.connect(self.indice_cambiado)
        desplegable.currentTextChanged.connect(self.texto_cambiado)

    def indice_cambiado(self, indice):
        print("Nuevo índice ->", indice)

    def texto_cambiado(self, texto):
        print("Nuevo texto ->", texto)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())