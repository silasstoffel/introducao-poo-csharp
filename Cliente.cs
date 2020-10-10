using System;

namespace ByteBank
{
    public class Cliente
    {
        private string nome;
        private string cpf;
        private string profissao;

        public Cliente(string cpf = null, string nome = null, string profissao = null)
        {
            this.SetCpf(cpf)
                .SetNome(nome)
                .SetProfissao(profissao);

        }

        public Cliente SetCpf(string cpf)
        {
            this.cpf = cpf;
            return this;
        }
        public string GetCpf()
        {
            return this.cpf;
        }

        public Cliente SetNome(string nome)
        {
            this.nome = nome;
            return this;
        }
        public string GetNome()
        {
            return this.nome;
        }

        public Cliente SetProfissao(string profissao)
        {
            this.profissao = profissao;
            return this;
        }
        public string GetProfissao()
        {
            return this.profissao;
        }


    }
}