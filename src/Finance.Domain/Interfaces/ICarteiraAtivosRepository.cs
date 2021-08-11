using System.Collections.Generic;
using Finance.Domain.Models;

namespace Finance.Domain.Interfaces
{
    public interface ICarteiraAtivosRepository
    {
        Carteira GetAtivosCarteiraById(int id);
        AtivosCarteira GetById(int id);
        IEnumerable<AtivosCarteira> GetAll();
        void Save(AtivosCarteira entity);
    }
}