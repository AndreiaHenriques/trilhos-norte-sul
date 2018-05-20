using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrilhosNorteSulWeb.Models
{
    public class Imagens
    {
        [Key]
        public int CodImagem { get; set; } // chave primária

        // dados da Imagem
        public string Imagem { get; set; }

        //**************************************************
        // especificação das chaves forasteiras
        //**************************************************

        //FK para Trilho
        [ForeignKey("Trilho")]
        public int TrilhoFK { get; set; }
        public virtual Trilhos Trilho { get; set; }
    }
}