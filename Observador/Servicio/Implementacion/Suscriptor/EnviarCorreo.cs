using Observador.Servicio.Interface;

namespace Observador.Servicio.Implementacion.Suscriptor
{
    class EnviarCorreo : ISuscriptor
    {
        public string Ejecutar(int _iAccion)
        {
            string cMensaje = string.Empty;
            if (_iAccion >= 5)
            {
                cMensaje = "Se notifico por correo...\n";
            }
            return cMensaje;
        }
    }
}
