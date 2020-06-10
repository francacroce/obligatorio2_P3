using Dominio.EntidadesDeNegocio;
using Dominio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
   public class RepostorioCliente: IRepositorio<Cliente>
    {
        private BDObligatorio2_0Context db = new BDObligatorio2_0Context();

        public bool Add(Cliente unObjeto)
        {
            if (unObjeto == null && unObjeto.Validar()) return false;
            try
            {
                db.Clientes.Add(unObjeto);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex) {
                return false;

            }
        }

        public IEnumerable<Cliente> FindAll()
        {
            throw new NotImplementedException();
        }

        public Cliente FindById(object Id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(object Id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente unObjeto)
        {
            throw new NotImplementedException();
        }
    }
}
