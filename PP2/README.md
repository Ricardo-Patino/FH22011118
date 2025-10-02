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
aqui va el código
```

## Páginas web donde halló posibles soluciones.

- https://www.markdownguide.org/basic-syntax
- https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-9.0
- https://dotnettutorials.net/lesson/data-annotations-in-asp-net-core-mvc
- https://weblogs.asp.net/ricardoperes/net-8-data-annotations-validation

## Snippets de código.


## Respuesta a las preguntas.

#### 1. ¿Cuál es el número que resulta al multiplicar, si se introducen los valores máximos permitidos en a y b?
El número más alto sería> 65025. Al ser cadenas de 8 caracteres binarios, es decir, un byte completo. El valor máximo en binario de 8 bits es: 255 en decimal.
- a = 11111111
- b = 11111111

Esto equivale a 255 en decimal para ambos.
255 × 255 = 65025



#### 2. ¿Es posible hacer las operaciones en otra capa? Si sí, ¿en cuál sería?

<p>
  Sí, es totalmente posible y recomendable realizar las operaciones en otra capa para mantener una arquitectura limpia y desacoplada. En el patrón MVC.

  La realización de operaciones matemáticas, transformaciones de sistemas numéricos y validaciones complejas debe hacerse en la capa de servicios o lógica de negocio de la arquitectura. En ASP.NET Core MVC,  corresponde a la clase 'Service' o clases utilitarias independientes del controlador y la vista.

Por lo que, la capa idónea para centralizar estas operaciones es la "service layer", que puede añadirse mediante inyección de dependencias.
</p>

