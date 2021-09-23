using Dev.Io.Ui.Site.Data;
using Dev.Io.Ui.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.Io.Ui.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TesteCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Farley Rufino",
                DataNascimento = DateTime.Now,
                Email="Farley.t.i@hotmail.com"
            };

            //Add
            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            //Selecionar
            var aluno2 = _contexto.Alunos.Find(aluno.Id);
            var aluno3 = _contexto.Alunos.FirstOrDefault(a=> a.Email== "Farley.t.i@hotmail.com");
            var aluno4 = _contexto.Alunos.Where(n => n.Nome == "Farley Rufino");

            //Alterar
            aluno.Nome = "Joao";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            //Excluir
            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            return View();
        }
    }
}
