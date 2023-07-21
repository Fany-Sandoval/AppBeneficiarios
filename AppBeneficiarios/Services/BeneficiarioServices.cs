using AppBeneficiarios.Data;
using AppBeneficiarios.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBeneficiarios.Services
{
    public class BeneficiarioServices : IBeneficiarioServices
    {
        private GestionSolicitudesDBEntities bd;
        public bool Insert(beneficiarios beneficiario)
        {
            bool respuesta = false;
            try
            {
                using (bd = new GestionSolicitudesDBEntities())
                {
                    bd.beneficiarios.Add(beneficiario);
                    bd.SaveChanges();
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                respuesta = false;
            }
            return respuesta;
        }
    }
}