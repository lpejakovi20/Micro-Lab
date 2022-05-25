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
    public class SampleRepository
    {
        public static Sample GetSample(int id)
        {
            Sample sample = null;

            string sql = $"SELECT * FROM Samples WHERE IdSample = '" + id + "'";
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);
   
            if (reader.HasRows)
            {
                reader.Read();
                sample = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return sample;
        }

        public static List<Sample> GetSamples()
        {
            var samples = new List<Sample>();
            string sql = $"SELECT * FROM Samples";
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Sample sample = CreateObject(reader);
                samples.Add(sample);
            }

            reader.Close();
            DB.CloseConnection();
            return samples;
        }
        public static Sample GetMaxID()
        {
            Sample sample = null;

            string sql = $"SELECT * FROM Samples WHERE IdSample=(SELECT MAX(IdSample) FROM Samples)";
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                sample = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return sample;
        }

        public static void InsertSample(string IdPatient, DateTime TimeOfReceipt, string IdEmployee, string SampleType, string SampleInfo)
        {
            SqlConnection db = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=lpejakovi20_DB;Persist Security Info=True;User ID=lpejakovi20;Password=Q=}o18]E");
            SqlCommand cmd = new SqlCommand("INSERT INTO Samples (IdPatient,TimeOfReceipt,IdEmployee,SampleType,SampleInfo) VALUES (@IdPatient, @TimeOfReceipt, @IdEmployee,@SampleType,@SampleInfo)", db);
            db.Open();
            cmd.Parameters.AddWithValue("@IdPatient", IdPatient);
            cmd.Parameters.AddWithValue("@SampleType", SampleType);
            cmd.Parameters.AddWithValue("@SampleInfo", SampleInfo);
            cmd.Parameters.AddWithValue("@TimeOfReceipt", TimeOfReceipt);
            cmd.Parameters.AddWithValue("@IdEmployee", IdEmployee);
            cmd.ExecuteNonQuery();
            db.Close();
        }

        public static void UpdateSample(string IdEmployee, string SampleType, string SampleInfo, int IdSample)
        {
            DB.OpenConnection();
            string sql = $"UPDATE Samples SET IdEmployee = '" + IdEmployee + "', SampleType = '" + SampleType + "', SampleInfo = '" + SampleInfo + "' WHERE IdSample = '" + IdSample + "'";
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteSample(int IdSample)
        {
            string sql = $"DELETE FROM Samples WHERE IdSample = '" + IdSample + "'";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void RefreshTable()
        {
            DB.OpenConnection();
            string sql = $"TRUNCATE TABLE Samples";
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        private static Sample CreateObject(SqlDataReader reader)
        {
            int idSample = int.Parse(reader["IdSample"].ToString());
            string idPatient = reader["IdPatient"].ToString();
            DateTime timeOfReceipt = DateTime.Parse(reader["TimeOfReceipt"].ToString());
            string idEmployee = reader["IdEmployee"].ToString();
            string sampleType = reader["SampleType"].ToString();
            string sampleInfo = reader["SampleInfo"].ToString();

            var sample = new Sample
            {
                IdSample = idSample,
                IdPatient = idPatient,
                TimeOfReceipt = timeOfReceipt,
                IdEmployee = idEmployee,
                SampleInfo = sampleInfo,
                SampleType = sampleType
            };

            return sample;
        }

        
    }
}
