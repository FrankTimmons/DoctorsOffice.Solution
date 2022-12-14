using System.Collections.Generic;

namespace DoctorsOffice.Models
{
  public class Specialty
  {
    public Specialty()
    {
      this.JoinEntities = new HashSet<DoctorSpecialty>();
    }

    public int SpecialtyId { get; set; }
    public string Description { get; set; }

    public virtual ICollection<DoctorSpecialty> JoinEntities { get;}
  }
}