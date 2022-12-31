namespace HotelCSharp.Interfaces
{
    public interface IGerente : ICamareira, IRecepcionista, IPessoa
    {
         void ApresentarHotel();
    }
}