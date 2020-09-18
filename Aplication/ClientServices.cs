using System.Collections.Generic;
using Domain.Model.Abstractions;
using Domain.Model.Entities;
using Infra.DataAccess.Repository;
namespace Aplication
{
    public class ClientServices
    {
        //readonly es un mecanismo de proteccion, que indica que la asignacion al campo solo puede ocurrir en el contructor de la misma clase
        readonly IClientRepository clientRepository;
        public ClientServices() {
            clientRepository = new ClientRepository();
        }
        //se esta usando la abtraccion de objeto
        public IEnumerable<Client> GetClients(string filter)
        {
            return clientRepository.GetClients(filter);
        }
    }
}
