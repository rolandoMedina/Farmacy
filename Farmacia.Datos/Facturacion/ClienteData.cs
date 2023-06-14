using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Datos.Facturacion
{
    public class ClienteData
    {

        public List<Cliente> listarTodos()
        {

            using(FarmaciaEntities db = new FarmaciaEntities())
            {

                return db.Cliente.ToList();

            }

        }

        public Cliente eliminar(string DNICliente) 
        {

            using(FarmaciaEntities db = new FarmaciaEntities())
            {

                Cliente cliente = db.Cliente.Find(DNICliente);

                if(cliente == null)
                {

                    return cliente;

                }
                else
                {

                    db.Cliente.Remove(cliente);
                    db.SaveChanges();
                    return cliente;

                }

            }

        }

    }
}
