using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaData
{
    public abstract class CRUD_SuperClass
    {
        string ConnectionString = @"Server=MGTMGTMD0110\MAINSERVER;Database=Tareasdb;Trusted_Connection=True";
        public string GeneralQuery { get; set; } = string.Empty;
        public string VisualizerName { get; set; } = string.Empty;
        public DataSet dataSet { get; set; } = new DataSet();
        


        public void CreateRegister(string Query)
        {
            
            SqlConnection CreateConnection = new SqlConnection(ConnectionString);
            CreateConnection.Open();
            //Query = "Query to Data base";
            SqlCommand cmd = new SqlCommand(Query, CreateConnection);
            cmd.ExecuteNonQuery();
            CreateConnection.Close();
        }

        public DataSet ReadRegister(string Query, string DataVisualizer, DataSet dataS)
        {
            SqlConnection ReadConnection = new SqlConnection(ConnectionString);
            ReadConnection.Open();  
            SqlDataAdapter adapter = new SqlDataAdapter(Query,ReadConnection);            
            adapter.Fill(dataS, DataVisualizer);
            return dataS;
        }

        public void UpdatedRegister(string Query)
        {
            SqlConnection UpdateConnection = new SqlConnection(ConnectionString);
            UpdateConnection.Open();
            SqlCommand cmd = new SqlCommand(Query,UpdateConnection);
            cmd.ExecuteNonQuery();
            UpdateConnection.Close();
        }

        public void DeleteRegister(string Query)
        {
            SqlConnection DeleteRegister = new SqlConnection(ConnectionString);
            DeleteRegister.Open();
            SqlCommand cmd = new SqlCommand(Query,DeleteRegister);
            cmd.ExecuteNonQuery();
            DeleteRegister.Close();

        }



    }
}
