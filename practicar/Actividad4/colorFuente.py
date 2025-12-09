from PySide6.QtWidgets import (QMainWindow, QApplication, QPushButton,
                               QColorDialog, QGridLayout, QWidget, QLabel,
                               QFontDialog)
import sys
from PySide6.QtCore import Qt
class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.resize(500,300)
        layout = QGridLayout()
        widget = QWidget()
        widget.setLayout(layout)
        self.setCentralWidget(widget)

        self.botonColor = QPushButton("Cambiar color")
        self.botonFuente = QPushButton("Cambiar fuente")
        
        self.label = QLabel("Texto de prueba")
        self.label.setAlignment(Qt.AlignCenter)

        layout.addWidget(self.botonColor,0,0)
        layout.addWidget(self.botonFuente,0,1)
        layout.addWidget(self.label,1,0,1,2)

        self.botonColor.pressed.connect(self.color_dialog)
        self.botonFuente.pressed.connect(self.fuente_dialog)

    def color_dialog(self):
        color = QColorDialog.getColor()
        if color.isValid():
            self.label.setStyleSheet(f"background-color: {color.name()}")
    
    def fuente_dialog(self):
        confirmado, fuente = QFontDialog.getFont()
        if confirmado:
            self.label.setFont(fuente)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())