using apiMDSF.Models;
using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Net.Http;

namespace apiMDSF.Data
{
    public class ConexionDB
    {
        NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        Estado est = new Estado();
        public object GetAllRegiones()
        {
            string JSONresult;
            try
            {
                String query = "select distinct(t_reg_nom) from public.banco_direcciones order by t_reg_nom;";
                conn.Open();
                NpgsqlCommand comand = new NpgsqlCommand(query, conn);
                NpgsqlDataAdapter ad = new NpgsqlDataAdapter(comand);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conn.Close();
                if (dt.Rows.Count == 0)
                {
                    est.estado = false;
                    est.mensaje = "La consulta no devolvió datos";
                    return JsonConvert.SerializeObject(est); ;
                }
                JSONresult = JsonConvert.SerializeObject(dt);
                return JSONresult;
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(ex.Message);
            }
        }

        public object GetProvinciasByNameOfRegion(string region)
        {
            string JSONresult;
            try
            {
                String query = "select distinct(t_prov_nom) from public.banco_direcciones where t_reg_nom = @region order by t_prov_nom;";
                conn.Open();
                NpgsqlCommand comand = new NpgsqlCommand(query, conn);
                comand.Parameters.AddWithValue("@region", region);
                NpgsqlDataAdapter ad = new NpgsqlDataAdapter(comand);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conn.Close();
                if (dt.Rows.Count == 0)
                {
                    est.estado = false;
                    est.mensaje = "La consulta no devolvió datos";
                    return JsonConvert.SerializeObject(est); ;
                }
                JSONresult = JsonConvert.SerializeObject(dt);
                return JSONresult;
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(ex.Message);
            }
        }

        public object GetComunasByNameOfProvincia(string provincia)
        {
            string JSONresult;
            try
            {
                String query = "select distinct(t_com_nom) from public.banco_direcciones where t_prov_nom = @provincia order by t_com_nom;";
                conn.Open();
                NpgsqlCommand comand = new NpgsqlCommand(query, conn);
                comand.Parameters.AddWithValue("@provincia", provincia);
                NpgsqlDataAdapter ad = new NpgsqlDataAdapter(comand);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conn.Close();
                if (dt.Rows.Count == 0)
                {
                    est.estado = false;
                    est.mensaje = "La consulta no devolvió datos";
                    return JsonConvert.SerializeObject(est); ;
                }
                JSONresult = JsonConvert.SerializeObject(dt);
                return JSONresult;
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(ex.Message);
            }
        }

        public object GetCallesByNameOfComuna(string comuna)
        {
            try
            {
                string JSONresult;
                String query = "select distinct(stname) from public.banco_direcciones where t_com_nom = @comuna order by stname;";
                conn.Open();
                NpgsqlCommand comand = new NpgsqlCommand(query, conn);
                comand.Parameters.AddWithValue("@comuna", comuna);
                NpgsqlDataAdapter ad = new NpgsqlDataAdapter(comand);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conn.Close();
                if (dt.Rows.Count == 0)
                {
                    est.estado = false;
                    est.mensaje = "La consulta no devolvió datos";
                    return JsonConvert.SerializeObject(est); ;
                }
                JSONresult = JsonConvert.SerializeObject(dt);
                return JSONresult;
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(ex.Message);
            }
        }

        public object GetNumerosByNameOfCalleComuna(string calle, string comuna)
        {
            string JSONresult;
            try
            {
                String query = "select distinct(addnum) from public.banco_direcciones where stname = @calle and t_com_nom = @comuna order by addnum; ";
                conn.Open();
                NpgsqlCommand comand = new NpgsqlCommand(query, conn);
                comand.Parameters.AddWithValue("@calle", calle);
                comand.Parameters.AddWithValue("@comuna", comuna);
                NpgsqlDataAdapter ad = new NpgsqlDataAdapter(comand);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conn.Close();
                if (dt.Rows.Count == 0)
                {
                    est.estado = false;
                    est.mensaje = "La consulta no devolvió datos";
                    return JsonConvert.SerializeObject(est); ;
                }
                JSONresult = JsonConvert.SerializeObject(dt);
                return JSONresult;
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(ex.Message);
            }
        }

        public object GetRegistroByNameOfNumCalleComuna(string numero, string calle, string comuna)
        {
            string JSONresult;
            try
            {
                String query = "select * from public.banco_direcciones where addnum = @numero and stname = @calle and t_com_nom = @comuna;";
                conn.Open();
                NpgsqlCommand comand = new NpgsqlCommand(query, conn);
                comand.Parameters.AddWithValue("@numero", numero);
                comand.Parameters.AddWithValue("@calle", calle);
                comand.Parameters.AddWithValue("@comuna", comuna);
                NpgsqlDataAdapter ad = new NpgsqlDataAdapter(comand);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conn.Close();

                if (dt.Rows.Count == 0)
                {

                    est.estado = false;
                    est.mensaje = "La consulta no devolvió datos";
                    return JsonConvert.SerializeObject(est); ;
                }

                JSONresult = JsonConvert.SerializeObject(dt);
                return JSONresult;
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(ex.Message);
            }
        }


