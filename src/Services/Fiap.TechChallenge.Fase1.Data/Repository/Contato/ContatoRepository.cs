﻿using Fiap.TechChallenge.Fase1.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Fiap.TechChallenge.Fase1.Data.Repository
{
    public class ContatoRepository : Repository<Dominio.Entidades.Contato>, IContatoRepository
    {
        public ContatoRepository(ContextTechChallenge db) : base(db)
        {
        }

        public async Task<Dominio.Entidades.Contato> ObterPorEmailAsync(string email)
        {
            return await Db.Contato.FirstOrDefaultAsync(x => x.Email == email && x.Excluido == false);
        }

        public async Task<List<Dominio.Entidades.Contato>> BuscaContatosPorDDD(int DDD)
        {
            return await Db.Contato.Where(x => x.DDD == DDD && x.Excluido == false).ToListAsync();
        }

        public async Task<Dominio.Entidades.Contato> ObterPorIdAsync(Guid id)
        {
            return await Db.Contato.FirstOrDefaultAsync(x => x.Id == id && x.Excluido == false);
        }
    }
}
