using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.InterfacesRepositorio;
using Dominio.EntidadesDeNegocio;

namespace Repositorios
{
    public class RepositorioProducto : IRepositorio<Producto>
    {
        private BDObligatorio2_0Context db = new BDObligatorio2_0Context();
        public bool Add(Producto unObjeto)
        {
            if (unObjeto == null && unObjeto.Validar())
            {
                return false;
            }

            try {
                db.Productos.Add(unObjeto);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex){
                return false;
            }
            


        }

        public IEnumerable<Producto> FindAll()
        {
            try
            {
                return db.Productos.ToList();

            }
            catch (Exception ex)
            {
                return null;
            }
           
        }

        public Producto FindById(object Id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(object Id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Producto unObjeto)
        {
            throw new NotImplementedException();
        }
    }
}
