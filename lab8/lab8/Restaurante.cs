using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    [Serializable]
    class Restaurante
    {
        private string name;
        private string owner;
        private int id_store;
        private string open_t;
        private string close_t;
        private bool exclusive_table;

        public Restaurante(string name, string owner, int id_store, string open_t, string close_t, bool exclusive_table)
        {
            this.name = name;
            this.owner = owner;
            this.id_store = id_store;
            this.open_t = open_t;
            this.close_t = close_t;
            this.exclusive_table = exclusive_table;
        }

        public string Name { get => name; set => name = value; }
        public string Owner { get => owner; set => owner = value; }
        public int Id_store { get => id_store; set => id_store = value; }
        public string Open_t { get => open_t; set => open_t = value; }
        public string Close_t { get => close_t; set => close_t = value; }
        public bool Exclusive_table { get => exclusive_table; set => exclusive_table = value; }

        public string info()
        {
            string info;
            info = "Nombre del Restaurante: " + Name + "\nDueño: " + Owner + "\nId: " + Id_store + "\nHorario: " + Open_t + "/" + Close_t;
            return info;
        }
    }
}
