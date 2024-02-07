# Bank OCR Examen

Es la solución del examen de Gobierno Digital para integrarme a laborar con ellos, de lo cual la solución es realizada en .NET con C# como lenguaje de programación.

## El inicio

Para poder iniciar el proyecto es necesario tener Visual Studio para compilar el proyecto

### Prerequisitos

```
Tener Visual Studio
```

### Solución en consola

Esto es una serie de pasos para entender el código

Por definición, la ruta predefinida está enrutado a Documentos, de lo cual para cambiar es en la línea 9 del archivo Program.cs, esta finalidad lo hice para no poner el Path Absoluto

```
9  List<string> lineasDeTexto = File.ReadAllLines(string.Format("C:\\Users\\franc\\OneDrive\\Documentos\\{0}", ruta)).ToList();
```
Y al correrlo, le pedirá la ubicación del archivo para leer los datos codificados.

## Solución en MAUI

Por el momento no se encuentra disponible, se realizará avances

## Contributing



## Versioning



## Authors

* **Francisco Árciga**

## License


