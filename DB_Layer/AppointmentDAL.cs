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
    public class AppointmentDAL
    {
        Patient patient = null;
        #region adding a record
        public int Add(Appointment appointment) {
            int affectedRows;
            string sql = "INSERT INTO doctor_has_patient (date,appointment_no,patient_id,doctor_id) values (@date,@appointment_no,@patient_id,@doctor_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.Connection("ap")))
            {
                affectedRows = connection.Execute(sql, new {
                                    date =appointment.date,
                                    appointment_no =appointment.appointment_no,
                                    doctor_id=appointment.doctor_id,
                                    patient_id=appointment.patient_id});
               
            }
            return affectedRows;
    }
        #endregion

        #region delete appointment
        public int Delete(Appointment appointment)
        {
            int affectedRows;
            string sql =@"DELETE FROM doctor_has_patient where 
                            date=@date,
                            appointment_no=@appointment_no,
                            patient_id=@patient_id,
                            doctor_id=@doctor_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.Connection("ap")))
            {
                affectedRows = connection.Execute(sql, new
                {
                    date = appointment.date,
                    appointment_no = appointment.appointment_no,
                    doctor_id = appointment.doctor_id,
                    patient_id = appointment.patient_id
                });

            }
            return affectedRows;
        }

        #endregion
    }
}
