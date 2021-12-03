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
    public class DVehiculos
    {
        public static DataTable Mostrar_Vehiculos()
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

        public static DataTable Buscar_Vehiculo(string dato)
        {

            DataTable DtResultado = new DataTable("Buscar_Vehiculo");

            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = Connection.conexion;

                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Buscar_Vehiculo",
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

        public static void Insertar_Vehiculo(int IdCliente, string Marca, string Modelo, int Año)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);

                SqlCommand comando = new SqlCommand() { 
                Connection = conexion,
                CommandText = "Insertar_Vehiculo",
                CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdCliete = new SqlParameter()
                {
                    ParameterName = "IdCliente",
                    SqlDbType = SqlDbType.Int,
                    Value = IdCliente
                };

                SqlParameter ParMarca = new SqlParameter()
                {
                    ParameterName = "Marca",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Marca
                };

                SqlParameter ParModelo = new SqlParameter()
                {
                    ParameterName = "Modelo",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Modelo
                };

                SqlParameter ParAño = new SqlParameter()
                {
                    ParameterName = "Año",
                    SqlDbType = SqlDbType.Int,
                    Value = Año
                };

                comando.Parameters.Add(ParIdCliete);
                comando.Parameters.Add(ParMarca);
                comando.Parameters.Add(ParModelo);
                comando.Parameters.Add(ParAño);

                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Insertar_Vehiculo",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Editar_Vehiculo(int IdVehiculo,int IdCliente, string Marca, string Modelo, int Año)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Editar_Vehiculo",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdVehiculo = new SqlParameter() { 
                    ParameterName = "IdVehiculo",
                    SqlDbType = SqlDbType.Int,
                    Value = IdVehiculo
                };

                SqlParameter ParIdCliete = new SqlParameter()
                {
                    ParameterName = "IdCliente",
                    SqlDbType = SqlDbType.Int,
                    Value = IdCliente
                };

                SqlParameter ParMarca = new SqlParameter()
                {
                    ParameterName = "Marca",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Marca
                };

                SqlParameter ParModelo = new SqlParameter()
                {
                    ParameterName = "Modelo",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Modelo
                };

                SqlParameter ParAño = new SqlParameter()
                {
                    ParameterName = "Año",
                    SqlDbType = SqlDbType.Int,
                    Value = Año
                };

                comando.Parameters.Add(ParIdVehiculo);
                comando.Parameters.Add(ParIdCliete);
                comando.Parameters.Add(ParMarca);
                comando.Parameters.Add(ParModelo);
                comando.Parameters.Add(ParAño);

                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Editar_Vehiculo",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable Escalar_Buscar_Vehiculo(int IdVehiculo)
        {
            DataTable dt = new DataTable("Vehiculo");

            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);

                SqlCommand comando = new SqlCommand() { 
                Connection = conexion,
                CommandText = "Escalar_Buscar_Vehiculo",
                CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdVehiculo = new SqlParameter()
                {
                    ParameterName = "IdVehiculo",
                    SqlDbType = SqlDbType.Int,
                    Value = IdVehiculo
                };

                comando.Parameters.Add(ParIdVehiculo);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);

                adapter.Fill(dt);
            }catch(Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Escalar_Buscar_Vehiculo",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }
    }
}
