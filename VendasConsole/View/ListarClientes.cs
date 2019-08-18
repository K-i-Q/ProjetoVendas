﻿using System;
using VendasConsole.DAO;
using VendasConsole.Model;

namespace VendasConsole.View
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            Console.WriteLine("Listar clientes");
            foreach (Cliente v in ClienteDAO.ListarClientes())
            {
                Console.WriteLine(v);
            }
        }
    }
}
