# Portafolio
Este proyecto se desarrolló usando ASP.NET Core MVC 9 y se generó a través de la [CLI de .NET.](https://learn.microsoft.com/en-us/dotnet/core/tools/)

## Descripción
Este es un proyecto piloto diseñado para el estudio y la práctica del desarrollo de aplicaciones web con el patrón MVC. Sirve como una implementación práctica de los conceptos aprendidos en el curso de Udemy "Aprende ASP.NET Core MVC 9 haciendo proyectos desde cero", impartido por Felipe Gavilán.

## Configuración y Ejecución en Modo Desarrollo

Sigue estos pasos para poner el proyecto en marcha en tu entorno local:

1. Funsionalidad del Fomulario Contacto

    ir a appsettings.Development.json y agregar los valores expuestos:

    "EMAIL": tu correo electronico; "PASSWORD": tu password

2. Inicio del Servidor Local

```bash
dotnet watch
```

Una vez que el servidor esté activo, abre tu navegador web y navega a http://localhost:5277/. La aplicación se recargará automáticamente cada vez que realices modificaciones en el código fuente.