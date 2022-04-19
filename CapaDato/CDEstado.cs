using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
    internal class CDEstado
    {
        string ConexionString = @"Server=MGTMGTMD0110\MAINSERVER;Database= Tareasdb;Trusted_Connection=True";

        public void Pruebadb()
        {
            SqlConnection prubaconexion = new SqlConnection(ConexionString);
            try
            {
                prubaconexion.Open();
                MessageBox.Show("Conectado");

                prubaconexion.Close();
                MessageBox.Show("Desconectado");


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                throw;
            }
        }


    }
}
