from PySide6.QtWidgets import (
    QApplication, QMainWindow, QLabel, QFormLayout, QWidget)
from PySide6.QtCore import Qt
import sys



class Contenedor(QLabel):
    def __init__(self, color):
        super().__init__()
        self.setStyleSheet(f"background-color:{color}")


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # creamos un layout en formulario
        formulario = QFormLayout()
        # configuraciones extra
        formulario.setLabelAlignment(Qt.AlignRight)
        formulario.setFormAlignment(Qt.AlignHCenter | Qt.AlignVCenter)

        # añadimos widgets con etiquetas en filas
        formulario.addRow("Campo 1", Contenedor("orange"))
        formulario.addRow("Campo 2", Contenedor("purple"))
        formulario.addRow("Campo 3", Contenedor("magenta"))
        formulario.addRow("Campo 4", Contenedor("gray"))
        formulario.addRow("Campo 5", Contenedor("red"))

        # cremos el widget dummy y le asignamos el layout
        widget = QWidget()
        widget.setLayout(formulario)

        self.setCentralWidget(widget)


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())

            # configuraciones extra
        #formulario.setLabelAlignment(Qt.AlignRight)
        #formulario.setFormAlignment(Qt.AlignHCenter | Qt.AlignVCenter)