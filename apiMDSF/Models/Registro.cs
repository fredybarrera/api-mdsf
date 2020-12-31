using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiMDSF.Models
{
    public class Registro
    {
        /// <summary>
        /// Número de la propiedad
        /// </summary>
        public string Addnum { get; set; }//addnum
        /// <summary>
        /// Nombre de la calle
        /// </summary>
        public string Stname { get; set; }//stname
        /// <summary>
        /// ubicación displayx_d
        /// </summary>
        public string Displayx_d { get; set; }//displayx_d
        /// <summary>
        /// ubicación displayy_d
        /// </summary>
        public string Displayy_d { get; set; }//displayy_d
        /// <summary>
        /// Nombre de la comuna
        /// </summary>
        public string T_com_nom { get; set; }//t_com_nom
        /// <summary>
        /// Nombre de la Provincia
        /// </summary>
        public string T_prov_nom { get; set; }//t_prov_nom
        /// <summary>
        /// Nombre de la Región
        /// </summary>
        public string T_reg_nom { get; set; }//t_reg_nom
        /// <summary>
        /// Nombre de la Fuente
        /// </summary>
        public string Fuente { get; set; }//fuente
		/// <summary>
		/// Nombre t_id_uv_ca
		/// </summary>
		public string T_id_uv_ca { get; set; }//t_id_uv_ca
		/// <summary>
		/// Nombre t_uv_nom
		/// </summary>
		public string T_uv_nom { get; set; }//t_uv_nom
		/// <summary>
		/// Nombre t_reg_ca
		/// </summary>
		public string T_reg_ca { get; set; }//t_reg_ca
		/// <summary>
		/// Nombre t_prov_ca
		/// </summary>
		public string T_prov_ca { get; set; }//t_prov_ca
		/// <summary>
		/// Nombre t_com
		/// </summary>
		public string T_com { get; set; }//t_com
		/// <summary>
		/// Nombre uv_carto
		/// </summary>
		public string Uv_carto { get; set; }//uv_carto

    }
}