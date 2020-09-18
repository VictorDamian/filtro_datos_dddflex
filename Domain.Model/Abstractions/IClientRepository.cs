using System.Collections.Generic;
using Domain.Model.Entities;

namespace Domain.Model.Abstractions
{
    public interface IClientRepository
    {
        //comportamientos que va tener, agregar, editar, eliminar, obtener
        //reciben parametro del objeto client.cs
        int add(Client client );
        int edit(Client client);
        int remove(Client client);
        IEnumerable<Client> GetClients(string filter);//este retorna una recoleccion con el resultado de la BD
    }
}
