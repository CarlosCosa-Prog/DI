from PySide6.QtWidgets import QApplication, QLabel, QMainWindow
import sys
class Contenedor(QLabel):
        def __init__(self, color):
            super().__init__()
            self.setStyleSheet(f"background-color:{color}")

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        contenedor = Contenedor("green")
        self.setCentralWidget(contenedor)    

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())