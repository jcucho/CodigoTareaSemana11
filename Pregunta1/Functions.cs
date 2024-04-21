namespace Pregunta1
{
    public class Functions
    {
        public static int Dividir(int numerador, int denominador)
        {
            int resultado = 0;
            try
            {
                resultado = numerador / denominador;
            }
            catch (DivideByZeroException)
            {
                throw new Exception("Error de Sistema, No se puede divir entre cero");
            }
            catch (Exception)
            {
                throw new Exception("Error de Sistema, Contactar al Administrador");
            }
            return resultado;
        }
    }
}
