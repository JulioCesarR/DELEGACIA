using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DELEGACIA.MODELOS;

namespace DELEGACIA.DAL
{
    public class ResumoDAL
    {
        Conexao con = new Conexao();

        public void cadastrar(ModeloResumo mod)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"INSERT INTO RESUMO(COD_USUARIO,CATEGORIA_OCORRENCIA,DESCRICAO_OCORRENCIA,QTD_OCORRENCIA,DATA_OCORRENCIA,HORA_OCORRENCIA) 
            VALUES(@COD_USUARIO,@CATEGORIA_OCORRENCIA,@DESCRICAO_OCORRENCIA,@QTD_OCORRENCIA,@DATA_OCORRENCIA,@HORA_OCORRENCIA)";
            cmd.Connection = con.conectar();
            cmd.Parameters.AddWithValue("@COD_USUARIO", mod.codUsuario);
            cmd.Parameters.AddWithValue("@CATEGORIA_OCORRENCIA", mod.categoriaOcorrencia);
            cmd.Parameters.AddWithValue("@DESCRICAO_OCORRENCIA", mod.descricaoOcorrencia);
            cmd.Parameters.AddWithValue("@QTD_OCORRENCIA", mod.qtdOcorrencia);
            cmd.Parameters.AddWithValue("@DATA_OCORRENCIA", mod.dataOcorrencia);
            cmd.Parameters.AddWithValue("@HORA_OCORRENCIA", mod.horaOcorrencia);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public void excluir(ModeloResumo mod)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"DELETE FROM RESUMO WHERE CODIGO = @CODIGO ";
            cmd.Connection = con.conectar();
            cmd.Parameters.AddWithValue("@CODIGO", mod.codigoOcorrencia);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public void atualizar(ModeloResumo mod)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"UPDATE RESUMO SET COD_USUARIO = @COD_USUARIO,CATEGORIA_OCORRENCIA = @CATEGORIA_OCORRENCIA,
            DESCRICAO_OCORRENCIA = @DESCRICAO_OCORRENCIA,QTD_OCORRENCIA = @QTD_OCORRENCIA,DATA_OCORRENCIA = @DATA_OCORRENCIA,HORA_OCORRENCIA = @HORA_OCORRENCIA
            WHERE CODIGO = @COD";
            cmd.Connection = con.conectar();
            cmd.Parameters.AddWithValue("@CODIGO", mod.codigoOcorrencia);
            cmd.Parameters.AddWithValue("@COD_USUARIO", mod.codUsuario);
            cmd.Parameters.AddWithValue("@CATEGORIA_OCORRENCIA", mod.categoriaOcorrencia);
            cmd.Parameters.AddWithValue("@DESCRICAO_OCORRENCIA", mod.descricaoOcorrencia);
            cmd.Parameters.AddWithValue("@QTD_OCORRENCIA", mod.qtdOcorrencia);
            cmd.Parameters.AddWithValue("@DATA_OCORRENCIA", mod.dataOcorrencia);
            cmd.Parameters.AddWithValue("@HORA_OCORRENCIA", mod.horaOcorrencia);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public DataTable consultar()
        {
            MySqlDataAdapter da = new MySqlDataAdapter(@"SELECT * FROM RESUMO", con.conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.desconectar();
            return dt;
        }
    }
}
