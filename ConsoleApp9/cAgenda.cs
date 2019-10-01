using System;
using System.Collections.Generic;
using System.Data;
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


        public DataTable ConvertToDatatable(List<cAgenda> list)
        {
            DataTable dt = new DataTable("Contato");

            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Tipo.de.Contato", typeof(string));
            dt.Columns.Add("CPF", typeof(string));
            dt.Columns.Add("RG", typeof(string));
            dt.Columns.Add("Sexo", typeof(string));
            dt.Columns.Add("Data.de.Nascimento", typeof(string));
            dt.Columns.Add("CNPJ", typeof(string));
            dt.Columns.Add("Inscricao.Estadual", typeof(string));
            dt.Columns.Add("Data.de.Criacao.da.Empresa", typeof(string));
            dt.Columns.Add("Endereco.de.Correspondencia", typeof(string));
            dt.Columns.Add("Endereco.de.Entrega", typeof(string));
            dt.Columns.Add("Endereco.de.Cobranca", typeof(string));

            foreach (var item in list)
            {
                dt.Rows.Add(item.Nome.ToString(),
                    item.TipoContato.ToString(),
                    item.Cpf.ToString(),
                    item.Rg.ToString(),
                    item.Sexo.ToString(),
                    item.DoB.ToString(),
                    item.Cnpj.ToString(),
                    item.InscEstad.ToString(),
                    item.DataCriaEmp.ToString(),
                    item.EndCorr.ToString(),
                    item.EndEntr.ToString(),
                    item.EndCobr.ToString());
            }

            return dt;
        }
    }
}
