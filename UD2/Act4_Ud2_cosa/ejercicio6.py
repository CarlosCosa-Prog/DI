from PySide6.QtWidgets import (QMainWindow, QApplication, QPushButton,
                               QGroupBox, QHBoxLayout, QWidget)
import sys
class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        # creo el layout general para almacenar el otro layouts
        layout = QHBoxLayout()
        widget = QWidget()
        widget.setLayout(layout)
        self.setCentralWidget(widget)
        
        # creo el grupo, el layout del grupo y los botones
        grupo = QGroupBox("Layout Horizontal")
        layoutBotones = QHBoxLayout()
        boton1 = QPushButton()
        boton2 = QPushButton()
        boton3 = QPushButton()
        boton4 = QPushButton()

        # añado al layout del grupo al general junto al grupo y los componentes
        grupo.setLayout(layoutBotones)
        layout.addWidget(grupo)
        layoutBotones.addWidget(boton1)
        layoutBotones.addWidget(boton2)
        layoutBotones.addWidget(boton3)
        layoutBotones.addWidget(boton4)
        
        # CAMBIAR COLOR
        #-----------------------------------------------------------------
        # necesario para utilizar el isChecked()
        boton1.setCheckable(True) 
        boton2.setCheckable(True)
        boton3.setCheckable(True)
        boton4.setCheckable(True)

        # establezco el verde como color inicial de los botones
        boton1.setStyleSheet("background-color: green;")
        boton2.setStyleSheet("background-color: green;")
        boton3.setStyleSheet("background-color: green;")
        boton4.setStyleSheet("background-color: green;")

        # llamar a la funcion de cambiar color
        boton1.clicked.connect(self.cambiar_color)
        boton2.clicked.connect(self.cambiar_color)
        boton3.clicked.connect(self.cambiar_color)
        boton4.clicked.connect(self.cambiar_color)
        #-----------------------------------------------------------------

    # función que cambia el color
    def cambiar_color(self):
        # sender() recoge automáticamente el botón que genera una señal
        sender = self.sender()

        # si está clicado, lo ponemos en rojo, sino en verde
        if sender.isChecked():
            sender.setStyleSheet("background-color: red;")
        else:
            sender.setStyleSheet("background-color: green;")

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())