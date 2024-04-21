// See https://aka.ms/new-console-template for more information
using Pregunta1;
try
{
    int numerador = 10;
    int denominador = 0;
    int result = Functions.Dividir(numerador, denominador);
    Console.WriteLine(result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.Read();
}

