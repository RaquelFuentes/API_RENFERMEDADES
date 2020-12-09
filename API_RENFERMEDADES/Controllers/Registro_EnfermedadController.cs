using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_RENFERMEDADES.Modelos;
using API_RENFERMEDADES.Conection;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_RENFERMEDADES.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantaFamiliaController : ControllerBase
    {
        // GET: api/<PlantaFamiliaController>
        [HttpGet]
        public JsonResult Get()
        {
            var lista = Registro_Enfermedad.ObtenerRegistro();
            return new JsonResult(lista);

        }
    }
}