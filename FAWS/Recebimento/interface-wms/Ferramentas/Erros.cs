using System;


namespace interface_wms.Ferramentas
{
    internal class Erros
    {
        //Métodos de retorno de erros
        internal static string erroAtvInat(Exception e)
        {
            return "Nenhum cadastro foi selecionado, selecione um cadastro para ser modificado!\n";
        }
        internal static string errovertodos(Exception e)
        {
            return "Nenhum cadastro foi encontrado!\n";
        }
        internal static string erroeditar(Exception e)
        {
            return "Nenhum cadastro foi selecionado!\n";
        }
        internal static string errosalvarAlt(Exception e)
        {
            return "Nenhum cadastro foi selecionado para poder salvar as alterações!\n";
        }

        //Portarias
        internal static string erroSalvarDadosPortarias(Exception e)
        {
            return "Nenhum cadastro com esse Número de NF foi encontrado na tabela de \"Relação de NF\", verifique e tente novamente com outro número!\n";
        }

        //Recebimento
        internal static string erroSalvarDadosRecebimento(Exception e)
        {
            return "Nenhum cadastro com esse Número de NF e/ou Número do Pedido foi encontrado na tabela de \"Portarias\", verifique e tente novamente com outro número!\n";
        }

        //Divergencias
        internal static string erroSalvarDadosDivergencias(Exception e)
        {
            return "Nenhum cadastro com essa Cod. do Produto foi encontrado salvo como \"Divergencia\" na tabela de \"Recebimentos\", verifique e tente novamente com outro número!\n";
        }

    }
}
