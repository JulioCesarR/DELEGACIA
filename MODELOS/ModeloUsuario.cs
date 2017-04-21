using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DELEGACIA.MODELOS
{
    public class ModeloUsuario
    {
        public int codigo { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string tipo { get; set; }
        public int codDelegacia { get; set; }
    }
}
