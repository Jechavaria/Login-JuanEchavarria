******************  Login ****************** 

Una aplicación sencilla de login desarrollada en C# utilizando Windows Forms.

****************** Descripción ******************

Esta aplicación es un ejemplo básico que demuestra cómo implementar un sistema de autenticación de usuario sin bases de datos. Incluye:

-> Validación de dos usuarios predefinidos.
-> Un contador de intentos que bloquea el acceso tras varios intentos fallidos.
-> Manejo de eventos para aceptar la tecla Enter y simular acciones de clic.
-> Un botón "Salir" para cerrar la aplicación completamente.




****************** Características ****************** 

-> Validación de usuario:
Permite el login con credenciales fijas (por ejemplo, usuario: "JuanEchavarria" y contraseña: "1234").

-> Contador de intentos:
Bloquea el acceso tras tres intentos fallidos.

-> Manejo de eventos:
Usa eventos KeyPress para manejar la tecla Enter en los campos de texto.

-> Cierre de la aplicación:
Implementa un botón "Salir" que llama a Application.Exit() para finalizar la aplicación.




****************** Requisitos ****************** 

-> Visual Studio (2017 o superior recomendado).

-> .NET Framework (la versión 4.7.2 o superior).

-> Conocimientos básicos de C# y Windows Forms.




****************** Uso ****************** 

1. Descarga o clona el repositorio.

2. Abre el proyecto en Visual Studio.

3. Compila la solución.

4. Ejecuta la aplicación.

5. Para iniciar sesión:

    Ingresa uno de los usuarios predefinidos:

    -> Usuario: JuanEchavarria, Contraseña: 1234
    -> Usuario: Jgaleano, Contraseña: 1234

6. Interacción:

    -> Presiona el botón "Continuar" o la tecla Enter (según el campo) para validar el login.

    -> Una vez autenticado, se mostrará el formulario de bienvenida.

    -> Utiliza el botón "Salir" o cierra el formulario de bienvenida para finalizar la aplicación.




****************** Estructura del Proyecto ****************** 

-> FrmInicioDeSesion.cs:
Contiene el formulario de login y la lógica de validación de usuarios.

-> frmBienvenido.cs:
Es el formulario de bienvenida que se muestra tras un login exitoso.

-> Program.cs:
Punto de entrada de la aplicación.











































































































si llegaste hasta aquí, busca algo que hacer con tu vida :D