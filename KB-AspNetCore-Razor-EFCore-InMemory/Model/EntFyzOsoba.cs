using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KB_AspNetCore_Razor_EFCore_InMemory.Model
{
  public class EntFyzOsoba
  {
    [MaxLength(20)]
    public string ID { get; set; }

    [MaxLength(100)]
    public string FYZOSOBA_PRIJMENI { get; set; }

    [MaxLength(100)]
    public string FYZOSOBA_JMENO { get; set; }

    public DateTime FYZOSOBA_DATUM_NAROZENI { get; set; }

    [MaxLength(20)]
    public string POZNAMKA { get; set; }
  }
}
