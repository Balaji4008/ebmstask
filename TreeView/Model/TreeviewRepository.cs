using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace TreeView.Model
{
   
        public class TreeviewRepository: ITreeviewRepository
    {
        IConfiguration _configuration;

        public TreeviewRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public List<TreeviewModel> GetList()
        {
            var connectionString = this.GetConnection();
            List<TreeviewModel> catyegorylist = new List<TreeviewModel>();

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECT * FROM treedata";
                    catyegorylist = con.Query<TreeviewModel>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return catyegorylist;
            }
        }
        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("TreeContext").Value;
            return connection;
        }
    }
}
