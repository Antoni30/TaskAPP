﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly TaskAPP.Data.TaskAPPContext _context;

        public IndexModel(TaskAPP.Data.TaskAPPContext context)
        {
            _context = context;
        }

        public IList<Estudiante> Estudiante { get;set; } = default!;
        public IList<Tarea> Tarea { get;set; }=default!;
        

        public async Task OnGetAsync()
        {
            Estudiante = await _context.Estudiante.ToListAsync();
            Tarea = await _context.Tarea.ToListAsync();
        }
    }
}