        public object GetComunasByNameOfRegion(string region)
        {
            string JSONresult;
            try
            {

                String query = "select distinct t_com_nom from public.banco_direcciones  where t_reg_nom = @region order by t_com_nom;";
                conn.Open();
                NpgsqlCommand comand = new NpgsqlCommand(query, conn);
                comand.Parameters.AddWithValue("@region", region);
                NpgsqlDataAdapter ad = new NpgsqlDataAdapter(comand);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conn.Close();
                if (dt.Rows.Count == 0)
                {
                    est.estado = false;
                    est.mensaje = "La consulta no devolvió datos";
                    return JsonConvert.SerializeObject(est); ;
                }
                JSONresult = JsonConvert.SerializeObject(dt);
                return JSONresult;
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(ex.Message);
            }
        }



        public object InsertaRegistro(Registro registro)
        {
            string JSONresult;
            try
            {

                //String query = "insert into public.banco_direcciones(addnum,stname,displayx_d,displayy_d,t_com_nom,t_prov_nom,t_reg_nom,fuente) values(@Numero,@Calle,@X,@Y,@Comuna,@Provincia,@Region,@Fuente)";
                String query = "insert into public.banco_direcciones(displayx_d,displayy_d,t_reg_nom,t_prov_nom,t_com_nom,t_id_uv_ca,t_uv_nom,t_reg_ca,t_prov_ca,t_com,uv_carto,addnum,stname,fuente) values(@Displayx_d,@Displayy_d,@T_reg_nom,@T_prov_nom,@T_com_nom,@T_id_uv_ca,@T_uv_nom,@T_reg_ca,@T_prov_ca,@T_com,@Uv_carto,@Addnum,@Stname,@Fuente)";
                conn.Open();
                NpgsqlCommand comand = new NpgsqlCommand(query, conn);
                // comand.Parameters.AddWithValue("@Numero", registro.Numero);//addnum
                // comand.Parameters.AddWithValue("@Calle", registro.Calle);//stname
                // comand.Parameters.AddWithValue("@X", registro.X);//displayx_d
                // comand.Parameters.AddWithValue("@Y", registro.Y);//displayy_d
                // comand.Parameters.AddWithValue("@Comuna", registro.Comuna);//t_com_nom
                // comand.Parameters.AddWithValue("@Provincia", registro.Provincia);//t_prov_nom
                // comand.Parameters.AddWithValue("@Region", registro.Region);//t_reg_nom
                // comand.Parameters.AddWithValue("@Fuente", registro.Fuente);//fuente

                comand.Parameters.AddWithValue("@Displayx_d", registro.Displayx_d);
                comand.Parameters.AddWithValue("@Displayy_d", registro.Displayy_d);
                comand.Parameters.AddWithValue("@T_reg_nom", registro.T_reg_nom);
                comand.Parameters.AddWithValue("@T_prov_nom", registro.T_prov_nom);
                comand.Parameters.AddWithValue("@T_com_nom", registro.T_com_nom);
                comand.Parameters.AddWithValue("@T_id_uv_ca", registro.T_id_uv_ca);
                comand.Parameters.AddWithValue("@T_uv_nom", registro.T_uv_nom);
                comand.Parameters.AddWithValue("@T_reg_ca", registro.T_reg_ca);
                comand.Parameters.AddWithValue("@T_prov_ca", registro.T_prov_ca);
                comand.Parameters.AddWithValue("@T_com", registro.T_com);
                comand.Parameters.AddWithValue("@Uv_carto", registro.Uv_carto);
                comand.Parameters.AddWithValue("@Addnum", registro.Addnum);
                comand.Parameters.AddWithValue("@Stname", registro.Stname);
                comand.Parameters.AddWithValue("@Fuente", registro.Fuente);


                // JSONresult = JsonConvert.SerializeObject((comand.ExecuteNonQuery() == 1 ? "Registro insertado correctamente" : "No se ha podido ingresar el registro"));
                if (comand.ExecuteNonQuery() == 1)
                {
                    est.estado = true;
                    est.status = 200;
                    est.mensaje = "Registro insertado correctamente";
                }
                else
                {
                    est.estado = false;
                    est.status = 400;
                    est.mensaje = "No se ha podido ingresar el registro";
                }
                conn.Close();
               
                return JsonConvert.SerializeObject(est);
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(ex.Message);
            }
        }


        public object UpdateCoordByNameOfComCalleNum(string comuna, string calle, string numero, string x, string y)
        {
            string JSONresult;
            try
            {

                String query = "update public.banco_direcciones set displayx_d=@Displayx_d, displayy_d=@Displayy_d where t_com_nom=@T_com_nom and stname=@Stname and addnum=@Addnum";
                conn.Open();
                NpgsqlCommand comand = new NpgsqlCommand(query, conn);
                comand.Parameters.AddWithValue("@T_com_nom", comuna);//lmunic
                comand.Parameters.AddWithValue("@Stname", calle);//stname
                comand.Parameters.AddWithValue("@Addnum", numero);//addnum
                comand.Parameters.AddWithValue("@Displayx_d", x);//x
                comand.Parameters.AddWithValue("@Displayy_d", y);//y

                JSONresult = JsonConvert.SerializeObject((comand.ExecuteNonQuery() == 1 ? "Registro actualizado correctamente" : "No se ha podido actualizar el registro"));
                conn.Close();
                return JSONresult;

            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(ex.Message);
            }
        }
    }
}