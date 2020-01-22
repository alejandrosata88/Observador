using Observador.Servicio.Interface;
using System.Collections.Generic;

namespace Observador.Servicio.Implementacion.Publicador
{
    public class Selector : IPublicador
    {
        public int iAccion { get; set; }

        public List<ISuscriptor> lstISuscriptor = new List<ISuscriptor>();

        public void Suscribir(ISuscriptor _ISuscriptor)
        {
            this.lstISuscriptor.Add(_ISuscriptor);
        }

        public void Desuscribir(ISuscriptor _ISuscriptor)
        {
            this.lstISuscriptor.Remove(_ISuscriptor);
        }

        public string Notificar()
        {
           string cMensaje = string.Empty;
           string cMensajeAuxuiliar = string.Empty;
            foreach (ISuscriptor ISuscriptor in lstISuscriptor)
            {
                cMensajeAuxuiliar = ISuscriptor.Ejecutar(this.iAccion);
                if (!string.IsNullOrEmpty(cMensajeAuxuiliar))
                    cMensaje += cMensajeAuxuiliar;
            }
            return cMensaje;
        }
    }
}
