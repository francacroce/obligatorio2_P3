using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.EntidadesDeNegocio
{
    [Table("Producto")]
    public class Producto
    {
        #region Atributos
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public decimal Peso { get; set; }

        [Required]
        public Cliente Cliente { get; set; }

        [Required]
        public int Stock { get; set; }


        #endregion

        #region Validaciones
        public bool Validar()
        {
            //Regla de validación, solo se controla que todos los atributos tengan algún
            //valor. 
            return !string.IsNullOrEmpty(Nombre) &&
                    Id > 0 &&
                    Peso > 0 &&
                    Cliente != null;

        }
        #endregion
    }
}
