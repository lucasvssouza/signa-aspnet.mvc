using Microsoft.EntityFrameworkCore;

namespace SIGNA.Models
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options)
        {

        }

        public DbSet<DataModel> PESSOA { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataModel>().HasData(
                    new DataModel
                    {
                        PESSOA_ID = 1,
                        NOME_FANTASIA = "Coca Coallers",
                        CNPJ_CPF = "694.678.770-66"
                    },
                    new DataModel
                    {
                        PESSOA_ID = 2,
                        NOME_FANTASIA = "Nika",
                        CNPJ_CPF = "265.752.130-49"
                    },
                    new DataModel
                    {
                        PESSOA_ID = 3,
                        NOME_FANTASIA = "DJDonalds",
                        CNPJ_CPF = "102.584.620-60"
                    },
                    new DataModel()
                    {
                        PESSOA_ID = 4,
                        NOME_FANTASIA = "Soda King",
                        CNPJ_CPF = "984.814.520-68"
                    },
                    new DataModel
                    {
                        PESSOA_ID = 5,
                        NOME_FANTASIA = "Pólen Station",
                        CNPJ_CPF = "563.968.300-78"
                    },
                    new DataModel
                    {
                        PESSOA_ID = 6,
                        NOME_FANTASIA = "Beto Carreto",
                        CNPJ_CPF = "720.070.510-10"
                    },
                    new DataModel
                    {
                        PESSOA_ID = 7,
                        NOME_FANTASIA = "Mercadão",
                        CNPJ_CPF = "834.227.360-18"
                    },
                    new DataModel
                    {
                        PESSOA_ID = 8,
                        NOME_FANTASIA = "Suprema",
                        CNPJ_CPF = "425.927.670-02"
                    },
                    new DataModel
                    {
                        PESSOA_ID = 9,
                        NOME_FANTASIA = "Grapes",
                        CNPJ_CPF = "878.451.000-56"
                    },
                    new DataModel
                    {
                        PESSOA_ID = 10,
                        NOME_FANTASIA = "Soni Edison",
                        CNPJ_CPF = "467.754.590-17"
                    });
        }
    }
}
