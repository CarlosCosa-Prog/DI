import sys
from PySide6.QtWidgets import QApplication, QMainWindow

app = QApplication(sys.argv)

# Ahora la ventana la gestiona el widget de ventana principal
window = QMainWindow()

# Damos un título a la ventana principal
window.setWindowTitle("Hola mundo")

window.show()

sys.exit(app.exec_())