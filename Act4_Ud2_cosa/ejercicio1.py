from PySide6.QtWidgets import (
    QApplication, QMainWindow,
    QPushButton, QColorDialog
)
import sys
class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        
        # ventana 1
        # creo el boton y lo añado al widget
        boton1 = QPushButton("Haz clic para que el dialogo aparezca")
        # convertir el boton a atributo para utilizarlo fuera de la clase
        self.boton1 = boton1
        self.setCentralWidget(boton1)

        # llamar a la funcion de clicar boton
        boton1.clicked.connect(self.boton_clicado)

    # funcion para abrir el selector de color        
    def boton_clicado(self):
        color = QColorDialog.getColor()

        # si el usuario presiona "cancelar" el color no es valido
        if color.isValid():
            # modificar el fondo con ccs (valor hex)
            self.boton1.setStyleSheet(f"background-color: {color.name()}")


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())