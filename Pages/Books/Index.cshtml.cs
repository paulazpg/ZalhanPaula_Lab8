using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZalhanPaula_Lab8.Data;
using ZalhanPaula_Lab8.Models;

namespace ZalhanPaula_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly ZalhanPaula_Lab8.Data.ZalhanPaula_Lab8Context _context;

        public IndexModel(ZalhanPaula_Lab8.Data.ZalhanPaula_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            //The Publiher entity is include in the query result
            Book = await _context.Book.Include(b=>b.Publisher).ToListAsync();   
        }
    }
}
