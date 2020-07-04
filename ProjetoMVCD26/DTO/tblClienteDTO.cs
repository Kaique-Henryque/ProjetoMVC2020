using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoMVCD26.DTO
{
    public class tblClienteDTO
    {
        private int id_cliente, tp_cliente;
        private string nome_cliente, sobrenome_cliente, email_cliente, senha_cliente, nome_mae, cpf_client;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Tp_cliente { get => tp_cliente; set => tp_cliente = value; }
        public string Sobrenome_cliente { get => sobrenome_cliente; set => sobrenome_cliente = value; }
        public string Email_cliente { get => email_cliente; set => email_cliente = value; }
        public string Senha_cliente { get => senha_cliente; set => senha_cliente = value; }

        public string Nome_cliente
        {
            set
            {
                if(value != string.Empty)
                {
                    this.nome_cliente = value;
                }
                else
                {
                    throw new Exception("O campo nome é inválido!");
                }
            }
            get { return this.nome_cliente; }
        }

        public string Nome_Mae
        {
            set
            {
                if(value != string.Empty)
                {
                    this.nome_mae = value;
                }
                else
                {
                    throw new Exception("O campo de Nome da Mãe é Inválido!");
                }
            }
            get { return this.nome_mae; }
        }

        public string Cpf_cliente
        {
            set
            {
                if(value != string.Empty)
                {
                    this.cpf_client = value;
                }
                else
                {
                    throw new Exception("O campo de Cpf é Inválido!");
                }
            }
            get { return this.cpf_client; }
        }
    }
}