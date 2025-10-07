Un archivo de documentación llamado README.md, hecho en Markdown, donde se indique lo siguiente:

Su nombre y carné.

Los comandos de dotnet utilizados (CLI).

Páginas web donde halló posibles soluciones a problemas encontrados o Snippets de código.

Prompts (consultas y respuestas) de los chatbots de IA (Copilot, Gemini, ChatGPT, etc.) que haya utilizado.

Este puede ser el vínculo compartido de dicho chatbot.
Las respuestas a las siguientes preguntas:

¿Cuál es el número que resulta al multiplicar, si se introducen los valores máximos permitidos en a y b? Indíquelo en todas las bases (binaria, octal, decimal y hexadecimal).
¿Es posible hacer las operaciones en otra capa? Si sí, ¿en cuál sería?

# Práctica Programada 2 (PP2)

## Estudiante

- **Nombre:** Ricardo Patiño
- **Carné:** FH22011118

## Comandos utilizados (CLI)

```bash
#crear carpeta
mkdir

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

# abrir VSC desde consola
 code .
```

## Páginas web donde halló posibles soluciones.

- https://www.markdownguide.org/basic-syntax
- https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-9.0
- https://dotnettutorials.net/lesson/data-annotations-in-asp-net-core-mvc
- https://weblogs.asp.net/ricardoperes/net-8-data-annotations-validation

## Snippets de código.

###GitBash Codes
<img width="1243" height="777" alt="Creation codes" src="https://github.com/user-attachments/assets/55c5d47f-fcc1-4a1d-a529-a3331adafc17" />

<img width="1919" height="1032" alt="Creation codes" src="https://github.com/user-attachments/assets/3dc79535-72d7-4d5f-8774-d4ca7040e14b" />

###BinaryInputModel.cs

<img width="1919" height="1032" alt="BinaryInpuModel" src="https://github.com/user-attachments/assets/d3db6a81-97a9-4473-9a4f-b10e5f6cba14" />

###Home Controller

<img width="763" height="876" alt="Home Controller" src="https://github.com/user-attachments/assets/148a1df6-e62f-45ac-a787-131451a69ee3" />


###Index

<img width="690" height="835" alt="image" src="https://github.com/user-attachments/assets/7ddcaa67-f7a1-4a92-90fe-d29047afae4e" />

###dotnet run

<img width="1306" height="995" alt="image" src="https://github.com/user-attachments/assets/d4353df7-924d-4539-8c86-eee7c1b8d959" />


###Web up and running

<img width="1877" height="1038" alt="image" src="https://github.com/user-attachments/assets/006cd91d-efe1-4a79-a988-abf09d077330" />


## Respuesta a las preguntas.

#### 1. ¿Cuál es el número que resulta al multiplicar, si se introducen los valores máximos permitidos en a y b?
El número más alto sería> 65025. Al ser cadenas de 8 caracteres binarios, es decir, un byte completo. El valor máximo en binario de 8 bits es: 255 en decimal.
- a = 11111111
- b = 11111111

Esto equivale a 255 en decimal para ambos.
255 × 255 = 65025
</br>
</br>

#### 2. ¿Es posible hacer las operaciones en otra capa? Si sí, ¿en cuál sería?

<p>
  Sí, es totalmente posible y es recomendable, realizar las operaciones en otra capa para mantener una arquitectura limpia y desacoplada.

  La realización de operaciones matemáticas, transformaciones de sistemas numéricos y validaciones complejas debe hacerse en la capa de servicios o lógica de negocio de la arquitectura. En ASP.NET Core MVC,  corresponde a la clase 'Service' o clases utilitarias independientes del controlador y la vista.

Por lo que, la capa idónea para centralizar estas operaciones es la "service layer", que puede añadirse mediante inyección de dependencias.
</p>

