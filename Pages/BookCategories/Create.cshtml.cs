﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZalhanPaula_Lab8.Data;
using ZalhanPaula_Lab8.Models;

namespace ZalhanPaula_Lab8.Pages.BookCategories
{
    public class CreateModel : PageModel
    {
        private readonly ZalhanPaula_Lab8.Data.ZalhanPaula_Lab8Context _context;

        public CreateModel(ZalhanPaula_Lab8.Data.ZalhanPaula_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["BookID"] = new SelectList(_context.Set<Book>(), "ID", "TitleAndAuthor");
            ViewData["CategoryID"] = new SelectList(_context.Set<Category>(), "ID", "CategoryName");
            return Page();
        }

        [BindProperty]
        public BookCategory BookCategory { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BookCategory.Add(BookCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
