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
        public class FamiliaController : ControllerBase
        {
            //GET /api/ENFERMEDAD/all
            [HttpGet("all")]
            public JsonResult ObtenerEnfermedades()
            {
                //json
                var EnfermedadesLocalisadas = ENFERMEDADCONECTION.ObtenerEnfermedades();
                return new JsonResult(EnfermedadesLocalisadas);
            }

            //GET /api/ENFERMEDAD/{idenfermedad}-{nombre_tecnico}
            [HttpGet("{ENFERMEDAD}")]
            public JsonResult ObtenerEnfermedades(string ENFERMEDAD)
            {
                var conversionExitosa = int.TryParse(ENFERMEDAD, out int idConvertido);

                ENFERMEDAD EnfermedadesLocalisadas;

                if (conversionExitosa)
                {
                EnfermedadesLocalisadas = ENFERMEDADCONECTION.ObtenerENFERMEDAD(idConvertido);
                }
                else
                {
                EnfermedadesLocalisadas = ENFERMEDADCONECTION.ObtenerENFERMEDAD(ENFERMEDAD);
                }

                if (EnfermedadesLocalisadas is null)
                {
                    return new JsonResult($"Intente nuevamente con un parametro distinto a {ENFERMEDAD}");
                }
                else
                {
                    return new JsonResult(EnfermedadesLocalisadas);
                }


            }


        }
    }