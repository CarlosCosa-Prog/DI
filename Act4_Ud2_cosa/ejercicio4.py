from PySide6.QtWidgets import (QMainWindow, QApplication, QToolBar,
                               QDockWidget, QTextEdit, QLabel, QWidget,
                               QHBoxLayout)
import sys
from PySide6.QtGui import QIcon, QAction
from pathlib import Path
from PySide6.QtCore import Qt

def absPath(file):
    return str(Path(__file__).parent.absolute() / file)

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.resize(480,320)

        # MENU BAR
        #---------------------------------------------------------------------------------------
        menu = self.menuBar()
        menu1 = menu.addMenu("Menu")
        # creo la acción para Imprimir (necesario para utilizar el statusTip)
        accionImprimir = QAction("Imprimir", self)
        accionImprimir.setIcon(QIcon(absPath("./imagenes/printer.png")))
        accionImprimir.setShortcut("Ctrl + I")
        
        # Al pasar el ratón por encima la barra de estado mostrará el texto “Imprimir miedo consuela”
        accionImprimir.setStatusTip("Imprimir miedo consuela")
        # Establecer la barra de estado para que sea visible
        self.statusBar()
        
        # Conectar la funcion con la accion y añadirla al menu
        accionImprimir.triggered.connect(self.imprimir_consola)
        menu1.addAction(accionImprimir)
        #---------------------------------------------------------------------------------------

        # BARRA DE HERRAMIENTAS
        #---------------------------------------------------------------------------------------
        # creo la barra de herramientas, la añado y utilizo la funcionalidad anteriror para esta
        barraHer = QToolBar("Barra de herramientas principal")
        self.addToolBar(barraHer)
        barraHer.addAction(accionImprimir)
        #---------------------------------------------------------------------------------------

        # BARRA DE ESTADO
        #---------------------------------------------------------------------------------------
        # creo la barra de herramientas, la añado y utilizo la funcionalidad anteriror para esta
        barra_estado = self.statusBar()
        barra_estado.showMessage("Listo. Esperando acción", 5000) # tiempo en milisegundos
        
        # añado la etiqueta con el so y su funcion
        label_so = QLabel(self.detectarSO())
        barra_estado.addPermanentWidget(label_so)
        #---------------------------------------------------------------------------------------

        # DOCKS
        #---------------------------------------------------------------------------------------
        dock_base = QDockWidget("Componente base 1")
        #dock_base.setFeatures(QDockWidget.NoDockWidgetFeatures)

        # Contenedor interno con layout horizontal
        contenedor = QWidget()
        layout = QHBoxLayout()  # Horizontal: label a la izquierda, QTextEdit a la derecha
        contenedor.setLayout(layout)

        # Widgets internos
        label_izquierda = QLabel("Componente principal")
        label_izquierda.setAlignment(Qt.AlignVCenter | Qt.AlignLeft)  # Centrado vertical, alineado a la izquierda

        texto = QTextEdit()

        # Añadimos los widgets al layout
        layout.addWidget(label_izquierda)
        layout.addWidget(texto)

        # Asignamos el contenedor al dock
        dock_base.setWidget(contenedor)
        self.addDockWidget(Qt.RightDockWidgetArea, dock_base)
        #---------------------------------------------------------------------------------------

    def imprimir_consola(self):
        print("Acción lanzada a través del menú, uso del atajo de teclado o de la barra de herramientas")
    
    def detectarSO(self):
                if sys.platform.startswith("linux"):
                    return "Linux"
                elif sys.platform.startswith("win"):
                    return "Windows"
                elif sys.platform.startswith("darwin"):
                    return "macOS"
                else:
                    return "Sistema desconocido"

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())