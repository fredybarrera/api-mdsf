using apiMDSF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiMDSF.Models
{
    public class ApiMDSFModel
    {
        ConexionDB con = new ConexionDB();
        public object GetAllRegiones()
        {
            return con.GetAllRegiones();
        }

        public object GetProvinciasByNameOfRegion(string region)
        {
            return con.GetProvinciasByNameOfRegion(region);
        }
        public object GetComunasByNameOfProvincia(string provincia)
        {
            return con.GetComunasByNameOfProvincia(provincia);
        }

        public object GetCallesByNameOfComuna(string comuna)
        {
            return con.GetCallesByNameOfComuna(comuna);
        }
        public object GetNumerosByNameOfCalleComuna(string calle, string comuna)
        {
            return con.GetNumerosByNameOfCalleComuna(calle, comuna);
        }
        public object GetRegistroByNameOfNumCalleComuna(string numero, string calle, string comuna)
        {
            return con.GetRegistroByNameOfNumCalleComuna(numero, calle, comuna);
        }

        public object GetComunasByNameOfRegion(string region)
        {
            return con.GetComunasByNameOfRegion(region);
        }


        public object InsertaRegistro(Registro registro)
        {
            return con.InsertaRegistro(registro);
        }
    }
}