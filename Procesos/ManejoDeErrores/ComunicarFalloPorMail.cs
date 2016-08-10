using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace Procesos.ManejoDeErrores
{
    public class ComunicarFalloPorMail : ErrorGestion
    {
        //Constructor
        public ComunicarFalloPorMail(string mailDelUsuario)
        {
            setMailDelUsuario(mailDelUsuario);
            
        }

        public override void lanzar(Proceso proceso)
        {
            enviarAviso();
        }
       
        private void enviarAviso()
        {
            //La cadena "servidor" es el servidor de correo que enviará tu mensaje
            string servidor = "smtp.gmail.com";

            // Crea el mensaje estableciendo quién lo manda y quién lo recibe
            MailMessage mensaje = new MailMessage(
                                                    "Proceso con falla",
                                                    getMailDelUsser(),
                                                    "Fallo en la ejecución del proceso",
                                                    "La ejecución del proceso ha fallado");


            SmtpClient cliente = new SmtpClient(servidor);
            //Añade credenciales si el servidor lo requiere.
            cliente.Credentials = new System.Net.NetworkCredential("xyz@gmail.com", "password");
            cliente.Port = 587;
            cliente.Host = "smtp.gmail.com";
            cliente.EnableSsl = true;
            cliente.UseDefaultCredentials = false;

            //Envía el mensaje.
            cliente.Send(mensaje);

        }


    }
}
