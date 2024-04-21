namespace Pregunta3
{
    public class Functions
    {
        public static int convertirNumero(string cadena)
        {
            int number;
            try
            {
                number = int.Parse(cadena);
            }
            catch (FormatException)
            {
                throw new Exception("Error de Sistema, No se puede convertir a numero la cadena ingresada");
            }
            catch (Exception e)
            {
                throw new Exception("Error de Sistema, Contactar al Administrador");
            }

            return number;
        }
    }
}
