using System;
using System.Collections.Generic;
using System.Linq;
using Finance.Domain.Interfaces;
using Finance.Domain.Models;
using Finance.Infra.Context;
namespace Finance.Infra.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }        
        public virtual TEntity GetById(int id)
        {
            var query = _context.Set<TEntity>().Where(e => e.Id == id);
            if(query.Any())
                return query.FirstOrDefault();
            return null;
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            var query = _context.Set<TEntity>();
            if(query.Any())
                return query.ToList();
            return new List<TEntity>();
        }
        public virtual void Save(TEntity entity)
        {

            //          var cliente = new Cliente
            // {
            //     Nome = "Rodrigo",
            //     CEP = "13203554",
            //     Cidade = "Jundiai",
            //     Estado = "SP",
            //     Telefone = "11963379743",
            //     DataCriacao = DateTime.Now
            // };

            // _context.Set<Cliente>().Add(cliente);   

            

            // var categoria = new Categoria
            // {
            //     Nome = "Ações",
            //     DataCriacao = DateTime.Now
                
            // };

            // _context.Set<Categoria>().Add(categoria);  

            var ativo = new Ativo("VVAR3", 1);
            // var ativo2 = new Ativo("ITSA4", 1);
            // var ativ3 = new Ativo("MEAL3", 1);
            // ativo.Categoria = categoria;

            // var listAtivos = new List<Ativo>();
            // listAtivos.Add(ativo);
            // listAtivos.Add(ativo2);
            // listAtivos.Add(ativ3);

            // _context.Set<Ativo>().AddRange(listAtivos); 

            // var corretora = new Corretora
            // {
            //      DataCriacao = DateTime.Now,
            //     Nome = "CLEAR"
            // };

            // // _context.Set<Corretora>().Add(corretora); 
            //  var carteira = new Carteira
            // {
            //   IdCliente = 2,
            //   Corretora = new Corretora
            // {
            //      DataCriacao = DateTime.Now,
            //     Nome = "CLEAR"
            // },
            //   DataCriacao = DateTime.Now
            // };

            // _context.Set<Carteira>().Add(carteira); 

            //    _context.SaveChanges();

            var AtivosCarteira = new List<AtivosCarteira>
            {
new AtivosCarteira
{
 CarteiraId = 6,
 AtivoId = 2,
 DataCriacao = DateTime.Now,
 Quantidade = 995,
 Valor = 11.54m,
 delete = false

            },
            new AtivosCarteira
{
 CarteiraId = 6,
 AtivoId = 1,
 DataCriacao = DateTime.Now,
 Quantidade = 1100,
 Valor = 11.94m,
 delete = false

            }
         };

           _context.Set<AtivosCarteira>().AddRange(AtivosCarteira);  

           _context.SaveChanges();


            //_context.Set<TEntity>().Add(entity);   
        }
    }
}