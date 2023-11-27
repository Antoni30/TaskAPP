using System.ComponentModel.DataAnnotations;

namespace TaskAPP.Models
{
    public class Tarea
    {
        //Cremos el modelo que va a poseer nuestros datos
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
       [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }
        public bool Done { get; set; }

    }
}


