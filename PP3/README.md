# Práctica Programada 3 (PP3)

## Estudiante

- **Nombre:** Ricardo Patiño
- **Carné:** FH22011118

## Comandos utilizados (CLI)

```bash
#crear carpeta
mkdir

# abrir VSC desde consola
 code .

# Crear solución
dotnet new sln -n PP3
dotnet new web -n TextApi --framework net8.0
dotnet sln add TextApi/TextApi.csproj

# Crear proyecto de consola
dotnet new console -n PP3App -f net8.0

# Agregar proyecto a la solución
dotnet sln add PP3App

# Ejecutar el programa
dotnet run --project TextApi

# compilar el programa
dotnet build

# correr el programa
dotnet run

# cambiamos al proyecto
 cd PP2App/

# correr el proyecto
 dotnet run

```

## Páginas web donde halló posibles soluciones.

- https://www.markdownguide.org/basic-syntax
- https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-9.0
- https://dotnettutorials.net/lesson/data-annotations-in-asp-net-core-mvc
- https://weblogs.asp.net/ricardoperes/net-8-data-annotations-validation
- https://dotnettutorials.net/lesson/viewdata-asp-net-core-mvc
- https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/controller-methods-views?view=aspnetcore-9.0
- https://learn.microsoft.com/en-us/dotnet/api/system.convert?view=net-8.0

## Snippets de código.

###GitBash Codes


###Web up and running






## Respuesta a las preguntas.

#### 1) ¿Es posible enviar valores en el Body (por ejemplo, en el Form) del Request de tipo GET?
<p>
No, No es una buena práctica hacer esto y no debería hacerse. Aunque hay navegadores o herramientas que lo permiten, no es parte del estándar de HTTP y la mayoría de los servidores o frameworks (incluido ASP.NET Core), porque simplemente lo ignoran.
<br>
En los métodos GET, los datos deben enviarse por la URL, ya sea como parámetros de ruta o en la cadena de consulta (query string).
<br>
El cuerpo (body) está pensado para métodos como POST, PUT o DELETE, que sí procesan información enviada desde el cliente hacia el servidor.
</p>

</br>
</br>

#### 2. ¿Qué ventajas y desventajas observa con el Minimal API si se compara con la opción de utilizar Controllers?

<p>

Minimal API vs Controllers (ventajas y desventajas)
</br>
Minimal API es una forma más simple y directa de crear endpoints.
Su mayor ventaja es que requiere menos código y configuración, lo que la hace ideal para proyectos pequeños, microservicios o prototipos. Además, todo se define en un solo archivo (Program.cs), lo que facilita entender el flujo rápidamente.</br>
Por otro lado, cuando el proyecto empieza a crecer, se vuelve más difícil de mantener y organizar, ya que no tiene la misma estructura modular ni las convenciones de los controladores tradicionales.
</br>
En cambio, los Controllers (MVC o Web API) son más adecuados para aplicaciones grandes o con mucha lógica.
Permiten separar responsabilidades, usar filtros, validaciones, middlewares personalizados y organizar mejor el código por capas.</br>
La desventaja es que requieren más configuración y archivos, lo que puede sentirse más “pesado” para proyectos pequeños.
</p>
