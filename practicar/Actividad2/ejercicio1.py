from PySide6.QtWidgets import (QMainWindow, QApplication, QLineEdit,
                               QLabel, QHBoxLayout, QWidget)
import sys
class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        text = QLineEdit()
        text.setMaxLength(5)
        text.setFixedSize(50,30)
        self.label = QLabel()

        text.textChanged.connect(self.cambiar_texto)
        
        layout = QHBoxLayout()

        layout.addWidget(text)
        layout.addWidget(self.label)
        
        widget = QWidget()
        widget.setLayout(layout)
        self.setCentralWidget(widget)
    
    def cambiar_texto(self, texto):
        self.label.setText(texto)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())