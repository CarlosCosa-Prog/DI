from PySide6.QtWidgets import QApplication, QMainWindow
from PySide6.QtCore import QUrl
from PySide6.QtGui import QDesktopServices
from ejercicio8 import Ui_MainWindow  # importamos la clase generada por Qt Designer
import sys

class MainWindow(QMainWindow, Ui_MainWindow):
    def __init__(self):
        super().__init__()
        self.setupUi(self)

        # llenar la lista lateral
        self.listWidget.setCurrentRow(0)  # mostrar la primera página al iniciar

        # conectar cambios de página
        self.listWidget.currentRowChanged.connect(self.mostrar_pagina)

        # conectar botones y acciones
        self.pushButton.clicked.connect(self.cambiar_mensaje_inicio)
        self.pushButton_2.clicked.connect(self.abrir_url)
        self.pushButton_3.clicked.connect(self.mostrar_seleccion)

    # función para cambiar de página según la lista
    def mostrar_pagina(self, index):
        self.stackedWidget.setCurrentIndex(index)

    # función para cambiar el texto de la página de inicio
    def cambiar_mensaje_inicio(self):
        self.label_2.setText("Has hecho clic en el botón")

    # función para abrir una url externa
    def abrir_url(self):
        QDesktopServices.openUrl(QUrl("https://iespacomolla.es/"))

    # función para mostrar el estado de los checkboxes
    def mostrar_seleccion(self):
        print("Configuración actual:")
        print(f"- Modo oscuro: {self.checkBox.isChecked()}")
        print(f"- Notificaciones activas: {self.checkBox_2.isChecked()}")
        print(f"- Actualizar automáticamente: {self.checkBox_3.isChecked()}")

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())
