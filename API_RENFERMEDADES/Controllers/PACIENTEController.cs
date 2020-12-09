using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_RENFERMEDADES.Conection;
using API_RENFERMEDADES.Modelos;
using Microsoft.AspNetCore.Mvc;



namespace API_RENFERMEDADES.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PACIENTEController : ControllerBase
    {
   
        [HttpGet("all")]
        public JsonResult ObtenerPlantas()
        {
            var PacientesRecibidos = PACIENTECONNECTION.ObtenerPacientes();
            return new JsonResult(PacientesRecibidos);
        }

       

        [HttpGet("{idPlanta}")]
        public JsonResult ObtenerPlanta(string rut)
        {
            var conversionExitosa = int.TryParse(rut, out int rutConvertido);
            PACIENTE PacienteRecibido;

            if (conversionExitosa)
            {
                PacienteRecibido = PACIENTECONNECTION.ObtenerPACIENTEPorrut(rutConvertido);
            }
            else
            {
                PacienteRecibido = PACIENTECONNECTION.ObtenerPACIENTEPorNombre(rut);
            }

            if (PacienteRecibido is null)
            {
                return new JsonResult($"Intente nuevamente con un parametro distinto a {rut}");
            }
            else
            {
                return new JsonResult(PacienteRecibido);
            }

        }

      
        [HttpPost]
        public void AgregarPACIENTE([FromBody] PACIENTE Paciente)
        {
            PACIENTECONNECTION.AgregarPACIENTE(Paciente);
        }
    }
}