using Fiap.TechChallenge.Fase1.SharedKernel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.TechChallenge.Fase1.Infraestructure.DTO.Contato
{
    public class ContatoDTO
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public int DDD { get; set; }
        public string Telefone { get; set; }
    }

    public class CriarContatoDTOValidator : AbstractValidator<ContatoDTO>
    {
        public CriarContatoDTOValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage(MensagemErroContato.MENSAGEM_EMAIL_NAO_PODE_SER_VAZIO)
                .NotNull()
                .WithMessage(MensagemErroContato.MENSAGEM_EMAIL_NAO_PODE_SER_NULO)
                .EmailAddress()
                .WithMessage(MensagemErroContato.MENSAGEM_EMAIL_NAO_ESTA_NO_FORMATO_CORRETO);

            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage(MensagemErroContato.MENSAGEM_NOME_NAO_PODE_SER_VAZIO)
                .NotNull()
                .WithMessage(MensagemErroContato.MENSAGEM_NOME_NAO_PODE_SER_NULO);

            RuleFor(x => x.DDD)
                .NotNull()
                .WithMessage(MensagemErroContato.MENSAGEM_ROLE_NAO_PODE_SER_NULO)
                .NotNull()
                .WithMessage(MensagemErroContato.MENSAGEM_EMAIL_NAO_PODE_SER_NULO);

            RuleFor(x => x.Telefone)
                .NotEmpty()
                .WithMessage(MensagemErroContato.MENSAGEM_SENHA_NAO_PODE_SER_VAZIO)
                .NotNull()
                .WithMessage(MensagemErroContato.MENSAGEM_SENHA_NAO_PODE_SER_NULO);
        }
    }
}
