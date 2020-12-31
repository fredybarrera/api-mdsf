using apiMDSF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiMDSF.Controllers
{
    public class ProvinciaController : ApiController
    {
        /// <summary>
        /// Listado de provincias de una región
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult GetProvinciasByNameRegion(string id)
        {
            ApiMDSFModel model = new ApiMDSFModel();
            return Ok(model.GetProvinciasByNameOfRegion(id));
        }
    }
}
