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
    public class DRepuestos
    {
        public static DataTable Mostrar_Repuestos()
        {
            DataTable DtResultado = new DataTable("Mostrar_Repuestos");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //Cargar la conexion del servidor 
                sqlCon.ConnectionString = Connection.conexion;

                //Creando un objeto SQLCommand que llamara al procedimiento almacenado
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Mostrar_Repuestos",
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

        public static DataTable Buscar_Repuesto(string dato)
        {
            DataTable DtResultado = new DataTable("Buscar_Repuesto");

            SqlConnection sqlCon = new SqlConnection();

            try
            {
                //Cargar la conexion del servidor 
                sqlCon.ConnectionString = Connection.conexion;

                //Creando un objeto SQLCommand que llamara al procedimiento almacenado
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Buscar_Repuesto",
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

        public static void Insertar_Repuesto(string Descripcion,string Marca,string Modelo,decimal Precio ,int Cantidad)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Insertar_Repuesto",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParDescripcion = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "descripcion",
                    Value = Descripcion
                };

                SqlParameter ParModelo = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "modelo",
                    Value = Modelo
                };

                SqlParameter ParMarca = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "marca",
                    Value = Marca
                };

                SqlParameter ParPrecio = new SqlParameter()
                {
                    SqlDbType = SqlDbType.Decimal,
                  
                    ParameterName = "precio",
                    Value = Precio
                };

                SqlParameter ParCantidad = new SqlParameter()
                {
                    SqlDbType = SqlDbType.Int,
                   
                    ParameterName = "cantidad",
                    Value = Cantidad
                };

                

                comando.Parameters.Add(ParDescripcion);
                comando.Parameters.Add(ParMarca);
                comando.Parameters.Add(ParModelo);
                comando.Parameters.Add(ParPrecio);
                comando.Parameters.Add(ParCantidad);
                

                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Insertar_Mecanico",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void Editar_Repuesto(int idRepuesto ,string Descripcion, string Marca, string Modelo, decimal Precio, int Cantidad)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Editar_Repuesto",
                    CommandType = CommandType.StoredProcedure
                };


                SqlParameter ParIdRepuesto = new SqlParameter()
                {
                    SqlDbType = SqlDbType.Int,
                    
                    ParameterName = "IdRepuesto",
                    Value = idRepuesto
                };

                SqlParameter ParDescripcion = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "descripcion",
                    Value = Descripcion
                };

                SqlParameter ParModelo = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "modelo",
                    Value = Modelo
                };

                SqlParameter ParMarca = new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    ParameterName = "marca",
                    Value = Marca
                };

                SqlParameter ParPrecio = new SqlParameter()
                {
                    SqlDbType = SqlDbType.Decimal,

                    ParameterName = "precio",
                    Value = Precio
                };

                SqlParameter ParCantidad = new SqlParameter()
                {
                    SqlDbType = SqlDbType.Int,

                    ParameterName = "cantidad",
                    Value = Cantidad
                };


                comando.Parameters.Add(ParIdRepuesto);
                comando.Parameters.Add(ParDescripcion);
                comando.Parameters.Add(ParMarca);
                comando.Parameters.Add(ParModelo);
                comando.Parameters.Add(ParPrecio);
                comando.Parameters.Add(ParCantidad);


                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Insertar_Mecanico",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void Cambiar_Estado_Repuesto(int IdRepuesto)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "Cambiar_Estado_Repuesto"
                };

                SqlParameter parIdRepuesto = new SqlParameter()
                {
                    SqlDbType = SqlDbType.Int,
                    Value = IdRepuesto,
                    ParameterName = "IdRepuesto"
                };

                comando.Parameters.Add(parIdRepuesto);

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Cambiar_Estado_Repuesto",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
