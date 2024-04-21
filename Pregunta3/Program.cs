using Pregunta3;

try
{
    string cadena = "s";
    Console.WriteLine(Functions.convertirNumero(cadena));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.Read();
}
