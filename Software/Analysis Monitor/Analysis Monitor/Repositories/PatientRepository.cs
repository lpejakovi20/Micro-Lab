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
        public static void InsertPatient(string IdPatient, string FirstName, string LastName, string PhoneNum, string Email, DateTime BirthDate, string ResidentialAddress)
        {
            SqlConnection db = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=lpejakovi20_DB;Persist Security Info=True;User ID=lpejakovi20;Password=Q=}o18]E");
            SqlCommand cmd = new SqlCommand("INSERT INTO Patients (IdPatient, FirstName, LastName, PhoneNum, Email, ResidentialAddress, BirthDate) VALUES (@IdPatient, @FirstName, @LastName, @PhoneNum, @Email, @ResidentialAddress, @BirthDate)",db);
            db.Open();
            cmd.Parameters.AddWithValue("@IdPatient",IdPatient);
            cmd.Parameters.AddWithValue("@FirstName",FirstName);
            cmd.Parameters.AddWithValue("@LastName",LastName);
            cmd.Parameters.AddWithValue("@PhoneNum",PhoneNum);
            cmd.Parameters.AddWithValue("@Email",Email);
            cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
            cmd.Parameters.AddWithValue("@ResidentialAddress", ResidentialAddress);
            cmd.ExecuteNonQuery();
            db.Close();
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
