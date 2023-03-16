using OfQuala.Model;
using System.Data.SqlClient;
using System.Data;
using OfQuala.Connection;

namespace OfQuala.Data
{
    public class Currencys
    {
        Connectionbd cn = new Connectionbd();
        public async Task<List<Currency>> ViewCurrency()
        {
            var listCurrency = new List<Currency>();
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("Sp_view_currency", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync())
                        {
                            var mcurrency = new Currency();
                            mcurrency.id = (int)item["id"];
                            mcurrency.nombre = (string)item["nombre"];

                            listCurrency.Add(mcurrency);
                        }

                    }
                }
            }
            return listCurrency;
        }
    }
}
