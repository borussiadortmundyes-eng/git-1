// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<double> nota = new List<double>();
bool continuar = true;
int opcion;
do
{
    Console.Clear();
    Console.WriteLine("1)ingresar notas");
    Console.WriteLine("2) ver nota");
    Console.WriteLine("3) salir");
    opcion = int.Parse(Console.ReadLine());
} while (continuar = false);
