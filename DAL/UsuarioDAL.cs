using System.Data;
using MySql.Data.MySqlClient;
using DELEGACIA.MODELOS;

namespace DELEGACIA.DAL
{
    
    public class UsuarioDAL
    {

        Conexao con = new Conexao();

        public static string TipoUserLog;
        public static string nomeUsu;
        public static int codDelegacia;
        
        public bool autenticar(ModeloUsuario mod)
        {
            MySqlCommand cmd = new MySqlCommand(@"select login, senha, tipo, codDelegacia from usuarios where login = @log and senha like binary @sen", con.conectar());
            cmd.Parameters.AddWithValue("@log", mod.login);
            cmd.Parameters.AddWithValue("@sen", mod.senha);
           
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                TipoUserLog = dr["tipo"].ToString();
                nomeUsu = dr["login"].ToString();
                codDelegacia = int.Parse(dr["codDelegacia"].ToString());
                con.desconectar();
                dr.Close(); 
                return true;
            }
            else
            {
                TipoUserLog = "";
                nomeUsu = "";
                con.desconectar();
                dr.Close();
                return false;
            }

        }    
        public void cadastrar(ModeloUsuario mod) 
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"INSERT INTO USUARIOS(login,senha,tipo,codDelegacia) VALUES(@LOG,@SEN,@TIP,@DEL)";
            cmd.Connection = con.conectar();
            cmd.Parameters.AddWithValue("@LOG",mod.login);
            cmd.Parameters.AddWithValue("@SEN", mod.senha);
            cmd.Parameters.AddWithValue("@TIP", mod.tipo);
            cmd.Parameters.AddWithValue("@DEL",mod.codDelegacia);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public void excluir(ModeloUsuario mod) 
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"DELETE FROM USUARIOS WHERE COD = @COD ";
            cmd.Connection = con.conectar();
            cmd.Parameters.AddWithValue("@COD",mod.codigo);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public void atualizar(ModeloUsuario mod)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"UPDATE USUARIOS SET LOGIN = @LOG, SENHA = @SENHA, TIPO = @TIP WHERE COD = @cod";
            cmd.Connection = con.conectar();
            cmd.Parameters.AddWithValue("@LOG", mod.login);
            cmd.Parameters.AddWithValue("@SENHA", mod.senha);
            cmd.Parameters.AddWithValue("@TIP", mod.tipo);
            cmd.Parameters.AddWithValue("@cod", mod.codigo);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public DataTable consultar()
        {

            MySqlDataAdapter da = new MySqlDataAdapter(@"SELECT * FROM USUARIOS", con.conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.desconectar();
            return dt;
        }
        public DataTable consultar(string Nome)
        {

            MySqlDataAdapter da = new MySqlDataAdapter(@"SELECT * FROM USUARIOS WHERE LOGIN LIKE @nome", con.conectar());
            da.SelectCommand.Parameters.Add("@nome", MySqlDbType.VarChar).Value = "%" + Nome + "%";
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.desconectar();
            return dt;
        }


    }
}
