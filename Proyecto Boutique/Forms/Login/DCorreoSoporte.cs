using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Boutique
{
    public class DCorreoSoporte: recuperarPassword
    {
        public DCorreoSoporte()
        {
            remitenteCorreo = "minwcraft78@gmail.com";
            password = "xfmv rzxg slvd qrdw";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
