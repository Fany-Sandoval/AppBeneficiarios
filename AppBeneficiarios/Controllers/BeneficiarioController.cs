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
    public class BeneficiarioController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Create(BeneficiariosDto beneficiariosDto)
        {
            try
            {
                IBeneficiarioServices services = new BeneficiarioServices();
                beneficiarios beneficiario = new beneficiarios();
                beneficiario.Nombre = beneficiariosDto.Nombre.ToLower();
                beneficiario.ApellidoPaterno = beneficiariosDto.ApellidoPaterno.ToLower();
                beneficiario.ApellidoMaterno = beneficiariosDto.ApellidoMaterno.ToLower();
                beneficiario.Curp = beneficiariosDto.Curp.ToLower();
                beneficiario.FechaNacimiento = beneficiariosDto.FechaNacimiento;
                beneficiario.IdSexo = beneficiariosDto.IdSexo;

                telefonos telefono = new telefonos();
                telefono.StrNumeroCasa = beneficiariosDto.TelefonoDto.StrNumeroCasa;
                telefono.StrNumeroCelular = beneficiariosDto.TelefonoDto.StrNumeroCelular;
                telefono.StrNumeroTrabajo = beneficiariosDto.TelefonoDto.StrNumeroTrabajo;
                beneficiario.telefonos = telefono;

                direcciones direccion = new direcciones();
                direccion.StrCalle = beneficiariosDto.DireccionDto.StrCalle.ToLower();
                direccion.StrNumInterior = beneficiariosDto.DireccionDto.StrNumInterior.ToLower();
                direccion.StrNumExterior = beneficiariosDto.DireccionDto.StrNumExterior.ToLower();
                beneficiario.direcciones = direccion;

                if (services.Insert(beneficiario))
                {
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                return BadRequest();
            }
        }
    }
}
