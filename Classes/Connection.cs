using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Cinema.Classes
{
    public class Connection
    {
        public static SqlConnection bd_connection = new SqlConnection(
            "server = LEONARDO; " +
            "database = VideoClub; " +
            "integrated security = true"
            );

        SqlCommand? cmd;

        public SqlConnection openConnection()
        {
            if (bd_connection.State == ConnectionState.Closed) bd_connection.Open();
            return bd_connection;
        }
        public SqlConnection closeConnection()
        {
            if(bd_connection.State == ConnectionState.Open) bd_connection.Close();
            return bd_connection;
        }
        public DataTable mostrar_actor()
        {
            DataTable table = new DataTable();
            cmd = new SqlCommand();

            cmd.Connection = openConnection();
            cmd.CommandText = "sql_mostrar_actor";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            dt.Fill(table);
            closeConnection();
            return table;
        }
        public DataTable buscar_actor(int id)
        {
            DataTable table = new DataTable();
            cmd = new SqlCommand();

            cmd.Connection = openConnection();
            cmd.CommandText = "sql_buscar_actor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            dt.Fill(table);
            closeConnection();
            return table;
        }
        public DataTable QuerySearch(string query)
        {
            DataTable table = new();
            cmd = new SqlCommand(query, openConnection());
            SqlDataAdapter data = new(cmd);
            
            data.Fill(table);
            return table;
        }
        public string insertar_actor(Actor actor)
        {
            string respuesta;
            cmd = new SqlCommand();
            cmd.Connection = openConnection();
            cmd.CommandText = "sql_insertar_actor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", actor.Name);
            cmd.Parameters.AddWithValue("@ap", actor.LastName);
            cmd.Parameters.AddWithValue("@ge", actor.Gender);
            cmd.Parameters.AddWithValue("@nac", actor.Date);

            try
            {
                respuesta = cmd.ExecuteNonQuery() == 1 ? " Actor Registrado " : " No se registro el actor ";
            }
            catch(Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                closeConnection();
            }

            return respuesta;
        }
        public string actualizar(Actor actor)
        {
            string respuesta;
            cmd = new SqlCommand();
            cmd.Connection = openConnection();
            cmd.CommandText = "sql_actualizar_actor";//nombre del procedimeinto creado en sql 
            cmd.CommandType = CommandType.StoredProcedure;
            //parametros 
            cmd.Parameters.AddWithValue("@id", actor.Id);
            cmd.Parameters.AddWithValue("@name", actor.Name);
            cmd.Parameters.AddWithValue("@last", actor.LastName);
            cmd.Parameters.AddWithValue("@date", actor.Date);
            try
            {
                respuesta = cmd.ExecuteNonQuery() == 1 ? " Actor actualizado " : " Error en la actualizacion ";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                closeConnection();
            }
            return respuesta;
        }
        public string eliminar_actor(int id)
        {
            string respuesta;
            cmd = new SqlCommand("sql_eliminar_actor", openConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                respuesta = cmd.ExecuteNonQuery() == 1 ? " Actor eliminado " : " Error al eliminar ";
            }
            catch(Exception ex)
            {
                respuesta = ex.Message
            }
            finally
            {
                closeConnection();
            }
            return respuesta;
        }
    }
}
