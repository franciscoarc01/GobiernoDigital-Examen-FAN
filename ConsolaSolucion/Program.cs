// See https://aka.ms/new-console-template for more information
using Libreria;
using System.Text;

Console.WriteLine("Ingrese la ubicación del archivo txt para analizar las cuentas:");
String ruta = Console.ReadLine();
try
{
    List<string> lineasDeTexto = File.ReadAllLines(string.Format("C:\\Users\\franc\\OneDrive\\Documentos\\{0}", ruta)).ToList();
    Console.WriteLine("_________________________________________________Resultados________________________________________________________________");
    List<string> cuentas = new List<string>();
    StringBuilder construirCadena = new StringBuilder();
    bool alto(uint contador, uint parametro) => contador < parametro;
    for (int lineas = 0; lineas < lineasDeTexto.Count; lineas = lineas + 4)
    {
        for (uint i = 0; alto(i, (uint)lineasDeTexto[lineas].Length) && alto(i, (uint)lineasDeTexto[lineas + 1].Length) && alto(i, (uint)lineasDeTexto[lineas + 2].Length); i += 3)
        {
            construirCadena.Append(Funciones.Decodificar(lineasDeTexto[lineas].Substring((int)i, 3), lineasDeTexto[lineas + 1].Substring((int)i, 3), lineasDeTexto[lineas + 2].Substring((int)i, 3)));
        }
        cuentas.Add(construirCadena.ToString());
        construirCadena.Clear();
    }
    foreach (String cuenta in cuentas)
    {
        try 
        { 
            string resultado = Funciones.ValidacionCuenta(cuenta);
            Console.WriteLine(resultado);
        } 
        catch 
        {
            string resultado = string.Format("Cuenta: {0} Ilegible", cuenta);
            Console.WriteLine(resultado);
        }
    }
}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}