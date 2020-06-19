using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Models
{
    public class Pet
    {
        [Key]
        public int IdPet { get; set; }
        [ForeignKey("BreedType")]
        public int IdBreedType { get; set; }
        public string Name { get; set; }
        public bool isMale { get; set; }
        public DateTime DateRegistered { get; set; }
        public DateTime ApprocimateDateOfBirth { get; set; }
        public DateTime? AdoptedDate { get; set; }

        public virtual BreedType BreedType { get; set; }
        public virtual ICollection<Volunteer_Pet> Volunteer_Pets { get; set; }
    }
}
