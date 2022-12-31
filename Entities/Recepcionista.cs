using System.Text;
using HotelCSharp.Interfaces;

namespace HotelCSharp.Entities
{
    public class Recepcionista : Pessoa, IRecepcionista
    {
        public Recepcionista(string nome, string cpf, string telefone, string sexo) : base(nome, cpf, telefone, sexo)
        {
        }

        public override void Apresentacao()
        {
            Console.WriteLine($"Olá, sou {(Sexo.ToUpper() == "M" ? "o" : "a")} Recepcionista, {Nome}");
            Console.WriteLine();
        }

        public void AtenderTelefone()
        {
            string periodo;
            int hora = DateTime.Now.Hour;

            if (hora < 12)
            {
                periodo = "bom dia";
            }
            else if ( hora < 18)
            {
                periodo = "boa tarde";
            }
            else
            {
                periodo = "boa noite";
            }

            Console.WriteLine($"Hotel XPTO, {periodo}");
            Console.WriteLine();
        }

        public void FalarIngles()
        {
            Console.WriteLine("I'm speak english... a little");
            Console.WriteLine();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Recepcionista: {Nome}");
            sb.AppendLine($"CPF: {Cpf}");
            sb.AppendLine($"Telefone: {Telefone}");
            sb.AppendLine($"Gênero: {(Sexo == "M" ? "Masculino" : "Feminino")}");

            return sb.ToString();
        }
    }
}