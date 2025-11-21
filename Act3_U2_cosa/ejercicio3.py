from PySide6.QtWidgets import QApplication, QMainWindow, QGridLayout, QLabel, QLineEdit, QSpinBox, QDoubleSpinBox, QWidget
# from PySide6.QtCore import QSize, Qt
import sys

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        layout = QGridLayout()
        texto1 = QLabel("Text:")
        texto2 = QLabel("Enter:")
        texto3 = QLabel("Decimal:")
        textoEdit = QLineEdit()
        spinbox = QSpinBox()
        spinbox2 = QDoubleSpinBox()
        # añadimos unas cuantas cajas
        layout.addWidget(texto1,1,0)
        layout.addWidget(texto2,2,0)
        layout.addWidget(texto3,3,0)
        layout.addWidget(textoEdit,1,1)
        layout.addWidget(spinbox,2,1)
        layout.addWidget(spinbox2,3,1)


        widget = QWidget()
        widget.setLayout(layout)
        self.setCentralWidget(widget)


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())