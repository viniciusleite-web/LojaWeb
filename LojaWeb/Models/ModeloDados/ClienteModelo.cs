﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaWeb.Models.ModeloDados
{
        public class ClienteModel
        {
            public string Id { get; set; }
            public string Nome { get; set; }
            public string CPF { get; set; }
            public string Telefone { get; set; }
            public string Endereço { get; set; }
            public string NumeroCartaoCredito { get; set; }

        }
    
}
