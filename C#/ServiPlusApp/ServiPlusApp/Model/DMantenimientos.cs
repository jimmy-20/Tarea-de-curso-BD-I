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
    public class DMantenimientos
    {
        public static DataTable Mostrar_Mantenimientos()
        {
            DataTable DtResultado = new DataTable("Mostrar_Mantenimientos");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //Cargar la conexion del servidor 
                sqlCon.ConnectionString = Connection.conexion;

                //Creando un objeto SQLCommand que llamara al procedimiento almacenado
                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Mostrar_Mantenimientos",
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

        public static DataTable Buscar_Mantenimiento(string dato)
        {

            DataTable DtResultado = new DataTable("Buscar_Mantenimiento");

            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = Connection.conexion;

                SqlCommand sqlCmd = new SqlCommand
                {
                    Connection = sqlCon,
                    CommandText = "Buscar_Mantenimiento",
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

        public static void Insertar_Mantenimiento(int IdVehiculo, DateTime FechaEntrada, DateTime FechaSalida, int IdMecanico, int IdServicio)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);

                conexion.Open();
                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Insertar_Mantenimiento",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdVehiculo = new SqlParameter()
                {
                    ParameterName = "IdVehiculo",
                    SqlDbType = SqlDbType.Int,
                    Value = IdVehiculo
                };

                SqlParameter ParFechaEntrada = new SqlParameter()
                {
                    ParameterName = "FechaEntrada",
                    SqlDbType = SqlDbType.DateTime,
                    Value = FechaEntrada
                };

                SqlParameter ParFechaSalida = new SqlParameter()
                {
                    ParameterName = "FechaSalida",
                    SqlDbType = SqlDbType.DateTime,
                    Value = FechaSalida
                };

                SqlParameter ParIdMecanico = new SqlParameter()
                {
                    ParameterName = "IdMecanico",
                    SqlDbType = SqlDbType.Int,
                    Value = IdMecanico
                };

                SqlParameter ParIdServicio = new SqlParameter()
                {
                    ParameterName = "IdServicio",
                    SqlDbType = SqlDbType.Int,
                    Value = IdServicio
                };

                comando.Parameters.Add(ParIdVehiculo);
                comando.Parameters.Add(ParFechaEntrada);
                comando.Parameters.Add(ParFechaSalida);
                comando.Parameters.Add(ParIdMecanico);
                comando.Parameters.Add(ParIdServicio);

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Insertar_Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static DataTable Mostrar_Mantenimientos_Servicios(int IdMantenimiento)
        {
            DataTable dt = new DataTable("Servicios");
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Mostrar_Mantenimientos_Servicios",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdMantenimiento = new SqlParameter()
                {
                    ParameterName = "IdMantenimiento",
                    SqlDbType = SqlDbType.Int,
                    Value = IdMantenimiento
                };

                comando.Parameters.Add(ParIdMantenimiento);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Mostrar_Mantenimientos_Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }

        //Devuelve los respuestos aplicados en 1 servicio
        public static DataTable Mostrar_Servicios_Repuestos(int IdDetalleMantenimiento)
        {
            DataTable dt = new DataTable("Servicios");
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Mostrar_Servicios_Repuestos",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdMantenimiento = new SqlParameter()
                {
                    ParameterName = "IdDetalleMantenimiento",
                    SqlDbType = SqlDbType.Int,
                    Value = IdDetalleMantenimiento
                };

                comando.Parameters.Add(ParIdMantenimiento);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Mostrar_Servicio_Repuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }

        public static void Cambiar_Estado_Servicio_Mantenimiento(int IdDetalleMantenimiento)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Cambiar_Estado_Servicio_Mantenimiento",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdDetalleMantenimiento = new SqlParameter()
                {
                    ParameterName = "IdDetalleMantenimiento",
                    SqlDbType = SqlDbType.Int,
                    Value = IdDetalleMantenimiento
                };

                comando.Parameters.Add(ParIdDetalleMantenimiento);

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Cambiar_Estado_Servicio_Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Cambiar_Estado_Mantenimiento_Facturado(int IdMantenimiento)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    CommandText = "Cambiar_Estado_Mantenimiento_Facturado",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conexion
                };

                SqlParameter ParIdMantenimiento = new SqlParameter()
                {
                    ParameterName = "IdMantenimiento",
                    SqlDbType = SqlDbType.Int,
                    Value = IdMantenimiento
                };

                comando.Parameters.Add(ParIdMantenimiento);

                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Cambiar_Estado_Mantenimiento_Facturado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Asignar_Servicio(int IdMantenimiento, int IdMecanico, int IdServicio)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    CommandText = "Asignar_Servicio",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conexion
                };

                SqlParameter ParIdMantenimiento = new SqlParameter()
                {
                    ParameterName = "IdMantenimiento",
                    SqlDbType = SqlDbType.Int,
                    Value = IdMantenimiento
                };

                SqlParameter ParIdMecanico = new SqlParameter()
                {
                    ParameterName = "IdMecanico",
                    SqlDbType = SqlDbType.Int,
                    Value = IdMecanico
                };

                SqlParameter ParIdServicio = new SqlParameter()
                {
                    ParameterName = "IdServicio",
                    SqlDbType = SqlDbType.Int,
                    Value = IdServicio
                };

                comando.Parameters.Add(ParIdMantenimiento);
                comando.Parameters.Add(ParIdMecanico);
                comando.Parameters.Add(ParIdServicio);

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Asignar_Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static DataTable Factura_Header(int IdMantenimiento, string Usuario)
        {
            DataTable dt = new DataTable("Principal");

            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    CommandText = "Factura_Header",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conexion
                };

                SqlParameter ParIdMantenimiento = new SqlParameter()
                {
                    ParameterName = "IdMantenimiento",
                    SqlDbType = SqlDbType.Int,
                    Value = IdMantenimiento
                };

                SqlParameter ParUsuario = new SqlParameter()
                {
                    ParameterName = "Usuario",
                    SqlDbType = SqlDbType.VarChar,
                    Value = Usuario,
                    Size = 100
                };

                comando.Parameters.Add(ParIdMantenimiento);
                comando.Parameters.Add(ParUsuario);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);

                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Factura_Header", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }

        public static DataTable Factura_Detalle_Servicios()
        {
            DataTable dt = new DataTable("Servicios");

            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Factura_Detalle_Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }


            return dt;
        }

        public static DataTable Factura_Detalle_Repuestos()
        {
            DataTable dt = new DataTable("Repuestos");

            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Factura_Detalle_Repuestos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }

        public static DataTable Mostrar_Mantenimiento_Mecanico(int IdMecanico)
        {
            DataTable dt = new DataTable("Mantenimientos");

            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Mostrar_Mantenimiento_Mecanico",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdMecanico = new SqlParameter()
                {
                    ParameterName = "IdMecanico",
                    SqlDbType = SqlDbType.Int,
                    Value = IdMecanico
                };

                comando.Parameters.Add(ParIdMecanico);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dt);

            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Mostrar_Mantenimiento_Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }

        public static DataTable Escalar_Buscar_Mantenimiento()
        {
            DataTable dt = new DataTable("Ultimo_Mantenimiento");
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    CommandText = "Escalar_Buscar_Mantenimiento",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conexion
                };

                SqlDataAdapter adapter = new SqlDataAdapter(comando);

                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Escalar_Buscar_Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }

        public static DataTable Historial_Mantenimientos(int IdVehiculo)
        {
            DataTable dt = new DataTable("Mantenimientos");

            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    CommandText = "Historial_Mantenimientos",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conexion
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

            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Historial_Mantenimientos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }

        public static DataTable Historial_Header(int IdVehiculo)
        {
            DataTable dt = new DataTable("Cliente");

            try
            {
                SqlConnection conexion = new SqlConnection(Connection.conexion);
                conexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    CommandText = "Historial_Header",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conexion
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

            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message, "Historial_Mantenimientos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }

    }
}
