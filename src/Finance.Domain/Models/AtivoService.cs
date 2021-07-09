using Finance.Domain.Interfaces;
namespace Finance.Domain.Models
{
    public class AtivoService
    {
        private readonly IRepository<Ativo> _AtivoRepository;
        public AtivoService(IRepository<Ativo> AtivoRepository)
        {
            _AtivoRepository = AtivoRepository;
        }
        public void Save(int id, string nome, int  categoriaId)
        {
            var Ativo = _AtivoRepository.GetById(id);
            if(Ativo == null)
            {
                Ativo = new Ativo(nome,categoriaId);
                _AtivoRepository.Save(Ativo);
            }
            else
                Ativo.Update(nome, categoriaId);
        }
    }
}