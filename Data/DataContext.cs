using BairroConnectAPI.Models;
using BairroConnectAPI.Models.Enuns;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BairroConnectAPI.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }
        public DbSet<Logins> TB_LOGINS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Logins>().HasData
            (

            new Logins() {  idPessoa = 1, nome = "Carlos", sobrenome = "Silva", email = "carlos.e.789999@gmail.com", dataNasc = new(2006, 08, 28), tipoConta = TipoConta.Organizador },
            new Logins() {  idPessoa = 2, nome = "Daniel", sobrenome = "Silva", email = "daniel.silva@gmail.com", dataNasc = new(2006, 04, 08), tipoConta = TipoConta.Organizador    },
            new Logins() {  idPessoa = 3, nome = "teste", sobrenome = "teste", email = "teste.e.@gmail.com", dataNasc = new(2006, 08, 28),  tipoConta = TipoConta.Municipe           }
        

            );
            modelBuilder.Entity<Logins>().HasKey(l => l.idPessoa);

        }
    }
}