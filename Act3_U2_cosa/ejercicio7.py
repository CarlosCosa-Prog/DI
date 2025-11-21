from PySide6.QtWidgets import QApplication, QMainWindow, QLabel, QGridLayout, QWidget
# from PySide6.QtCore import QSize, Qt
import sys

class contenedor(QLabel):
    def __init__(self, color):
        super().__init__()
        self.setStyleSheet(f"background-color:{color}")

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        layout = QGridLayout()

        for fila in range(8):
            for columna in range(8):
                color = "white" if (fila + columna) % 2 == 0 else "black"
                layout.addWidget(contenedor(color), fila, columna)

        # añadir el layout como principal
        widget = QWidget()
        widget.setLayout(layout)
        self.setCentralWidget(widget)
        
        # cambiar el tamaño de la ventana
        self.resize(500,500)

        # para eliminar los bordes
        layout.setContentsMargins(0,0,0,0)
        layout.setSpacing(0) 

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())