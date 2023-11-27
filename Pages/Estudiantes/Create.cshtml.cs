using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskAPP.Data;
using TaskAPP.Models;

namespace TaskAPP.Pages.Estudiantes
{
    public class CreateModel : PageModel
    {
        private readonly TaskAPP.Data.TaskAPPContext _context;

        public CreateModel(TaskAPP.Data.TaskAPPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            LoadTareas();
            return Page();
        }

        [BindProperty]
        public Estudiante Estudiante { get; set; } = default!;
        public IList<Tarea> Tarea { get;set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                LoadTareas();
                return Page();
            }

            _context.Estudiante.Add(Estudiante);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        private async void LoadTareas()
        {
            Tarea = await _context.Tarea.ToListAsync();
        }
    }
}
