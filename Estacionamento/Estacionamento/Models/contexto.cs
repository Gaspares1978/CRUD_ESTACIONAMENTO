using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Estacionamento.Models
{
    public class contexto: DbContext
    {
       public DbSet<carros>Carros { get; set; }
    }
}