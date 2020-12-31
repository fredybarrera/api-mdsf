using apiMDSF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiMDSF.Controllers
{
    public class NumeroController : ApiController
    {
        /// <summary>
        /// Listado números de una calle dentro de una comuna
        /// </summary>
        /// <param name="calle"></param>
        /// <param name="comuna"></param>
        /// <returns></returns>
        public IHttpActionResult GetNumerosByNameOfCalleComuna(string calle, string comuna)
        {
            ApiMDSFModel model = new ApiMDSFModel();
            return Ok(model.GetNumerosByNameOfCalleComuna(calle,comuna));
        }
    }
}
