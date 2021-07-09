using System.Collections.Generic;
using System.Linq;
using Finance.Domain.Models;
using Finance.Infra.Context;
namespace Finance.Infra.Repositories
{
    public class AtivoRepository : Repository<Ativo>
    {
        public AtivoRepository(AppDbContext context) : base(context)
        {}

        public override Ativo GetById(int id)
        {
            var query = _context.Set<Ativo>().Where(e => e.Id == id);

            if(query.Any())
                return query.First();

            return null;
        }

        public override IEnumerable<Ativo> GetAll()
        {
            var query = _context.Set<Ativo>();

            return query.Any() ? query.ToList() : new List<Ativo>();
        }
    }
}