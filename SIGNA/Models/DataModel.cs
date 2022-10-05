using System.ComponentModel.DataAnnotations;

namespace SIGNA.Models
{
    public class DataModel
    {
        [Key, Required]
        public int PESSOA_ID { get; set; }

        [Required, MaxLength(255)]
        public string NOME_FANTASIA { get; set; }
    
        [Required, MaxLength(20)]
        public string CNPJ_CPF { get; set; }
    }
}
