from PySide6.QtWidgets import (QApplication, QMainWindow,
                               QPushButton, QFontDialog)
import sys

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        # creación del boton y establecer como widget principal
        boton = QPushButton("Haz clic para que el dialogo aparezca")
        self.boton = boton
        self.setCentralWidget(boton)
        # llamada de la funcion
        boton.clicked.connect(self.clic_boton)
    
    def clic_boton(self):
        confirmado, fuente = QFontDialog.getFont(self)
        # si el usuario le da a confirmar, se establce la fuente
        if confirmado:
            self.boton.setFont(fuente)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())