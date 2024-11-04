# Proyecto: Conexión a Base de Datos en Visual Studio

## Descripción
Este proyecto está diseñado para establecer una conexión entre una base de datos y un programa en Visual Studio utilizando SQL Server como gestor de bases de datos. Siga estos pasos antes de ejecutar el programa para asegurar que la base de datos esté configurada correctamente.

## Requisitos Previos
- **SQL Server** instalado y configurado en tu equipo.
- **Visual Studio** con soporte para conexión a bases de datos.
- **Carpeta BD**: La base de datos necesaria para el programa se encuentra en una carpeta llamada `BD` en este repositorio.

## Configuración de la Base de Datos
1. Acceda a la carpeta `BD` en el repositorio y ubique los siguientes scripts:
   - `001_BASE_DE_DATOS_Y_TABLAS.sql`: Este script crea la base de datos y sus tablas.
   - `002_INSERT_TABLES.sql`: Este script inserta los datos iniciales en las tablas.
   
2. Ejecute los scripts en el orden especificado utilizando el modo *master* en SQL Server Management Studio (SSMS) o un gestor de bases de datos similar:
   - Primero, ejecute `001_BASE_DE_DATOS_Y_TABLAS.sql`.
   - Luego, ejecute `002_INSERT_TABLES.sql`.

## Conexión de la Base de Datos con Visual Studio

Siga estos pasos para establecer la conexión entre Visual Studio y la base de datos:

1. **Abrir el Explorador de Soluciones**: En Visual Studio, abra el Explorador de Soluciones desde el lado izquierdo de la pantalla.
   
2. **Conectar con la Base de Datos**:
   - En el Explorador de Soluciones, haga clic en el botón de **Conectar con la base de datos**.
   
3. **Configurar la Conexión**:
   - En la ventana que aparece, ingrese la información de conexión:
     - **Nombre del servidor**: Introduzca el nombre de su servidor SQL Server.
     - **Tipo de autenticación**: Seleccione **Autenticación de SQL Server**.
     - **Nombre de usuario**: Ingrese `sa`.
     - **Contraseña**: Proporcione la contraseña de su base de datos.
     - **Opciones adicionales**: Marque las opciones **Confiar en el certificado** y **Guardar mi contraseña**.
   - Seleccione o escriba el nombre de la base de datos y haga clic en **Probar Conexión**. Si la conexión es exitosa, haga clic en **Aceptar**.

4. **Actualizar la Cadena de Conexión en `Web.config`**:
   - En la nueva conexión creada en Visual Studio, haga clic derecho y seleccione **Propiedades**.
   - En la sección inferior derecha, busque el campo **Cadena de conexión** y cópiela.
   - Abra el archivo `Web.config` en su programa y busque la línea `<connectionStrings>` (aproximadamente en la línea 63).
   - Reemplace la cadena de conexión existente con la nueva cadena copiada.

## Contacto
Para cualquier duda o sugerencia, no dude en ponerse en contacto con nosotros.

