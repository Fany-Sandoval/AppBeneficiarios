using AppBeneficiarios.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBeneficiarios.Infraestructure
{
    public interface IBeneficiarioServices
    {
        bool Insert(beneficiarios beneficiario);
    }
}
