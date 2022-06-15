using System.ComponentModel.DataAnnotations;

namespace CadastroProfessores1._0.Models
{
    public class Professor
    {
        [Key]
        public int IdProfessor { get; set; }
        public string NomeProfessor { get; set; }
        public string Diciplina  { get; set; }
        public int Telefone { get; set; }

        public string  Email { get; set; }

    }
}
