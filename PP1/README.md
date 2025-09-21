# Práctica Programada 1 (PP1)

## Estudiante

- **Nombre:** Ricardo Patiño
- **Carné:** FH22011118

## Comandos utilizados (CLI)

```bash
#crear carpeta
mkdir

# Crear solución
dotnet new sln -n PP1

# Crear proyecto de consola
dotnet new console -n PP1App -f net8.0

# Agregar proyecto a la solución
dotnet sln add PP1App

# Ejecutar el programa
dotnet run --project PP1App

# compilar el programa
dotnet build

# correr el programa
dotnet run

# cambiamos al proyecto
 cd PP1App/

# correr el proyecto
 dotnet run

# abrir VSC desde consola
 code .
```

## Páginas web donde halló posibles soluciones.

https://www.markdownguide.org/basic-syntax
https://stackoverflow.com/questions/39709453/c-sharp-recursive-method-that-receives-an-integer-n-and-prints-all-the-integers

## Snippets de código.

<img width="1488" height="493" alt="image" src="https://github.com/user-attachments/assets/d0b7f520-1af8-4921-a40c-3c52013645db" />
<img width="1499" height="363" alt="image" src="https://github.com/user-attachments/assets/6a037839-72aa-49b6-ae59-7b305902f2e5" />

## Prompts.

https://chatgpt.com/share/68d06a59-6a08-800b-bdc1-69e15ac718cc

## Respuesta a las preguntas.

<p>
1. ¿Por qué difieren los resultados entre métodos y estrategias?
a) Diferencias entre fórmula y bucle

Fórmula (Gauss):
Hace la multiplicación n _ (n+1) primero. Esa multiplicación puede desbordar (overflow) en int aunque el resultado final (dividido entre 2) todavía quepa.
Ejemplo:
Para n = 65535, la suma real es 2147450880 (cabe en int).
Pero 65535 _ 65536 = 4294901760 → eso ya excede int.MaxValue (2,147,483,647).
Entonces la fórmula falla antes.

Bucle (iterativo):
Va acumulando suma por suma. Aquí el desbordamiento ocurre cuando el total acumulado excede int.MaxValue. Esto pasa más tarde (exactamente en n = 65536).
Resultado: el bucle aguanta más que la fórmula en int.

</p>
<p>
b) Diferencias entre ascendente y descendente

El orden en que sumás también importa cuando hay overflow o pérdida de precisión:

En int con overflow: si sumás en orden ascendente, las sumas se acumulan y explotan más o menos “cuando toca”.

En orden descendente, el patrón puede diferir (ej. si el acumulador ya se acerca al límite y las sumas grandes entran primero). Eso hace que los errores de overflow aparezcan en un punto diferente o incluso antes.

En tipos de punto flotante (double, float), también importa el orden: porque la precisión finita hace que números muy pequeños sumados a números muy grandes se “pierdan”. Pero aquí como trabajamos con enteros, lo crítico es el overflow.

</p>
<p>
2. ¿Qué pasaría con un método recursivo (SumRec)?

El método recursivo sería algo como:

static int SumRec(int n)
{
if (n == 0) return 0;
return n + SumRec(n - 1);
}

a) Problemas prácticos

Stack Overflow (de la pila de llamadas):
Cada llamada recursiva guarda un frame en la pila. Para n grandes (ej. millones), la pila del programa se desborda mucho antes de que se llegue al límite de int.

- En .NET, normalmente alrededor de 20.000–50.000 llamadas recursivas ya tiran StackOverflowException.
  Entonces el método recursivo es impracticable para n grandes.

Overflow aritmético (igual que antes):
Incluso si la recursión llegara lejos, la suma acumulada se enfrenta a los mismos límites de int → el resultado se desbordaría como con el bucle.

b) Comparación entre ascendente y descendente con recursión

En realidad, SumRec definido como arriba siempre recorre de n hacia 0, es decir, equivalente a la estrategia descendente.
Podrías hacer una variante “ascendente”:

static int SumRecAsc(int n, int current = 1)
{
if (current > n) return 0;
return current + SumRecAsc(n, current + 1);
}

</p>
