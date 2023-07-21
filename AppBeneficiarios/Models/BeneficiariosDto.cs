using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBeneficiarios.Models
{
    public class BeneficiariosDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Curp { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdSexo { get; set; }
        public TelefonoDto TelefonoDto { get; set; }
        public DireccionDto DireccionDto { get; set; }
    }
}