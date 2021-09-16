using System;
using System.Net;
using System.Net.Mail;

namespace EnvioEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {//cria uma mensagem
                MailMessage email = new MailMessage();

                //define os endereços
                email.From = new MailAddress("Endereço do remetente");
                email.To.Add("Endereço do destinatário");

                //define o conteúdo
                email.Subject = "envio"; // Assunto do e-mail
                email.Body = "***********";   // Corpo do E-mail

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;

                smtp.UseDefaultCredentials = true;
                // inclui as credenciais
                NetworkCredential cred = new NetworkCredential("Email", " senha");
                smtp.Credentials = cred;

                //envia a mensagem
                smtp.Send(email);


                Console.Write("Email enviado com sucesso !");
            }catch(SmtpException ex)
            {
                Console.Write(ex.Message);
            }
            Console.ReadKey();
        }
        
    }
}
