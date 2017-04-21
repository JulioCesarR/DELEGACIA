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
    public class ResumoBLL
    {

        ResumoDAL dal = new ResumoDAL();


        public void cadastrar(ModeloResumo mod)
        {
            dal.cadastrar(mod);
        }
        public void excluir(ModeloResumo mod)
        {
            dal.excluir(mod);
        }
        public void atualizar(ModeloResumo mod)
        {
            dal.atualizar(mod);
        }
        public DataTable consultar()
        {
            return dal.consultar();
        }
    }
}
