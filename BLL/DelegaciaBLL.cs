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
    public class DelegaciaBLL
    {
        DelegaciaDAL dal = new DelegaciaDAL();

        public void cadastrar(ModeloDelegacia mod)
        {
            dal.cadastrar(mod);
        }
        public void excluir(ModeloDelegacia mod)
        {
            dal.excluir(mod);
        }
        public void atualizar(ModeloDelegacia mod)
        {
            dal.atualizar(mod);
        }
        public DataTable consultar()
        {
            return dal.consultar();
        }
    }
    
}
