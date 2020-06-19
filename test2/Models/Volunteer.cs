using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Models
{
    public class Volunteer
    {
        [Key]
        public int IdVolunteer { get; set; }
        [ForeignKey("Supervisor")]
        public int? IdSupervisor { get; set; }
        [MaxLength(80)]
        public string Name { get; set; }
        [MaxLength(80)]
        public string Surname { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(80)]
        public string Email { get; set; }
        public DateTime StartingDate { get; set; }

        public virtual Volunteer Supervisor { get; set; }
        public virtual ICollection<Volunteer_Pet> Volunteer_Pets { get; set; }
        public virtual ICollection<Volunteer> Volunteers { get; set; }

    }
}
