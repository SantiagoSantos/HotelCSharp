using HotelCSharp.Interfaces;

namespace HotelCSharp.Entities
{
    public class Hotel
    {
        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public List<IRecepcionista> Recepcionistas { get; private set; }
        public List<ICamareira> Camareiras { get; private set; }
        public IGerente? Gerente { get; private set; }
        
        public Hotel(string nome, Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Recepcionistas = new();
            Camareiras = new();
        }

        public void ContratarGerente(IGerente gerente)
        {
            Gerente = gerente;
        }

        public void ContratarCamareira(ICamareira camareira)
        {
            Camareiras.Add(camareira);
        }

        public void ContratarRecepcionista(IRecepcionista recepcionista)
        {
            Recepcionistas.Add(recepcionista);
        }
    }
}