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

            SqlConnection DB = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=lpejakovi20_DB;Persist Security Info=True;User ID=lpejakovi20;Password=Q=}o18]E");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Samples WHERE IdSample = '" + id + "'", DB);
            DB.Open();
            SqlDataReader reader = cmd.ExecuteReader();
   
            if (reader.HasRows)
            {
                reader.Read();
                sample = CreateObject(reader);
                reader.Close();
            }

            DB.Close();
            return sample;
        }

        public static List<Sample> GetSamples()
        {
            var samples = new List<Sample>();
            SqlConnection DB = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=lpejakovi20_DB;Persist Security Info=True;User ID=lpejakovi20;Password=Q=}o18]E");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Samples", DB);
            DB.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Sample sample = CreateObject(reader);
                samples.Add(sample);
            }

            reader.Close();
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

        /*public static void InsertSample(Sample sample)
        {
            SqlConnection DB = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=lpejakovi20_DB;Persist Security Info=True;User ID=lpejakovi20;Password=Q=}o18]E");
            SqlCommand cmd = new SqlCommand("INSERT INTO Samples (IdPatient,TimeOfReceipt,SampleType,SampleInfo) VALUES ({sample.IdPatient},GETDATE(),{sample.SampleType},{sample.SampleInfo})", DB);
            DB.Open();
            cmd.ExecuteNonQuery();
            DB.Close();
        }
        */
        public static Sample GetMaxID()
        {
            Sample sample = null;

            SqlConnection DB = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=lpejakovi20_DB;Persist Security Info=True;User ID=lpejakovi20;Password=Q=}o18]E");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Samples WHERE IdSample=(SELECT MAX(IdSample) FROM Samples)", DB);
            DB.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                sample = CreateObject(reader);
                reader.Close();
            }
            DB.Close();
            return sample;
        }
    }
}
