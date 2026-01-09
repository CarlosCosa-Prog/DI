from PySide6.QtWidgets import (QMainWindow, QApplication, QMessageBox,
                               QToolBar, QDialog, QGridLayout, QLabel,
                               QLineEdit, QListWidget, QPushButton,
                               QDockWidget, QTextEdit)
from PySide6.QtGui import Qt, QIcon
from PySide6.QtCore import Signal
import sys
from pathlib import Path

import sqlite3 # Librería para la gestión de bases de datos SQLite
from PySide6.QtSql import QSqlDatabase, QSqlTableModel, QSqlQuery

def absPath(file):
    return str(Path(__file__).parent.absolute() / file)

class mainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Actividad 8 Unidad 2")
        self.resize(1000,800)

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

        self.dockCambios = QDockWidget("Últimos Cambios", self)
        self.dockCambios.setAllowedAreas(Qt.RightDockWidgetArea | Qt.LeftDockWidgetArea)

        self.visorCambios = QTextEdit()
        self.visorCambios.setReadOnly(True)
        self.dockCambios.setWidget(self.visorCambios)

        self.addDockWidget(Qt.RightDockWidgetArea, self.dockCambios)

        self.statusBar = self.statusBar()
        self.actualizar_status()

        # Llamada a la funcion para conectar con la base de datos
        self.conectar_bd()
        # Llamada de la funcion que crea la base de datos si no existe
        self.crear_tabla_si_no_existe()
        # LLamada a la función que devuelve TRUE si la tabla está vacia
        print(self.tabla_vacia())
        # LLamada a la función que inserta un contacto de ejemplo a la tabla
        self.insertar_demo()
        print(self.tabla_vacia())

    def mostrar_ayuda(self):
        mensajeAyuda = QMessageBox(self)
        mensajeAyuda.setWindowTitle("Ayuda")
        mensajeAyuda.setText("Informacion sobre la aplicacion")
        mensajeAyuda.setIcon(QMessageBox.Information)
        mensajeAyuda.setStandardButtons(QMessageBox.Ok)
        mensajeAyuda.exec()

    def barra_herramientas(self):
        barraHer = QToolBar()
        self.addToolBar(barraHer)
        añadir = barraHer.addAction(QIcon(absPath("./iconos/añadir.png")),"Añadir")
        añadir.triggered.connect(self.mostrar_dialog)
        eliminar = barraHer.addAction(QIcon(absPath("./iconos/eliminar.png")), "Eliminar")
        eliminar.triggered.connect(self.eliminar_contacto)
        barraHer.addAction(QIcon(absPath("./iconos/exit.png")),"Salir",self.close)

    def mostrar_dialog(self):
        dialogo = Dialogo()
        dialogo.contacto_guardado.connect(self.añadir_contacto)
        dialogo.exec()
    
    def añadir_contacto(self, nombre, telefono, email):
        contacto = f"{nombre} | {telefono} | {email}"
        self.listaContactos.addItem(contacto)
        self.registrar_cambio("Añadido", contacto)
        self.actualizar_status()
        
        # Creo la consulta 
        consulta = QSqlQuery()
        # Creo el sql que añadira los datos del contacto con el contenido que se la pasa a la funcion añadir_contacto
        consulta.prepare(
            "INSERT INTO contactos (nombre, telefono, email) VALUES (?, ?, ?)"
            )
        # Añade los valores en orden de cada columna
        consulta.addBindValue(nombre)
        consulta.addBindValue(telefono)
        consulta.addBindValue(email)

        if not consulta.exec():
            QMessageBox.warning(
                self, "Error al insertar", "No se ha podido insertar correctamente"
            )
    
    def eliminar_contacto(self):
        contactoSel = self.listaContactos.currentItem()

        if not contactoSel:
            QMessageBox.warning(self, "Adevertencia", "Debe seleccionar primero un contacto.")
            return
   
        respuesta = QMessageBox.question(
            self,
            "Confirmar eliminación",
            f"¿Está seguro de que desea eliminar el contacto:\n{contactoSel.text()}?",
            QMessageBox.Yes | QMessageBox.No
        )

        if respuesta == QMessageBox.Yes:
            row = self.listaContactos.row(contactoSel)
            self.listaContactos.takeItem(row)
            self.registrar_cambio("Eliminado", contactoSel.text())
            self.actualizar_status()  

    def registrar_cambio(self, accion, contacto):
        """
        accion: str -> "Añadido" o "Eliminado"
        contacto: str -> descripción del contacto (nombre, teléfono, email)
        """
        self.visorCambios.append(f"{accion}: {contacto}")

    def actualizar_status(self):
        cantidad = self.listaContactos.count()
        self.statusBar.showMessage(f"Cantidad de contactos: {cantidad}")
    

    # Función para conectar con la base de datos
    def conectar_bd(self):
        # Creo una variable con la ruta de la base de datos
        db_nombre = absPath("SQLite/contactos.db")
        # Creo una variable que compruebe que la base de datos existe
        self.db = QSqlDatabase.addDatabase("QSQLITE")  
        self.db.setDatabaseName(db_nombre)

        if not self.db.open():
            QMessageBox.critical(
                self, "Error Base de Datos", "No se ha podido abrir la BD SQLite/contactos.db"
            )

    # Función que crea la tabla (BD) (Si no existe)
    def crear_tabla_si_no_existe(self):
        consulta = QSqlQuery()
        consulta.exec(
            """
            CREATE TABLE IF NOT EXISTS contactos
            (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                nombre VARCHAR(40) NOT NULL,
                telefono VARCHAR(50),
                email  VARCHAR(60) NOT NULL
            )
            """
        )
    
    # Función que devuelve TRUE si la tabla está  vacia
    def tabla_vacia(self):
        consulta = QSqlQuery("SELECT COUNT(*) FROM contactos")
        if consulta.next(): # Se situa en el primer resultado
            total = consulta.value(0)
            return total == 0
        return True
    
    # Función que inserta un contacto por defecto
    def insertar_demo(self):
        # solo inserta el ejemplo si la tabla no está vacia (no funciona como deberia por eso lo comento)
        if not self.tabla_vacia():
            return
        
        nombre = "ejemplo"
        telefono = "784569459"
        email =  "ejemplo@gmail.com"

        consulta = QSqlQuery()
        consulta.prepare(
            "INSERT INTO contactos (nombre, telefono, email) VALUES (?, ?, ?)"
            )
        
        consulta.addBindValue(nombre)
        consulta.addBindValue(telefono)
        consulta.addBindValue(email)

        if not consulta.exec():
            QMessageBox.warning(
                self, "Error al insertar", "No se ha podido insertar correctamente"
            )

    # Funcion que carga los contactos al iniciar el programa
    def cargar_contactos(self):
        self.listaContactos.clear()

        consulta = QSqlQuery(
            "SELECT nombre, telefono, email FROM contactos ORDER BY nombre"
        )

        while consulta.next():
            nombre = consulta.value(0)
            telefono = consulta.value(1)
            email = consulta.value(2)

            contacto = f"{nombre} | {telefono} | {email}"
            self.listaContactos.addItem(contacto)

        self.actualizar_status()

class Dialogo(QDialog):
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

        boton_guardar = QPushButton("Guardar")
        layout.addWidget(boton_guardar, 3, 0, 1, 2)
        boton_guardar.clicked.connect(self.guardar_contacto)

    def guardar_contacto(self):
        nombre = self.text1.text().strip()
        telefono = self.text2.text().strip()
        email = self.text3.text().strip()

        if not nombre:
            QMessageBox.warning(self, "Error", "El nombre no puede estar vacío.")
            return
        if "@" not in email or email.count("@") != 1 or "." not in email.split("@")[1]:
            QMessageBox.warning(self, "Error", "El correo no tiene formato válido.")
            return

        self.contacto_guardado.emit(nombre, telefono, email)
        self.accept()  
        

if __name__ == "__main__":
    app = QApplication(sys.argv)

    with open(absPath("estilos.qss"), "r") as f:
        app.setStyleSheet(f.read())

    window = mainWindow()
    window.show()
    sys.exit(app.exec())