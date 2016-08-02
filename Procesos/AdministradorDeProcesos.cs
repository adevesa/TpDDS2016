using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;       
using System.Net.Mail;

namespace Procesos
{
    static public class AdministradorDeProcesos
    {
        static public void notificarSiEsNecesario(int demoraRealDelProceso, int duracionMaximaPermitida, string mailDelAdministrador)
        {
            if (demoraRealDelProceso > duracionMaximaPermitida)
            {
                enviarAviso(mailDelAdministrador);
            }
        }

        static private void enviarAviso(string mailDelAdministrador)
        {
            //La cadena "servidor" es el servidor de correo que enviará tu mensaje
            string servidor = "smtp.gmail.com";

            // Crea el mensaje estableciendo quién lo manda y quién lo recibe
            MailMessage mensaje = new MailMessage(
                                                    "Terminal búsqueda puntos de interés",
                                                    mailDelAdministrador, 
                                                    "Exceso de tiempo en búsqueda", 
                                                    "Se ha registrado que una búsqueda ha demorado más de lo esperado");

            
            SmtpClient cliente = new SmtpClient(servidor);
            //Añade credenciales si el servidor lo requiere.
            cliente.Credentials= new System.Net.NetworkCredential("xyz@gmail.com", "password");
            cliente.Port = 587;
            cliente.Host = "smtp.gmail.com";
            cliente.EnableSsl = true;
            cliente.UseDefaultCredentials = false;

            //Envía el mensaje.
            cliente.Send(mensaje);

        }

    }
}
