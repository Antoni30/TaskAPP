using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskAPP.Data;
using TaskAPP.Models;

namespace TaskAPP.Pages.Estudiantes
{
    public class DeleteModel : PageModel
    {
        private readonly TaskAPP.Data.TaskAPPContext _context;

        public DeleteModel(TaskAPP.Data.TaskAPPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Estudiante Estudiante { get; set; } = default!;
        public IList<Tarea> Tarea { get; set; } = default!;
        private async void LoadTareas()
        {
            Tarea = await _context.Tarea.ToListAsync();
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LoadTareas();
            var estudiante = await _context.Estudiante.FirstOrDefaultAsync(m => m.Id == id);

            if (estudiante == null)
            {
                return NotFound();
            }
            else
            {
                Estudiante = estudiante;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudiante = await _context.Estudiante.FindAsync(id);
            LoadTareas();
            if (estudiante != null)
            {
                Estudiante = estudiante;
                _context.Estudiante.Remove(Estudiante);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
