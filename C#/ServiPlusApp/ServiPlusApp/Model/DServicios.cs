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
    public class DServicios
    {
        public static DataTable Mostrar_Servicios()
        {
            DataTable DtResultado = new DataTable("Mostrar_Servicios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //Cargar la conexion del servidor 
                sqlCon.ConnectionString = Connection.conexion;

                //Creando un objeto SQLCommand que llamara al procedimiento almacenado
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Mostrar_Servicios",
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

        public static DataTable Buscar_Servicio(string dato)
        {

            DataTable DtResultado = new DataTable("Buscar_Servicio");

            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = Connection.conexion;

                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Buscar_Servicio",
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

        public static void Cambiar_Estado_Servicio(int IdUsuario)
        {
            SqlConnection conexion = new SqlConnection(Connection.conexion);
            conexion.Open();

            try
            {
                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "Cambiar_Estado_Servicio"
                };

                SqlParameter parIdUsuario = new SqlParameter()
                {
                    ParameterName = "IdServicio",
                    SqlDbType = SqlDbType.Int,
                    Value = IdUsuario,
                };

                comando.Parameters.Add(parIdUsuario);

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message,"Error en BD",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Insertar_Servicio(string Descripcion, decimal Precio, string Tipo)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();
                SqlCommand comando = new SqlCommand()
                {
                    CommandText = "Insertar_Servicio",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conexion
                };

                SqlParameter ParDescripcion = new SqlParameter()
                {
                    ParameterName =  "Descripcion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Descripcion
                };

                SqlParameter ParPrecio = new SqlParameter()
                {
                    ParameterName = "Precio",
                    SqlDbType = SqlDbType.Decimal,
                    Value = Precio
                };

                SqlParameter ParTipo = new SqlParameter()
                {
                    ParameterName = "Tipo",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 15,
                    Value = Tipo
                };

                comando.Parameters.Add(ParDescripcion);
                comando.Parameters.Add(ParPrecio);
                comando.Parameters.Add(ParTipo);

                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Insertar_Servicio",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Editar_Servicio(int IdServicio ,string Descripcion, decimal Precio, string Tipo)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();
                SqlCommand comando = new SqlCommand()
                {
                    CommandText = "Editar_Servicio",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conexion
                };

                SqlParameter ParIdServicio = new SqlParameter()
                {
                    ParameterName = "IdServicio",
                    SqlDbType = SqlDbType.Int,
                    Value = IdServicio
                };

                SqlParameter ParDescripcion = new SqlParameter()
                {
                    ParameterName = "Descripcion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Descripcion
                };

                SqlParameter ParPrecio = new SqlParameter()
                {
                    ParameterName = "Precio",
                    SqlDbType = SqlDbType.Decimal,
                    Value = Precio
                };

                SqlParameter ParTipo = new SqlParameter()
                {
                    ParameterName = "Tipo",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 15,
                    Value = Tipo
                };

                comando.Parameters.Add(ParIdServicio);
                comando.Parameters.Add(ParDescripcion);
                comando.Parameters.Add(ParPrecio);
                comando.Parameters.Add(ParTipo);

                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Editar_Servicio",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
