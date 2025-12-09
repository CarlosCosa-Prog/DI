from PySide6.QtWidgets import (QMainWindow, QApplication, 
                               QTabWidget, QLabel)
import sys

class contenedor(QLabel):
    def __init__(self,color):
        super().__init__()
        self.setStyleSheet(f"background-color: {color}")

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        tab = QTabWidget()
        tab.setTabPosition(QTabWidget.West)
        self.setCentralWidget(tab)
        tab.addTab(contenedor("yellow"),"Amarillo")
        tab.addTab(contenedor("red"),"Rojo")
        tab.addTab(contenedor("blue"),"Azul")

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())