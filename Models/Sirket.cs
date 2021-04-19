using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternAPI.Models
{
    public class Sirket
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        public string Ad { get; set; }
        [StringLength(50)]
        public string Kod { get; set; }
        [StringLength(50)]
        public string Sektör { get; set; }
        [StringLength(50)]
        public string Adres { get; set; }
        [StringLength(50)]
        public string Telefon { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        [StringLength(50)]
        public string Site { get; set; }
    }
}