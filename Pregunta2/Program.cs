using Pregunta2;

try
{
    var listInt = new List<int> { 1, 2, 3 };
    //ManejadorLista manejadorLista = new ManejadorLista(listInt);
    ManejadorLista manejadorLista = new ManejadorLista();
    for (int i = 0; i < 5; i++)
    {
        manejadorLista.eliminarElemento();
        Console.WriteLine("Se elimino el indice :" + i);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.Read();
}
