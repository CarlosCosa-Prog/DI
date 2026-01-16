from PySide6.QtWidgets import (QMainWindow, QApplication, QHBoxLayout, 
                               QVBoxLayout, QPushButton, QWidget, QGroupBox,
                               QGridLayout, QLabel, QTextEdit, QLineEdit,
                               QDialogButtonBox)
import sys
from PySide6.QtGui import QIcon
from pathlib import Path

def absPath(file):
    return str(Path(__file__).parent.absolute() / file)

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        
        # creo el menu y añado la accion de salir
        menuBar = self.menuBar()
        menu = menuBar.addMenu("Archivo")
        menu.addAction(QIcon(absPath("./imagenes/exit.png")),"Salir",self.close,"Ctrl+S")
        
        # creo un layout general para almacenar los demás layouts
        layout = QVBoxLayout()
        widget = QWidget()
        widget.setLayout(layout)
        self.setCentralWidget(widget)
        
        # BOTONES
        #-----------------------------------------------------------
        # creo un contenedor para almacenar los botones
        grupoBotones = QGroupBox("Layout Horizontal")
        # creo un layout para la distribución de los botones
        layoutBotones = QHBoxLayout()
        # establezaco el layout del contenedor y creo los botones
        grupoBotones.setLayout(layoutBotones)
        boton1 = QPushButton("Botón 1")
        boton2 = QPushButton("Botón 2")
        boton3 = QPushButton("Botón 3")
        boton4 = QPushButton("Botón 4")
        
        # añado los botones a su layout 
        layoutBotones.addWidget(boton1)
        layoutBotones.addWidget(boton2)
        layoutBotones.addWidget(boton3)
        layoutBotones.addWidget(boton4)

        # añado el contenedor de botones al layout principal
        layout.addWidget(grupoBotones)
        #-----------------------------------------------------------
        
        # GRID LAYOUT
        #-----------------------------------------------------------
        # creación de los componentes
        layoutGrid = QGridLayout()
        grupoGrid = QGroupBox("Layout Grid")
        label1 = QLabel("Línea 1")
        label2 = QLabel("Línea 2")
        text1 = QLineEdit()
        text2 = QLineEdit()
        textEdit1 = QTextEdit("Esto es un QTextEdit.")

        # establezco el layout para el grupo
        grupoGrid.setLayout(layoutGrid)
        # añado el grupo al layout principal
        layout.addWidget(grupoGrid)
        # añado todos los componentes al layout del contenedor
        layoutGrid.addWidget(label1, 0, 0)
        layoutGrid.addWidget(label2, 1, 0)
        layoutGrid.addWidget(text1, 0, 1)
        layoutGrid.addWidget(text2, 1, 1)
        # fila, columna, numeros de fila que ocupa, numeros de columnas que ocupa
        layoutGrid.addWidget(textEdit1, 0, 2, 2, 1)
        #-----------------------------------------------------------
        
        # BARRA DE ESTADO
        #-----------------------------------------------------------
        botones = QDialogButtonBox(QDialogButtonBox.Ok | QDialogButtonBox.Cancel)
        barra_estado = self.statusBar()
        # addWidget() lo alinea a la izquierda
        # addPermanentWidget() lo alinea a la derecha
        barra_estado.addPermanentWidget(botones)
         #-----------------------------------------------------------
        



if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    exit(app.exec())