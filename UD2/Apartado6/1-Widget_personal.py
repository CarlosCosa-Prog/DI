from PySide6.QtWidgets import QApplication, QMainWindow, QLabel
import sys

# Creamos una subclase de QLabel para personalizar el contenedor
class Contenedor(QLabel):
    def __init__(self, color):
        super().__init__()
        # Establecemos el color de fondo usando hojas de estilo
        self.setStyleSheet(f"background-color:{color}")

# Creamos la ventana principal
class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        
        # El contenedor tendrá un color de fondo verde
        caja = Contenedor("green")
        self.setCentralWidget(caja)


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())