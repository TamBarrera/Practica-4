﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form2 : Form
    {
        string[] Agenda = { "Empresa", "Mamá", "Hermano", "Papá" };
        string[] Servicios_disponibles = { "luz", "Agua", "Gas", "Internet"};
        string[] Tarjeta = { "American Express", "Banamex", "Bancomer" };
        public Form2()
        {
            InitializeComponent();

            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            popularAgenda();
            popularServicios();
            popularTarjeta();
        }

        void popularAgenda()
        {
            for (int i = 0; i <Agenda.Length; i++) 
            {
                Agendabox.Items.Add(Agenda[i]);
            }
        }

        void popularServicios() 
        {
            for (int i = 0; i <Servicios_disponibles.Length; i++)
            {
                Servicios.Items.Add(Servicios_disponibles[i]);
            }
        }

        void popularTarjeta() 
        {
            for (int i = 0; i <Tarjeta.Length; i++) 
            {
                Tarjetas.Items.Add(Tarjeta[i]);
            }
        }
    }





}

