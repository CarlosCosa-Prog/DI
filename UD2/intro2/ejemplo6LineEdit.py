from PySide6.QtWidgets import QApplication, QMainWindow, QLineEdit
from PySide6.QtCore import QSize, Qt
import sys

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        texto = QLineEdit()
        self.setCentralWidget(texto)

        texto.setMaxLength(10)
        texto.setPlaceholderText("Excribe máximo 10 caracteres")

        texto.textChanged.connect(self.texto_cambiado)
        texto.returnPressed.connect(self.enter_presionado)
    
    def texto_cambiado(selg, texto):
        print("Texto cambiado -> ", texto)
    
    def enter_presionado(self):
        texto = self.centralWidget().text()
        print("Enter presionado, texto ->", texto)
        

           

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())