using apiMDSF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiMDSF.Controllers
{
    public class CalleController : ApiController
    {
        /// <summary>
        /// Listado de calles de una comuna
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult GetCallesByNameOfComuna(string id)
        {
            ApiMDSFModel model = new ApiMDSFModel();
            return Ok(model.GetCallesByNameOfComuna(id));
        }
      }
}
