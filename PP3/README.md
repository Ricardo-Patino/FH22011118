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


<img width="1756" height="972" alt="image" src="https://github.com/user-attachments/assets/b23ee283-d3b2-4169-8b5c-8ad44dd28384" />



## Respuesta a las preguntas.

#### 1) ¿Es posible enviar valores en el Body (por ejemplo, en el Form) del Request de tipo GET?
El número más alto sería> 65025. Al ser cadenas de 8 caracteres binarios, es decir, un byte completo. El valor máximo en binario de 8 bits es: 255 en decimal.
- a = 11111111
- b = 11111111

Esto equivale a 255 en decimal para ambos.
255 × 255 = 65025
</br>


<img width="1704" height="960" alt="image" src="https://github.com/user-attachments/assets/6e43ba94-2393-4cc2-94d2-bcec8be22d11" />



</br>

#### 2. ¿Qué ventajas y desventajas observa con el Minimal API si se compara con la opción de utilizar Controllers?

<p>
  Sí, es totalmente posible y es recomendable, realizar las operaciones en otra capa para mantener una arquitectura limpia y desacoplada.

  La realización de operaciones matemáticas, transformaciones de sistemas numéricos y validaciones complejas debe hacerse en la capa de servicios o lógica de negocio de la arquitectura. En ASP.NET Core MVC,  corresponde a la clase 'Service' o clases utilitarias independientes del controlador y la vista.

Por lo que, la capa idónea para centralizar estas operaciones es la "service layer", que puede añadirse mediante inyección de dependencias.
</p>
