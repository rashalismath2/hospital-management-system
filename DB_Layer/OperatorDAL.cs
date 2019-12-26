using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BI_Layer;
using MySql.Data.MySqlClient;
using Dapper;

namespace DB_Layer
{
    public class OperatorDAL
    {
        #region select * operators
        public List<BI_Layer.Operator> Select()
        {
            List<Operator> operators = null;

            string sql = "select * from operator;";
            using (MySqlConnection connection = new MySqlConnection(Helper.Connection("ap")))
            {
                operators = connection.Query<Operator>(sql).ToList();

            }
            return operators;
        }
        #endregion

        #region select * from operators where email
        public Operator getOperatorByEmail(string email) {

            string sql = "SELECT * from operator where email=@email;";
            using (MySqlConnection connection = new MySqlConnection(Helper.Connection("ap")))
            {
                Operator Operator = connection.QuerySingleOrDefault<Operator>(sql, new { email = email });
                return Operator;
            }
        }

        #endregion

    }
}
