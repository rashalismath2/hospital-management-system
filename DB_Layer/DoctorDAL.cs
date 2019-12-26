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
    public class DoctorDAL
    {
        #region select * doctor
        public List<Doctor> Select()
        {
            List<Doctor> doctors = null;

            string sql = "select * from doctor;";
            using (MySqlConnection connection = new MySqlConnection(Helper.Connection("ap")))
            {
                doctors = connection.Query<Doctor>(sql).ToList();

            }
            return doctors;
        }
        #endregion



    }
}