using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origens
{
    public class Candidato
    {
        public int? codigo { get; set; }
        public int? codCorOlho { get; set; }

        public int? corCorCabelo { get; set; }

        public int? codEstado { get; set; }

        public int? codCorPele { get; set; }

        public int? codTipoCabelo { get; set; }

        public int? codFaixaAltura { get; set; }

        public int? codTemperamento { get; set; }

        public int? codEscolaridade { get; set; }

        public int? codDoenca { get; set; }

        public bool praticarEsporte { get; set; }

        public bool le { get; set; }

        public string nome { get; set; }

        private string _cpf;
        public string cpf
        {
            get
            {
                return this._cpf.Replace(",", "").Replace(".", "").Replace("-", "");
            }
            set
            {
                this._cpf = value;
            }
        }

        private string _cep;
        public string cep
        {
            get
            {
                return this._cep.Replace(",", "").Replace(".", "").Replace("-", "");
            }
            set
            {
                this._cep = value;
            }
        }

        public DateTime dataNascimento { get; set; }

        public string telefone { get; set; }

        public string cidade { get; set; }

        public string endereco { get; set; }

        public string complemento { get; set; }
    }
}
