using HotelCSharp.Interfaces;

namespace HotelCSharp.Entities
{
    public class Gerente : Pessoa, IGerente
    {
        public Gerente(string nome, string cpf, string telefone, string sexo) : base(nome, cpf, telefone, sexo)
        {
        }

        public override void Apresentacao()
        {
            Console.WriteLine($"Olá, sou {(Sexo.ToUpper() == "M" ? "o" : "a")} Gerente, {Nome}");
            Console.WriteLine();
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine();
        }

        public void ApresentarHotel()
        {
            Console.WriteLine($"Seja bem-vindo ao Hotel CSharp.");
            Console.WriteLine();
        }

        public void ArrumarCama()
        {
            Console.WriteLine("Sou o gerente e sei como arrumar a cama.");
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
            Console.WriteLine("I'm the Manager and I speak english");
            Console.WriteLine();
        }

        public void LimparQuarto()
        {
            Console.WriteLine("Sou o gerente e sei limpar o quarto.");
            Console.WriteLine();
        }
    }
}