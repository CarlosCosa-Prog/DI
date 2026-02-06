# importaciones de widgets, layouts y funcionalidades de qt
from PySide6.QtWidgets import (
    QApplication, QMainWindow, QWidget, QVBoxLayout, QPushButton, QLabel,
    QListWidget, QHBoxLayout, QStackedWidget, QCheckBox, QGroupBox
)
from PySide6.QtCore import QUrl  # para manejar urls
from PySide6.QtGui import QDesktopServices  # para abrir urls en el navegador
import sys  # para manejar argumentos y salir de la app

# clase principal de la ventana
class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.resize(600, 400)  # tamaño inicial de la ventana

        layout = QHBoxLayout()  # layout horizontal principal

        # lista lateral para cambiar de página
        self.lista = QListWidget()
        self.lista.addItems(["Inici", "Informació", "Configuració"])
        self.lista.currentRowChanged.connect(self.mostrar_pagina)
        layout.addWidget(self.lista)

        # stack de páginas que se muestran según la selección
        self.stack = QStackedWidget()
        layout.addWidget(self.stack)

        # página de inicio
        self.pagina_inicio = QWidget()
        layout_inicio = QVBoxLayout()
        self.label_inicio = QLabel("Benvingut a l'aplicació")
        layout_inicio.addWidget(self.label_inicio)
        self.boton_inicio = QPushButton("Canviar missatge")
        self.boton_inicio.clicked.connect(self.cambiar_mensaje_inicio)
        layout_inicio.addWidget(self.boton_inicio)
        layout_inicio.addStretch()
        self.pagina_inicio.setLayout(layout_inicio)
        self.stack.addWidget(self.pagina_inicio)

        # página de información
        self.pagina_info = QWidget()
        layout_info = QVBoxLayout()
        self.label_info = QLabel("Informació de l'IES Paco Mollá")
        layout_info.addWidget(self.label_info)
        boton_info = QPushButton("Obrir URL")
        boton_info.clicked.connect(self.abrir_url)
        layout_info.addWidget(boton_info)
        layout_info.addStretch()
        self.pagina_info.setLayout(layout_info)
        self.stack.addWidget(self.pagina_info)

        # página de configuración
        self.pagina_config = QWidget()
        layout_config = QVBoxLayout()
        grupo = QGroupBox("Opcions")  # grupo de checkboxes
        layout_grupo = QVBoxLayout()
        self.checkbox1 = QCheckBox("Activar modo fosc")
        self.checkbox2 = QCheckBox("Notificacions actives")
        self.checkbox3 = QCheckBox("Actualitzar automáticament")
        layout_grupo.addWidget(self.checkbox1)
        layout_grupo.addWidget(self.checkbox2)
        layout_grupo.addWidget(self.checkbox3)
        grupo.setLayout(layout_grupo)
        layout_config.addWidget(grupo)
        boton_mostrar = QPushButton("Mostrar selecció")
        boton_mostrar.clicked.connect(self.mostrar_seleccion)
        layout_config.addWidget(boton_mostrar)
        layout_config.addStretch()
        self.pagina_config.setLayout(layout_config)
        self.stack.addWidget(self.pagina_config)

        # widget central que contiene todo
        central_widget = QWidget()
        central_widget.setLayout(layout)
        self.setCentralWidget(central_widget)

        self.lista.setCurrentRow(0)  # se muestra la primera página al iniciar

    # función para cambiar de página según la lista
    def mostrar_pagina(self, index):
        self.stack.setCurrentIndex(index)

    # función para cambiar el texto de la página de inicio
    def cambiar_mensaje_inicio(self):
        self.label_inicio.setText("Has hecho clic en el botón")

    # función para abrir una url externa
    def abrir_url(self):
        QDesktopServices.openUrl(QUrl("https://iespacomolla.es/"))

    # función para mostrar el estado de los checkboxes
    def mostrar_seleccion(self):
        print("Configuració actual:")
        print(f"- Mode fosc: {self.checkbox1.isChecked()}")
        print(f"- Notificacions actives: {self.checkbox2.isChecked()}")
        print(f"- Actualitzar automáticament: {self.checkbox3.isChecked()}")

# bloque principal para ejecutar la app
if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())
