using System;

namespace ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Cliente(string cpf = null, string nome = null, string profissao = null)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Profissao = profissao;
        }


    }
}