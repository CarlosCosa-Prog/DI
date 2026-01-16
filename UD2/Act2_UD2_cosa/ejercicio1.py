# componentes QLineEdit(tam max 5 car y 50x30 píxeles) y QLabel  (tam 50x30 píxeles y se desplazará 50 píxeles)
# cuando el QLineEdit cambie, la etiqueta mostrará el texto introducido.

from PySide6.QtWidgets import QApplication, QMainWindow, QLineEdit, QLabel 
#from PySide6.QtCore import QSize, Qt
import sys

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # creación del Line Edit
        self.texto = QLineEdit()
        self.setCentralWidget(self.texto)
        self.texto.setMaxLength(5)  # tamaño máximo de 5 carácteres
        self.texto.setFixedSize(50,30) # tamaño de 50x30 pixeles

        # llamada a la función texto_cambiado
        self.texto.textChanged.connect(self.texto_cambiado)
        
        # creación de la etiqueta
        self.etiqueta = QLabel(self)
        self.etiqueta.setFixedSize(50, 30)  # tamaño de 50x30 pixeles
        self.etiqueta.move(50, 50) # desplazar 50 pixeles
        
    # función que modifica el texto de la etiqueta cuando se cambia el texto del Line Edit
    def texto_cambiado(self, texto):
        self.etiqueta.setText(texto)


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())
