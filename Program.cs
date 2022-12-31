using HotelCSharp.Entities;
using HotelCSharp.Exceptions;
using HotelCSharp.Interfaces;

Console.Clear();

string nomeProjeto = "########### Hotel CSharp ############";
Console.Clear();
Console.WriteLine("#".PadRight(nomeProjeto.Length, '#'));
Console.WriteLine(nomeProjeto);
Console.WriteLine("#".PadRight(nomeProjeto.Length, '#'));

ICamareira camareira1 = new Camareira("Mulher Gato", "", "01133445566","F");
ICamareira camareira2 = new Camareira("Zorro", "46545678564", "05122179951","M");

IRecepcionista recepcionista1 = new Recepcionista("Tempestade", "98765432100", "01777665544", "F");
IRecepcionista recepcionista2 = new Recepcionista("Homem de Ferro", "07734125648", "04441521324", "M");

IGerente gerente1 = new Gerente("Viúva Negra", "44455566610", "021999994444", "F");
IGerente gerente2 = new Gerente("Professor Charles", "94521314855", "019743544567", "M");

var hotel = new Hotel(
    "Hotel CSharp",
    new Endereco("Universo dos Herois", "2023", "Fundos", "Quadrinhos", "Dos Cinemas", "RO", "12345000", "02948670147")
);

hotel.ContratarCamareira(camareira1);
hotel.ContratarCamareira(camareira2);
hotel.ContratarRecepcionista(recepcionista1);
hotel.ContratarRecepcionista(recepcionista2);
hotel.ContratarGerente(gerente1);
hotel.ContratarRecepcionista(gerente2);

#region ApenasTestes
/*
hotel.Gerente?.Apresentacao();
hotel.Gerente?.ArrumarCama();
hotel.Gerente?.AtenderTelefone();
hotel.Gerente?.LimparQuarto();
hotel.Gerente?.FalarIngles();

Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine();

hotel.Camareiras
    .ForEach(c => 
                {
                    c.Apresentacao();
                    c.ArrumarCama();
                    c.LimparQuarto();
                    Console.WriteLine("****");
                }
            );

Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine();

hotel.Recepcionistas
    .ForEach(c => 
                {
                    c.Apresentacao();
                    c.AtenderTelefone();
                    c.FalarIngles();
                    Console.WriteLine("****");
                }
            );

Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine();
*/
#endregion 

IRHTerceirizado rh = new RH("Top Squad DHO", hotel);

var camareira3 = new Camareira("She-Ra", "123", "1144556677", "F");
var recepcionista3 = new Recepcionista("Harry Potter", "77889", "41997854125", "F");

rh.ContratarCamareira(camareira3);
rh.ContratarRecepcionista(recepcionista3);

ListarRecepcionistas();
ListarCamareiras();

try
{
    rh.PromoverParaGerente((Camareira)camareira1);
    hotel.Camareiras.Remove(camareira1);
    hotel?.Gerente?.Apresentacao();
}
catch (DocumentosInvalidosException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

ListarCamareiras();

void ListarRecepcionistas()
{
    Console.WriteLine($"Recepcionistas no quadro: {hotel?.Recepcionistas.Count}\n\n");

    hotel?.Recepcionistas
    .ForEach(c => 
                {
                    Console.WriteLine(c);
                    Console.WriteLine("****");
                }
            );

Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine();
}

void ListarCamareiras()
{
    Console.WriteLine($"Camareiras no quadro: {hotel?.Camareiras.Count}\n\n");

    hotel?.Camareiras
    .ForEach(c => 
                {
                    Console.WriteLine(c);
                    Console.WriteLine("****");
                }
            );

Console.WriteLine();
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine();
}