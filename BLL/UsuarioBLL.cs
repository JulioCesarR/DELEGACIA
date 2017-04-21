using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DELEGACIA.MODELOS;
using DELEGACIA.DAL;
using System.Data;

namespace DELEGACIA.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL dal = new UsuarioDAL();

        public bool autenticar(ModeloUsuario mod) 
        {
            return dal.autenticar(mod);
        }
        public void cadastrar(ModeloUsuario mod)
        {
            dal.cadastrar(mod);
        }
        public void excluir(ModeloUsuario mod)
        {
            dal.excluir(mod);
        }
        public void atualizar(ModeloUsuario mod)
        {
            dal.atualizar(mod);
        }
        public DataTable consultar()
        {
            return dal.consultar();
        }
    }
}
