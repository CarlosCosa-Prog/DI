from PySide6.QtWidgets import QApplication, QMainWindow, QFormLayout, QWidget, QLabel
# from PySide6.QtCore import QSize, Qt
import sys

class contenedor(QLabel):
    def __init__(self, color):
        super().__init__()
        self.setStyleSheet(f"background-color:{color}")

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        formulario = QFormLayout()
        # añadimos widgets con etiquetas en filas
        formulario.addRow("Campo 1", contenedor("orange"))
        formulario.addRow("Campo 2", contenedor("purple"))
        formulario.addRow("Campo 3", contenedor("magenta"))
        formulario.addRow("Campo 4", contenedor("gray"))
        formulario.addRow("Campo 5", contenedor("red"))
        # cremos el widget dummy y le asignamos el layout
        widget = QWidget()
        widget.setLayout(formulario)
        self.setCentralWidget(widget)
    

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())