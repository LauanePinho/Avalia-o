using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação
{
    class Humano : Mamifero
    {
        private string Cpf;

        public void Sorri();
        {

        }

        public Humano(int Idade, string Som, float Velocidade, float Peso, string Cpf)
        {
            Idade = Idade;
            Peso = Peso;
            Som = Som;
            CPF = Cpf;
            Velocidade = Velocidade;
        }
        public string CPF
        {
            get
            {
                if (CPF == null)
                    Console.WriteLine("O CPF ainda não foi digitado");
                return Cpf;
            }
            set
            {
                if (value.Length > 11)
                    Console.WriteLine("CPF deve conter apenas 11 caracteres");
                else
                    Cpf = value;
            }
        }
    }
}
