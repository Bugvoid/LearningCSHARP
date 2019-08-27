using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WFornecedor
{
    /// <summary>
    /// Descrição resumida de ServiceDB
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceDB : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Olá, Mundo";
        }

        [WebMethod]
        public DataTable GetDados()
        {
            string contr = ConfigurationManager.ConnectionStrings["conexaoProdutos"].ConnectionString;
            using (SqlConnection con = new SqlConnection(contr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Produtos"))
                {
                    using(SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using(DataTable dt = new DataTable())
                        {
                            dt.TableName = "Produtos";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
    }
}
