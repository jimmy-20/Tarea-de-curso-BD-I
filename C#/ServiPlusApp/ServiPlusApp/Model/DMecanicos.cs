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

        public static void Insertar_Mecanico(string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido,
                                             string Especialidad, decimal Salario, string Direccion, string Telefono, string Correo)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Insertar_Mecanico",
                    CommandType = CommandType.StoredProcedure
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

                SqlParameter ParEspecialidad = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Especialidad",
                    Value = Especialidad
                };

                SqlParameter ParSalario = new SqlParameter()
                {
                    SqlDbType = SqlDbType.Decimal,
                    ParameterName = "Salario",
                    Value = Salario
                };

                SqlParameter ParDireccion = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Dirrecion",
                    Value = Direccion
                };

                SqlParameter ParTelefono = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Telefono",
                    Value = Telefono
                };

                SqlParameter ParCorreo = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Correo",
                    Value = Correo
                };

                comando.Parameters.Add(ParPrimerNombre);
                comando.Parameters.Add(ParSegundoNombre);
                comando.Parameters.Add(ParPrimerApellido);
                comando.Parameters.Add(ParSegundoApellido);
                comando.Parameters.Add(ParEspecialidad);
                comando.Parameters.Add(ParSalario);
                comando.Parameters.Add(ParDireccion);
                comando.Parameters.Add(ParTelefono);
                comando.Parameters.Add(ParCorreo);

                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Insertar_Mecanico",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Editar_Mecanico(int IdMecanico, string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido,
                                             string Especialidad, decimal Salario, string Direccion, string Telefono, string Correo)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Editar_Mecanico",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdMecanico = new SqlParameter()
                {
                    SqlDbType = SqlDbType.Int,
                    ParameterName = "IdMecanico",
                    Value = IdMecanico
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

                SqlParameter ParEspecialidad = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Especialidad",
                    Value = Especialidad
                };

                SqlParameter ParSalario = new SqlParameter()
                {
                    SqlDbType = SqlDbType.Decimal,
                    ParameterName = "Salario",
                    Value = Salario
                };

                SqlParameter ParDireccion = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Direccion",
                    Value = Direccion
                };

                SqlParameter ParTelefono = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Telefono",
                    Value = Telefono
                };

                SqlParameter ParCorreo = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "Correo",
                    Value = Correo
                };

                comando.Parameters.Add(ParIdMecanico);
                comando.Parameters.Add(ParPrimerNombre);
                comando.Parameters.Add(ParSegundoNombre);
                comando.Parameters.Add(ParPrimerApellido);
                comando.Parameters.Add(ParSegundoApellido);
                comando.Parameters.Add(ParEspecialidad);
                comando.Parameters.Add(ParSalario);
                comando.Parameters.Add(ParDireccion);
                comando.Parameters.Add(ParTelefono);
                comando.Parameters.Add(ParCorreo);

                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Editar_Mecanico",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
