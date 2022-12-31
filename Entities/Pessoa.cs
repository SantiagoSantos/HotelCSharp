using HotelCSharp.Interfaces;

namespace HotelCSharp.Entities
{
    public abstract class Pessoa : IPessoa
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Telefone { get; private set; }
        public string Sexo { get; private set; }
        
        public Pessoa(string nome, string cpf, string telefone, string sexo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Sexo = sexo;
        }

        public virtual void Apresentacao()
        {
            Console.WriteLine($"Olá, sou {(Sexo == "M" ? "o" : "a")} {Nome}");
        }
    }
}