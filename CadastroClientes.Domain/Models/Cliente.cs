using CadastroClientes.Domain.Enums;
using CadastroClientes.Util.Validacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroClientes.Domain.Models
{
    class Cliente
    {
        private int Id;
        public int _id
        {
            get { return Id; }
            set { Id = _id; }
        }
        private string Nome;
        public string _nome
        {
            get { return Nome; }
            set
            {
                if (ValidarNome.IsNome(_nome))
                {
                    Nome = _nome;
                }
                throw new ArgumentException("Nome Inválido");
            }
        }
        private string SobreNome;
        public string _sobreNome
        {
            get { return SobreNome; }
            set
            {
                if (ValidarNome.IsNome(_sobreNome))
                {
                    SobreNome = _sobreNome;
                }
                throw new ArgumentException("Sobre nome inválido");
            }
        }
        private string CPF;
        public string _cpf
        {
            get { return CPF; }
            set
            {
                if (ValidarCpf.IsCpf(_cpf))
                {
                    CPF = _cpf;
                }
                throw new ArgumentException("CPF inválido");
            }
        }
        private DateTime DataNascimento;
        public DateTime _dataNascimento
        {
            get { return DataNascimento; }
            set { DataNascimento = _dataNascimento; }
        }
        private decimal Saldo;
        public decimal _saldo
        {
            get { return Saldo; }
            set { Saldo = _saldo; }
        }
        private EnumStatusConta ContaStatus;
        public EnumStatusConta _contaStatus
        {
            get { return ContaStatus; }
            set { ContaStatus = _contaStatus; }
        }

    }
}
