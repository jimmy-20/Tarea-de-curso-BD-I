using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ServiPlusApp.Data
{
    class DUser
    {
        public DataTable Validar_Acceso(string username, string passWord)
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

       
        public DataTable Crear_Usuario(string nombre,string apellido,string telefono,string especialidad,string rol,string username, string passWord)
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
                    Value = username
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

        public DataTable Validar_Creacion_Usuario(string username, string passWord)
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


        public DataTable Tabla_Usuarios()
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

        public DataTable Tabla_Vehiculos()
        {
            DataTable DtResultado = new DataTable("Vehiculos");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //Cargar la conexion del servidor 
                sqlCon.ConnectionString = Connection.conexion;

                //Creando un objeto SQLCommand que llamara al procedimiento almacenado
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Mostrar_Vehiculos",
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

        public DataTable Tabla_Clientes()
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

        public DataTable Mostrar_Mecanicos()
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

        public DataTable Mostrar_Servicios()
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
    }
}
