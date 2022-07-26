using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class Cachorro
    {        //Caracteristicas//
        int QntPatas { get; set; }
        int Idade { get; set; }
        string Cor { get; set; }
        string Nome { get; set; }
        string Raça { get; set; }

        public Cachorro()
        {
        }

        public Cachorro(int qdtPatas, int idade, string cor, string nome, string raça)
        {
            QntPatas = qdtPatas;
            this.Idade = idade;
            this.Cor = cor;
            Nome = nome;
            Raça = raça;
        }




        //Ações//
        public void Auau()
        {
            Console.WriteLine("Auauau!!!");
        }
        public void Caminhar()
        {
            Console.WriteLine("Estou caminhando");
        }
        public void Pular()
        {
            Console.WriteLine("Estou pulando");
        }
        public void Corre()
        {
            Console.WriteLine("Estou correndo");
        }
        public override string ToString()
        {
            return $"Raça: {Raça} - Nome {Nome} - Cor {Cor} - Idade {Idade} - QntPatas {QntPatas}";
        }



    }

}
