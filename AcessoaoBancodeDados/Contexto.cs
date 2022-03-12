using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AcessoaoBancodeDados.Entidades;
namespace AcessoaoBancodeDados
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt): base(opt) 
        {

        }
        public DbSet<Usuario> USUARIOS { get; set; }


    }
}
