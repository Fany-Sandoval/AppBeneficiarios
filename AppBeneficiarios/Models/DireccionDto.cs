using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBeneficiarios.Models
{
    public class DireccionDto
    {
        public int Id { get; set; }
        public string StrCalle { get; set; }
        public string StrNumInterior { get; set; }
        public string StrNumExterior { get; set; }
    }
}