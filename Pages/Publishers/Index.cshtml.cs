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
    public class IndexModel : PageModel
    {
        private readonly Cucu_Denisa_Flavia_Lab2_1_.Data.Cucu_Denisa_Flavia_Lab2_1_Context _context;

        public IndexModel(Cucu_Denisa_Flavia_Lab2_1_.Data.Cucu_Denisa_Flavia_Lab2_1_Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
