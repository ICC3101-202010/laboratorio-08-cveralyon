using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Ventana_principal : Form
    {
        List<string> categorias_tienda = new List<string>();
        List<string> lista_locales = new List<string>();

        public Ventana_principal()
        {
            InitializeComponent();
        }


        private void Ventana_principal_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void btn_agregar_nuevo_local_Click(object sender, EventArgs e)
        {
            panel_agregar_nuevo_local.Visible = true;
            panel_agregar_nuevo_local.Dock = DockStyle.Fill;
        }

        private void btn_revisar_info_locales_Click(object sender, EventArgs e)
        {
            panel_ver_info_locales.Visible = true;
            panel_ver_info_locales.Dock = DockStyle.Fill;
            Controller.Cargar();
            foreach (Recreacional recreacional in Controller.lista_recre)
            {
                int n = tabla_recre.Rows.Add();
                tabla_recre.Rows[n].Cells[0].Value = recreacional.Name;
                tabla_recre.Rows[n].Cells[1].Value = recreacional.Owner;
                tabla_recre.Rows[n].Cells[2].Value = recreacional.Id_store;
                tabla_recre.Rows[n].Cells[3].Value = recreacional.Open_t;
                tabla_recre.Rows[n].Cells[4].Value = recreacional.Close_t;
                comboBox_LISTA_locales_para_editar.Items.Add(recreacional.Name);
            }
            foreach (Cine cine in Controller.lista_cines)
            {
                int n1 = tabla_cines.Rows.Add();
                tabla_cines.Rows[n1].Cells[0].Value = cine.Name;
                tabla_cines.Rows[n1].Cells[1].Value = cine.Owner;
                tabla_cines.Rows[n1].Cells[2].Value = cine.Id_store;
                tabla_cines.Rows[n1].Cells[3].Value = cine.Open_t;
                tabla_cines.Rows[n1].Cells[4].Value = cine.Close_t;
                tabla_cines.Rows[n1].Cells[5].Value = cine.Num_salas;
                comboBox_LISTA_locales_para_editar.Items.Add(cine.Name);

            }
            
            foreach (Tienda tienda in Controller.lista_tiendas)
            {
                int n2 = tabla_tiendas.Rows.Add();
                tabla_tiendas.Rows[n2].Cells[0].Value = tienda.Name;
                tabla_tiendas.Rows[n2].Cells[1].Value = tienda.Owner;
                tabla_tiendas.Rows[n2].Cells[2].Value = tienda.Id_store;
                tabla_tiendas.Rows[n2].Cells[3].Value = tienda.Open_t;
                tabla_tiendas.Rows[n2].Cells[4].Value = tienda.Close_t;
                string categorias = "";
                foreach (string ca in tienda.Categories1)
                {
                    categorias = ca + ", ";
                }
                tabla_tiendas.Rows[n2].Cells[5].Value = categorias;
                
                comboBox_LISTA_locales_para_editar.Items.Add(tienda.Name);

            }
            foreach (Restaurante restaurante in Controller.lista_restaurantes)
            {
                int n3 = tabla_restaurantes.Rows.Add();
                tabla_restaurantes.Rows[n3].Cells[0].Value = restaurante.Name;
                tabla_restaurantes.Rows[n3].Cells[1].Value = restaurante.Owner;
                tabla_restaurantes.Rows[n3].Cells[2].Value = restaurante.Id_store;
                tabla_restaurantes.Rows[n3].Cells[3].Value = restaurante.Open_t;
                tabla_restaurantes.Rows[n3].Cells[4].Value = restaurante.Close_t;
                tabla_restaurantes.Rows[n3].Cells[5].Value = restaurante.Exclusive_table;
                comboBox_LISTA_locales_para_editar.Items.Add(restaurante.Name);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_sistema__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_atras_de_agregar_local_Click(object sender, EventArgs e)
        {
            panel_agregar_nuevo_local.Visible = false;
        }

        private void btn_cerrar_sesion_de_agregar_nuevo_local_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_mesas_explusivas_restaurante_Click(object sender, EventArgs e)
        {

        }

        private void label_categoria_tienda_Click(object sender, EventArgs e)
        {

        }

        private void label_numero_salas_cine_Click(object sender, EventArgs e)
        {

        }

        private void numero_salas_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Accesorios_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Accesorios.Checked == true)
            {
                categorias_tienda.Add(checkBox_Accesorios.Text);
            }
            if (checkBox_Accesorios.Checked == false)
            {
                categorias_tienda.Remove(checkBox_Accesorios.Text);
            }
        }

        private void panel_agregar_nuevo_local_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_tipo_De_local_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_tipo_De_local.Text == "Restaurante")
            {
                label_mesas_explusivas_restaurante.Visible = true;
                checkBox_mesas_explisivas.Visible = true;
                label_no_mesas_exclusivas.Visible = true;
                label_numero_salas_cine.Visible = false;
                numero_salas_text.Visible = false;
                label_categoria_tienda.Visible = false;
                checkBox_Entretenimiento.Visible = false;
                checkBox_Farmacia.Visible = false;
                checkBox_Infantil.Visible = false;
                checkBox_Juguetes.Visible = false;
                checkBox_Libros.Visible = false;
                checkBox_Accesorios.Visible = false;
                checkBox_Caféteria.Visible = false;
                checkBox_Calzado.Visible = false;
                checkBox_Deportes.Visible = false;
                checkBox_Electrónica.Visible = false;
                checkBox_Musica.Visible = false;
                checkBox_Ropa.Visible = false;
            }
            if (comboBox_tipo_De_local.Text == "Cine")
            {
                label_numero_salas_cine.Visible = true;
                numero_salas_text.Visible = true;
                label_mesas_explusivas_restaurante.Visible = false;
                checkBox_mesas_explisivas.Visible = false;
                label_no_mesas_exclusivas.Visible = false;
                label_si_mesas_exclusivas.Visible = false;
                label_categoria_tienda.Visible = false;
                checkBox_Entretenimiento.Visible = false;
                checkBox_Farmacia.Visible = false;
                checkBox_Infantil.Visible = false;
                checkBox_Juguetes.Visible = false;
                checkBox_Libros.Visible = false;
                checkBox_Accesorios.Visible = false;
                checkBox_Caféteria.Visible = false;
                checkBox_Calzado.Visible = false;
                checkBox_Deportes.Visible = false;
                checkBox_Electrónica.Visible = false;
                checkBox_Musica.Visible = false;
                checkBox_Ropa.Visible = false;
            }
            if (comboBox_tipo_De_local.Text == "Recreacional")
            {
                label_mesas_explusivas_restaurante.Visible = false;
                checkBox_mesas_explisivas.Visible = false;
                label_no_mesas_exclusivas.Visible = false;
                label_si_mesas_exclusivas.Visible = false;
                label_numero_salas_cine.Visible = false;
                numero_salas_text.Visible = false;
                label_categoria_tienda.Visible = false;
                checkBox_Entretenimiento.Visible = false;
                checkBox_Farmacia.Visible = false;
                checkBox_Infantil.Visible = false;
                checkBox_Juguetes.Visible = false;
                checkBox_Libros.Visible = false;
                checkBox_Accesorios.Visible = false;
                checkBox_Caféteria.Visible = false;
                checkBox_Calzado.Visible = false;
                checkBox_Deportes.Visible = false;
                checkBox_Electrónica.Visible = false;
                checkBox_Musica.Visible = false;
                checkBox_Ropa.Visible = false;
            }
            if (comboBox_tipo_De_local.Text == "Tienda")
            {
                label_mesas_explusivas_restaurante.Visible = false;
                checkBox_mesas_explisivas.Visible = false;
                label_no_mesas_exclusivas.Visible = false;
                label_si_mesas_exclusivas.Visible = false;
                label_numero_salas_cine.Visible = false;
                numero_salas_text.Visible = false;
                label_categoria_tienda.Visible = true;
                checkBox_Entretenimiento.Visible = true;
                checkBox_Farmacia.Visible = true;
                checkBox_Infantil.Visible = true;
                checkBox_Juguetes.Visible = true;
                checkBox_Libros.Visible = true;
                checkBox_Accesorios.Visible = true;
                checkBox_Caféteria.Visible = true;
                checkBox_Calzado.Visible = true;
                checkBox_Deportes.Visible = true;
                checkBox_Electrónica.Visible = true;
                checkBox_Musica.Visible = true;
                checkBox_Ropa.Visible = true;

            }
        }

        private void checkBox_mesas_explisivas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mesas_explisivas.Checked == true)
            {
                label_no_mesas_exclusivas.Visible = false;
                label_si_mesas_exclusivas.Visible = true;
            }
            if (checkBox_mesas_explisivas.Checked == false)
            {
                label_no_mesas_exclusivas.Visible = true;
                label_si_mesas_exclusivas.Visible = false;
            }

        }

        private void checkBox_Caféteria_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Caféteria.Checked == true)
            {
                categorias_tienda.Add(checkBox_Caféteria.Text);
            }
            if (checkBox_Caféteria.Checked == false)
            {
                categorias_tienda.Remove(checkBox_Caféteria.Text);
            }
        }

        private void checkBox_Calzado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Calzado.Checked == true)
            {
                categorias_tienda.Add(checkBox_Calzado.Text);
            }
            if (checkBox_Calzado.Checked == false)
            {
                categorias_tienda.Remove(checkBox_Calzado.Text);
            }
        }

        private void checkBox_Deportes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Deportes.Checked == true)
            {
                categorias_tienda.Add(checkBox_Deportes.Text);
            }
            if (checkBox_Deportes.Checked == false)
            {
                categorias_tienda.Remove(checkBox_Deportes.Text);
            }
        }

        private void checkBox_Electrónica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Electrónica.Checked == true)
            {
                categorias_tienda.Add(checkBox_Electrónica.Text);
            }
            if (checkBox_Electrónica.Checked == false)
            {
                categorias_tienda.Remove(checkBox_Electrónica.Text);
            }
        }

        private void checkBox_Entretenimiento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Entretenimiento.Checked == true)
            {
                categorias_tienda.Add(checkBox_Entretenimiento.Text);
            }
            if (checkBox_Entretenimiento.Checked == false)
            {
                categorias_tienda.Remove(checkBox_Entretenimiento.Text);
            }
        }

        private void checkBox_Farmacia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Farmacia.Checked == true)
            {
                categorias_tienda.Add(checkBox_Farmacia.Text);
            }
            if (checkBox_Farmacia.Checked == false)
            {
                categorias_tienda.Remove(checkBox_Farmacia.Text);
            }
        }

        private void checkBox_Infantil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Infantil.Checked == true)
            {
                categorias_tienda.Add(checkBox_Infantil.Text);
            }
            if (checkBox_Infantil.Checked == false)
            {
                categorias_tienda.Remove(checkBox_Infantil.Text);
            }
        }

        private void checkBox_Juguetes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Juguetes.Checked == true)
            {
                categorias_tienda.Add(checkBox_Juguetes.Text);
            }
            if (checkBox_Juguetes.Checked == false)
            {
                categorias_tienda.Remove(checkBox_Juguetes.Text);
            }
        }

        private void checkBox_Libros_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Libros.Checked == true)
            {
                categorias_tienda.Add(checkBox_Libros.Text);
            }
            if (checkBox_Libros.Checked == false)
            {
                categorias_tienda.Remove(checkBox_Libros.Text);
            }
        }

        private void checkBox_Musica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Musica.Checked == true)
            {
                categorias_tienda.Add(checkBox_Musica.Text);
            }
            if (checkBox_Musica.Checked == false)
            {
                categorias_tienda.Remove(checkBox_Musica.Text);
            }
        }

        private void checkBox_Ropa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Ropa.Checked == true)
            {
                categorias_tienda.Add(checkBox_Ropa.Text);
            }
            if (checkBox_Ropa.Checked == false)
            {
                categorias_tienda.Remove(checkBox_Ropa.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e) // guardar
        {

            string hora_open = comboBox_hora_apertura.Text + ":" + comboBox_minutos_apertura.Text;
            string hora_close = comboBox_hora_cierre.Text + ":" + comboBox_minutos_cierre.Text;
            bool mesas = false;
            if (checkBox_mesas_explisivas.Checked == true)
            {
                mesas = true;
            }
            if (checkBox_mesas_explisivas.Checked == false)
            {
                mesas = false;
            }

            if (comboBox_tipo_De_local.Text == "Restaurante")
            {

                Controller.nuevo_restaurant(nombre_text_local.Text, dueno_text_local.Text, int.Parse(id_text_local.Text), hora_open, hora_close, mesas);

            }
            if (comboBox_tipo_De_local.Text == "Cine")
            {
                Controller.nuevo_cine(nombre_text_local.Text, dueno_text_local.Text, int.Parse(id_text_local.Text), hora_open, hora_close, int.Parse(numero_salas_text.Text));

            }
            if (comboBox_tipo_De_local.Text == "Recreacional")
            {
                Controller.nuevo_recre(nombre_text_local.Text, dueno_text_local.Text, int.Parse(id_text_local.Text), hora_open, hora_close);

            }
            if (comboBox_tipo_De_local.Text == "Tienda")
            {
                Controller.nueva_tienda(nombre_text_local.Text, dueno_text_local.Text, int.Parse(id_text_local.Text), hora_open, hora_close, categorias_tienda);
            }
            Controller.Guardar();
            label_mesas_explusivas_restaurante.Visible = false;
            checkBox_mesas_explisivas.Visible = false;
            label_no_mesas_exclusivas.Visible = false;
            label_si_mesas_exclusivas.Visible = false;
            label_numero_salas_cine.Visible = false;
            numero_salas_text.Visible = false;
            label_categoria_tienda.Visible = false;
            checkBox_Entretenimiento.Visible = false;
            checkBox_Farmacia.Visible = false;
            checkBox_Infantil.Visible = false;
            checkBox_Juguetes.Visible = false;
            checkBox_Libros.Visible = false;
            checkBox_Accesorios.Visible = false;
            checkBox_Caféteria.Visible = false;
            checkBox_Calzado.Visible = false;
            checkBox_Deportes.Visible = false;
            checkBox_Electrónica.Visible = false;
            checkBox_Musica.Visible = false;
            checkBox_Ropa.Visible = false;
            checkBox_Entretenimiento.Checked = false;
            checkBox_Farmacia.Checked = false;
            checkBox_Infantil.Checked = false;
            checkBox_Juguetes.Checked = false;
            checkBox_Libros.Checked = false;
            checkBox_Accesorios.Checked = false;
            checkBox_Caféteria.Checked = false;
            checkBox_Calzado.Checked = false;
            checkBox_Deportes.Checked = false;
            checkBox_Electrónica.Checked = false;
            checkBox_Musica.Checked = false;
            checkBox_Ropa.Checked = false;
            nombre_text_local.Text = "";
            dueno_text_local.Text = "";
            id_text_local.Text = "";
            comboBox_tipo_De_local.Text = "";
            numero_salas_text.Text = "";
            checkBox_mesas_explisivas.Checked = false;
            comboBox_hora_apertura.Text = "";
            comboBox_minutos_apertura.Text = "";
            comboBox_hora_cierre.Text = "";
            comboBox_minutos_cierre.Text = "";
            panel_agregar_nuevo_local.Visible = false;
        }

        private void comboBox_hora_apertura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_minutos_apertura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_hora_cierre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_minutos_cierre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel_ver_info_locales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e) //atras ver info tiendas
        {
            panel_ver_info_locales.Visible = false;
            tabla_cines.Rows.Clear();
            tabla_recre.Rows.Clear();
            tabla_restaurantes.Rows.Clear();
            tabla_tiendas.Rows.Clear();
            comboBox_LISTA_locales_para_editar.Items.Clear();
        }

        private void btn_ir_para_editar_locales_Click(object sender, EventArgs e)
        {
            tabla_cines.Rows.Clear();
            tabla_recre.Rows.Clear();
            tabla_restaurantes.Rows.Clear();
            tabla_tiendas.Rows.Clear();
            comboBox_LISTA_locales_para_editar.Items.Clear();
            
            panel_ir_editar_local.Visible = true;
            panel_ir_editar_local.Dock = DockStyle.Fill;
            foreach (Recreacional recreacional in Controller.lista_recre)
            {
                if (comboBox_LISTA_locales_para_editar.Text == recreacional.Name)
                {
                    text_nombre_editar.Text = recreacional.Name;
                    text_duenio_editar.Text = recreacional.Owner;
                    text_id_editar.Text = recreacional.Id_store.ToString();
                    text_hora_open_editar.Text = recreacional.Open_t;
                    text_hora_close_editare.Text = recreacional.Close_t;
                }
            }
            foreach (Cine cine in Controller.lista_cines)
            {
                if (comboBox_LISTA_locales_para_editar.Text == cine.Name)
                {
                    text_nombre_editar.Text = cine.Name;
                    text_duenio_editar.Text = cine.Owner;
                    text_id_editar.Text = cine.Id_store.ToString();
                    text_hora_open_editar.Text = cine.Open_t;
                    text_hora_close_editare.Text = cine.Close_t;
                }
            }
            foreach (Tienda tienda in Controller.lista_tiendas)
            {
                if (comboBox_LISTA_locales_para_editar.Text == tienda.Name)
                {
                    text_nombre_editar.Text = tienda.Name;
                    text_duenio_editar.Text = tienda.Owner;
                    text_id_editar.Text = tienda.Id_store.ToString();
                    text_hora_open_editar.Text = tienda.Open_t;
                    text_hora_close_editare.Text = tienda.Close_t;
                }
            }
            foreach (Restaurante restaurante in Controller.lista_restaurantes)
            {
                if (comboBox_LISTA_locales_para_editar.Text == restaurante.Name)
                {
                    text_nombre_editar.Text = restaurante.Name;
                    text_duenio_editar.Text = restaurante.Owner;
                    text_id_editar.Text = restaurante.Id_store.ToString();
                    text_hora_open_editar.Text = restaurante.Open_t;
                    text_hora_close_editare.Text = restaurante.Close_t;
                }
            }
        }

        private void comboBox_LISTA_locales_para_editar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_ir_editar_local.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void text_nombre_editar_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_duenio_editar_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_id_editar_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_hora_open_editar_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_hora_close_editare_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e) // btn guardar
        {

            panel_ir_editar_local.Visible = false;
            foreach (Recreacional recreacional in Controller.lista_recre)
            {
                if (text_id_editar.Text == recreacional.Id_store.ToString())
                {
                    recreacional.Name = text_nombre_editar.Text;
                    recreacional.Owner = text_duenio_editar.Text;
                    recreacional.Open_t = text_hora_open_editar.Text;
                    recreacional.Close_t = text_hora_close_editare.Text;
                }
            }
            foreach (Cine cine in Controller.lista_cines)
            {
                if (text_id_editar.Text == cine.Id_store.ToString())
                {
                    cine.Name = text_nombre_editar.Text;
                    cine.Owner = text_duenio_editar.Text;
                    cine.Open_t = text_hora_open_editar.Text;
                    cine.Close_t = text_hora_close_editare.Text;
                }
            }
            foreach (Tienda tienda in Controller.lista_tiendas)
            {
                if (text_id_editar.Text == tienda.Id_store.ToString())
                {
                    tienda.Name = text_nombre_editar.Text;
                    tienda.Owner = text_duenio_editar.Text;
                    tienda.Open_t = text_hora_open_editar.Text;
                    tienda.Close_t = text_hora_close_editare.Text;
                }
            }
            foreach (Restaurante restaurante in Controller.lista_restaurantes)
            {
                if (text_id_editar.Text == restaurante.Id_store.ToString())
                {
                    restaurante.Name = text_nombre_editar.Text;
                    restaurante.Owner = text_duenio_editar.Text;
                    restaurante.Open_t = text_hora_open_editar.Text;
                    restaurante.Close_t = text_hora_close_editare.Text;
                }
            }
            Controller.Guardar();
            text_nombre_editar.Text = "";
            text_duenio_editar.Text = "";
            text_id_editar.Text = "";
            text_hora_open_editar.Text = "";
            text_hora_close_editare.Text = "";
            Controller.Cargar();
            foreach (Recreacional recreacional in Controller.lista_recre)
            {
                int n = tabla_recre.Rows.Add();
                tabla_recre.Rows[n].Cells[0].Value = recreacional.Name;
                tabla_recre.Rows[n].Cells[1].Value = recreacional.Owner;
                tabla_recre.Rows[n].Cells[2].Value = recreacional.Id_store;
                tabla_recre.Rows[n].Cells[3].Value = recreacional.Open_t;
                tabla_recre.Rows[n].Cells[4].Value = recreacional.Close_t;
                comboBox_LISTA_locales_para_editar.Items.Add(recreacional.Name);
            }
            foreach (Cine cine in Controller.lista_cines)
            {
                int n1 = tabla_cines.Rows.Add();
                tabla_cines.Rows[n1].Cells[0].Value = cine.Name;
                tabla_cines.Rows[n1].Cells[1].Value = cine.Owner;
                tabla_cines.Rows[n1].Cells[2].Value = cine.Id_store;
                tabla_cines.Rows[n1].Cells[3].Value = cine.Open_t;
                tabla_cines.Rows[n1].Cells[4].Value = cine.Close_t;
                tabla_cines.Rows[n1].Cells[5].Value = cine.Num_salas;
                comboBox_LISTA_locales_para_editar.Items.Add(cine.Name);

            }
            
            foreach (Tienda tienda in Controller.lista_tiendas)
            {
                int n2 = tabla_tiendas.Rows.Add();
                tabla_tiendas.Rows[n2].Cells[0].Value = tienda.Name;
                tabla_tiendas.Rows[n2].Cells[1].Value = tienda.Owner;
                tabla_tiendas.Rows[n2].Cells[2].Value = tienda.Id_store;
                tabla_tiendas.Rows[n2].Cells[3].Value = tienda.Open_t;
                tabla_tiendas.Rows[n2].Cells[4].Value = tienda.Close_t;
                string categorias = "";
                foreach (string ca in tienda.Categories1)
                {
                    categorias = categorias + ca + ", ";
                }
                tabla_tiendas.Rows[n2].Cells[5].Value = categorias;
                comboBox_LISTA_locales_para_editar.Items.Add(tienda.Name);

            }
            foreach (Restaurante restaurante in Controller.lista_restaurantes)
            {
                int n3 = tabla_restaurantes.Rows.Add();
                tabla_restaurantes.Rows[n3].Cells[0].Value = restaurante.Name;
                tabla_restaurantes.Rows[n3].Cells[1].Value = restaurante.Owner;
                tabla_restaurantes.Rows[n3].Cells[2].Value = restaurante.Id_store;
                tabla_restaurantes.Rows[n3].Cells[3].Value = restaurante.Open_t;
                tabla_restaurantes.Rows[n3].Cells[4].Value = restaurante.Close_t;
                tabla_restaurantes.Rows[n3].Cells[5].Value = restaurante.Exclusive_table;
                comboBox_LISTA_locales_para_editar.Items.Add(restaurante.Name);

            }
        }
    }
}
