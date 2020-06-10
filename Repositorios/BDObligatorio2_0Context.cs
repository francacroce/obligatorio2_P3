using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.EntidadesDeNegocio;

namespace Repositorios
{
   public class BDObligatorio2_0Context: DbContext
    {

        //Agrego un DbSet por cada entidad
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public BDObligatorio2_0Context() : base("conexionObligatorio") { }

    }
}
