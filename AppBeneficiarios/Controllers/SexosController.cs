using AppBeneficiarios.Data;
using AppBeneficiarios.Infraestructure;
using AppBeneficiarios.Models;
using AppBeneficiarios.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppBeneficiarios.Controllers
{
    public class SexosController : ApiController
    {
        //Get: api/Sexos
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                IServicesSexos services = new ServicesSexos();
                List<sexos> lista = services.Get();
                List<SexoDto> sexosDto = new List<SexoDto>();
                foreach(sexos g in lista)
                {
                    sexosDto.Add(new SexoDto { Id = g.Id, StrValor = g.StrValor});
                }
                return Ok(sexosDto);
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                return BadRequest();
            }
        }

        [HttpPost]
        public IHttpActionResult Create(sexos sexo)
        {
            try
            {
                IServicesSexos services = new ServicesSexos();
                return Ok(services.Insertar(sexo));
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                return BadRequest("Esta solicitud no se pudo procesar de forma adecuada.!");
            }
        }

        //Delete: api/Sexos
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                IServicesSexos services = new ServicesSexos();
                return Ok(services.Delete(id));
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult Update(SexoDto sexo)
        {
            try
            {
                IServicesSexos services = new ServicesSexos();
                var entidad = new sexos { Id = sexo.Id, StrValor = sexo.StrValor };
                return Ok(services.Update(entidad));
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                return BadRequest();
            }
        }

    }
}
