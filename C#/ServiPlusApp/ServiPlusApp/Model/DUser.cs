using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ServiPlusApp.Model
{
    class DUser
    {
        public static DataTable Validar_Acceso(string username, string passWord)
        {
            DataTable DtResultado = new DataTable("Iniciar_Sesión");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //Cargar la conexion del servidor 
                sqlCon.ConnectionString = Connection.conexion;

                //Creando un objeto SQLCommand que llamara al procedimiento almacenado

                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Validar_Acceso",
                    CommandType = CommandType.StoredProcedure
                };

                //Cargando los parametros del procedimiento almacenado
                SqlParameter parUser = new SqlParameter
                {
                    ParameterName = "@usuario",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value = username
                };
                sqlCmd.Parameters.Add(parUser);

                SqlParameter parPassWord = new SqlParameter
                {
                    ParameterName = "@contraseña",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Value = passWord
                };
                sqlCmd.Parameters.Add(parPassWord);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        public static DataTable Crear_Usuario(string nombre, string apellido, string telefono, string especialidad, string rol, string username, string passWord)
        {
            DataTable DtResultado = new DataTable("Crear_Usuario");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //Cargar la conexion del servidor 
                sqlCon.ConnectionString = Connection.conexion;

                //Creando un objeto SQLCommand que llamara al procedimiento almacenado
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Crear_Usuario",
                    CommandType = CommandType.StoredProcedure
                };

                //Cargando los parametros del procedimiento almacenado
                SqlParameter parNombre = new SqlParameter
                {
                    ParameterName = "@FirstName",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 80,
                    Value = nombre
                };
                sqlCmd.Parameters.Add(parNombre);

                SqlParameter parApellido = new SqlParameter
                {
                    ParameterName = "@LastName",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 80,
                    Value = apellido
                };
                sqlCmd.Parameters.Add(parApellido);

                SqlParameter parTelefono = new SqlParameter
                {
                    ParameterName = "@Telefono",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 80,
                    Value = telefono
                };
                sqlCmd.Parameters.Add(parTelefono);

                SqlParameter parEspecialidad = new SqlParameter
                {
                    ParameterName = "@Especialidad",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 80,
                    Value = especialidad
                };
                sqlCmd.Parameters.Add(parEspecialidad);

                SqlParameter parUsername = new SqlParameter
                {
                    ParameterName = "@username",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 80,
                    Value = especialidad
                };
                sqlCmd.Parameters.Add(parUsername);

                SqlParameter parPassword = new SqlParameter
                {
                    ParameterName = "@contraseña",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 80,
                    Value = passWord
                };
                sqlCmd.Parameters.Add(parPassword);

                SqlParameter parRol = new SqlParameter
                {
                    ParameterName = "@rol",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value = rol
                };
                sqlCmd.Parameters.Add(parRol);



                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DtResultado = null;
            }
            return DtResultado;
        }

        public static DataTable Validar_Creacion_Usuario(string username, string passWord)
        {
            DataTable DtResultado = new DataTable("Validar_Creacion");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //Cargar la conexion del servidor 
                sqlCon.ConnectionString = Connection.conexion;

                //Creando un objeto SQLCommand que llamara al procedimiento almacenado

                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Validar_Creacion_Usuario",
                    CommandType = CommandType.StoredProcedure
                };

                //Cargando los parametros del procedimiento almacenado
                SqlParameter parUser = new SqlParameter
                {
                    ParameterName = "@usuario",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value = username
                };
                sqlCmd.Parameters.Add(parUser);


                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static DataTable Tabla_Usuarios()
        {
            DataTable DtResultado = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //Cargar la conexion del servidor 
                sqlCon.ConnectionString = Connection.conexion;

                //Creando un objeto SQLCommand que llamara al procedimiento almacenado
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Mostrar_Usuarios",
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

        public static DataTable Buscar_Usuario(string dato)
        {
            DataTable DtResultado = new DataTable("Buscar_Usuario");

            SqlConnection sqlCon = new SqlConnection();

            try
            {
                //Cargar la conexion del servidor 
                sqlCon.ConnectionString = Connection.conexion;

                //Creando un objeto SQLCommand que llamara al procedimiento almacenado
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Buscar_Usuario",
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

        public static void Cambiar_Estado_Usuario(int IdUsuario)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    CommandText = "Cambiar_Estado_Usuario",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conexion
                };

                SqlParameter parIdUsuario = new SqlParameter()
                {
                    ParameterName = "IdUsuario",
                    SqlDbType = SqlDbType.Int,
                    Value = IdUsuario
                };

                comando.Parameters.Add(parIdUsuario);

                comando.ExecuteNonQuery();
            } catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error en BD",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable Escalar_Buscar_Colaborador(int IdColaborador)
        {
            DataTable dt = new DataTable("Colabo");

            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Escalar_Buscar_Colaborador",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdColaborador = new SqlParameter()
                {
                    ParameterName = "IdColaborador",
                    SqlDbType = SqlDbType.Int,
                    Value = IdColaborador
                };

                comando.Parameters.Add(ParIdColaborador);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dt);

            } catch (Exception e)
            {
                dt = null;
                MessageBox.Show("Error : " + e.Message, "Escalar_Buscar_Colaborador");
            }

            return dt;
        }

        public static DataTable Escalar_Buscar_Usuario(int IdUsuario)
        {
            DataTable dt = new DataTable("Colabo");

            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Escalar_Buscar_Usuario",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdUsuario = new SqlParameter()
                {
                    ParameterName = "IdUsuario",
                    SqlDbType = SqlDbType.Int,
                    Value = IdUsuario
                };

                comando.Parameters.Add(ParIdUsuario);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dt);

            }
            catch (Exception e)
            {
                dt = null;
                MessageBox.Show("Error : " + e.Message, "Escalar_Buscar_Usuario");
            }

            return dt;
        }

        public static void Editar_Usuario(int IdUsuario, int IdColaborador, string Nombres, string Apellidos, string Telefono,string UsernName, string Rol)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Editar_Usuario",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter parIdUsuario = new SqlParameter()
                {
                    SqlDbType = SqlDbType.Int,
                    ParameterName = "IdUsuario",
                    Value = IdUsuario
                };

                SqlParameter parIdColaborador = new SqlParameter()
                {
                    SqlDbType = SqlDbType.Int,
                    ParameterName = "IdColaborador",
                    Value = IdColaborador
                };

                SqlParameter ParNombres = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Nombres,
                    ParameterName = "Nombres"
                };

                SqlParameter ParApellidos = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Apellidos,
                    ParameterName = "Apellidos"
                };

                SqlParameter ParTelefono = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Telefono,
                    ParameterName = "Telefono"
                };

                SqlParameter ParUserName = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = UsernName,
                    ParameterName = "UserName"
                };

                SqlParameter ParRol = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Rol,
                    ParameterName = "Rol"
                };

                comando.Parameters.Add(parIdUsuario);
                comando.Parameters.Add(parIdColaborador);
                comando.Parameters.Add(ParNombres);
                comando.Parameters.Add(ParApellidos);
                comando.Parameters.Add(ParTelefono);
                comando.Parameters.Add(ParUserName);
                comando.Parameters.Add(ParRol);

                comando.ExecuteNonQuery();

            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Editar_Usuario",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
