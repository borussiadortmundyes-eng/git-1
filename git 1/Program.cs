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
    switch (opcion)
    {
        case 1:
            Console.WriteLine("ingrese la nota");
            double n = double.Parse(Console.ReadLine());
            nota.Add(n);
            break;
        case 2:
            Console.WriteLine("las notas ingresadas son:");
            foreach (double item in nota)
            {
                Console.WriteLine(item);
            }
            break;
        case 3:
            continuar = false;
            break;
        default:
            Console.WriteLine("opcion no valida");
            break;
        }

    } while (continuar = false);

