using Observador.Servicio.Implementacion.Suscriptor;
using Observador.Servicio.Implementacion.Publicador;
using System;

namespace Observador.Controlador
{
    public class Cliente
    {
        public void Main()
        {
            string cMensaje = string.Empty;
            Selector Selector = new Selector();
            SubirCodigo SubirCodigo = new SubirCodigo();
            CompilarCodigo CompilarCodigo = new CompilarCodigo();
            EjecutarPruebaUnitaria EjecutarPruebaUnitaria = new EjecutarPruebaUnitaria();
            InstalarVersion InstalarVersion = new InstalarVersion();
            EnviarCorreo EnviarCorreo = new EnviarCorreo();
            Selector.Suscribir(SubirCodigo);
            Selector.Suscribir(CompilarCodigo);
            Selector.Suscribir(EjecutarPruebaUnitaria);
            Selector.Suscribir(InstalarVersion);
            Selector.Suscribir(EnviarCorreo);

            Console.WriteLine("Se realiza el comando 1");
            Selector.iAccion = 1;
            cMensaje=Selector.Notificar();
            Console.WriteLine(cMensaje);

            Console.WriteLine("Se realiza el comando 5");
            Selector.iAccion = 5;
            cMensaje = Selector.Notificar();
            Console.WriteLine(cMensaje);

            Console.WriteLine("Se elimina la acción 3 y 5 realiza el comando 5");
            Selector.Desuscribir(EjecutarPruebaUnitaria);
            Selector.Desuscribir(EnviarCorreo);
            cMensaje = Selector.Notificar();
            Console.WriteLine(cMensaje);

            Console.ReadLine();
        }
    }
}
