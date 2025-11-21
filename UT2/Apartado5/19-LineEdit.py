from PySide6.QtWidgets import QApplication, QMainWindow, QLineEdit
import sys


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # creamos un campo de texto
        texto = QLineEdit()
        self.setCentralWidget(texto)

        # Probamos algunas opciones
        texto.setMaxLength(10)
        # Texto inicial (opcional)
        texto.setPlaceholderText("Escribe máximo 10 caracteres")

        # Probamos algunas señales
        texto.textChanged.connect(self.texto_cambiado)
        texto.returnPressed.connect(self.enter_presionado)

    # Metodo que muestra letra a letra el texto según va cambiando
    def texto_cambiado(self, texto):
        print("Texto cambiado ->", texto)

    # Metodo que coge el texto completo una vez se finaliza la edición y pulsamos Enter
    def enter_presionado(self):
        # al presionar enter recuperamos el texto a partir del widget central
        texto = self.centralWidget().text()
        print("Enter presionado, texto ->", texto)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())