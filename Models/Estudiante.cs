using System.ComponentModel.DataAnnotations;

namespace TaskAPP.Models;
    public class Estudiante
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? IdTarea { get; set; }
    }

