using apiMDSF.Models;
using System.Web.Http;

namespace apiMDSF.Controllers
{
    public class RegionController : ApiController
    {
        /// <summary>
        /// Listado de regiones
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAllRegiones()
        {
            ApiMDSFModel model = new ApiMDSFModel();
            return Ok(model.GetAllRegiones());
        }

    }
}
