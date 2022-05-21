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

            SqlConnection DB = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=lpejakovi20_DB;Persist Security Info=True;User ID=lpejakovi20;Password=Q=}o18]E");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Patients WHERE IdPatient = '" + id +"'", DB);
            DB.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                patient = CreateObject(reader);
                reader.Close();
            }

            DB.Close();
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
