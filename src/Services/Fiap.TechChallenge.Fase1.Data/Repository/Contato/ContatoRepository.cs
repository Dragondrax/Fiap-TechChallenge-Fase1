
using Fiap.TechChallenge.Fase1.Data.Context;
using Fiap.TechChallenge.Fase1.SharedKernel.Data;
using Microsoft.EntityFrameworkCore;

namespace Fiap.TechChallenge.Fase1.Data.Repository.Contato
{
    public class ContatoRepository : Repository<Entidades.Contato>, IContatoRepository
    {
        public ContatoRepository(ContextTechChallenge db) : base(db)
        {

        }

        public Task AdicionarAsync(Data.Entidades.Contato entidade)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarAsync(Data.Entidades.Contato entidade)
        {
            throw new NotImplementedException();
        }

        public Task RemoverAsync(Data.Entidades.Contato entidade)
        {
            throw new NotImplementedException();
        }

        Task<Data.Entidades.Contato> IRepository<Data.Entidades.Contato>.ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
