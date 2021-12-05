using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinhaDemoMvc.Models;

namespace MinhaDemoMvc.Data
{
    //cria as tabelas
    //add-migration Identity -Context MinhaDemoMvcContext
    //atualizar o banco de dados de novas tabelas
    //update-database -Context MinhaDemoMvcContext
    public class MinhaDemoMvcContext : DbContext
    {
        public MinhaDemoMvcContext (DbContextOptions<MinhaDemoMvcContext> options)
            : base(options)
        {
        }

        public DbSet<MinhaDemoMvc.Models.Filme> Filme { get; set; }
    }
}
