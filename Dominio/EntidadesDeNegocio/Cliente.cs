using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.EntidadesDeNegocio
{
   public class Cliente
    {
        #region Atributos
        [Key]
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaIngreso { get; set; }

        public int Antiguedad
        {
            get
            {
                TimeSpan dif = DateTime.Now.Subtract(FechaIngreso);
                int ant = (dif.Days / 365);

                return ant;
            }
        }


        #endregion

        #region Validaciones
        public bool Validar()
        {
            //Regla de validación, solo se controla que todos los atributos tengan algún
            //valor. 
            return !string.IsNullOrEmpty(Nombre) &&
                 !string.IsNullOrEmpty(Rut) &&
                  Rut.Length == 12 &&
                  FechaIngreso > DateTime.MinValue;

        }
        #endregion
    }
}

