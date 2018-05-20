using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrilhosNorteSulWeb.Models
{
    public class Trilhos
    {   
        // criar o construtor
        public Trilhos()
        {
            ListaDeDesafios = new HashSet<Desafios>();

            ListaDeImagens = new HashSet<Imagens>();

        }

        [Key]
        public int CodTrilho { get; set; } // chave primária

        // dados do Trilho
        public string TipoDeUtilizacao { get; set; }

        public string Distrito { get; set; }

        public string Cidade { get; set; }

        public string CoordenadasInicio { get; set; }

        public string CoordenadasFim { get; set; }

        public float Distancia { get; set; }

        public int GrauDificuldadeTrilho { get; set; }

        // criar uma lista de Desafios
        // associados ao Trilho
        public virtual ICollection<Desafios> ListaDeDesafios { get; set; }

        // criar uma lista de imagens
        // associadas ao Trilho
        public virtual ICollection<Imagens> ListaDeImagens { get; set; }

    }
}