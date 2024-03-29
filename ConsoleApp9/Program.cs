﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static List<cAgenda> agenda;

        static void Main(string[] args)
        {

            DataTable oDataAgenda = new DataTable(); 

            cAgenda oAgenda = new cAgenda();

            agenda = new List<cAgenda>();

        oMenu:
            Console.Clear();
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
                    Thread.Sleep(2000);
                    goto oMenu;
            }

        oCadastrar:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("[ Informe dados solicitados ]");
            Console.Write("Nome: ");
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
            String oCnpj = "";
            String oInscEstad = "";
            String oDataCriaEmp = "";
            Console.WriteLine("");

            Console.Write("CPF: ");
            String oCpf = Console.ReadLine();
            Console.Write("RG: ");
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
            Console.Write("Data de Nascimento: ");
            String oDoB = Console.ReadLine();
            goto oEnderecos;

        oJuridica:
            oCpf = "";
            oRg = "";
            oSexo = "";
            oDoB = "";
            Console.WriteLine("");

            Console.Write("CNPJ: ");
            oCnpj = Console.ReadLine();
            Console.Write("Inscrição Estadual: ");
            oInscEstad = Console.ReadLine();
            Console.Write("Data de Criação da Empresa: ");
            oDataCriaEmp = Console.ReadLine();
            goto oEnderecos;

        oEnderecos:
            Console.Write("Endereço de Correspondência: ");
            String oEndCorr = Console.ReadLine();
            Console.Write("Endereço de Entrega: ");
            String oEndEntr = Console.ReadLine();
            Console.Write("Endereço de Cobrança: ");
            String oEndCobr = Console.ReadLine();

        oSalvarOuNao:
            Console.WriteLine("Digite [S] para Salvar ou [M] para voltar ao Menu sem salvar.");
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
                    Thread.Sleep(2000);
                    goto oCadastrar;
            }

        oNomes:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("[ Lista de Nomes armazenados ]");
            Console.WriteLine("");
            foreach (var p in agenda)
            {
                Console.WriteLine("Nome: " + p.Nome);
            }
            Console.WriteLine("");
            Console.WriteLine("Pressione [Enter] para voltar ao Menu Principal.");
            Console.ReadLine();
            goto oMenu;

        oListaEndEntrega:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("[ Lista de Endereços de Entrega armazenados ]");
            Console.WriteLine("");
            foreach (var p in agenda)
            {
                Console.WriteLine("Endereço de Entrega para " + p.Nome + ": " + p.EndEntr);
            }


            
            Console.WriteLine("");
            Console.WriteLine("Pressione [Enter] para voltar ao Menu Principal.");
            Console.ReadLine();
            goto oMenu;

        oListaEndCobranca:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("[ Lista de Endereços de Cobrança armazenados ]");
            Console.WriteLine("");
            foreach (var p in agenda)
            {
                Console.WriteLine("Endereço de Cobrança para " + p.Nome + ": " + p.EndCobr);
            }
            Console.WriteLine("");
            Console.WriteLine("Pressione [Enter] para voltar ao Menu Principal.");
            Console.ReadLine();
            goto oMenu;

        oListaEndCorresp:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("[ Lista de Endereços de Correspondência armazenados ]");
            Console.WriteLine("");
            foreach (var p in agenda)
            {
                Console.WriteLine("Endereço de Correspondência para " + p.Nome + ": " + p.EndCorr);
            }
            Console.WriteLine("");
            Console.WriteLine("Pressione [Enter] para voltar ao Menu Principal.");
            Console.ReadLine();
            goto oMenu;

        oListaEnd:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("[ Lista de todos os Endereços armazenados ]");
            Console.WriteLine("");
            foreach (var p in agenda)
            {
                Console.WriteLine("Endereços para " + p.Nome + ": " + p.EndEntr + ", " + p.EndCobr + ", e " + p.EndCorr);
            }
            Console.WriteLine("");
            Console.WriteLine("Pressione [Enter] para voltar ao Menu Principal.");
            Console.ReadLine();
            goto oMenu;

        oFinalizar:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine(@"Criando arquivo XML em [C:\temp] ...");
            try
            {
                oDataAgenda = oAgenda.ConvertToDatatable(agenda);
                DataSet oXML = new DataSet("Agenda");
                oXML.Tables.Add(oDataAgenda);
                oXML.WriteXml(@"c:\temp\agenda.xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
                Console.WriteLine(ex.Message.ToString());
                Console.WriteLine(ex.Source.ToString());
                Console.WriteLine("");
            }
            Console.WriteLine("Finalizando atividades...");
            Thread.Sleep(2000);
        }

    }
}
