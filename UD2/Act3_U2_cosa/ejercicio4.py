from PySide6.QtWidgets import QApplication, QMainWindow, QTabWidget, QLabel
# from PySide6.QtCore import QSize, Qt
import sys

class contenedor(QLabel):
    def __init__(self, color):
        super().__init__()
        self.setStyleSheet(f"background-color:{color}")

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        
        
        tabs = QTabWidget()
        # mover las pestañas al lado izquierdo
        tabs.setTabPosition(QTabWidget.West)
        
        tabs.addTab(contenedor("red"), "red")
        tabs.addTab(contenedor("green"), "green")
        tabs.addTab(contenedor("blue"), "blue")
        tabs.addTab(contenedor("yellow"), "yellow")
        
        self.setCentralWidget(tabs)
        # cambiar el tamaño de la ventana
        self.resize(350,250)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())