from PySide6.QtWidgets import (
    QApplication, QMainWindow, QLabel, QTabWidget)
import sys


class Caja(QLabel):
    def __init__(self, color):
        super().__init__()
        self.setStyleSheet(f"background-color:{color}")


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # creamos un layout de pestañas
        tabs = QTabWidget()

        # Añadimos varios widgets como pestañas con nombres
        tabs.addTab(Caja("orange"), "Uno")
        tabs.addTab(Caja("magenta"), "Dos")
        tabs.addTab(Caja("purple"), "Tres")
        tabs.addTab(Caja("red"), "Cuatro")

        # configuracion de los tabs de las pestanyas en la orientación deseada
        # West, East, North, South
        tabs.setTabPosition(QTabWidget.West)  

        # permitimos que las pestañas se puedan mover arrastrándolas
        tabs.setMovable(True)

        # asignamos las pestañas como widget central
        self.setCentralWidget(tabs)


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())