using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LojaVirtual.Database
{
    public class LojaVirtualContext : DbContext
    {
        //ORM - Object Relation Mapping
        //Biblioteca para mapear Objetos para Bancos de dados relacionais

        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options) : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        
        public DbSet<NewsletterEmail> NewsletterEmails { get; set; }

    }
}