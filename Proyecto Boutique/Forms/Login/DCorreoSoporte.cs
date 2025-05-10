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
            remitenteCorreo = "l22211934@tectijuana.edu.mx";
            password = "bqdz hsew zwnj cjxy ";
            host = "smtp.tectijuana.edu.mx";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
