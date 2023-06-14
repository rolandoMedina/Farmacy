using Farmacia.Datos;
using Farmacia.Datos.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Logica.Facturacion
{
    public class ClienteController
    {

        public List<Cliente> listarTodos()
        {

            ClienteData CD = new ClienteData();

            return CD.listarTodos();

        }

        public int eliminar(string DNICliente)
        {

            //VARIABLES
            int val = 0;
            ClienteData CD = new ClienteData();

            //VALIDACIONES
            if(DNICliente == "" || DNICliente == null)
            {

                val++;

            }

            //REQUEST
            if(val == 0)
            {

                Cliente cliente = CD.eliminar(DNICliente);

                if(cliente == null)
                {

                    return 2;

                }
                else
                {

                    return 1;

                }

            }
            else
            {

                return 0;

            }

        }
        
    }
}
