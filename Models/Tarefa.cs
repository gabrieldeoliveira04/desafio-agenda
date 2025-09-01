using System.ComponentModel.DataAnnotations;

namespace TrilhaApiDesafio.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Titulo { get; set; }

        [MaxLength(1000)]
        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        public EnumStatusTarefa Status { get; set; }
    }
}

