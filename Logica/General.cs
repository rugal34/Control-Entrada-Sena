using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class General
    {//SqlConexion, se utiliza para conectarnos a la base de datos
        public static SqlConnection conexion = new SqlConnection(Datos.ConexionBD.cadenaconexion);
        //SqlCommand, para realizar consultas
        public static SqlCommand consulta = conexion.CreateCommand();
        //SqlDataReader, para leer un flujo de filas,
        // el signo de interrogacion representa un parametro
        // que luego sera remplazado
        public static SqlDataReader LeerVariosRegistros;
        // SqlTransaction, confirmar o anular una transaccion
        // El signo de ? significa que puede aceptar valores null
        public static SqlTransaction mytransaction;
        // SqlDataAdapter, se utiliza para rellenar un DataSet
        public static SqlDataAdapter da = new SqlDataAdapter();
        // DataTable, representa una tabla de datos en la memoria
        public static DataTable temporal = new DataTable();
        public static string cadena;

        //ExecuteScalar: use esta preracion para ejecutar cualquier instruccion SQL en SQL Server
        // para devolver un valor unico. Esta operacion devuelve el valor solo en la primera columna de 
        // la primera fila del conjunto de resultados devuelto por la instruccion SQL

        public static void Consulta_Cadena(string Texto)
        {
            cadena = string.Empty;
            try
            {
                conexion.Open();
                mytransaction= conexion.BeginTransaction();
                consulta.Transaction = mytransaction;
                consulta.CommandText = Texto;
                if (Information.IsDBNull(consulta.ExecuteScalar()))
                {
                    cadena = string.Empty;
                }
                else
                {
                    cadena = consulta.ExecuteScalar().ToString();
                    mytransaction.Commit();
                }
            }
            catch (Exception)
            {

                mytransaction?.Rollback();
            }
            finally 
            { 
                conexion.Close ();
            }
        }

        public static void InsertarActualizar(string Texto, byte[] Foto, string Cedula, string Nombre, string Correo,
            string Usuario, string Contraseña, string Rol, int TipoCrud)
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Open();
                mytransaction  = conexion.BeginTransaction();
                consulta.Transaction = mytransaction;
                consulta.CommandText = Texto;
                // 1 = Insertar 2 = Actualizar
                // 3 = Eliminar
                if (TipoCrud == 1 || TipoCrud == 2)
                {
                    General.consulta.Parameters.AddWithValue("@Foto", Foto);
                    General.consulta.Parameters.AddWithValue("@Cedula", Cedula);
                    General.consulta.Parameters.AddWithValue("@Nombre", Nombre);
                    General.consulta.Parameters.AddWithValue("@Correo", Correo);
                    General.consulta.Parameters.AddWithValue("@Usuario", Usuario);
                    General.consulta.Parameters.AddWithValue("@Contrasena", Contraseña);
                    General.consulta.Parameters.AddWithValue("@Rol", Rol);
                }
                consulta.ExecuteNonQuery();
                mytransaction.Commit();
            }
            catch (Exception e)
            {
                mytransaction?.Rollback();
                MessageBox.Show("No se puede realizar la operación " + e.Message);                
            }
            finally 
            {
                General.consulta.Parameters.Clear();
                conexion.Close();
            }
        }

        public static void VerificaExistenRegistros(string texto)
        {
            try
            {
                conexion.Open();
                mytransaction= conexion.BeginTransaction();
                consulta.Transaction = mytransaction;
                consulta.CommandText = texto;
                if (Information.IsDBNull(consulta.ExecuteScalar()))
                {
                    cadena = string.Empty;
                }
                else
                {
                    cadena = consulta.ExecuteScalar().ToString();
                    mytransaction.Commit();
                }
            }
            catch (Exception)
            {
                mytransaction?.Rollback();
            }
            finally 
            { 
                conexion.Close(); 
            }
        }

        public static void BuscarRegistros(string texto)
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            conexion.Open();
            consulta.CommandText = texto;
            da = new SqlDataAdapter(consulta);
            temporal.Clear();
            da.Fill(temporal);
            conexion.Close() ;
        }

        //public static void VerificarConexion()
        //{ try 
        //    { 
        //        conexion.Open();
        //        MessageBox.Show("Conexion Valida", "Felicitaciones");
        //    } 
        //    catch (Exception e) 
        //    {
        //        MessageBox.Show("Conexion Invalida" + e.Message.ToString(), "Error");
        //    }
        //    finally
        //    { 
        //        conexion.Close(); 
        //    }
        //}        
    }
}
