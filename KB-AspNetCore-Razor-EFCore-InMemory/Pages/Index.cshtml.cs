using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KB_AspNetCore_Razor_EFCore_InMemory.Model;

namespace KB_AspNetCore_Razor_EFCore_InMemory.Pages
{
    public class IndexModel : PageModel
    {
      private readonly InMemoryDbContext _context;

      public IndexModel(InMemoryDbContext context)
      {
        _context = context;
      }

      public EntFyzOsoba entFyzOsoba{ get; set; }

      public async Task OnGetAsync()
      {
        entFyzOsoba = _context.EntFyzOsoba.FirstOrDefault<EntFyzOsoba>(x => x.ID == "20190114222300000001");
      }
    }
}