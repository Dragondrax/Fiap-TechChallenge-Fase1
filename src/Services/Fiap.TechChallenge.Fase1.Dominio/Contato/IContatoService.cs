using Fiap.TechChallenge.Fase1.Infraestructure.DTO;
using Fiap.TechChallenge.Fase1.Infraestructure.DTO.Contato;
using Fiap.TechChallenge.Fase1.Infraestructure.DTO.Usuario;
using Fiap.TechChallenge.Fase1.SharedKernel.Model;

namespace Fiap.TechChallenge.Fase1.Dominio
{
    public interface IContatoService
    {
        Task<ResponseModel> SalvarContato(ContatoDTO contato);
        Task<ResponseModel> ConsultaContato(ContatoDTO contato);
        Task<ResponseModel> EditarContato(ContatoDTO contato);
    }
}
