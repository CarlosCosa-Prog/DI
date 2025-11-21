from PySide6.QtWidgets import QApplication, QMainWindow, QListWidget
from PySide6.QtCore import QSize, Qt
import sys

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        #creamos una lista
        lista = QListWidget()
        self.setCentralWidget(lista)

        # Añadimos algunas opciones
        lista.addItems(["Opcion 1", "Opcion 2", "Opcion 3"])
        # Y algunas señales
        lista.currentItemChanged.connect(self.item_cambiado)

        # Mostrar el item acutal
        print(lista.currentItem())

    # Conseguimos el texto del item con su método text()
    def item_cambiado(self, item):
        print("Nuevo item ->", item.text())

           

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())
