using Observador.Servicio.Interface;

namespace Observador.Servicio.Implementacion.Suscriptor
{
    class InstalarVersion : ISuscriptor
    {
        public string Ejecutar(int _iAccion)
        {
            string cMensaje = string.Empty;
            if (_iAccion >= 4)
            {
                cMensaje = "Se instalo la version...\n";
            }
            return cMensaje;
        }
    }
}
