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
    public class DClientes
    {
        public static DataTable Tabla_Clientes()
        {
            DataTable DtResultado = new DataTable("Clientes");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //Cargar la conexion del servidor 
                sqlCon.ConnectionString = Connection.conexion;

                //Creando un objeto SQLCommand que llamara al procedimiento almacenado
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Mostrar_Clientes",
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

        public static DataTable Buscar_Cliente(string dato)
        {
            DataTable DtResultado = new DataTable("Buscar_Cliente");

            SqlConnection sqlCon = new SqlConnection();

            try
            {
                //Cargar la conexion del servidor 
                sqlCon.ConnectionString = Connection.conexion;

                //Creando un objeto SQLCommand que llamara al procedimiento almacenado
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Buscar_Cliente",
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

        public static void Cambiar_Estado(int IdCliente)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Cambiar_Estado_Cliente",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter parametro1 = new SqlParameter()
                {
                    ParameterName = "IdCliente",
                    SqlDbType = SqlDbType.Int,
                    Value = IdCliente
                };

                comando.Parameters.Add(parametro1);

                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error interno en BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Insertar_Cliente(string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido,
                                            string Direccion, string Correo, string Telefono)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);

                SqlCommand comando = new SqlCommand()
                {
                    CommandText = "Insertar_Cliente",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conexion
                };

                SqlParameter ParPrimerNombre = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "PrimerNombre",
                    Value = PrimerNombre
                };

                SqlParameter ParSegundoNombre = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "SegundoNombre",
                    Value = SegundoNombre
                };

                SqlParameter ParPrimerApellido = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "PrimerApellido",
                    Value = PrimerApellido
                };

                SqlParameter ParSegundoApellido = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "SegundoApellido",
                    Value = SegundoApellido
                };

                SqlParameter ParDireccion = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Direccion",
                    Value = Direccion
                };

                SqlParameter ParCorreo = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Correo",
                    Value = Correo
                };

                SqlParameter ParTelefono = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Telefono",
                    Value = Telefono
                };

                comando.Parameters.Add(ParPrimerNombre);
                comando.Parameters.Add(ParSegundoNombre);
                comando.Parameters.Add(ParPrimerApellido);
                comando.Parameters.Add(ParSegundoApellido);
                comando.Parameters.Add(ParDireccion);
                comando.Parameters.Add(ParCorreo);
                comando.Parameters.Add(ParTelefono);

                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Insertar_Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void Editar_Cliente(int IdCliente,string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido,
                                            string Direccion, string Correo, string Telefono)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);

                SqlCommand comando = new SqlCommand()
                {
                    CommandText = "Editar_Cliente",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conexion
                };

                SqlParameter ParIdCliente = new SqlParameter()
                {
                    SqlDbType = SqlDbType.Int,
                    ParameterName = "IdCliente",
                    Value = IdCliente
                };

                SqlParameter ParPrimerNombre = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "PrimerNombre",
                    Value = PrimerNombre
                };

                SqlParameter ParSegundoNombre = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "SegundoNombre",
                    Value = SegundoNombre
                };

                SqlParameter ParPrimerApellido = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "PrimerApellido",
                    Value = PrimerApellido
                };

                SqlParameter ParSegundoApellido = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "SegundoApellido",
                    Value = SegundoApellido
                };

                SqlParameter ParDireccion = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Direccion",
                    Value = Direccion
                };

                SqlParameter ParCorreo = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Correo",
                    Value = Correo
                };

                SqlParameter ParTelefono = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Telefono",
                    Value = Telefono
                };

                comando.Parameters.Add(ParIdCliente);
                comando.Parameters.Add(ParPrimerNombre);
                comando.Parameters.Add(ParSegundoNombre);
                comando.Parameters.Add(ParPrimerApellido);
                comando.Parameters.Add(ParSegundoApellido);
                comando.Parameters.Add(ParDireccion);
                comando.Parameters.Add(ParCorreo);
                comando.Parameters.Add(ParTelefono);

                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Editar_Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
