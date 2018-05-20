using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrilhosNorteSulWeb.Models
{
    public class Inscricao
    {
        [Key]
        public int CodInscricao { get; set; } // chave primária

        // dados da Inscricao
        public DateTime DataInscricao { get; set; }

        public int NumMaxParticipantes { get; set; }


        //**************************************************
        // especificação das chaves forasteiras
        //**************************************************

        //FK para Desafio
        [ForeignKey("Desafio")]
        public int DesafioFK { get; set; }
        public virtual Desafios Desafio { get; set; }

        //FK para Participante
        [ForeignKey("Participante")]
        public int ParticipanteFK { get; set; }
        public virtual Participantes Participante { get; set; }

    }
}