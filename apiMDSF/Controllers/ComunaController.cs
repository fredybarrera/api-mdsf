using apiMDSF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiMDSF.Controllers
{
    public class ComunaController : ApiController
    {
        /// <summary>
        /// Listado de comunas de una provincia
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult GetComunasByNameOfProvincia(string id)
        {
            ApiMDSFModel model = new ApiMDSFModel();
            return Ok(model.GetComunasByNameOfProvincia(id));
        }
    }
}
