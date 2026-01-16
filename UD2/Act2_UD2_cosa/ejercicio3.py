"""Haz un programa que disponga de un botón y cada vez que hacemos clic, nos mostrará
un refrán de manera aleatoria en el título de la ventana.
Si el refrán es “De los errores se aprende”, el botón quedará deshabilitado y ya no
dejará clicar y leer más refranes aleatorios. Haremos uso de la función choice de la
librería random para hacer el ramdom.
from random importe choice"""
# Programa que disponga un botón y una etiqueta con un texto
#   - Al hacer clic mostrará un refrán de manera aleatoria
#   - 
from PySide6.QtWidgets import QApplication, QMainWindow, QLabel, QPushButton, QHBoxLayout, QWidget
import sys, random

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        # creo el boton, etiqueta, layout y contenedor
        self.boton = QPushButton("Mostrar refrán")
        self.etiqueta = QLabel()
        layout = QHBoxLayout()
        widget = QWidget()

        # Lista de refranes
        self.refranes = [
            "Haz el bien sin mirar a quien",
            "Más vale prevenir que curar",
            "A mal tiempo, buena cara",
            "Quien tiene un amigo tiene un tesoro",
            "La avaricia rompe el saco",
            "De los errores se aprende"
        ]
        # asigno el layout al widget y establezco como central de la ventana
        widget.setLayout(layout)
        self.setCentralWidget(widget)
        # añado el botón y la etiqueta al layout
        layout.addWidget(self.boton)
        layout.addWidget(self.etiqueta)

        # también se puede usar pressed que se ejecuta cuando el usuario presiona el botón (antes de soltarlo)
        # el clicked se ejecuta cuando el usuario suelta el botón
        self.boton.clicked.connect(self.mostrar_refran)

    def mostrar_refran(self):
        refran = random.choice(self.refranes)
        self.etiqueta.setText(refran)
        
        # Si el refrán es el especial, deshabilita el boton
        if refran == "De los errores se aprende":
            self.boton.setEnabled(False)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())