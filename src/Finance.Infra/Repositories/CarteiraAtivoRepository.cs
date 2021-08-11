using System.Collections.Generic;
using System.Linq;
using Finance.Domain.Interfaces;
using Finance.Domain.Models;
using Finance.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Finance.Infra.Repositories
{
    public class CarteiraAtivoRepository :  ICarteiraAtivosRepository
    {
        protected readonly AppDbContext _context;
        public CarteiraAtivoRepository(AppDbContext context)
        {
            _context = context;
        }

        public  AtivosCarteira GetById(int id)
        {
            var query = _context.Set<AtivosCarteira>().Where(e => e.Id == id);

            if(query.Any())
                return query.First();

            return null;
        }

        public  Carteira GetAtivosCarteiraById(int id)
        {
            var query = _context.Set<Carteira>().Where(e => e.Id == id).
                                Include(e => e.AtivosCarteira).ThenInclude(o => o.Ativo)
                                    .Include(e => e.Cliente);

            if(query.Any())
                return query.First();

            return null;
        }

        public IEnumerable<AtivosCarteira> GetAll()
        {
            var query = _context.Set<AtivosCarteira>();

            return query.Any() ? query.ToList() : new List<AtivosCarteira>();
        }
        public virtual void Save(AtivosCarteira entity)
        {

        }

    }
}