using Fiap.TechChallenge.Fase1.Data.Entidades;
using Fiap.TechChallenge.Fase1.Data.Repository;
using Fiap.TechChallenge.Fase1.Data.Repository.Contato;
using Fiap.TechChallenge.Fase1.Infraestructure.DTO;
using Fiap.TechChallenge.Fase1.Infraestructure.DTO.Contato;
using Fiap.TechChallenge.Fase1.Infraestructure.DTO.Usuario;
using Fiap.TechChallenge.Fase1.SharedKernel;
using Fiap.TechChallenge.Fase1.SharedKernel.Model;

namespace Fiap.TechChallenge.Fase1.Dominio
{ 
    public class ContatoService : IContatoService
    {
        private readonly IContatoRepository _contatoRepository;
        private List<string> _mensagem = new List<string>();
        private const int WorkFactor = 12;
        public ContatoService(IContatoRepository contatoRepository)
        {

            _contatoRepository = contatoRepository;
        }

        public async Task<ResponseModel> SalvarContato(ContatoDTO dto)
        {
            var contato = new Contato(dto.Nome, dto.DDD, dto.Telefone, dto.Email);

            _contatoRepository.AdicionarAsync(contato);

            _mensagem.Add(MensagemErroGenerico.MENSAGEM_SUCESSO);



            return;
        }

        public Task<ResponseModel> ConsultaContato(ContatoDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel> EditarContato(ContatoDTO dto)
        {
            throw new NotImplementedException();
        }
    }
} 
