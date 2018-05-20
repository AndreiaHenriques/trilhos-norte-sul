using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrilhosNorteSulWeb.Models
{
    public class Participantes
    {
        // criar construtor
        public Participantes()
        {
            ListaDeInscricoes = new HashSet<Inscricao>();
        }

        [Key]
        public int CodParticipante { get; set; } // chave primária

        // dados do Participante
        [Required]
        public string NomeProprio { get; set; }

        [Required]
        public string Apelido { get; set; }

        public string Fotografia { get; set; }

        [Required]
        public DateTime DataDeNascimento { get; set; }

        [Required]
        [StringLength(1)]
        public string Sexo  { get; set; }

        // criar uma lista de Inscricoes
        // associadas ao Participante
        public virtual ICollection<Inscricao> ListaDeInscricoes { get; set; }
    }
}