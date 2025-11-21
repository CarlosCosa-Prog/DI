from PySide6.QtWidgets import QApplication, QMainWindow, QWidget, QVBoxLayout, QGroupBox, QCheckBox
# from PySide6.QtCore import QSize, Qt
import sys

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        grupo = QGroupBox("Exclusive Radio Buttons")
        layout = QVBoxLayout()

        self.checkbox1 = QCheckBox("Primer checkbox")
        self.checkbox2 = QCheckBox("Segundo checkbox")
        self.checkbox3 = QCheckBox("Tercer checkbox")

        layout.addWidget(self.checkbox1)
        layout.addWidget(self.checkbox2)
        layout.addWidget(self.checkbox3)

        grupo.setLayout(layout)
        layout.addWidget(grupo)

        widget = QWidget()
        widget.setLayout(layout)
        self.setCentralWidget(widget)
        self.checkbox1.stateChanged.connect(self.mostrar_seleccion)
        self.checkbox2.stateChanged.connect(self.mostrar_seleccion)
        self.checkbox3.stateChanged.connect(self.mostrar_seleccion)
    
    def mostrar_seleccion(self):
        seleccionados = []
        if self.checkbox1.isChecked():
            seleccionados.append("Primer checkbox")
        if self.checkbox2.isChecked():
            seleccionados.append("Segundo checkbox")
        if self.checkbox3.isChecked():
            seleccionados.append("Tercer checkbox")
        print("Checkbox marcados:", seleccionados)
        
if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())