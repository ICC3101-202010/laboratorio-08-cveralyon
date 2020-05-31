using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab8
{
    static class Controller
    {

        public static List<Recreacional> lista_recre = new List<Recreacional>();
        public static List<Cine> lista_cines = new List<Cine>();
        public static List<Tienda> lista_tiendas = new List<Tienda>();
        public static List<Restaurante> lista_restaurantes = new List<Restaurante>();
        public static List<string> Lista_categiria_tiendas = new List<string>();

        public static void Cargar()
        {
            lista_tiendas = Deserial_tienda();
            lista_restaurantes = Deserial_restaurant();
            lista_cines = Deserial_cine();
            lista_recre = Deserial_recre();
        }
        public static void Guardar()
        {
            Serial_tienda(lista_tiendas);
            Serial_restaurant(lista_restaurantes);
            Serial_cine(lista_cines);
            Serial_recre(lista_recre);

        }
        public static void Serial_recre(List<Recreacional> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Recreacional.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<Recreacional> Deserial_recre()  //deserializamos
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("Recreacional.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            try
            {
                List<Recreacional> v = (List<Recreacional>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v;
            }
            catch
            {
                List<Recreacional> v = new List<Recreacional>();
                stream6.Close();
                return v;
            }
        }
        public static void Serial_cine(List<Cine> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Cine.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<Cine> Deserial_cine()  //deserializamos
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("Cine.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            try
            {
                List<Cine> v1 = (List<Cine>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v1;
            }
            catch
            {
                List<Cine> v1 = new List<Cine>();
                stream6.Close();
                return v1;
            }
        }
        public static void Serial_restaurant(List<Restaurante> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Restaurante.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<Restaurante> Deserial_restaurant()  //deserializamos
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("Restaurante.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            try
            {
                List<Restaurante> v1 = (List<Restaurante>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v1;
            }
            catch
            {
                List<Restaurante> v1 = new List<Restaurante>();
                stream6.Close();
                return v1;
            }
        }
        public static void Serial_tienda(List<Tienda> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Restaurante.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<Tienda> Deserial_tienda()  //deserializamos
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("Tienda.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            try
            {
                List<Tienda> v1 = (List<Tienda>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v1;
            }
            catch
            {
                List<Tienda> v1 = new List<Tienda>();
                stream6.Close();
                return v1;
            }
        }
        public static  Recreacional nuevo_recre(string nombre, string owner, int id, string open, string close)
        {
            Recreacional recreacional = new Recreacional(nombre, owner, id, open, close);
            lista_recre.Add(recreacional);
            Serial_recre(lista_recre);
            return recreacional;
        }

        public static Cine nuevo_cine (string nombre, string owner, int id, string open, string close, int salas)
        {
            Cine cine = new Cine(nombre, owner, id, open, close, salas);
            lista_cines.Add(cine);
            Serial_cine(lista_cines);
            return cine;
        }

        public static Restaurante nuevo_restaurant(string nombre, string owner, int id, string open, string close, bool exclusive)
        {
            Restaurante restaurante = new Restaurante(nombre, owner, id, open, close, exclusive);
            lista_restaurantes.Add(restaurante);
            Serial_restaurant(lista_restaurantes);
            return restaurante;
        }

        public static Tienda nueva_tienda(string nombre, string owner, int id, string open, string close, List<string> categories)
        {
            Tienda tienda = new Tienda(nombre, owner, id, open, close, categories);
            lista_tiendas.Add(tienda);
            Serial_tienda(lista_tiendas);
            return tienda;
        }
        

    }
}
