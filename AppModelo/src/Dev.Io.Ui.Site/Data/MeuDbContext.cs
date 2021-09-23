using Dev.Io.Ui.Site.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.Io.Ui.Site.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options)
        :base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; } //Nome da Tabela
    }
}
