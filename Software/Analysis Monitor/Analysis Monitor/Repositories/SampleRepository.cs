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
    }
}
