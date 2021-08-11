using Finance.Domain.Interfaces;
namespace Finance.Domain.Models
{
    
    public class AtivosCarteiraService 
    {
        private readonly ICarteiraAtivosRepository _carteiraAtivoRepository;
        public AtivosCarteiraService(ICarteiraAtivosRepository carteiraAtivoRepository)
        {
             _carteiraAtivoRepository = carteiraAtivoRepository;
        }

        public Carteira GetAtivosCarteiraById(int id)
        {
            return _carteiraAtivoRepository.GetAtivosCarteiraById(id);
        }

    }

}