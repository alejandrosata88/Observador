using Observador.Servicio.Interface;

namespace Observador.Servicio.Implementacion.Suscriptor
{
    class EjecutarPruebaUnitaria: ISuscriptor
    {
        public string Ejecutar(int _iAccion)
        {
            string cMensaje = string.Empty;
            if (_iAccion >= 3)
            {
                cMensaje = "Se ejecutaron las pruebas unitarias del codigo...\n";
            }
            return cMensaje;
        }
    }
}
