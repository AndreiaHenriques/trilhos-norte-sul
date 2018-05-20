using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrilhosNorteSulWeb.Models
{
    public class Desafios
    {
        // criar o construtor
        public Desafios()
        {
            ListaDeTrilhos = new HashSet<Trilhos>();

            ListaDeInscricoes = new HashSet<Inscricao>();
        }

        [Key]
        public int CodDesafio { get; set; } // chave primária 

        // dados do Desafio
        public string FaixaEtaria { get; set; }

        public int GrauDificuldadeDesafio { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public int NumParticipantes { get; set; }

        // criar uma lista de Trilhos
        // associados ao Desafio
        public virtual ICollection<Trilhos> ListaDeTrilhos { get; set; }

        // criar uma lista de Inscrições
        // associadas ao Desafio
        public virtual ICollection<Inscricao> ListaDeInscricoes { get; set; }

    }
}