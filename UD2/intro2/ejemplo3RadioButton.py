from PySide6.QtWidgets import QApplication, QMainWindow, QRadioButton
from PySide6.QtCore import QSize, Qt
import sys

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # creamos un botón radial y lo establecemos de widget central
        radial = QRadioButton("Botón radial")
        self.setCentralWidget(radial)

        # señal para detectar cambios en el botón
        radial.toggled.connect(self.estado_cambiado)

        # podemos activarla por defecto
        radial.setChecked(True)

        print("¿Activada?", radial.isChecked())        
    
    def estado_cambiado(self, estado):
        if estado:
            print("Radial marcado")
        else:
            print("Radial desmarcado")

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())