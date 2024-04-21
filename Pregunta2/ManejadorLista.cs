namespace Pregunta2
{
    public class ManejadorLista
    {
        private List<int> ints = new List<int>();
        public ManejadorLista()
        {

        }
        public ManejadorLista(List<int> ints)
        {
            this.ints = ints;
        }

        public void eliminarElemento()
        {
            try
            {
                if (ints.First() > 0)
                {
                    this.ints.RemoveAt(ints.Count - 1);
                }
            }
            catch (InvalidOperationException)
            {
                throw new Exception("Error de Sistema, No se puede eliminar ultimo elemento la lista esta vacia");
            }
            catch (Exception e)
            {
                throw new Exception("Error de Sistema, Contactar al Administrador");
            }

        }
    }
}
