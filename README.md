# README: Proyecto ASP.NET Core 3.1 con Razor Pages

Este repositorio contiene un proyecto desarrollado con ASP.NET Core 3.1 utilizando Razor Pages. Razor Pages es un enfoque de desarrollo basado en la creación de páginas web en lugar de controladores y vistas separadas, proporcionando una forma sencilla y compacta de construir aplicaciones web.

## Características del Proyecto

- **Framework:** ASP.NET Core 3.1
- **Tipo de Proyecto:** Razor Pages
- **Lenguaje de Programación:** C#
- **Base de Datos:** Entity Framework Core
- **Frontend:** Bootstrap para estilos y diseño responsivo

## Estructura del Proyecto

- **Pages:**
  - **Estudiantes:**
    - **Create.cshtml:** Página de creación de estudiantes con formulario y lista de tareas.
    - **Index.cshtml:** Página principal que lista los estudiantes.
    - **Edit.cshtml y Delete.cshtml:** Páginas para editar y eliminar estudiantes.
  - **Tarea:**
    - **Create.cshtml:** Página de creación de tarea con formulario y lista de tareas.
    - **Index.cshtml:** Página principal que lista las tareas.
    - **Edit.cshtml y Delete.cshtml:** Páginas para editar y eliminar tarea.


- **Modelos:**
  - **Estudiante.cs:** Clase que representa a un estudiante con propiedades como `Id`, `Name`, y `IdTarea`.
  - **Tarea.cs:** Clase que representa una tarea con propiedades como `Id`, `Title`, `Details`,`Done` y `Deliver date`.

- **Data:**
  - **TaskAPPContext.cs:** Contexto de la base de datos utilizando Entity Framework Core para interactuar con las tablas de estudiantes y tareas.

- **wwwroot:**
  - **css:** Contiene archivos CSS personalizados.
  - **js:** Contiene archivos JavaScript personalizados.

## Configuración y Ejecución

1. **Requisitos:**
   - [.NET8 SDK](https://dotnet.microsoft.com/download) instalado.
2. **Clonar Repositorio**
   - Repositorio: https://github.com/Antoni30/TaskAPP Repositorio
3. **Complilar**
   Abrimos una consola y ejecutamos con el comando
   ```terminal
   dotnet watch
   ```
## Personalizaciones y Mejoras
Puedes personalizar el diseño y estilos en los archivos CSS en la carpeta wwwroot/css.
Considera agregar validaciones adicionales en el modelo Estudiante.cs.
Añade nuevas funcionalidades o páginas según los requisitos del proyecto.

## Notas Finales
Este proyecto es una aplicación básica que utiliza Razor Pages para gestionar estudiantes y tareas. Puedes expandir y mejorar la aplicación según tus necesidades específicas. Además, asegúrate de seguir las mejores prácticas de desarrollo y documentación para facilitar el mantenimiento y la colaboración.



