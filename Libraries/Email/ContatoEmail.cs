using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using lojaVirtual.Models;
using System.Threading.Tasks;

namespace lojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            /* SMTP -> Servidor de envio de e-mails*/
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("anarkiasocial@gmail.com", "s3gur013");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2>Contato - Loja Virtual</h2>" +
                "<b>Nome: </b> {0} <br />" +
                "<b>E-mail: </b> {1} <br />" +
                "<b>Texto: </b> {2} <br />" +
                "<br />E-mail enviado automaticamente do site LojaVirtual.",
                contato.Nome,
                contato.Email,
                contato.Texto
                );

            /*MailMessage -> Constrói a mensagem */
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("anarkiasocial@gmail.com");
            mensagem.To.Add("anarkiasocial@gmail.com");
            mensagem.Subject = "Contato Loja Virtual - E-mail: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            //Enviar mensagem via SMTP
            smtp.Send(mensagem);

        }
    }
}