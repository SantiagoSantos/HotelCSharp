using System.Text;
using HotelCSharp.Interfaces;

namespace HotelCSharp.Entities
{
    public class Camareira : Pessoa, ICamareira
    {
        public Camareira(string nome, string cpf, string telefone, string sexo) : base(nome, cpf, telefone, sexo)
        {
        }

        public override void Apresentacao()
        {
            Console.WriteLine($"Olá, sou {(Sexo.ToUpper() == "M" ? "o camareiro" : "a camareira")} {Nome}");
            Console.WriteLine();
        }

        public void ArrumarCama()
        {
            Console.WriteLine("Sei como arrumar a cama.");
            Console.WriteLine();
        }

        public void LimparQuarto()
        {
            Console.WriteLine("Sei limpar o quarto.");
            Console.WriteLine();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Camareira: {Nome}");
            sb.AppendLine($"CPF: {Cpf}");
            sb.AppendLine($"Telefone: {Telefone}");
            sb.AppendLine($"Gênero: {(Sexo == "M" ? "Masculino" : "Feminino")}");

            return sb.ToString();
        }
    }
}