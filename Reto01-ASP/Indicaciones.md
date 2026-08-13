# Estructura del Proyecto ASP.NET MVC

## Carpetas y Archivos principales

### Controllers
Contiene las clases controladoras que manejan las solicitudes HTTP. Los controladores reciben datos del usuario, interactúan con los modelos y envían los datos a las vistas para su presentación. Ejemplo: `HomeController.cs`

### Models
Define las clases que representan la estructura de datos de la aplicación. Aquí se encuentran las entidades y objetos que contienen la lógica empresarial y la información de dominio de la aplicación.

### Views
Almacena las plantillas HTML (archivos `.cshtml`) que se encargan de presentar los datos al usuario. Cada vista está asociada a una acción de un controlador y recibe los datos para renderizar la interfaz de usuario.

### wwwroot
Carpeta que contiene archivos estáticos como CSS, JavaScript, imágenes y otros recursos que se sirven directamente al cliente sin procesamiento en el servidor.

### Program.cs
Archivo principal de configuración de la aplicación. Define el punto de entrada de la aplicación, la configuración de servicios (dependency injection), middlewares, y el enrutamiento de la aplicación.

### appsettings.json
Archivo de configuración en formato JSON que contiene valores de configuración como cadenas de conexión a bases de datos, niveles de logging, y otras opciones de configuración que pueden variar según el entorno (desarrollo, producción, etc.).
