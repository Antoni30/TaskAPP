using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPP.Models;

namespace TaskAPP.Data
{
    public class TaskAPPContext : DbContext
    {
        public TaskAPPContext (DbContextOptions<TaskAPPContext> options)
            : base(options)
        {
        }

        public DbSet<TaskAPP.Models.Tarea> Tarea { get; set; } = default!;
        public DbSet<TaskAPP.Models.Estudiante> Estudiante { get; set; } = default!;
    }
}
