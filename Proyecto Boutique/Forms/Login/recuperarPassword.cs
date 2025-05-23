﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Media;

namespace Proyecto_Boutique
{
    public class recuperarPassword
    {
        private SmtpClient smtpClient;

        databaseConnection db = new databaseConnection();

        protected string remitenteCorreo { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }


        protected void initializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(remitenteCorreo, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void sendMail(string subject, string body, List<string> destinariocorreo)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(remitenteCorreo);
                foreach (string mail in destinariocorreo)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
            }
            finally
            {
                mailMessage.Dispose();
            }
        }

        public string recoverPassword(string usuarioSolicitando)
        {
            db.Open();
            using(var command = new SqlCommand())
            {
                command.Connection = db.getConnection();
                command.CommandText = "SELECT Nombre, Correo, Contrasena FROM USUARIO WHERE Nombre = @usuario OR Correo = @correo";
                command.Parameters.AddWithValue("@usuario", usuarioSolicitando);
                command.Parameters.AddWithValue("@correo", usuarioSolicitando);
                command.CommandType = System.Data.CommandType.Text;

                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read() == true)
                {

                    string nombreUsuario = reader.GetString(0);
                    string correo = reader.GetString(1);
                    string contrasena = reader.GetString(2);


                    var mailService = new DCorreoSoporte();
                    mailService.sendMail(
                        subject: "SISTEMA DE BOUTIQUE: Recuperación de contraseña",
                        body: $"Hola {nombreUsuario},\n\n" +
                        $"Ha recibido una solicitud para recuperar la contraseña" +
                        $"\nSu contraseña es: {contrasena}" +
                        $"\n\nSaludos,\nSistema de Boutique",
                        destinariocorreo: new List<string> { correo }
                        );
                    return "Tu usuario ha sido verificado correctamente. " +
                        "\nPor favor, revisa tu correo electrónico para más instrucciones o notificaciones.";
                }
                else
                {
                    return "No se encontró el usuario o el correo no coincide.";
                }
            }
        }
    }
}
