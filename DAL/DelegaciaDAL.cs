using System.Data;
using MySql.Data.MySqlClient;
using DELEGACIA.MODELOS;

namespace DELEGACIA.DAL
{
    public class DelegaciaDAL
    {
        Conexao con = new Conexao();

        public void cadastrar(ModeloDelegacia mod)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"INSERT INTO DELEGACIAS(logradouro,numero,cep,bairro,cidade,estado,email,telefone) 
            VALUES(@LOG,@NUM,@CEP,@BAI,@CID,@EST,@EMA,@TEL)";
            cmd.Connection = con.conectar();
            cmd.Parameters.AddWithValue("@LOG", mod.logradouro);
            cmd.Parameters.AddWithValue("@NUM", mod.numero);
            cmd.Parameters.AddWithValue("@CEP", mod.cep);
            cmd.Parameters.AddWithValue("@BAI", mod.bairro);
            cmd.Parameters.AddWithValue("@CID", mod.cidade);
            cmd.Parameters.AddWithValue("@EST", mod.estado);
            cmd.Parameters.AddWithValue("@EMA", mod.email);
            cmd.Parameters.AddWithValue("@TEL", mod.telefone);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public void excluir(ModeloDelegacia mod)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"DELETE FROM DELEGACIAS WHERE CODIGO = @COD ";
            cmd.Connection = con.conectar();
            cmd.Parameters.AddWithValue("@COD", mod.codigo);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public void atualizar(ModeloDelegacia mod)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"UPDATE DELEGACIAS SET logradouro = @LOG,numero = @NUM,cep = @CEP,bairro = @BAI,
            cidade = @CID,estado = @EST,email = @EMA,telefone = @TEL WHERE CODIGO = @COD";
            cmd.Connection = con.conectar();
            cmd.Parameters.AddWithValue("@LOG", mod.logradouro);
            cmd.Parameters.AddWithValue("@NUM", mod.numero);
            cmd.Parameters.AddWithValue("@CEP", mod.cep);
            cmd.Parameters.AddWithValue("@BAI", mod.bairro);
            cmd.Parameters.AddWithValue("@CID", mod.cidade);
            cmd.Parameters.AddWithValue("@EST", mod.estado);
            cmd.Parameters.AddWithValue("@EMA", mod.email);
            cmd.Parameters.AddWithValue("@TEL", mod.telefone);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public DataTable consultar()
        {

            MySqlDataAdapter da = new MySqlDataAdapter(@"SELECT * FROM DELEGACIAS", con.conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.desconectar();
            return dt;
        }
    }
}
