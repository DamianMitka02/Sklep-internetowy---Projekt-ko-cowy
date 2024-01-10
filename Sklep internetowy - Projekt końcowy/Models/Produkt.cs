using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Produkty.Models
{
    public class Produkt
    { 

        [Key]
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string Nazwa { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Opis { get; set; }

        [Column(TypeName = "int")]
        public int Ocena { get; set; }
    }
}
