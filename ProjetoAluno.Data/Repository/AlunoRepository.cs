﻿using ProjetoAluno.Data.Context;
using ProjetoAluno.Data.Repository.Interface;
using ProjetoAluno.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAluno.Data.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly DbContexto _db;

        public AlunoRepository(DbContexto db)
        {
            _db = db;
        }

        public void Adicionar(Aluno aluno)
        {
            _db.Add(aluno);
            _db.SaveChanges();
        }

        public List<Aluno> ListarAlunos(int paginaAtual, int itensPorPagina, out int totalItens)
        {
            totalItens = _db.Alunos.Count();

            return _db.Alunos
                   .OrderBy(a => a.Id)
                   .Skip((paginaAtual - 1) * itensPorPagina)
                   .Take(totalItens)
                   .ToList();
        }

        public List<Aluno> ListarAtivos(int paginaAtual, int itensPorPagina, int ativo, out int totalItens)
        {
            var query = _db.Alunos.Where(a => a.Status == 1); // ← agora usa o parâmetro

            totalItens = query.Count();

            return query
                .OrderBy(a => a.Id)
                .Skip((paginaAtual - 1) * itensPorPagina)
                .Take(itensPorPagina)
                .ToList();
        }

        public List<Aluno> ListarInativos(int paginaAtual, int itensPorPagina, int inativo, out int totalItens)
        {
            var query = _db.Alunos.Where(a => a.Status == 0);
            totalItens = query.Count();

            return query
                .OrderBy(a => a.Id)
                .Skip((paginaAtual - 1) * itensPorPagina)
                .Take(itensPorPagina)
                .ToList();
        }
    }
}
