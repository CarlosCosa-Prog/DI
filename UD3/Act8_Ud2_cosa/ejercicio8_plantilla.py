from PySide6.QtWidgets import (QMainWindow, QApplication, QMessageBox,
                               QToolBar, QDialog, QGridLayout, QLabel,
                               QLineEdit, QListWidget, QPushButton,
                               QDockWidget, QTextEdit)
from PySide6.QtGui import Qt, QIcon
from PySide6.QtCore import Signal
import sys
from pathlib import Path

def absPath(file):
    return str(Path(__file__).parent.absolute() / file)

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Actividad 8 Unidad 2")
        self.resize(1000,800)

        # el elemento que he utilizado como visor es un QListWidget
        self.listaContactos = QListWidget()
        self.setCentralWidget(self.listaContactos)

        menu = self.menuBar()
        menuFichero = menu.addMenu("Fichero")
        menuFichero.addAction("Salir",self.close)
        
        menuContacto = menu.addMenu("Contacto")
        añadir = menuContacto.addAction("Añadir","Ctrl+A")
        añadir.triggered.connect(self.mostrar_dialog)
        eliminar = menuContacto.addAction("Eliminar","Ctrl+E")
        eliminar.triggered.connect(self.eliminar_contacto)

        menuAyuda = menu.addMenu("Ayuda")
        info = menuAyuda.addAction("Informacion")
        info.triggered.connect(self.mostrar_ayuda)

        self.barra_herramientas()

        # dock que muestra los últimos datos modificados
        self.dockCambios = QDockWidget("Últimos Cambios", self)
        self.dockCambios.setAllowedAreas(Qt.RightDockWidgetArea | Qt.LeftDockWidgetArea)

        self.visorCambios = QTextEdit()
        self.visorCambios.setReadOnly(True)
        self.dockCambios.setWidget(self.visorCambios)

        self.addDockWidget(Qt.RightDockWidgetArea, self.dockCambios)

        # crear el status bar que muestra la cantidad de contactos que hay en la lista
        self.statusBar = self.statusBar()
        self.actualizar_status()

    # funcion para el QMessageBox de ayuda   
    def mostrar_ayuda(self):
        mensajeAyuda = QMessageBox(self)
        mensajeAyuda.setWindowTitle("Ayuda")
        mensajeAyuda.setText("Informacion sobre la aplicacion")
        # esto me lo dijo el ChatGpt, puedes añadir iconos de la libreria
        mensajeAyuda.setIcon(QMessageBox.Information)
        # tambien puedes añadir botones estandar que ya tienen un función establecida
        mensajeAyuda.setStandardButtons(QMessageBox.Ok) # si no lo estableces ya aparece por defecto por lo que no es necesaria esta linea
        # mostrar el mensaje de forma modal (no puede utilizar la otra ventana hasta que cierres esta)
        mensajeAyuda.exec()

    # Funcion que crea y muestra la barra de herramientas
    def barra_herramientas(self):
        barraHer = QToolBar()
        self.addToolBar(barraHer)
        añadir = barraHer.addAction(QIcon(absPath("./iconos/añadir.png")),"Añadir")
        añadir.triggered.connect(self.mostrar_dialog)
        eliminar = barraHer.addAction(QIcon(absPath("./iconos/eliminar.png")), "Eliminar")
        eliminar.triggered.connect(self.eliminar_contacto)
        barraHer.addAction(QIcon(absPath("./iconos/exit.png")),"Salir",self.close)

    # Funcion que muestra el dialogo para añadir los usuarios
    def mostrar_dialog(self):
        dialogo = Dialogo()
        # SEÑALES: conecto la señal del diálogo a la función del mainWindow
        dialogo.contacto_guardado.connect(self.añadir_contacto)
        dialogo.exec()
    
    # Funcion que registra un contacto en la lista de contactos
    def añadir_contacto(self, nombre, telefono, email):
        contacto = f"{nombre} | {telefono} | {email}"
        self.listaContactos.addItem(contacto)
        # registrar la acción en el dock
        self.registrar_cambio("Añadido", contacto)
        # actualizar la barra de estado
        self.actualizar_status()
    
    # Funcion que elimina un contacto en la lista de contactos
    def eliminar_contacto(self):
        contactoSel = self.listaContactos.currentItem()

        # si no se selecciona ningun contacto aparece un mensaje de advertencia
        if not contactoSel:
            QMessageBox.warning(self, "Adevertencia", "Debe seleccionar primero un contacto.")
            return
        
        # confirmación antes de eliminar, una vez seleccionado
        respuesta = QMessageBox.question(
            self,
            "Confirmar eliminación",
            f"¿Está seguro de que desea eliminar el contacto:\n{contactoSel.text()}?",
            QMessageBox.Yes | QMessageBox.No
        )

        # si se selecciona si, se elimina el contacto
        if respuesta == QMessageBox.Yes:
            row = self.listaContactos.row(contactoSel)
            self.listaContactos.takeItem(row)
            # registrar la acción en el dock
            self.registrar_cambio("Eliminado", contactoSel.text())
            # actualizar la barra de estado
            self.actualizar_status()  

    # Funcion que muestra los cambios de la lista en el dock         
    def registrar_cambio(self, accion, contacto):
        """
        accion: str -> "Añadido" o "Eliminado"
        contacto: str -> descripción del contacto (nombre, teléfono, email)
        """
        self.visorCambios.append(f"{accion}: {contacto}")
    
    # Función que actualiza el status bar con la cantidad de contactos
    def actualizar_status(self):
        cantidad = self.listaContactos.count()
        self.statusBar.showMessage(f"Cantidad de contactos: {cantidad}")
    
    


