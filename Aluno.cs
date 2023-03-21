using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5___081220002
{
    internal class Aluno
    {
        private string nome;
        private double nota1;
        private double nota2;

        public string Nome
        {
            get => nome;
            set
            {
                if (value.Trim().Length == 0)
                    throw new Exception("Um nome deve ser cadastrado!");
                else
                    nome = value;
            }
        }
        public double Nota1
        {
            get => nota1;
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Insira uma nota entre 0 e 10");
                else
                    nota1 = value;
            }
        }
        public double Nota2
        {
            get => nota2;
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Insira uma nota entre 0 e 10");
                else
                    nota2 = value;
            }
        }

        public double Media
        {
            get => (nota1 + nota2) / 2;
        } 
    }
}
