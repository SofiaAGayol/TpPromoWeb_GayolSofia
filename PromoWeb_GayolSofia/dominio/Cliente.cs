﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int CP { get; set; }

        public Cliente(int id, int documento, string nombre, string apellido, string email, string direccion, string ciudad, int cp)
        {
            Id = id;
            Documento = documento;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Direccion = direccion;
            Ciudad = ciudad;
            CP = cp;
        }

        public Cliente() { }
    }
}
