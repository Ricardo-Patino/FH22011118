# Práctica Programada 2 (PP2)

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
dotnet new sln -n PP2

# Crear proyecto de consola
dotnet new console -n PP2App -f net8.0

# Agregar proyecto a la solución
dotnet sln add PP2App

# Ejecutar el programa
dotnet run --project PP2App

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
<img width="1243" height="777" alt="Creation codes" src="https://github.com/user-attachments/assets/55c5d47f-fcc1-4a1d-a529-a3331adafc17" />

<img width="1919" height="1032" alt="Creation codes" src="https://github.com/user-attachments/assets/3dc79535-72d7-4d5f-8774-d4ca7040e14b" />

###BinaryInputModel.cs

<img width="903" height="690" alt="image" src="https://github.com/user-attachments/assets/1aa411a1-de43-40ca-88e2-3b996e3919d2" />


###Home Controller

<img width="939" height="989" alt="image" src="https://github.com/user-attachments/assets/6ea97c31-91f5-4984-9b7e-3379bb7b905c" />


###Index

<img width="655" height="959" alt="image" src="https://github.com/user-attachments/assets/8ff331a3-98e1-4a1a-a2ac-1eb46a7dc6cc" />


###dotnet run

<img width="1306" height="995" alt="image" src="https://github.com/user-attachments/assets/d4353df7-924d-4539-8c86-eee7c1b8d959" />


###Web up and running


<img width="1756" height="972" alt="image" src="https://github.com/user-attachments/assets/b23ee283-d3b2-4169-8b5c-8ad44dd28384" />



## Respuesta a las preguntas.

#### 1. ¿Cuál es el número que resulta al multiplicar, si se introducen los valores máximos permitidos en a y b?
El número más alto sería> 65025. Al ser cadenas de 8 caracteres binarios, es decir, un byte completo. El valor máximo en binario de 8 bits es: 255 en decimal.
- a = 11111111
- b = 11111111

Esto equivale a 255 en decimal para ambos.
255 × 255 = 65025
</br>


<img width="1704" height="960" alt="image" src="https://github.com/user-attachments/assets/6e43ba94-2393-4cc2-94d2-bcec8be22d11" />



</br>

#### 2. ¿Es posible hacer las operaciones en otra capa? Si sí, ¿en cuál sería?

<p>
  Sí, es totalmente posible y es recomendable, realizar las operaciones en otra capa para mantener una arquitectura limpia y desacoplada.

  La realización de operaciones matemáticas, transformaciones de sistemas numéricos y validaciones complejas debe hacerse en la capa de servicios o lógica de negocio de la arquitectura. En ASP.NET Core MVC,  corresponde a la clase 'Service' o clases utilitarias independientes del controlador y la vista.

Por lo que, la capa idónea para centralizar estas operaciones es la "service layer", que puede añadirse mediante inyección de dependencias.
</p>

