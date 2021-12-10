using System;
using System.Collections.Generic;

namespace FAWS_WMS.Entrada
{
    class ListaUsuarios
    {
        //Usuários FATEC
        const string FatecUser = "FATEC@FAWS";
        const string FatecPass = "9999";

        //Usuários Professores
        const string ProfessorUser = "FATEC@PROFESSOR";
        const string ProfessorPass = "0000";

        //Usuários Clientes e Fornecedores
        const string ClientesFornecedoresGestorUser = "CLIENTESEFORNECEDORES@GESTOR";
        const string ClientesFornecedoresGestorPass = "1100";

        const string ClientesFornecedoresOperadorUser = "CLIENTESEFORNECEDORES@OPERADOR01";
        const string ClientesFornecedoresOperadorPass = "1101";

        //Usúarios Produtos
        const string ProdutosAdmUser = "PRODUTOS@ADMINISTRADOR";
        const string ProdutosAdmPass = "2200";

        const string ProdutosFuncionarioUser = "PRODUTOS@FUNCIONARIO01";
        const string ProdutosFuncionarioPass = "2201";

        //Usúarios Recebimento
        const string RecebimentoSupervisorUser = "RECEBIMENTO@SUPERVISOR";
        const string RecebimentoSupervisorPass = "3300";        
        
        const string RecebimentoPorteiroUser = "RECEBIMENTO@PORTEIRO01";
        const string RecebimentoPorteiroPass = "3301";

        const string RecebimentoConferenteUser = "RECEBIMENTO@CONFERENTE01";
        const string RecebimentoConferentePass = "3301";

        const string RecebimentoInspetorUser = "RECEBIMENTO@INSPETORDEQUALIDADE01";
        const string RecebimentoInspetorPass = "3301";

        //Usúarios Armazem
        const string ArmazemGestorUser = "ARMAZEM@GESTOR";
        const string ArmazemGestorPass = "4400";

        const string ArmazemOperadorUser = "ARMAZEM@OPERADOR01";
        const string ArmazemOperadorPass = "4401";

        //Usuários Expedição
        const string ExpedicaoUser = "EXPEDICAO@EXPEDIDOR";
        const string ExpedicaoPass = "5500";

        //Usuários FATEC
        private static readonly Dictionary<string, string> UsuariosFatec = new Dictionary<string, string>()
        {
            { FatecUser, FatecPass }
        };

        //Usuários Professores
        private static readonly Dictionary<string, string> UsuariosProfessor = new Dictionary<string, string>()
        { 
            { ProfessorUser, ProfessorPass } 
        };

        //Usuários Clientes e Fonecedores
        private static readonly Dictionary<string, string> UsuariosClientesForncedores = new Dictionary<string, string>()
        {
            { ClientesFornecedoresGestorUser, ClientesFornecedoresGestorPass },
            { ClientesFornecedoresOperadorUser, ClientesFornecedoresOperadorPass }
        };

        //Usuários Produtos
        private static readonly Dictionary<string, string> UsuariosProdutos = new Dictionary<string, string>()
        {
            { ProdutosAdmUser, ProdutosAdmPass },
            { ProdutosFuncionarioUser, ProdutosFuncionarioPass }
        };

        //Usuários Recebimento
        private static readonly Dictionary<string, string> UsuariosRecebimento = new Dictionary<string, string>() 
        {
            { RecebimentoSupervisorUser, RecebimentoSupervisorPass },
            { RecebimentoPorteiroUser,  RecebimentoPorteiroPass },
            { RecebimentoConferenteUser,  RecebimentoConferentePass },
            { RecebimentoInspetorUser,  RecebimentoInspetorPass }
        };

        //Usuários Armazém
        private static readonly Dictionary<string, string> UsuariosArmazem = new Dictionary<string, string>()
        {
            { ArmazemGestorUser, ArmazemGestorPass },
            { ArmazemOperadorUser, ArmazemOperadorPass }
        };

        //Usuários Expedição
        private static readonly Dictionary<string, string> UsuariosExpedicao = new Dictionary<string, string>()
        {
            { ExpedicaoUser, ExpedicaoPass }
        };


        //gets

        public static Dictionary<string, string> getUsuariosFatec { get => UsuariosFatec; }
        protected static Dictionary<string, string> getUsuariosProfessor { get => UsuariosProfessor; }
        public static Dictionary<string, string> getUsuariosClientesForncedores { get => UsuariosClientesForncedores; }
        public static Dictionary<string, string> getUsuariosProdutos { get => UsuariosProdutos; }
        public static Dictionary<string, string> getUsuariosRecebimento { get => UsuariosRecebimento; }        
        public static Dictionary<string, string> getUsuariosArmazem { get => UsuariosArmazem; }        
        public static Dictionary<string, string> getUsuariosExpedicao { get => UsuariosExpedicao; }        





    }


}
