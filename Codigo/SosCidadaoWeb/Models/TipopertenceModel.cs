﻿using System.ComponentModel.DataAnnotations;

namespace SosCidadaoWeb.Models
{
    public class TipopertenceModel
    {
        [Display(Name = "Nº Cadastral")]
        public int? IdTipoPertence { get; set; }

        [Display(Name = "Nome")]
        [StringLength(45, MinimumLength = 5, ErrorMessage = "Campo Nome deve possuir no mínimo 5 caracteres.")]
        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Display(Name = "Organização")]
        [Key]
        [Required(ErrorMessage = "Não foi possivel identificar o IdOrganizacao")]
        public int IdOrganizacao { get; set; }
    }
}
