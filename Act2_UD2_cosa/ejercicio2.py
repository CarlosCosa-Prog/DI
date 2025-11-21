""" 
El QComboBox utiliza dos señales interesantes que se producen al cambiar la selección
del componente. Una señal es currentIndexChanged(*int index) que vuelve la posición
del elemento del comboBox y la otra señal es currentTextChanged(conos Qstring
&texto) que pasa el texto que cuento el elemento seleccionado. También podemos hacer
uso de los parámetros currentText() y currentIndex().
"""
# Listado de todos los meses del año
#   - al seleccionar un mes se imprimirá por consola el número de la posición que ocupa y el més 

from PySide6.QtWidgets import QApplication, QMainWindow, QComboBox
# from PySide6.QtCore import QSize, Qt
import sys

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__() 

        # creo la lista desplegable
        desplegable = QComboBox()
        # coloca el deplegable en la ventana 
        self.setCentralWidget(desplegable)
        # añade el contenido del desplegable
        desplegable.addItems(["Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"])

        # llamada de las funciones que muestran la posición y el contenido
        desplegable.currentIndexChanged.connect(self.posicion)
        desplegable.currentTextChanged.connect(self.mes)
        
    # creción de la función que devuelve la posición del desplgable mas 1 para que sea de 1 a 12
    def posicion(self, indice):
        print("Posición: ", indice + 1)
    
    # creación de la función que devuelve el texto del desplegable 
    def mes(self, texto):
        print("Mes: ", texto)



if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = mainWindow()
    window.show()
    sys.exit(app.exec())