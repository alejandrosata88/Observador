using Observador.Servicio.Interface;

namespace Observador.Servicio.Implementacion.Suscriptor
{
    class SubirCodigo : ISuscriptor
    {
        public string Ejecutar(int _iAccion)
        {
            string cMensaje = string.Empty;
            if(_iAccion>=1)
            {
                cMensaje = "Se subio el codigo..\n";
            }
            return cMensaje;
        }
    }
}
