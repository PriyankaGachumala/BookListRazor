using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class EditBookModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public EditBookModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Book Book { get; set; }
        public async Task OnGet(int id)
        {
            Book = await _db.Book.FindAsync(id);

        }
        public async Task<IActionResult> OnPost() 
        { 
            if(ModelState.IsValid)
            {
                var BookFromDB = await _db.Book.FindAsync(Book.Id);
                BookFromDB.Name = Book.Name;
                BookFromDB.Author = Book.Author;
                BookFromDB.Cost = Book.Cost;
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}