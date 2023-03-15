using System.Data;
using System.Data.SqlClient;
using OfQuala.Connection;
using OfQuala.Model;

namespace OfQuala.Data
{
    public class Sites
    {
        Connectionbd cn = new Connectionbd();

        public async Task<List<Site>> ViewSite()
        {
            var listProd = new List<Site>();
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("Sp_view_sites", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync())
                        {
                            var msites = new Site();
                            msites.codigo = (int)item["codigo"];
                            msites.descripcion = (string)item["descripcion"];
                            msites.direccion = (string)item["direccion"];
                            msites.identificacion = (string)item["identificacion"];
                            msites.fecha_Creacion = (DateTime)item["fecha_creacion"];
                            msites.moneda = (string)item["moneda"];

                            listProd.Add(msites);
                        }

                    }
                }
            }
            return listProd;
        }

        public async Task<List<Site>> ViewSiteId(int codigo)
        {
            var listProd = new List<Site>();
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("Sp_view_sites_id", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    await sql.OpenAsync();
                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync())
                        {
                            var msites = new Site();
                            msites.codigo = (int)item["codigo"];
                            msites.descripcion = (string)item["descripcion"];
                            msites.direccion = (string)item["direccion"];
                            msites.identificacion = (string)item["identificacion"];
                            msites.fecha_Creacion = (DateTime)item["fecha_creacion"];
                            msites.moneda = (string)item["moneda"];

                            listProd.Add(msites);
                        }

                    }
                }
            }
            return listProd;
        }        

        public async Task InsertSite(Site param)
        {
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("Sp_insert_sites", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", param.codigo);
                    cmd.Parameters.AddWithValue("@descripcion", param.descripcion);
                    cmd.Parameters.AddWithValue("@direccion", param.direccion); 
                    cmd.Parameters.AddWithValue("@identificacion", param.identificacion);
                    cmd.Parameters.AddWithValue("@fecha_creacion", param.fecha_Creacion);
                    cmd.Parameters.AddWithValue("@moneda", param.moneda);

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task EditSite(Site param)
        {
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("Sp_edit_sites", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", param.codigo);
                    cmd.Parameters.AddWithValue("@descripcion", param.descripcion);
                    cmd.Parameters.AddWithValue("@direccion", param.direccion);
                    cmd.Parameters.AddWithValue("@identificacion", param.identificacion);
                    cmd.Parameters.AddWithValue("@fecha_creacion", param.fecha_Creacion);
                    cmd.Parameters.AddWithValue("@moneda", param.moneda);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteSite(int codigo)
        {
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("Sp_delete_sites", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
