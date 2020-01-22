using Observador.Servicio.Interface;

namespace Observador.Servicio.Implementacion.Suscriptor
{
    class CompilarCodigo: ISuscriptor
    {
        public string Ejecutar(int _iAccion)
        {
            string cMensaje = string.Empty;
            if (_iAccion >= 2)
            {
                cMensaje = "Se ejecuto el codigo...\n";
            }
            return cMensaje;
        }
    }
}
