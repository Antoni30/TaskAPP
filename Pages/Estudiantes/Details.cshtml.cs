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
    public class DetailsModel : PageModel
    {
        private readonly TaskAPP.Data.TaskAPPContext _context;

        public DetailsModel(TaskAPP.Data.TaskAPPContext context)
        {
            _context = context;
        }

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

            var estudiante = await _context.Estudiante.FirstOrDefaultAsync(m => m.Id == id);
            LoadTareas();
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
    }
}
