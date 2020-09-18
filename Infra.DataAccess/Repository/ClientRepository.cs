using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Domain.Model.Abstractions;
using Domain.Model.Entities;

namespace Infra.DataAccess.Repository
{
    public class ClientRepository : ConnectionSQL, IClientRepository
    {

        public int add(Client client)
        {
            throw new NotImplementedException();
        }

        public int edit(Client client)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetClients(string filter)
        {
            SqlDataReader LeerFilas;
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = con;
            Comando.CommandText = "verRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", filter);

            con.Open();

            LeerFilas = Comando.ExecuteReader();
            List<Client> ListaGenereica = new List<Client>();//lista generica
            //DICCIONARIO
            //SERIALIZACION: XML, JSON, NATIVA
            while (LeerFilas.Read())//agregar
            {
                ListaGenereica.Add(new Client
                {
                    ID = LeerFilas.GetInt32(0),
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Direccion = LeerFilas.GetString(3),
                    Ciudad = LeerFilas.GetString(4),
                    Email = LeerFilas.GetString(5),
                    Telefono = LeerFilas.GetString(6),
                    Ocupacion = LeerFilas.GetString(7),
                });
            }
            LeerFilas.Close();
            con.Close();
            return ListaGenereica;
        }

        public int remove(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
