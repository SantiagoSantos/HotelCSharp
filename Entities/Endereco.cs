namespace HotelCSharp.Entities
{
    public class Endereco
    {
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Uf { get; private set; }
        public string Cep { get; private set; }
        public string Telefone { get; private set; }
        
        public Endereco(string logradouro, string numero, string complemento, 
                        string bairro, string cidade, string uf, string cep,
                        string telefone)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Cep = cep;
            Telefone = telefone;
        }
    }
}