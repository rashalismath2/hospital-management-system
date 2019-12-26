using BI_Layer;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DB_Layer
{
    public class PatientDAL
    {
        #region Select one patient
        public Patient Select(int id) {
          
            string sql="SELECT * from patient where id=@id;";
            using (MySqlConnection connection=new MySqlConnection(Helper.Connection("ap"))) {
                 Patient patient = connection.QuerySingle<Patient>(sql,new { id=id});
                return patient;
            }
        }
        #endregion
    }
}
