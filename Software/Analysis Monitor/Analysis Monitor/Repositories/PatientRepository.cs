using DBLayer;
using Analysis_Monitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Analysis_Monitor.Repositories
{
    public class PatientRepository
    {
        public static Patient GetPatient(string id)
        {
            Patient patient = null;

            string sql = $"SELECT * FROM Patients WHERE IdPatient = '" + id + "'";
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                patient = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return patient;
        }

        private static Patient CreateObject(SqlDataReader reader)
        {
            string idPatient = reader["IdPatient"].ToString();
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string phoneNum = reader["PhoneNum"].ToString();
            string email = reader["Email"].ToString();
            DateTime birthDate = DateTime.Parse(reader["BirthDate"].ToString());
            string residentialAddress = reader["ResidentialAddress"].ToString();
            var patient = new Patient
            {
                IdPatient = idPatient,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNum,
                Email = email,
                BirthDate = birthDate,
                ResidentialAddress = residentialAddress
            };

            return patient;
        }
    }
}
