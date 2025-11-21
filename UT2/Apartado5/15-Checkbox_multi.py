from PySide6.QtWidgets import QApplication, QMainWindow, QCheckBox  # edited
from PySide6.QtWidgets import QVBoxLayout, QWidget
import sys

class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Ejemplo de Múltiples Checkboxes")

        layout = QVBoxLayout()
        
        # 1. Crear las casillas
        self.check1 = QCheckBox("Opción 1")
        self.check2 = QCheckBox("Opción 2")
        self.check3 = QCheckBox("Opción 3")
        
        # 2. agrupamos casillas
        casillas = [self.check1, self.check2, self.check3]
        
        # 4. Conectar las señales
        for check in casillas:
            check.stateChanged.connect(self.on_state_changed)
        
        # 3. Organizar en la interfaz
        layout.addWidget(self.check1)
        layout.addWidget(self.check2)
        layout.addWidget(self.check3)
        
        widget = QWidget()
        widget.setLayout(layout)
        self.setCentralWidget(widget)

    # 5. Función para consultar el estado
    def on_state_changed(self, state):
        # El estado se puede obtener con `isChecked()`
        print(f"Check 1 está marcado: {self.check1.isChecked()}")
        print(f"Check 2 está marcado: {self.check2.isChecked()}")
        print(f"Check 3 está marcado: {self.check3.isChecked()}")

   
if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())