using AppBeneficiarios.Data;
using AppBeneficiarios.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBeneficiarios.Services
{
    public class ServicesSexos : IServicesSexos
    {
        private GestionSolicitudesDBEntities gestion;

        public ServicesSexos()
        {

        }

        public bool Insertar(sexos sexo)
        {
            bool respuesta = false;
            try
            {
                using (gestion = new GestionSolicitudesDBEntities())
                {
                    gestion.sexos.Add(sexo);
                    gestion.SaveChanges();
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
            return respuesta;
        }

        public bool Delete(int id)
        {
            bool respuesta = false;
            try
            {
                using (gestion = new GestionSolicitudesDBEntities())
                {
                    var sexo = gestion.sexos.Where(p => p.Id == id).FirstOrDefault();
                    gestion.sexos.Remove(sexo);
                    gestion.SaveChanges();
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
            return respuesta;
        }

        public List<sexos> Get()
        {
            var sexos = new List<sexos>();
            try
            {
                using(gestion = new GestionSolicitudesDBEntities())
                {
                    return gestion.sexos.ToList();
                }
                
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                return sexos;
            }
        }

        public sexos GetById(int id)
        {
            sexos sexo = new sexos();
            try
            {
                using(gestion = new GestionSolicitudesDBEntities())
                {
                    return gestion.sexos.Where(p => p.Id == id).FirstOrDefault();
                }
                
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                return sexo;
            }
        }

        public bool Update(sexos sexo)
        {
            bool respuesta = false;
            try
            {
                using (gestion = new GestionSolicitudesDBEntities())
                {
                    var entitie =  gestion.sexos.Where(p => p.Id == sexo.Id).FirstOrDefault();
                    entitie.StrValor = sexo.StrValor;
                    gestion.SaveChanges();
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
            return respuesta;
        }

    }
}