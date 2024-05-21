﻿using Fiap.TechChallenge.Fase1.Infraestructure.Enum;
using Fiap.TechChallenge.Fase1.SharedKernel.Data;

namespace Fiap.TechChallenge.Fase1.Data.Entidades
{
    public class Usuario : Entity
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public Roles Role { get; private set; }

        public Usuario() { }

        public Usuario(string nome, string email, string senha, Roles role)
        {
            Nome = nome;
            Email = email.ToLower();
            Senha = senha;
            Role = role;
            AtualizarDtCadastro();
        }

        public void AlterarUsuario(string nome, string email, string senha, Roles role) 
        {
            Nome = nome;
            Email = email.ToLower();
            Senha = senha;
            Role = role;
            AtualizarDtAlteracao();
        }

        public void ExcluirUsuario()
        {
            Exclusao();
        }
    }
}
