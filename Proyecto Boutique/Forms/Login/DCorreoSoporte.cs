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
            remitenteCorreo = "boutiquesistema98@gmail.com";
            password = "lotk kycg hert pymn";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
