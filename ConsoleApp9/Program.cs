using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static List<cAgenda> agenda;

        static void Main(string[] args)
        {
            agenda = new List<cAgenda>();

        oMenu:
            Console.WriteLine("");
            Console.WriteLine("[ Menu Principal da Agenda ]");
            Console.WriteLine("[1] Cadastrar nova entrada");
            Console.WriteLine("[2] Listar todos os Nomes");
            Console.WriteLine("[3] Listar todos os Endereços de Entrega");
            Console.WriteLine("[4] Listar todos os Endereços de Cobrança");
            Console.WriteLine("[5] Listar todos os Endereços de Correspondência");
            Console.WriteLine("[6] Listar todos os Endereços");
            Console.WriteLine("[7] Sair");
            String oMenuSelect = Console.ReadLine();
            switch (oMenuSelect.ToUpper())
            {
                case "1":
                    goto oCadastrar;
                    break;
                case "2":
                    goto oNomes;
                    break;
                case "3":
                    goto oListaEndEntrega;
                    break;
                case "4":
                    goto oListaEndCobranca;
                    break;
                case "5":
                    goto oListaEndCorresp;
                    break;
                case "6":
                    goto oListaEnd;
                    break;
                case "7":
                    goto oFinalizar;
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("Por favor siga as instruções da tela corretamente.");
                    goto oMenu;
            }

        oCadastrar:
            Console.WriteLine("");
            Console.WriteLine("[ Informe dados solicitados ]");
            Console.WriteLine("Nome:");
            String oNome = Console.ReadLine();

        oTipoContato:
            Console.WriteLine("Tipo de Contato:");
            Console.WriteLine("(Digite [F] para Pessoa Física, ou [J] para Pessoa Jurídica)");
            String oTipoContato = Console.ReadLine();

            switch (oTipoContato.ToUpper())
            {
                case "F":
                    Console.WriteLine("[F] Pessoa Física selecionado");
                    goto oFisica;
                    break;
                case "J":
                    Console.WriteLine("[P] Pessoa Jurídica selecionado");
                    goto oJuridica;
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("Por favor siga as instruções da tela corretamente.");
                    goto oTipoContato;
                    break;
            }

        oFisica:
            String oCnpj = null;
            String oInscEstad = null;
            String oDataCriaEmp = null;
            Console.WriteLine("");

            Console.WriteLine("CPF:");
            String oCpf = Console.ReadLine();
            Console.WriteLine("RG:");
            String oRg = Console.ReadLine();
        oSexo:
            Console.WriteLine("Sexo:");
            Console.WriteLine("(Digite [F] para Feminino, ou [M] para Masculino)");
            String oSexo = Console.ReadLine();
            switch (oSexo.ToUpper())
            {
                case "F":
                    Console.WriteLine("[F] Feminio selecionado");
                    break;
                case "M":
                    Console.WriteLine("[M] Masculino selecionado");
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("Por favor siga as instruções da tela corretamente.");
                    goto oSexo;
            }
            Console.WriteLine("Data de Nascimento:");
            String oDoB = Console.ReadLine();
            goto oEnderecos;

        oJuridica:
            oCpf = null;
            oRg = null;
            oSexo = null;
            oDoB = null;
            Console.WriteLine("");

            Console.WriteLine("CNPFJ:");
            oCnpj = Console.ReadLine();
            Console.WriteLine("Inscrição Estadual:");
            oInscEstad = Console.ReadLine();
            Console.WriteLine("Data de Criação da Empresa:");
            oDataCriaEmp = Console.ReadLine();
            goto oEnderecos;

        oEnderecos:
            Console.WriteLine("Endereço de Correspondência:");
            String oEndCorr = Console.ReadLine();
            Console.WriteLine("Endereço de Entrega:");
            String oEndEntr = Console.ReadLine();
            Console.WriteLine("Endereço de Cobrança:");
            String oEndCobr = Console.ReadLine();

        oSalvarOuNao:
            Console.WriteLine("Digite [S] para Salvar ou [M] para voltar ao Menu sem salvar");
            String oSimNao = Console.ReadLine();

            switch (oSimNao.ToUpper())
            {
                case "S":
                    Console.WriteLine("");
                    Console.WriteLine("Dados salvos com sucesso.");
                    goto oGravar;
                case "M":
                    Console.WriteLine("");
                    Console.WriteLine("Dados descartados com sucesso.");
                    goto oMenu;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("Por favor siga as instruções da tela corretamente.");
                    goto oSalvarOuNao;
            }

        oGravar:

            if (oSimNao.ToUpper() == "S")
            {
                agenda.Add(new cAgenda
                       (oNome,
                        oTipoContato,
                        oCpf,
                        oRg,
                        oSexo,
                        oDoB,
                        oCnpj,
                        oInscEstad,
                        oDataCriaEmp,
                        oEndCorr,
                        oEndEntr,
                        oEndCobr));
            }

            Console.WriteLine("");
            Console.WriteLine("Criar novo registro?");
            Console.WriteLine("Digite [N] para Novo registro ou [M] para Menu principal.");
            String oNovoRegistro = Console.ReadLine();

            switch (oNovoRegistro.ToUpper())
            {
                case "N":
                    Console.WriteLine("Dados estão sendo gravados.");
                    goto oCadastrar;
                case "M":
                    Console.WriteLine("Os dados não foram gravados !!!!");
                    goto oMenu;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("Por favor siga as instruções da tela corretamente.");
                    goto oCadastrar;
            }
        oFinalizar:
            Console.WriteLine("======================================");
            Console.WriteLine(" Programa finalizado sera finalizado ");
            Console.WriteLine("======================================");
            Console.WriteLine(" Lista de dados armazenados");
            Console.WriteLine("======================================");

            foreach (var p in agenda)
            {
                Console.WriteLine("Nome:" + p.Nome + " Sexo:" +
                        p.Cpf + " Nacionalidade" +
                        p.Rg + " Naturalidade" +
                        p.DoB + " ");
            }

            Console.WriteLine(" Pressione <Enter> para finalizar.");
            Console.ReadLine();
        }
    }
}