class Dialogo(QDialog):
    # SEÑALES: defino una señal que enviará los datos al mainWindow (está explicado en el apartado 4.4 de la teoria)
    contacto_guardado = Signal(str, str, str)

    def __init__(self):
        super().__init__() 

        layout = QGridLayout()
        self.setLayout(layout)

        label1 = QLabel("Nombre")
        label2 = QLabel("Teléfono")
        label3 = QLabel("Email")
        self.text1 = QLineEdit()
        self.text2 = QLineEdit()
        self.text3 = QLineEdit()

        layout.addWidget(label1,0,0)
        layout.addWidget(label2,1,0)
        layout.addWidget(label3,2,0)
        layout.addWidget(self.text1,0,1)
        layout.addWidget(self.text2,1,1)
        layout.addWidget(self.text3,2,1)

        # Botón de guardar
        boton_guardar = QPushButton("Guardar")
        layout.addWidget(boton_guardar, 3, 0, 1, 2)
        boton_guardar.clicked.connect(self.guardar_contacto)

    # Funcion que guarda los contactos dentro de una señal
    def guardar_contacto(self):
        # self.text1.text() coge el texto que el ususario ha escrito
        # strip() elimina los espacios en blanco
        nombre = self.text1.text().strip()
        telefono = self.text2.text().strip()
        email = self.text3.text().strip()

        # Validación
        if not nombre:
            QMessageBox.warning(self, "Error", "El nombre no puede estar vacío.")
            return
        if "@" not in email or email.count("@") != 1 or "." not in email.split("@")[1]:
            QMessageBox.warning(self, "Error", "El correo no tiene formato válido.")
            return
        
        # SEÑALES: emito la señal con los datos
        self.contacto_guardado.emit(nombre, telefono, email)
        # cierra el dialogo
        self.accept()  
        

if __name__ == "__main__":
    app = QApplication(sys.argv)

    # Cargar archivo de estilos
    with open(absPath("estilos.qss"), "r") as f:
        app.setStyleSheet(f.read())

    window = mainWindow()
    window.show()
    sys.exit(app.exec())