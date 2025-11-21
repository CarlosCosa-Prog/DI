from PySide6.QtWidgets import QApplication, QMainWindow,QVBoxLayout,QHBoxLayout,QWidget
# from PySide6.QtCore import QSize, Qt
import sys

class color(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setStyleSheet(f"background-color:{color}")

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        layout1=QHBoxLayout()
        layout2=QVBoxLayout()
        layout3=QVBoxLayout()
        layout2.addWidget(color("red"))
        layout2.addWidget(color("yellow"))
        layout2.addWidget(color("purple"))
        layout1.addLayout(layout2)
        layout1.addWidget(color("green"))
        layout3.addWidget(color("red"))
        layout3.addWidget(color("purple"))
        layout1.addLayout(layout3)
        
        #Quitar margenes entre layouts
        layout1.setContentsMargins(0,0,0,0)
        
        #Quitar margenes externos
        layout1.setSpacing(0)
       
        #Un Layout no se puede mostrar como Widget central
        widget=QWidget()
        widget.setLayout(layout1)
        self.setCentralWidget(widget)
        
if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())