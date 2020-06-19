using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Models
{
    public class BreedType
    {

     
        [Key]
        public int idBreedType { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }


        public virtual ICollection<Pet> Pets { get; set; }


    }
}
