using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GestionContactos1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int Tam = 10;
        string[] nombres = new string[Tam];
        string[] telefonos = new string[Tam];
        int cont = 0;
        void añadirContacto(string[] nombres, string[] telefonos, string nombre, string telefono)
        {
            bool stop = false;
            for (int i = 0; i < nombres.Length && !stop; i++)
            {
                if (nombres[i] == null)
                {
                    nombres[i] = nombre;
                    telefonos[i] = telefono;
                    stop = true;
                }
            }
        }



        bool comprobarNombre(string[] nombres, string nombre)
        {
            bool valido = true;
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] != null)
                {
                    if (nombres[i] == nombre)
                    {
                        valido = false;
                    }
                }
            }
            return valido;
        }


        private void btnAñadirCont_Click(object sender, EventArgs e)
        {
            string nombre = "", telefono = "";
            nombre = Interaction.InputBox("Nombre: ");
            while (!comprobarNombre(nombres, nombre))
            {
                MessageBox.Show("Nombre repetido");
                nombre = Interaction.InputBox("Nombre: ");
            }
            telefono = Interaction.InputBox("Telefono: ");
            añadirContacto(nombres, telefonos, nombre, telefono);
        }

        bool EliminarContacto(string[] nombres, string[] telefonos, string nombre)
        {
            bool encontrado = false;
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] == nombre)
                {
                    encontrado = true;
                    nombres[i] = null;
                    telefonos[i] = null;
                }
            }
            return encontrado;
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            string nombre = "";
            nombre = Interaction.InputBox("Nombre: ");
            if (EliminarContacto(nombres, telefonos, nombre))
            {
                MessageBox.Show("Contacto eliminado");
            }
            else 
            {
                MessageBox.Show("Contacto no ha encontrado");
            }
            
        }

        bool modificarTel(string[] nombres, string nombre) 
        {
            bool valido = false;
            for (int i = 0; i < nombres.Length && !valido; i++) 
            {
                if (nombres[i] == nombre) 
                {
                    valido = true;
                    telefonos[i] = Interaction.InputBox("Nuevo telefono: ");
                }
            }
            return valido;
        }

        private void btnModificarContacto_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Nombre del contacto para modificar telefono: ");
            bool valido = modificarTel(nombres, nombre);
            if (valido)
            {
                MessageBox.Show("Telefono ha cambiado");
            }
            else 
            {
                MessageBox.Show("Error: nombre no existe");
            }
        }

        string MostrarContacto ( string[] nombres, string[] telefonos )
        {
            string text = "Contactos: \n";
            for (int i = 0; i < Tam; i++)
            {
                text += nombres[i] + " " + telefonos[i] + "\n";
            }
            return text;
        }

        private void btnMostrarContacto_Click ( object sender, EventArgs e )
        {
            MessageBox.Show(MostrarContacto(nombres, telefonos));
        }
    }
}
