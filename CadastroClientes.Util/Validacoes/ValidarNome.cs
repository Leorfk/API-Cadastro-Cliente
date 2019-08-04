using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace CadastroClientes.Util.Validacoes
{
    public static class ValidarNome
    {
        public static bool IsNome(string nome)
        {
            string padrao = @"^[a-záàâãéèêíïóôõöúçñ ]+";
            Regex verificar = new Regex(padrao, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach(char letra in nome)
            {
                if (!verificar.IsMatch(letra.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}