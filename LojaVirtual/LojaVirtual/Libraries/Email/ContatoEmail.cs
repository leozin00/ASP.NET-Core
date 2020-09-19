using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            //SMTP -> Servidor que irá enviar a mensagem.
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("leo.vasconcelos2000@gmail.com", "");
            smtp.EnableSsl = true;

            string corpoMensagem = string.Format("<h3>Contato - Loja Virtual</h3> <br />" +
                "<b>Nome:</b> {0} <br />" +
                "<b>Email:</b> {1} <br />" +
                "<b>Texto:</b> {2} <br />" +
                "<br /> Email enviado automanticamente do site Loja Virtual.", 
                contato.Nome, contato.Email, contato.Texto
            );

            //MailMessage -> Responsável por construir a mensagem.
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("leo.vasconcelos2000@gmail.com");
            mensagem.To.Add(new MailAddress("leo.vasconcelos2000@gmail.com"));
            mensagem.Subject = "Contato - Loja Virtual - " + contato.Email;
            mensagem.Body = corpoMensagem;
            mensagem.IsBodyHtml = true;

            smtp.Send(mensagem);
        }
    }
}
