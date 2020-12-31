using apiMDSF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiMDSF.Controllers
{
    public class RegistroController : ApiController
    {
        /// <summary>
        /// Registro completo, dependiendo del número, nombre de calle y comuna
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="calle"></param>
        /// <param name="comuna"></param>
        /// <returns></returns>
        public IHttpActionResult GetRegistroByNameOfNumCalleComuna(string numero, string calle, string comuna)
        {
            ApiMDSFModel model = new ApiMDSFModel();
            return Ok(model.GetRegistroByNameOfNumCalleComuna(numero, calle, comuna));
            
        }
        /// <summary>
        /// Inserta registro
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult InsertaRegistro([FromBody] Registro registro)
        { 
         ApiMDSFModel model = new ApiMDSFModel();
            return Ok(model.InsertaRegistro(registro));
         
        }

    }
}
