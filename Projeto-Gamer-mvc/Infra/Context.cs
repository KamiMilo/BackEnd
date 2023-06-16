using Microsoft.EntityFrameworkCore;
using Projeto_Gamer_mvc.Models;

namespace Projeto_Gamer_mvc.Infra
{
    //Classe para configurar o Banco de dados.
    public class Context : DbContext
    {
        public Context()
        {
            
        }

        public Context(DbContextOptions<Context>options) :base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)
            {
            //sTRING DE CONEXÃO COM O BANCO.
            //Data Source: gerenciador do banco.
            //inital catalog: nome do banco de dados

            //AUTENTICAÇÃO PELO WINDOWNS
            //Integrated Security= true
            //TrustServerCertificate 

            //AUTENTICAÇÃO PELO SQL SERVER
            //Id User= "Nome do seu usúario de login"
            //Password= "senha do seu usúario"
            //pwd="senha do usúario"

                 optionsBuilder.UseSqlServer("Data Source = NOTE01-S15; initial catalog=Projeto-Gamer-mvc GamerProject;user Id=sa; pwd= Senai@134;TrustServerCertificate= true");

                //  optionsBuilder.UseSqlServer("Data Source = LAPTOP-PNE5VUNU\\SQLEXPRESS; initial catalog=Projeto-Gamer-mvc GamerProject;user Id=sa; pwd=12345;TrustServerCertificate= true");
                 
                //optionsBuilder.UseSqlServer("Data Source = LAPTOP-PNE5VUNU\\SQLEXPRESS; initial catalog=Projeto-Gamer-mvc GamerProject;Integrated Security= true;TrustServerCertificate= true");
            }
        }

        //Transforma as classes em tabelas no Banco de dados.
        public DbSet<Jogador> Jogador {get; set;}
        public DbSet<Equipe> Equipe {get; set;}

    }
}