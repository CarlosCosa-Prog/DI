from PySide6.QtWidgets import (QApplication, QMainWindow, QLabel,
                               QPushButton, QVBoxLayout, QWidget,
                               QDialog, QGridLayout, QLineEdit,
                               QColorDialog, QFontDialog, QDialogButtonBox)
import sys
from pathlib import Path
from PySide6.QtCore import Qt

def absPath(file):
    return str(Path(__file__).parent.absolute() / file)

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.resize(480,320)

        menu = self.menuBar()
        menu.addMenu("Configuración")

        # creación del layout que contendrá el label y el boton
        layout = QVBoxLayout()
        contenedor = QWidget()
        contenedor.setLayout(layout)
        self.setCentralWidget(contenedor)

        self.label = QLabel("Hola")
        self.label.setAlignment(Qt.AlignCenter)

        boton = QPushButton("Preferencias...")
        boton.clicked.connect(self.mostrar_dialog)
        
        # añado el label y el boton al layout para que se muestren
        layout.addWidget(self.label)
        layout.addWidget(boton)

    def mostrar_dialog(self):
        dialogo = Dialogo()
        #   dialogo.exec() --> abre el dialogo en modo modal (bloquea la ventana principal hasta que se cierre)
       
        if dialogo.exec() == QDialog.Accepted:
            # aplicar cambios si se presiona ok
            if dialogo.color_seleccionado:
                self.label.setStyleSheet(f"background-color: {dialogo.color_seleccionado}")
            if dialogo.fuente_seleccionada:
                self.label.setFont(dialogo.fuente_seleccionada)
            if dialogo.texto_usuario:
                self.label.setText(f"Hola, {dialogo.texto_usuario}")

class Dialogo(QDialog):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Preferenecias")
        self.resize(300, 200)

        # Variables para almacenar los cambios que se utilizarán para el principal
        self.color_seleccionado = None
        self.fuente_seleccionada = None
        self.texto_usuario = None

        # CONTENIDO DEL QDIALOG
        layoutG = QGridLayout()
        label1 = QLabel("Nombre de usuario: ")
        label2 = QLabel("Color de fondo: ")
        label3 = QLabel("Tipo de letra: ")

        self.textE = QLineEdit()
        self.valorColor = QLabel()
        self.valorFuente = QLabel()
        self.botonColor = QPushButton("Elige color...")
        self.botonFuente = QPushButton("Elige fuente...")
        
        self.previsual = QLabel("Previsualización")
        self.previsual.setAlignment(Qt.AlignCenter)

        layoutG.addWidget(label1,0,0)
        layoutG.addWidget(label2,1,0)
        layoutG.addWidget(label3,2,0)

        layoutG.addWidget(self.textE,0,1,1,2)
        layoutG.addWidget(self.valorColor,1,1)
        layoutG.addWidget(self.valorFuente,2,1)
        layoutG.addWidget(self.botonColor,1,2)
        layoutG.addWidget(self.botonFuente,2,2)
        
        layoutG.addWidget(self.previsual, 3, 0, 1, 0)
        
        # botones de cancelar y ok
        botones = QDialogButtonBox(QDialogButtonBox.Ok | QDialogButtonBox.Cancel)
        layoutG.addWidget(botones, 4,2)

        self.setLayout(layoutG)

        self.botonColor.clicked.connect(self.cambiar_color)
        self.botonFuente.clicked.connect(self.cambiar_fuente)

        botones.accepted.connect(self.guardar_usuario)  # al hacer click en ok se guarda el usuario en la variable texto_usuario
        botones.accepted.connect(self.accept)
        botones.rejected.connect(self.reject)
       
    def cambiar_color(self):
        color = QColorDialog.getColor()

        if color.isValid():
            colorHex = color.name()
            # cambio el texto
            self.valorColor.setText(colorHex)   
            # cambio el color de la previsualización
            self.previsual.setStyleSheet(f"background-color: {colorHex}") 
            # asigna el valor de el color a la variable de color_seleccionado
            self.color_seleccionado = colorHex

    def cambiar_fuente(self):
        confirmado, fuente = QFontDialog.getFont(self)
       
        # si el usuario le da a confirmar, se establce la fuente
        if confirmado:
            # cambia el texto de valorFuente con el nombre de la fuente
            self.valorFuente.setText(fuente.family())
            # cambia la fuente de la previsualización
            self.previsual.setFont(fuente)
            # asigna el valor de la fuente a la variable fuente_seleccionada
            self.fuente_seleccionada = fuente
    
    def guardar_usuario(self):
        self.texto_usuario = self.textE.text().strip()

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())