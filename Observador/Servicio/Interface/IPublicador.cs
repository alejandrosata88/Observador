namespace Observador.Servicio.Interface
{
    public interface IPublicador
    {
        void Suscribir(ISuscriptor _ISuscriptor);

        void Desuscribir(ISuscriptor _ISuscriptor);

        string Notificar();
    }
}
