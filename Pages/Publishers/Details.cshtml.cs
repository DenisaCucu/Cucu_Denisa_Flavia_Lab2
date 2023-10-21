using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cucu_Denisa_Flavia_Lab2_1_.Data;
using Cucu_Denisa_Flavia_Lab2_1_.Models;

namespace Cucu_Denisa_Flavia_Lab2_1_.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Cucu_Denisa_Flavia_Lab2_1_.Data.Cucu_Denisa_Flavia_Lab2_1_Context _context;

        public DetailsModel(Cucu_Denisa_Flavia_Lab2_1_.Data.Cucu_Denisa_Flavia_Lab2_1_Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
