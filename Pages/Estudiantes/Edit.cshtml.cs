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
    public class EditModel : PageModel
    {
        private readonly TaskAPP.Data.TaskAPPContext _context;

        public EditModel(TaskAPP.Data.TaskAPPContext context)
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

            var estudiante =  await _context.Estudiante.FirstOrDefaultAsync(m => m.Id == id);
            LoadTareas();
            if (estudiante == null)
            {
                return NotFound();
            }
            Estudiante = estudiante;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Estudiante).State = EntityState.Modified;
            LoadTareas();

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstudianteExists(Estudiante.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }
        private bool EstudianteExists(int id)
        {
            return _context.Estudiante.Any(e => e.Id == id);
        }
    }
}
