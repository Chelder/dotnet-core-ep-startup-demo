﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StartupDemo.Models
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [Display(Name = "Nome Completo")]
        [MaxLength(100, ErrorMessage = "O valor máximo é 100")]
        [MinLength(2, ErrorMessage = "O valor mínimo é 2")]
        public string Nome { get; set; }

        [Range(10, 1000)]
        [Required(ErrorMessage = "Preencha o valor")]
        public decimal Valor { get; set; }
        public bool Gratuito { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatório")]
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
    }

    public class Categoria
    {
        public string Nome { get; set; }
    }

    public class EventoCategoriaViewModel
    {
        public Evento Evento { get; set; }
        public IEnumerable<Categoria> Categorias { get; set; }
    }
}
