using System.Entities;
using System.Data;
using System.Data.SqlClient;

namespace System.Datas
{
    public class ToCategory
    {
        public DataTable List()
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            { 
                SqlCon = Connection.GetInstance().CreateConnection();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCon.Open();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "categoria_listar";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                Result = SqlCmd.ExecuteReader();
                Table.Load(Result);
                Result.Close();
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Search(string Value)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.GetInstance().CreateConnection();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCon.Open();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "categoria_buscar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Param = new SqlParameter("@valor", SqlDbType.VarChar, 50);
                Param.Value = Value;
                SqlCmd.Parameters.Add(Param);

                Result = SqlCmd.ExecuteReader();
                Table.Load(Result);
                Result.Close();
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Insert(Category Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.GetInstance().CreateConnection();
                SqlCommand Comando = new SqlCommand("categoria_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Update(Category Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.GetInstance().CreateConnection();
                SqlCommand Comando = new SqlCommand("categoria_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.idcategoria;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Delete(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.GetInstance().CreateConnection();
                SqlCommand Comando = new SqlCommand("categoria_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Activate(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.GetInstance().CreateConnection();
                SqlCommand Comando = new SqlCommand("categoria_activar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Deactivate(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.GetInstance().CreateConnection();
                SqlCommand Comando = new SqlCommand("categoria_desactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
