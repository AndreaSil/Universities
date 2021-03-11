using System.ComponentModel.DataAnnotations;

namespace UniversitiesExam.Models
{
    public class Rebelde
    {
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display (Name = "Planeta")]
        public string Planeta { get; set; }

        public Rebelde(string nombre, string planeta)

        {
            Nombre = nombre;
            Planeta = planeta;
        }
    }
}
