using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiPlusApp.Model
{
    public class DMecanicos
    {
        public static DataTable Mostrar_Mecanicos()
        {
            DataTable DtResultado = new DataTable("Mostrar_Mecanicos");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //Cargar la conexion del servidor 
                sqlCon.ConnectionString = Connection.conexion;

                //Creando un objeto SQLCommand que llamara al procedimiento almacenado
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Mostrar_Mecanicos",
                    CommandType = CommandType.StoredProcedure
                };


                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static DataTable Buscar_Mecanico(string dato)
        {

            DataTable DtResultado = new DataTable("Buscar_Mecanico");

            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = Connection.conexion;

                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Buscar_Mecanico",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter parDato = new SqlParameter()
                {
                    ParameterName = "@dato",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Value = dato

                };

                sqlCmd.Parameters.Add(parDato);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception)
            {

                DtResultado = null;
            }

            return DtResultado;
        }

        public static void Cambiar_Estado_Mecanico(int IdMecanico)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "Cambiar_Estado_Mecanico"
                };

                SqlParameter parIdMecanico = new SqlParameter()
                {
                    SqlDbType = SqlDbType.Int,
                    Value = IdMecanico,
                    ParameterName = "IdMecanico"
                };

                comando.Parameters.Add(parIdMecanico);

                comando.ExecuteNonQuery();
            }catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error en BD",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
