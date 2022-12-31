using HotelCSharp.Exceptions;
using HotelCSharp.Interfaces;

namespace HotelCSharp.Entities
{
    public class RH : IRHTerceirizado
    {
        public string? NomeEmpresa { get; private set; }
        public Hotel? Hotel { get; private set; }
        public RH(string nomeEmpresa, Hotel hotel)
        {
            NomeEmpresa = nomeEmpresa;
            Hotel = hotel;
        }
        
        public void ContratarCamareira(ICamareira camareira)
        {
            Hotel?.Camareiras.Add(camareira);
        }

        public void ContratarRecepcionista(IRecepcionista recepcionista)
        {
            Hotel?.Recepcionistas.Add(recepcionista);
        }

        public void PromoverParaGerente(Camareira camareira)
        {

            if (string.IsNullOrEmpty(camareira.Cpf.Trim()))
            {
                throw new DocumentosInvalidosException($"{camareira.Nome}, seu CPF não está cadastrado. Regularize para estar apto(a) ao novo cargo.");
            }

            Hotel?.ContratarGerente(new Gerente(camareira.Nome, camareira.Cpf, camareira.Telefone, camareira.Sexo));
        }

        public void PromoverParaGerente(Recepcionista recepcionista)
        {
            if (string.IsNullOrEmpty(recepcionista.Cpf.Trim()))
            {
                throw new Exception("Documentação pendente. Regularize seu cadastro para estar apto à promoção.");
            }

            Hotel?.ContratarGerente(new Gerente(recepcionista.Nome, recepcionista.Cpf, recepcionista.Telefone, recepcionista.Sexo));
        }
    }
}