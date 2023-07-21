using AppBeneficiarios.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBeneficiarios.Infraestructure
{
    interface IServicesSexos
    {
        bool Insertar(sexos sexo);
        bool Delete(int id);
        List<sexos> Get();
        sexos GetById(int id);
        bool Update(sexos sexo);
    }
}
