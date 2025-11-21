from PySide6.QtWidgets import QApplication, QMainWindow, QLabel, QGridLayout, QWidget
# from PySide6.QtCore import QSize, Qt
import sys, random

class caja(QLabel):
    def __init__(self, color):
        super().__init__()
        self.setStyleSheet(f"background-color:{color}")

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # creo el layout en cuadrícula
        cuadricula = QGridLayout()

        # añado widgets en las celdas usando los indices
        # cuadricula.addWidget(caja("orange"),0,0)
        # cuadricula.addWidget(caja("purple"),1,1)
        # cuadricula.addWidget(caja("magenta"),2,2)
        # cuadricula.addWidget(caja("gray"),2,0)
        # cuadricula.addWidget(caja("red"),0,2)
        
        # bucles for para generar una cuadrícula
        for fila in range(5):
            for columna in range(5):
            # añadimos una caja de color aleatorio
                intento = str(hex(random.randint(0, 16777215))) # int(0xFFFFFF)
                intento = intento.rsplit("x")
                color = "Ox" + intento[1].zfill(6)
                cuadricula.addWidget(caja(f"#{color[2:]}"), fila, columna)

        # creo el widget dummy y le asigno el layout que he creado
        widget = QWidget()
        widget.setLayout(cuadricula)
        self.setCentralWidget(widget)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())