﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog_do_Matoso.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Senha { get; set; }
        public ICollection<Depoimentos> Depoimentos { get; set; }
    }

}
