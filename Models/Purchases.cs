using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Term_Project_Version_1.Models
{
    public class Purchases
    {
        [Key]
        public string ID { get; set; }
        [Range(15, 500)]
        [Required]
        public string Price { get; set; }
        public string Description { get; set; }
        [ForeignKey("MembersID")]
        public int MembersID { get; set; }
        public Members Members { get; set; }

    }
}
