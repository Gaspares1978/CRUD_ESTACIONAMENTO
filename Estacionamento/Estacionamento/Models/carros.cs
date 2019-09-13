using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estacionamento.Models
{
    public class carros
    {
        [Key]
        public int id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Proprietario { get; set; }
        public string Endereço { get; set; }
        public string Entrada { get; set; }
        public string Saida { get; set; }
        public string Permanencia { get; set; }
    }
}