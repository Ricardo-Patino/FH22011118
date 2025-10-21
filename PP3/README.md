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
 cd PP3App/

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
<img width="1850" height="974" alt="image" src="https://github.com/user-attachments/assets/f038dce4-aca1-4a24-8aa2-6b3f20a7cc93" />


###Web up and running

<img width="1736" height="763" alt="image" src="https://github.com/user-attachments/assets/d200e9f2-2589-4bdf-81c4-48bc1553d60f" />



## INSPECT

<img width="1884" height="1007" alt="image" src="https://github.com/user-attachments/assets/e9d27ce3-f8c4-4139-86d3-fcf8e1ab97ae" />


## Consola corriendo y sin errores

<img width="1877" height="1017" alt="image" src="https://github.com/user-attachments/assets/d1bfb58b-9b2d-4d22-b5d2-e3096d5b0c88" />



## Respuesta a las preguntas.

#### 1) ¿Es posible enviar valores en el Body (por ejemplo, en el Form) del Request de tipo GET?
<p>
No, en general no se deben enviar valores en el cuerpo (Body) de un método GET.<br>
Aunque algunos clientes o navegadores podrían permitirlo, no es parte del estándar HTTP y la mayoría de los servidores lo ignoran completamente.
<br></br>
El propósito del método GET es solicitar información, no enviar datos.<br></br>
Por eso, en este tipo de petición los valores se envían por la URL, ya sea como parte de la ruta (Route) o usando la query string (por ejemplo, ?param=valor).<br></br>
En los métodos GET, los datos deben enviarse por la URL, ya sea como parámetros de ruta o en la cadena de consulta (query string).<br>
<br>
Los métodos que sí usan el cuerpo del request son POST, PUT o DELETE, porque están diseñados para enviar o modificar datos en el servidor.
</p>

</br>
</br>

#### 2. ¿Qué ventajas y desventajas observa con el Minimal API si se compara con la opción de utilizar Controllers?

<p>

Minimal API vs Controllers (ventajas y desventajas)
</br></br>
Minimal API es una forma más sencilla y directa de crear endpoints. Su gran ventaja es que permiten escribir menos código y comenzar un proyecto de forma muy rápida.</br>
Todo se define dentro del archivo Program.cs, lo que las hace ideales para proyectos pequeños, pruebas rápidas o microservicios donde no se necesita mucha estructura.</br></br>
Sin embargo, cuando el proyecto crece, pueden volverse difíciles de mantener, porque no existe una separación clara entre lógica, validaciones y rutas. Además, tienen menos soporte para decoradores, filtros y atributos que los controladores tradicionales.</br></br></br>
Por otro lado, usar Controllers (MVC o Web API) es más recomendable para aplicaciones grandes o con muchas rutas y capas.
</br></br></br>
Los controladores permiten una organización más limpia y modular, usando archivos separados para cada grupo de endpoints, lo que facilita las pruebas, el mantenimiento y la escalabilidad.</br>
La desventaja es que requieren más configuración y estructura inicial, lo que puede parecer más pesado al inicio, pero a la larga ayuda a mantener el código ordenado.
</p>
