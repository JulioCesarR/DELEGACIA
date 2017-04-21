using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DELEGACIA.MODELOS
{
    public class ModeloResumo
    {
        public int codigoOcorrencia { get; set; }
        public int codUsuario { get; set; }
        public string categoriaOcorrencia { get; set; }
        public string descricaoOcorrencia { get;set; }
        public int qtdOcorrencia { get; set; }
        public DateTime dataOcorrencia { get; set; }
        public DateTime horaOcorrencia { get; set; }
    }
}
