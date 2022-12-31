namespace HotelCSharp.Entities
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, string cpf, string telefone, string sexo) : base(nome, cpf, telefone, sexo)
        {
        }

        public override void Apresentacao()
        {
            Console.WriteLine($"Olá, sou {(Sexo.ToUpper() == "M" ? "o" : "a")} {Nome}");
            Console.WriteLine();
        }
    }
}