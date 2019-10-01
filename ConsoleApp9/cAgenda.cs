using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class cAgenda
    {
        public cAgenda() { }
        public string Nome { get; set; }
        public string TipoContato { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Sexo { get; set; }
        public string DoB { get; set; }
        public string Cnpj { get; set; }
        public string InscEstad { get; set; }
        public string DataCriaEmp { get; set; }
        public string EndCorr { get; set; }
        public string EndEntr { get; set; }
        public string EndCobr { get; set; }

        public cAgenda(string nome,
                       string tipocontato,
                       string cpf,
                       string rg,
                       string sexo,
                       string dob,
                       string cnpj,
                       string inscestad,
                       string datacriaemp,
                       string endcorr,
                       string endentr,
                       string endcobr
                       )
        {
            Nome = nome;
            TipoContato = tipocontato;
            Cpf = cpf;
            Rg = rg;
            Sexo = sexo;
            DoB = dob;
            Cnpj = cnpj;
            InscEstad = inscestad;
            DataCriaEmp = datacriaemp;
            EndCorr = endcorr;
            EndEntr = endentr;
            EndCobr = endcobr;
        }

    }
}
