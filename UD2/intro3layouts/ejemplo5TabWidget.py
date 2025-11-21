from PySide6.QtWidgets import QApplication, QMainWindow, QLabel, QTabWidget
# from PySide6.QtCore import QSize, Qt
import sys

class contenedor(QLabel):
    def __init__(self, color):
        super().__init__()
        self.setStyleSheet(f"background-color:{color}")

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__() 
        # creamos un layout de pestañas
        tabs = QTabWidget()
        # Añadimos varios widgets como pestañas con nombres
        tabs.addTab(contenedor("orange"), "Uno")
        tabs.addTab(contenedor("magenta"), "Dos")
        tabs.addTab(contenedor("purple"), "Tres")
        tabs.addTab(contenedor("red"), "Cuatro")
        # asignamos las pestañas como widget central
        self.setCentralWidget(tabs) 

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())